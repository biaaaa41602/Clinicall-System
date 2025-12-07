Imports System.ComponentModel.Design.Serialization
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports System.Security.Cryptography
Imports System.Security.Permissions
Imports System.Windows.Forms
Imports ADODB

Module mod_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp As String 'Declaração de variaveis
    Public cont As Integer
    Public dir_banco = Application.StartupPath & "\access\cad_med.mdb"
    Public UsuarioLogadoID As Integer = 0
    Public UsuarioLogadoTipo As String = "" ' paciente ou admin

    Public Function AbrirConexaoDB() As Boolean
        Try
            If db.State <> ADODB.ObjectStateEnum.adStateOpen Then

                Dim CONNECTION_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\access\cad_med.mdb" & ";"

                db.Open(CONNECTION_STRING)
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show("ERRO CRÍTICO ao conectar ao banco de dados: " & ex.Message, "Falha de Conexão Global")
            Return False
        End Try
    End Function

    Public Sub FecharConexaoDB()
        If db IsNot Nothing AndAlso db.State = ADODB.ObjectStateEnum.adStateOpen Then
            db.Close()
        End If
    End Sub

    Sub conectar_banco_MySQL()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=cad_med;UID=root;PWD=usbw;port=3307;option=3;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    'Sub conectar_banco_access()
    '    Try
    '        db = CreateObject("ADODB.Connection")
    '        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
    '        MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    '    Catch ex As Exception
    '        MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
    '    End Try
    'End Sub

    'Sub carregar_dados()
    '    With uc_cad_usuarios.dgv_dados
    '        sql = "select*from tb_med_pac order by nome_login asc"
    '        rs = db.Execute(sql)
    '        cont = 0
    '        .Rows.Clear()
    '        Do While rs.EOF = False
    '            .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
    '            rs.MoveNext()
    '            cont = cont + 1

    '        Loop
    '    End With
    'End Sub

End Module
