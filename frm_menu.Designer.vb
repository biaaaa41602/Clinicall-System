<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_inicio = New Guna.UI.WinForms.GunaButton()
        Me.btn_genUsuarios = New Guna.UI.WinForms.GunaButton()
        Me.pnl_submenuUsuarios = New Guna.UI.WinForms.GunaPanel()
        Me.btn_cadUsuarios = New Guna.UI.WinForms.GunaButton()
        Me.btn_genConsultas = New Guna.UI.WinForms.GunaButton()
        Me.pnl_submenuConsultas = New Guna.UI.WinForms.GunaPanel()
        Me.btn_visuConsultas = New Guna.UI.WinForms.GunaButton()
        Me.btn_agenConsultas = New Guna.UI.WinForms.GunaButton()
        Me.btn_encerrar = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.pnl_conteudo = New System.Windows.Forms.Panel()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pnl_submenuUsuarios.SuspendLayout()
        Me.pnl_submenuConsultas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(238, 488)
        Me.GunaGradientPanel1.TabIndex = 2
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_inicio)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_genUsuarios)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnl_submenuUsuarios)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_genConsultas)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnl_submenuConsultas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_encerrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.GunaPanel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(238, 488)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn_inicio
        '
        Me.btn_inicio.AnimationHoverSpeed = 0.07!
        Me.btn_inicio.AnimationSpeed = 0.03!
        Me.btn_inicio.BackColor = System.Drawing.Color.Navy
        Me.btn_inicio.BaseColor = System.Drawing.Color.Transparent
        Me.btn_inicio.BorderColor = System.Drawing.Color.Black
        Me.btn_inicio.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_inicio.FocusedColor = System.Drawing.Color.Empty
        Me.btn_inicio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio.ForeColor = System.Drawing.Color.White
        Me.btn_inicio.Image = Nothing
        Me.btn_inicio.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_inicio.Location = New System.Drawing.Point(3, 3)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_inicio.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_inicio.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_inicio.OnHoverImage = Nothing
        Me.btn_inicio.OnPressedColor = System.Drawing.Color.Black
        Me.btn_inicio.Size = New System.Drawing.Size(235, 43)
        Me.btn_inicio.TabIndex = 2
        Me.btn_inicio.Text = "Início"
        '
        'btn_genUsuarios
        '
        Me.btn_genUsuarios.AnimationHoverSpeed = 0.07!
        Me.btn_genUsuarios.AnimationSpeed = 0.03!
        Me.btn_genUsuarios.BackColor = System.Drawing.Color.Navy
        Me.btn_genUsuarios.BaseColor = System.Drawing.Color.Transparent
        Me.btn_genUsuarios.BorderColor = System.Drawing.Color.Black
        Me.btn_genUsuarios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_genUsuarios.FocusedColor = System.Drawing.Color.Empty
        Me.btn_genUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genUsuarios.ForeColor = System.Drawing.Color.White
        Me.btn_genUsuarios.Image = Nothing
        Me.btn_genUsuarios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_genUsuarios.Location = New System.Drawing.Point(3, 52)
        Me.btn_genUsuarios.Name = "btn_genUsuarios"
        Me.btn_genUsuarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_genUsuarios.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_genUsuarios.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_genUsuarios.OnHoverImage = Nothing
        Me.btn_genUsuarios.OnPressedColor = System.Drawing.Color.Black
        Me.btn_genUsuarios.Size = New System.Drawing.Size(235, 42)
        Me.btn_genUsuarios.TabIndex = 0
        Me.btn_genUsuarios.Text = "Gerenciar Usuários"
        '
        'pnl_submenuUsuarios
        '
        Me.pnl_submenuUsuarios.Controls.Add(Me.btn_cadUsuarios)
        Me.pnl_submenuUsuarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_submenuUsuarios.Location = New System.Drawing.Point(3, 100)
        Me.pnl_submenuUsuarios.Name = "pnl_submenuUsuarios"
        Me.pnl_submenuUsuarios.Size = New System.Drawing.Size(235, 36)
        Me.pnl_submenuUsuarios.TabIndex = 2
        Me.pnl_submenuUsuarios.Visible = False
        '
        'btn_cadUsuarios
        '
        Me.btn_cadUsuarios.AnimationHoverSpeed = 0.07!
        Me.btn_cadUsuarios.AnimationSpeed = 0.03!
        Me.btn_cadUsuarios.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_cadUsuarios.BaseColor = System.Drawing.Color.Transparent
        Me.btn_cadUsuarios.BorderColor = System.Drawing.Color.Black
        Me.btn_cadUsuarios.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cadUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cadUsuarios.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cadUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cadUsuarios.ForeColor = System.Drawing.Color.White
        Me.btn_cadUsuarios.Image = Nothing
        Me.btn_cadUsuarios.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_cadUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btn_cadUsuarios.Name = "btn_cadUsuarios"
        Me.btn_cadUsuarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cadUsuarios.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_cadUsuarios.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cadUsuarios.OnHoverImage = Nothing
        Me.btn_cadUsuarios.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cadUsuarios.Size = New System.Drawing.Size(235, 36)
        Me.btn_cadUsuarios.TabIndex = 0
        Me.btn_cadUsuarios.Text = "Cadastrar Usuários"
        '
        'btn_genConsultas
        '
        Me.btn_genConsultas.AnimationHoverSpeed = 0.07!
        Me.btn_genConsultas.AnimationSpeed = 0.03!
        Me.btn_genConsultas.BackColor = System.Drawing.Color.Navy
        Me.btn_genConsultas.BaseColor = System.Drawing.Color.Transparent
        Me.btn_genConsultas.BorderColor = System.Drawing.Color.Black
        Me.btn_genConsultas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_genConsultas.FocusedColor = System.Drawing.Color.Empty
        Me.btn_genConsultas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genConsultas.ForeColor = System.Drawing.Color.White
        Me.btn_genConsultas.Image = Nothing
        Me.btn_genConsultas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_genConsultas.Location = New System.Drawing.Point(3, 142)
        Me.btn_genConsultas.Name = "btn_genConsultas"
        Me.btn_genConsultas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_genConsultas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_genConsultas.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_genConsultas.OnHoverImage = Nothing
        Me.btn_genConsultas.OnPressedColor = System.Drawing.Color.Black
        Me.btn_genConsultas.Size = New System.Drawing.Size(235, 43)
        Me.btn_genConsultas.TabIndex = 1
        Me.btn_genConsultas.Text = "Gerenciar Consultas"
        '
        'pnl_submenuConsultas
        '
        Me.pnl_submenuConsultas.Controls.Add(Me.btn_visuConsultas)
        Me.pnl_submenuConsultas.Controls.Add(Me.btn_agenConsultas)
        Me.pnl_submenuConsultas.Location = New System.Drawing.Point(3, 191)
        Me.pnl_submenuConsultas.Name = "pnl_submenuConsultas"
        Me.pnl_submenuConsultas.Size = New System.Drawing.Size(235, 75)
        Me.pnl_submenuConsultas.TabIndex = 4
        Me.pnl_submenuConsultas.Visible = False
        '
        'btn_visuConsultas
        '
        Me.btn_visuConsultas.AnimationHoverSpeed = 0.07!
        Me.btn_visuConsultas.AnimationSpeed = 0.03!
        Me.btn_visuConsultas.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_visuConsultas.BaseColor = System.Drawing.Color.Transparent
        Me.btn_visuConsultas.BorderColor = System.Drawing.Color.Black
        Me.btn_visuConsultas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_visuConsultas.FocusedColor = System.Drawing.Color.Empty
        Me.btn_visuConsultas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_visuConsultas.ForeColor = System.Drawing.Color.White
        Me.btn_visuConsultas.Image = Nothing
        Me.btn_visuConsultas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_visuConsultas.Location = New System.Drawing.Point(0, 39)
        Me.btn_visuConsultas.Name = "btn_visuConsultas"
        Me.btn_visuConsultas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_visuConsultas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_visuConsultas.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_visuConsultas.OnHoverImage = Nothing
        Me.btn_visuConsultas.OnPressedColor = System.Drawing.Color.Black
        Me.btn_visuConsultas.Size = New System.Drawing.Size(235, 32)
        Me.btn_visuConsultas.TabIndex = 1
        Me.btn_visuConsultas.Text = "Visualizar Consultas"
        '
        'btn_agenConsultas
        '
        Me.btn_agenConsultas.AnimationHoverSpeed = 0.07!
        Me.btn_agenConsultas.AnimationSpeed = 0.03!
        Me.btn_agenConsultas.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_agenConsultas.BaseColor = System.Drawing.Color.Transparent
        Me.btn_agenConsultas.BorderColor = System.Drawing.Color.Black
        Me.btn_agenConsultas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_agenConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_agenConsultas.FocusedColor = System.Drawing.Color.Empty
        Me.btn_agenConsultas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_agenConsultas.ForeColor = System.Drawing.Color.White
        Me.btn_agenConsultas.Image = Nothing
        Me.btn_agenConsultas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_agenConsultas.Location = New System.Drawing.Point(0, 0)
        Me.btn_agenConsultas.Name = "btn_agenConsultas"
        Me.btn_agenConsultas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_agenConsultas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_agenConsultas.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_agenConsultas.OnHoverImage = Nothing
        Me.btn_agenConsultas.OnPressedColor = System.Drawing.Color.Black
        Me.btn_agenConsultas.Size = New System.Drawing.Size(235, 33)
        Me.btn_agenConsultas.TabIndex = 0
        Me.btn_agenConsultas.Text = "Agendar Consultas"
        '
        'btn_encerrar
        '
        Me.btn_encerrar.AnimationHoverSpeed = 0.07!
        Me.btn_encerrar.AnimationSpeed = 0.03!
        Me.btn_encerrar.BackColor = System.Drawing.Color.Navy
        Me.btn_encerrar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_encerrar.BorderColor = System.Drawing.Color.Black
        Me.btn_encerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_encerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_encerrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_encerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar.ForeColor = System.Drawing.Color.White
        Me.btn_encerrar.Image = Nothing
        Me.btn_encerrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_encerrar.Location = New System.Drawing.Point(3, 272)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_encerrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_encerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_encerrar.OnHoverImage = Nothing
        Me.btn_encerrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_encerrar.Size = New System.Drawing.Size(235, 45)
        Me.btn_encerrar.TabIndex = 3
        Me.btn_encerrar.Text = "Encerrar Sessão"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Location = New System.Drawing.Point(244, 3)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(200, 200)
        Me.GunaPanel1.TabIndex = 3
        '
        'pnl_conteudo
        '
        Me.pnl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_conteudo.Location = New System.Drawing.Point(238, 0)
        Me.pnl_conteudo.Name = "pnl_conteudo"
        Me.pnl_conteudo.Size = New System.Drawing.Size(602, 488)
        Me.pnl_conteudo.TabIndex = 4
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 488)
        Me.Controls.Add(Me.pnl_conteudo)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_menu"
        Me.Text = "MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pnl_submenuUsuarios.ResumeLayout(False)
        Me.pnl_submenuConsultas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents pnl_submenuConsultas As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_visuConsultas As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_agenConsultas As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnl_submenuUsuarios As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_cadUsuarios As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_genUsuarios As Guna.UI.WinForms.GunaButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_genConsultas As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_encerrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnl_conteudo As Panel
    Friend WithEvents btn_inicio As Guna.UI.WinForms.GunaButton
End Class
