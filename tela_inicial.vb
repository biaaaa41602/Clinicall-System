Imports Newtonsoft.Json

Public Class tela_inicial

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        frm_login.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub tela_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.WindowState = FormWindowState.Minimized
            e.SuppressKeyPress = True
        End If
    End Sub

End Class