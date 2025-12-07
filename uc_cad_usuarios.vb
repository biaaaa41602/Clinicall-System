Imports ADODB

Public Class uc_cad_usuarios
        Inherits UserControl

        Private rs As ADODB.Recordset
        Private db As ADODB.Connection
        Private diretorio As String
        Private Sql As String
        Private cont As Integer

    Private Function AbrirConexaoAccess(ByVal dir_banco As String) As ADODB.Connection
            Try
                Dim conn As New ADODB.Connection()
                Dim CONNECTION_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco & ";"

                conn.Open(CONNECTION_STRING)

                MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                Return conn
            Catch ex As Exception
                MsgBox("Erro ao Conectar ao Access! Caminho inválido: " & dir_banco & vbCrLf &
                       "Detalhe: " & ex.Message,
                       MsgBoxStyle.Critical, "ERRO DE CONEXÃO")
                Return Nothing
            End Try
        End Function

    Private Sub limpar_campos()
        txt_cpff.Clear()
        txt_nome.Clear()
        txt_senha.Clear()
        txt_email.Clear()
        txt_tell.Clear()

        cmb_planosaude.SelectedIndex = -1

        txt_cpff.Focus()
    End Sub

    Private Sub limpar_campos_parcial()
        txt_senha.Clear()
        txt_email.Clear()
        txt_tell.Clear()

        cmb_planosaude.SelectedIndex = -1
    End Sub

    Private Sub uc_cad_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = AbrirConexaoAccess(Application.StartupPath & "\access\cad_med.mdb")

        cmb_planosaude.Items.Add("Particular")
        cmb_planosaude.Items.Add("SulAmérica")
        cmb_planosaude.Items.Add("Amil")
        cmb_planosaude.Items.Add("Santa Helena")
        cmb_planosaude.Items.Add("Unimed")
        cmb_planosaude.Items.Add("Hapvida")
        cmb_planosaude.Items.Add("Notredame")
        cmb_planosaude.Items.Add("Bradesco")
        cmb_planosaude.Items.Add("Outro")


        If db IsNot Nothing Then
            carregar_dados()
        Else
            MsgBox("Erro ao conectar banco de dados!", MsgBoxStyle.Critical, "ATENÇÃO")
        End If

    End Sub

    Sub carregar_dados()
        If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then
            MessageBox.Show("A conexão com o banco não está aberta.", "Erro")
            Return
        End If

        rs = New ADODB.Recordset()

        Try
            Sql = "SELECT id_usuario, cpf, tipo_cadastro, nome_login, email, tell, status FROM tb_med_pac ORDER BY nome_login asc"

            rs.Open(Sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            dgv_dados.Rows.Clear()

            Do While Not rs.EOF
                Dim isActive As Boolean = (rs.Fields("status").Value.ToString().ToLower() = "ativo")

                dgv_dados.Rows.Add(
                        rs.Fields("id_usuario").Value,
                        rs.Fields("tipo_cadastro").Value,
                        rs.Fields("cpf").Value,
                        rs.Fields("nome_login").Value,
                        "EXCLUIR",
                        isActive
                    )

                rs.MoveNext()
            Loop

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        Finally
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
            End Try
        End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then Return

        Dim rsCheck As ADODB.Recordset = Nothing

        If String.IsNullOrWhiteSpace(txt_cpff.Text) OrElse
       String.IsNullOrWhiteSpace(txt_nome.Text) OrElse
       String.IsNullOrWhiteSpace(txt_senha.Text) Then

            MsgBox("CPF, Nome/Login e Senha são obrigatórios!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim cpf As String = txt_cpff.Text.Replace("'", "''")
            Dim nomeLogin As String = txt_nome.Text.Replace("'", "''")
            Dim senha As String = txt_senha.Text.Replace("'", "''")
            Dim email As String = txt_email.Text.Replace("'", "''")
            Dim telefone As String = txt_tell.Text.Replace("'", "''")
            Dim planoSaude As String = cmb_planosaude.Text.Replace("'", "''")
            Dim dataNasc As String = dtp_datanasc.Value.ToString("yyyy-MM-dd")

            Dim tipoCadastro As String = "Paciente"
            Dim statusInicial As String = "ativo"

            Sql = $"SELECT * FROM tb_med_pac WHERE cpf='{cpf}'"
            rsCheck = db.Execute(Sql)

            If Not rsCheck.EOF Then
                Sql = "UPDATE tb_med_pac SET " &
                        $"nome_login='{nomeLogin}', " &
                        $"senha='{senha}', " &
                        $"email='{email}', " &
                        $"tell='{telefone}', " &
                        $"data_nasc='{dataNasc}', " &
                        $"plano_saude='{planoSaude}', " &
                        $"tipo_cadastro='{tipoCadastro}' " &
                  $"WHERE cpf='{cpf}'"

                db.Execute(Sql)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information)

            Else
                Sql = "INSERT INTO tb_med_pac (cpf, nome_login, senha, email, tell, data_nasc, plano_saude, tipo_cadastro, status) VALUES (" &
                        $"'{cpf}', '{nomeLogin}', '{senha}', '{email}', '{telefone}', '{dataNasc}', '{planoSaude}', '{tipoCadastro}', '{statusInicial}')"

                db.Execute(Sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information)
            End If

            carregar_dados()
            limpar_campos()

        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txt_cpff_LostFocus(sender As Object, e As EventArgs) Handles txt_cpff.LostFocus
        Try
            If String.IsNullOrWhiteSpace(txt_cpff.Text) Then Return

            Sql = $"SELECT * FROM tb_med_pac WHERE cpf='{txt_cpff.Text.Replace("'", "''")}'"
            rs = db.Execute(Sql)

            If Not rs.EOF Then
                txt_nome.Text = rs.Fields("nome_login").Value
                txt_senha.Text = rs.Fields("senha").Value
                txt_email.Text = rs.Fields("email").Value
                txt_tell.Text = rs.Fields("tell").Value
                dtp_datanasc.Value = rs.Fields("data_nasc").Value
                cmb_planosaude.Text = rs.Fields("plano_saude").Value
            Else
                Dim tempCpf As String = txt_cpff.Text
                limpar_campos_parcial()
                txt_cpff.Text = tempCpf
                txt_nome.Focus()
            End If

        Catch ex As Exception
            MsgBox("Erro ao consultar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 4 Then
            If MessageBox.Show("Excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim id_usuario As Integer = dgv_dados.Rows(e.RowIndex).Cells(0).Value
                ExcluirUsuario(id_usuario)
                carregar_dados()

            End If

        ElseIf e.ColumnIndex = 5 Then
                dgv_dados.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End Sub

    Private Sub dgv_dados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellValueChanged
        If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            Dim id As Integer

            If Integer.TryParse(dgv_dados.Rows(e.RowIndex).Cells(0).Value.ToString(), id) Then
                Dim isChecked As Boolean = CBool(dgv_dados.Rows(e.RowIndex).Cells(5).Value)
                Dim novo_status As String = If(isChecked, "ativo", "bloqueado")
                AtualizarStatus(id, novo_status)
            End If
        End If
    End Sub

    Private Sub AtualizarStatus(id As Integer, status As String)
            Try
                db.Execute("UPDATE tb_med_pac SET status = '" & status & "' WHERE id_usuario = " & id)
            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar: " & ex.Message)
            End Try
        End Sub

    Private Sub ExcluirUsuario(id As Integer)
        Try
            db.Execute($"DELETE FROM tb_med_pac WHERE id_usuario = {id}")
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir: " & ex.Message)
        End Try
    End Sub

End Class