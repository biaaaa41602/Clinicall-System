Public Class uc_add_consultas
    Private _idMedicoSelecionado As Integer = 0
    Private _dataConsultaSelecionada As DateTime
    Private _horaConsultaSelecionada As String = ""
    Private _idPacienteSelecionado As Integer = 0
    Private _planoSaudePaciente As String = ""

    Private Sub uc_add_consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then
            MessageBox.Show("ERRO: A conexão de banco de dados 'db' não está aberta ou é nula!", "Falha de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        CarregarEspecialidades()

        dtp_data.Value = DateTime.Today ' define a data inicial como hoje
        _dataConsultaSelecionada = dtp_data.Value

        cmb_medico.Enabled = False
        btn_marcar.Enabled = False
    End Sub

    Private Sub CarregarEspecialidades() ' carrega as especialidades no combobox

        Dim sql As String = "SELECT DISTINCT especialidade FROM tb_medico ORDER BY especialidade"

        cmb_especialidade.Items.Clear()

        Dim rs As New ADODB.Recordset()
        Try
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Do While Not rs.EOF
                cmb_especialidade.Items.Add(rs.Fields("especialidade").Value.ToString())
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar especialidades: " & ex.Message)
        Finally
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End Try
    End Sub

    Private Sub cmb_especialidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_especialidade.SelectedIndexChanged
        cmb_medico.Items.Clear()
        flp_horarios.Controls.Clear()

        If cmb_especialidade.SelectedItem Is Nothing Then
            cmb_medico.Enabled = False
            Return
        End If

        Dim especialidadeSelecionada As String = cmb_especialidade.Text.Replace("'", "''")

        Dim sql As String = $"SELECT id_medico, nome FROM tb_medico WHERE especialidade='{especialidadeSelecionada}' ORDER BY nome"

        Dim rs As New ADODB.Recordset()
        Try
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Do While Not rs.EOF
                Dim medicoNome As String = rs.Fields("nome").Value.ToString()
                Dim medicoID As Integer = CInt(rs.Fields("id_medico").Value)

                cmb_medico.Items.Add(New ComboItem(medicoNome, medicoID))

                rs.MoveNext()
            Loop

            cmb_medico.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar médicos: " & ex.Message)
        Finally
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End Try
    End Sub

    Private Sub cmb_medico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_medico.SelectedIndexChanged ' carrega os horários disponiveis ao selecionar o médico

        If cmb_medico.SelectedItem IsNot Nothing Then
            Dim selectedItem As ComboItem = CType(cmb_medico.SelectedItem, ComboItem)

            _idMedicoSelecionado = selectedItem.Value

            lbl_titulohorario.Text = $"Horários Disponíveis para :" & vbCrLf &
                                    selectedItem.Text
            CarregarHorarios()
        End If
    End Sub

    Public Class ComboItem
        Public Property Text As String
        Public Property Value As Integer

        Public Sub New(ByVal text As String, ByVal value As Integer)
            Me.Text = text
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Text
        End Function
    End Class

    Private Sub dtp_data_ValueChanged(sender As Object, e As EventArgs) Handles dtp_data.ValueChanged
        _dataConsultaSelecionada = dtp_data.Value.Date
        CarregarHorarios()
    End Sub

    Private Sub CarregarHorarios()

        flp_horarios.Controls.Clear()
        If _idMedicoSelecionado = 0 OrElse _dataConsultaSelecionada = Nothing Then
            Return
        End If

        Dim dataSomente As Date = CDate(_dataConsultaSelecionada.Date)
        Dim dataSql As String = dataSomente.ToString("MM/dd/yyyy")

        Dim diaSemana As Integer = Weekday(dataSomente) ' 1=dom, 2=seg...
        Dim slotsGerados As New List(Of String)

        Dim rsGrade As ADODB.Recordset = Nothing
        Dim rsOcupados As ADODB.Recordset = Nothing
        Dim listaOcupados As New List(Of String)

        Try
            Dim sqlGrade As String = $"SELECT hora_inicio, hora_fim, tempo_consulta FROM tb_grade_horarios WHERE medico_id = {_idMedicoSelecionado} AND dia_semana = {diaSemana}"

            rsGrade = New ADODB.Recordset()
            Try
                rsGrade.Open(sqlGrade, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Catch ex As Exception
                MessageBox.Show("ERRO AO ABRIR sqlGrade:" & vbCrLf & sqlGrade & vbCrLf & "Mensagem: " & ex.Message, "ERRO SQL GRADE")
                Return
            End Try

            If Not rsGrade.EOF Then

                If rsGrade.Fields("hora_inicio").Value Is Nothing OrElse rsGrade.Fields("hora_fim").Value Is Nothing Then

                Else
                    Dim inicio As Date = CDate(rsGrade.Fields("hora_inicio").Value)
                    Dim fim As Date = CDate(rsGrade.Fields("hora_fim").Value)
                    Dim duracao As Integer = CInt(rsGrade.Fields("tempo_consulta").Value)
                    Dim slotAtual As Date = inicio

                    While slotAtual < fim
                        slotsGerados.Add(slotAtual.ToString("HH:mm:ss"))
                        slotAtual = slotAtual.AddMinutes(duracao)
                    End While
                End If
            End If

            If rsGrade IsNot Nothing Then
                If rsGrade.State = ADODB.ObjectStateEnum.adStateOpen Then rsGrade.Close()
            End If

            Dim sqlOcupados As String =
            $"SELECT hora_consulta FROM tb_consultas WHERE id_medico = {_idMedicoSelecionado} AND DateValue(data_consulta) = #{dataSql}#"

            rsOcupados = New ADODB.Recordset()
            Try
                rsOcupados.Open(sqlOcupados, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Catch ex As Exception
                MessageBox.Show("ERRO AO ABRIR sqlOcupados:" & vbCrLf & sqlOcupados & vbCrLf & "Mensagem: " & ex.Message, "ERRO SQL OCUPADOS")
                Return
            End Try

            Do While Not rsOcupados.EOF
                If rsOcupados.Fields("hora_consulta").Value IsNot Nothing Then
                    Dim h As Date = CDate(rsOcupados.Fields("hora_consulta").Value)
                    listaOcupados.Add(h.ToString("HH:mm:ss"))
                End If
                rsOcupados.MoveNext()
            Loop

            If rsOcupados IsNot Nothing Then
                If rsOcupados.State = ADODB.ObjectStateEnum.adStateOpen Then rsOcupados.Close()
            End If

            For Each horario As String In slotsGerados ' cria botões para cada slot de horário
                Dim btnHorario As New Button()
                With btnHorario
                    .Text = horario
                    .Tag = horario
                    .Width = 70
                    .Height = 30
                    .Cursor = Cursors.Hand
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderSize = 0
                End With

                If listaOcupados.Contains(horario) Then
                    btnHorario.BackColor = Color.LightBlue
                    btnHorario.Enabled = False
                Else
                    btnHorario.BackColor = Color.FromArgb(70, 130, 180)
                    AddHandler btnHorario.Click, AddressOf Horario_Click
                End If

                flp_horarios.Controls.Add(btnHorario)
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar ou calcular slots: " & ex.Message, "Erro Crítico")
        Finally
            If rsGrade IsNot Nothing AndAlso rsGrade.State = ADODB.ObjectStateEnum.adStateOpen Then rsGrade.Close()
            If rsOcupados IsNot Nothing AndAlso rsOcupados.State = ADODB.ObjectStateEnum.adStateOpen Then rsOcupados.Close()
        End Try
    End Sub

    Private Sub Horario_Click(sender As Object, e As EventArgs) ' muda a cor do botão selecionado e armazena o horário escolhido
        Dim btnSelecionado As Button = DirectCast(sender, Button)

        For Each ctrl As Control In flp_horarios.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Enabled Then
                ctrl.BackColor = Color.FromArgb(70, 130, 180)
            End If
        Next

        btnSelecionado.BackColor = Color.LightBlue

        _horaConsultaSelecionada = btnSelecionado.Tag.ToString()

        lbl_resumoPac.Text = "Paciente: " & lbl_pac_selecionado.Text
        lbl_resumoMedico.Text = "Médico: " & cmb_medico.Text
        lbl_resumoDataHora.Text = $"Data/Hora: {_dataConsultaSelecionada.ToShortDateString()} às {_horaConsultaSelecionada}"

        btn_marcar.Enabled = True
    End Sub

    Private Sub btn_marcar_Click(sender As Object, e As EventArgs) Handles btn_marcar.Click
        If _idPacienteSelecionado = 0 Then
            MessageBox.Show("É necessário buscar e selecionar o paciente primeiro!", "Erro de Agendamento")
            Return
        End If

        If _idMedicoSelecionado = 0 OrElse String.IsNullOrWhiteSpace(_horaConsultaSelecionada) Then
            MessageBox.Show("Preencha todos os campos Médico, Data e Horário.", "ATENÇÃO")
            Return
        End If

        Dim dataAccessFormat As String = _dataConsultaSelecionada.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)

        Dim sqlInsert As String =
            "INSERT INTO tb_consultas (id_medico, id_paciente, data_consulta, hora_consulta) " &
            $"VALUES ({_idMedicoSelecionado}, {_idPacienteSelecionado}, #{dataAccessFormat}#, '{_horaConsultaSelecionada}')"

        If _planoSaudePaciente.ToUpper() = "PARTICULAR" Or _planoSaudePaciente.ToUpper() = "" Then

            Dim frmPagamento As New pagar_consulta()

            frmPagamento.IdMedico = _idMedicoSelecionado
            frmPagamento.IdPaciente = _idPacienteSelecionado
            frmPagamento.DataConsulta = _dataConsultaSelecionada
            frmPagamento.HoraConsulta = _horaConsultaSelecionada
            frmPagamento.ValorConsulta = 150D

            frmPagamento.ShowDialog()

        Else
            Try
                db.Execute(sqlInsert)

                MessageBox.Show("Consulta marcada com sucesso!")

            Catch ex As Exception
                MessageBox.Show("Erro ao marcar consulta: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        _idPacienteSelecionado = 0

        Dim cpfBusca As String = txt_cpf_busca.Text.Trim().Replace("'", "''")

        If String.IsNullOrWhiteSpace(cpfBusca) Then
            MessageBox.Show("Por favor, informe o CPF ou Login do paciente.", "Atenção")
            Return
        End If

        Dim sql As String = $"SELECT id_usuario, nome_login, plano_saude FROM tb_med_pac WHERE (cpf = '{cpfBusca}' OR nome_login = '{cpfBusca}') AND tipo_cadastro = 'Paciente'"

        Dim rs As New ADODB.Recordset()
        Try
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                _idPacienteSelecionado = CInt(rs.Fields("id_usuario").Value)
                Dim nomePaciente As String = rs.Fields("nome_login").Value.ToString()
                _planoSaudePaciente = rs.Fields("plano_saude").Value.ToString().Trim()

                lbl_pac_selecionado.Text = $"{nomePaciente} (ID: {_idPacienteSelecionado})"

                cmb_especialidade.Enabled = True

            Else
                MessageBox.Show("Paciente não encontrado. Verifique o CPF/Login.", "Erro na Busca")
                lbl_pac_selecionado.Text = "Paciente: Nenhum encontrado"
                cmb_especialidade.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Erro na busca de paciente: " & ex.Message)
        Finally
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End Try
    End Sub

End Class