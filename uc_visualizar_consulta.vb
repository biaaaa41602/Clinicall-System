Imports System.Reflection
Imports System.Security.Cryptography
Imports proj_engsoft1.uc_add_consultas

Public Class uc_visualizar_consulta
    Private Sub uc_visualizar_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDatasFiltro()
        AplicarVisibilidadeBaseadaNoPerfil()
        CarregarConsultas()
    End Sub

    Private Sub uc_visualizar_consulta_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            AplicarVisibilidadeBaseadaNoPerfil()
            CarregarConsultas() ' Recarregar sempre que a tela for reaberta
        End If
    End Sub

    Private Sub AplicarVisibilidadeBaseadaNoPerfil()
        Dim isPaciente As Boolean = mod_geral.UsuarioLogadoTipo.Trim().ToUpper() = "PACIENTE"

        txt_nomepesquisa.Visible = Not isPaciente
        cmb_datafiltro.Visible = Not isPaciente
        btn_buscarr.Visible = Not isPaciente
        ToolStrip2.Visible = Not isPaciente
    End Sub

    Public Sub CarregarConsultas()
        If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then
            MessageBox.Show("A conexão com o banco não está aberta. Verifique o módulo de conexão.", "Erro de Conexão")
            Return
        End If

        Dim rs As New ADODB.Recordset()
        Dim sqlBase As String
        Dim sqlWhere As New System.Text.StringBuilder()
        Dim isWhereAdded As Boolean = False

        If mod_geral.UsuarioLogadoTipo.Trim().ToUpper() = "PACIENTE" Then
            sqlWhere.Append($" WHERE P.id_usuario = {mod_geral.UsuarioLogadoID} ")
            isWhereAdded = True
        Else
            Dim nomeBusca As String = txt_nomepesquisa.Text.Trim().Replace("'", "''")

            If Not String.IsNullOrWhiteSpace(nomeBusca) Then
                sqlWhere.Append($" WHERE (P.nome_login LIKE '%{nomeBusca}%' OR M.nome LIKE '%{nomeBusca}%') ")
                isWhereAdded = True
            End If

            If cmb_datafiltro.SelectedIndex > 0 Then

                Dim itemSelecionado As ComboItem = DirectCast(cmb_datafiltro.SelectedItem, ComboItem)

                If TypeOf itemSelecionado.Value Is Date Then
                    Dim dataParaFiltrar As Date = CDate(itemSelecionado.Value)
                    Dim dataFiltro As String = dataParaFiltrar.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)

                    If isWhereAdded Then
                        sqlWhere.Append(" AND ")
                    Else
                        sqlWhere.Append(" WHERE ")
                        isWhereAdded = True
                    End If
                    sqlWhere.Append(" C.data_consulta = #" & dataFiltro & "# ")
                End If
            End If

        End If

        sqlBase =
        "SELECT " &
        "C.id_consulta, " &
        "P.nome_login AS Paciente, " & ' nome de login do paciente/usuário
        "M.nome AS Medico, " &
        "M.especialidade AS Especialidade, " &
        "C.data_consulta, " &
        "C.hora_consulta " &
        "FROM (tb_consultas AS C " &
        "INNER JOIN tb_med_pac AS P ON C.id_paciente = P.id_usuario) " &
        "INNER JOIN tb_medico AS M ON C.id_medico = M.id_medico "

        Dim sqlFinal As String = sqlBase & sqlWhere.ToString() &
        " ORDER BY C.data_consulta DESC, C.hora_consulta ASC"

        Try
            rs.Open(sqlFinal, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            dgv_consultas.Rows.Clear()

            If dgv_consultas.ColumnCount < 6 Then
                MessageBox.Show("Erro: O DataGridView não tem as 6 colunas esperadas.", "Configuração Incorreta")
                Return
            End If

            While Not rs.EOF
                Dim dataConsulta As Date = IIf(IsDBNull(rs.Fields("data_consulta").Value), Date.MinValue, CDate(rs.Fields("data_consulta").Value))
                Dim horaConsulta As Date = IIf(IsDBNull(rs.Fields("hora_consulta").Value), Date.MinValue, CDate(rs.Fields("hora_consulta").Value))

                Dim dataHoraDisplay As String = $"{dataConsulta.ToShortDateString()} às {horaConsulta.ToShortTimeString()}"

                Dim statusConsulta As String

                If dataConsulta < Date.Today Then
                    statusConsulta = "Realizada"
                ElseIf dataConsulta = Date.Today AndAlso horaConsulta.TimeOfDay < Date.Now.TimeOfDay Then
                    statusConsulta = "Em andamento"
                Else
                    statusConsulta = "Agendada"
                End If

                dgv_consultas.Rows.Add(
                rs.Fields("id_consulta").Value,
                rs.Fields("Paciente").Value,
                rs.Fields("Medico").Value,
                rs.Fields("Especialidade").Value,
                dataHoraDisplay,
                statusConsulta
                )

                rs.MoveNext()
            End While

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar consultas: " & ex.Message & vbCrLf & "SQL Final Executado: " & sqlFinal, "Erro de SQL")
        Finally
            If rs IsNot Nothing AndAlso rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End Try

    End Sub

    Public Class ComboItem
        Public Property Text As String
        Public Property Value As Object

        Public Sub New(text As String, value As Object)
            Me.Text = text
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub txt_nomepesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_nomepesquisa.TextChanged
        If mod_geral.UsuarioLogadoTipo.Trim().ToUpper() <> "PACIENTE" Then
            CarregarConsultas()
        End If
    End Sub

    Private Sub cmb_datafiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_datafiltro.SelectedIndexChanged
        If mod_geral.UsuarioLogadoTipo.Trim().ToUpper() <> "PACIENTE" Then
            CarregarConsultas()
        End If
    End Sub

    Private Sub CarregarDatasFiltro()
        cmb_datafiltro.Items.Clear()

        cmb_datafiltro.Items.Add(New ComboItem("Todas as Datas", "ALL"))

        ' Carrega 15 dias
        For i As Integer = 0 To 14
            Dim data As Date = Date.Today.AddDays(i)

            Dim nomeDia As String
            If i = 0 Then
                nomeDia = "Hoje"
            ElseIf i = 1 Then
                nomeDia = "Amanhã"
            Else
                nomeDia = data.ToString("dddd", System.Globalization.CultureInfo.CurrentCulture)
            End If

            Dim textoExibicao As String = $"{nomeDia}, {data.ToShortDateString()}"

            cmb_datafiltro.Items.Add(New ComboItem(textoExibicao, data.Date))
        Next

        cmb_datafiltro.SelectedIndex = 0
    End Sub

    Private Sub dgv_consultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultas.CellContentClick

        If e.RowIndex < 0 Then Return

        If dgv_consultas.Columns(e.ColumnIndex).Name = "btn_excluir" Then

            Dim idConsulta As Integer = CInt(dgv_consultas.Rows(e.RowIndex).Cells(0).Value)
            Dim statusConsulta As String = dgv_consultas.Rows(e.RowIndex).Cells(5).Value.ToString()

            If statusConsulta = "Realizada" Then
                MessageBox.Show("Consultas já realizadas não podem ser excluídas.", "Ação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim podeExcluir As Boolean = (mod_geral.UsuarioLogadoTipo.Trim().ToUpper() <> "PACIENTE") ' Admin pode excluir

            If MessageBox.Show("Tem certeza que deseja cancelar/excluir esta consulta?", "Confirmar Exclusão/Cancelamento",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                ExcluirConsulta(idConsulta)
            End If
        End If

    End Sub

    Private Sub ExcluirConsulta(idConsulta As Integer)
        If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then
            MessageBox.Show("A conexão com o banco não está aberta.", "Erro de Conexão")
            Return
        End If

        Try
            Dim sqlDel As String = $"DELETE FROM tb_consultas WHERE id_consulta = {idConsulta}"
            db.Execute(sqlDel)


            MessageBox.Show("Consulta cancelada/excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CarregarConsultas() ' Atualiza a lista

        Catch ex As Exception
            MessageBox.Show("Erro ao cancelar/excluir a consulta: " & ex.Message, "Erro no Banco de Dados")
        End Try
    End Sub

    Private Sub btn_buscarr_Click(sender As Object, e As EventArgs) Handles btn_buscarr.Click
        CarregarConsultas()
    End Sub
End Class