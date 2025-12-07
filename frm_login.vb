Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports ADODB
Public Class frm_login
    Private DatabaseHelper As Object

    'Private Function AbrirConexaoMySQL() As ADODB.Connection
    '    Try
    '        Dim conn As New ADODB.Connection()
    '        Dim CONNECTION_STRING As String = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=cad_med;UID=root;PWD=usbw;port=3307;Option=3;"

    '        conn.Open(CONNECTION_STRING)
    '        Return conn
    '    Catch ex As Exception
    '        MsgBox("Erro ao conectar banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '        Return Nothing
    '    End Try
    'End Function

    Private Function AbrirConexaoAccess(ByVal dir_banco As String) As ADODB.Connection ' conexão com o banco access
        Try
            Dim conn As New ADODB.Connection()
            Dim CONNECTION_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco & ";"

            conn.Open(CONNECTION_STRING)

            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Return conn
        Catch ex As Exception
            MsgBox("Erro ao Conectar ao Access! Verifique se o caminho do ficheiro " & dir_banco & " está correto. Detalhe: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO DE CONEXÃO")
            Return Nothing
        End Try
    End Function

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        Dim nome_usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        If Not AbrirConexaoDB() Then Return ' verifica se conectou ao banco de dados

        If String.IsNullOrWhiteSpace(nome_usuario) Or String.IsNullOrWhiteSpace(senha) Then  ' verifica se todos os campos estão preenchidos
            MsgBox("Preencha usuário e senha!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Return
        End If

        Dim conn As ADODB.Connection = AbrirConexaoAccess(Application.StartupPath & "\access\cad_med.mdb")
        If conn Is Nothing Then Return
        Dim rs As ADODB.Recordset = Nothing 

        Try
            rs = New ADODB.Recordset()
            Dim sql_query As String = "SELECT [id_usuario], [senha], [status], [tipo_cadastro] FROM [tb_med_pac] WHERE [nome_login] = '" & nome_usuario.Replace("'", "''") & "'"
            rs.Open(sql_query, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                Dim senhacorreta As String
                If Not IsDBNull(rs.Fields("senha").Value) Then
                    senhacorreta = rs.Fields("senha").Value.ToString()
                Else
                    senhacorreta = ""
                End If

                If Not IsDBNull(rs.Fields("id_usuario").Value) Then
                    mod_geral.UsuarioLogadoID = CInt(rs.Fields("id_usuario").Value)
                Else
                    mod_geral.UsuarioLogadoID = 0
                End If

                Dim status As String
                If Not IsDBNull(rs.Fields("status").Value) Then
                    status = rs.Fields("status").Value.ToString().ToUpper()
                Else
                    status = "BLOQUEADO"
                End If

                Dim tipoUsuario As String
                If Not IsDBNull(rs.Fields("tipo_cadastro").Value) Then
                    tipoUsuario = rs.Fields("tipo_cadastro").Value.ToString().ToUpper()
                Else
                    tipoUsuario = "PADRAO"
                End If

                If senha = senhacorreta Then
                    If status.ToUpper() = "BLOQUEADO" Then
                        MsgBox("Usuário bloqueado! Contate o Administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Return
                    End If

                    Dim usuarioSelectAdmin As Boolean = cbx_adm.Checked
                    Dim usuarioSelectPaciente As Boolean = cbx_pac.Checked
                    Dim tipoUsuarioDB As String = rs.Fields("tipo_cadastro").Value.ToString().Trim().ToUpper() 'ADM ou PAC

                    Dim acessoOk As Boolean = False

                    If usuarioSelectAdmin And usuarioSelectPaciente Then 'selecionou os dois perfis
                        MsgBox("Selecione apenas um perfil de acesso!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Return

                    ElseIf Not usuarioSelectAdmin And Not usuarioSelectPaciente Then 'não selecionou nenhum perfil
                        MsgBox("Selecione um perfil de acesso!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Return

                    ElseIf usuarioSelectAdmin And tipoUsuarioDB = "ADM" Then 'usuario admin db admin
                        acessoOk = True

                    ElseIf usuarioSelectPaciente And tipoUsuarioDB = "PACIENTE" Then 'usuario paciente db paciente
                        acessoOk = True

                    End If

                    If Not acessoOk Then 'usuario selecionou perfil diferente do cadastro
                        MsgBox("O perfil selecionado não corresponde ao seu cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Return
                    End If

                    mod_geral.UsuarioLogadoID = rs.Fields("id_usuario").Value
                    mod_geral.UsuarioLogadoTipo = tipoUsuarioDB.Trim().ToUpper()


                    MsgBox("Login feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()

                    If usuarioSelectAdmin Then
                        Dim menu As New frm_menu()
                        menu.AbrirMenu(tipoUsuarioDB)
                    ElseIf usuarioSelectPaciente Then
                        Dim menuPaciente As New frm_menu()
                        menuPaciente.AbrirMenu(tipoUsuarioDB)

                        MsgBox("Bem vindo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                Else
                    MsgBox("Usuário não encontrado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar consultar: " & ex.Message, "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not rs Is Nothing AndAlso rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
            If Not conn Is Nothing AndAlso conn.State = ADODB.ObjectStateEnum.adStateOpen Then conn.Close()
        End Try
    End Sub

End Class