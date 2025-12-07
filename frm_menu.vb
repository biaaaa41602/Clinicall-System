Public Class frm_menu
    Public Property perfil_usuario As String
    Public db As ADODB.Connection

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirTela(New uc_inicio()) 'abre a tela inicial ao abrir o menu
    End Sub

    Public Sub AbrirMenu(ByVal perfil As String)
        Me.perfil_usuario = perfil

        AjustarMenuPorPerfil()
        Me.Show()
    End Sub

    Private Sub AbrirTela(tela As UserControl)
        pnl_conteudo.Controls.Clear()
        tela.Dock = DockStyle.Fill
        pnl_conteudo.Controls.Add(tela)
    End Sub

    Private Sub btn_genUsuarios_Click(sender As Object, e As EventArgs) Handles btn_genUsuarios.Click

        pnl_submenuUsuarios.Visible = Not pnl_submenuUsuarios.Visible ' alternar visibilidade do submenu

        If pnl_submenuConsultas.Visible Then
                pnl_submenuConsultas.Visible = False
            End If

        Me.FlowLayoutPanel1.PerformLayout()

    End Sub

    Private Sub btn_genConsultas_Click(sender As Object, e As EventArgs) Handles btn_genConsultas.Click
        pnl_submenuConsultas.Visible = Not pnl_submenuConsultas.Visible

        If pnl_submenuUsuarios.Visible Then
            pnl_submenuUsuarios.Visible = False
        End If

        Me.FlowLayoutPanel1.PerformLayout()

    End Sub

    Private Sub btn_cadUsuarios_Click(sender As Object, e As EventArgs) Handles btn_cadUsuarios.Click
        AbrirTela(New uc_cad_usuarios())
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        AbrirTela(New uc_inicio())
    End Sub

    Private Sub btn_agenConsultas_Click(sender As Object, e As EventArgs) Handles btn_agenConsultas.Click
        AbrirTela(New uc_add_consultas())
    End Sub

    Private Sub btn_visuConsultas_Click(sender As Object, e As EventArgs) Handles btn_visuConsultas.Click
        AbrirTela(New uc_visualizar_consulta())
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        tela_inicial.Show()
        Me.Close()
    End Sub

    Private Sub AjustarMenuPorPerfil() ' ajusta a visibilidade dos botões com base no perfil do usuário

        If perfil_usuario = "PACIENTE" Then
            btn_inicio.Visible = True
            btn_genUsuarios.Visible = False
            btn_cadUsuarios.Visible = False
            btn_genConsultas.Visible = True
            btn_agenConsultas.Visible = False
            btn_visuConsultas.Visible = True
            btn_encerrar.Visible = True
            pnl_submenuUsuarios.Visible = False
            pnl_submenuConsultas.Visible = False

        ElseIf perfil_usuario = "ADM" Then
            btn_genUsuarios.Visible = True
            btn_cadUsuarios.Visible = True
            btn_genConsultas.Visible = True
            btn_agenConsultas.Visible = True
            btn_visuConsultas.Visible = True
            btn_encerrar.Visible = True
            btn_inicio.Visible = True
        End If

        FlowLayoutPanel1.PerformLayout()
    End Sub

End Class
