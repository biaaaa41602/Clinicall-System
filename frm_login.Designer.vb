<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_entrar = New Guna.UI.WinForms.GunaButton()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.txt_usuario = New ns1.BunifuMaterialTextbox()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.cbx_pac = New ns1.BunifuCheckbox()
        Me.cbx_adm = New ns1.BunifuCheckbox()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.GunaPictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 449)
        Me.Panel1.TabIndex = 6
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(-3, 145)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(176, 166)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 19
        Me.GunaPictureBox2.TabStop = False
        '
        'btn_entrar
        '
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BaseColor = System.Drawing.Color.Navy
        Me.btn_entrar.BorderColor = System.Drawing.Color.DarkBlue
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = Nothing
        Me.btn_entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_entrar.Location = New System.Drawing.Point(299, 290)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Size = New System.Drawing.Size(318, 33)
        Me.btn_entrar.TabIndex = 9
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Navy
        Me.BunifuImageButton1.BackgroundImage = CType(resources.GetObject("BunifuImageButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(426, 53)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(72, 60)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_usuario.HintForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.HintText = ""
        Me.txt_usuario.isPassword = False
        Me.txt_usuario.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_usuario.LineIdleColor = System.Drawing.Color.Lavender
        Me.txt_usuario.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_usuario.LineThickness = 3
        Me.txt_usuario.Location = New System.Drawing.Point(299, 145)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(318, 35)
        Me.txt_usuario.TabIndex = 17
        Me.txt_usuario.Text = "Usuário"
        Me.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.White
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = ""
        Me.txt_senha.isPassword = True
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Lavender
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_senha.LineThickness = 3
        Me.txt_senha.Location = New System.Drawing.Point(299, 202)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(318, 35)
        Me.txt_senha.TabIndex = 18
        Me.txt_senha.Text = "Senha"
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Navy
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(413, 255)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(68, 16)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "Paciente"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Navy
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(326, 255)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(50, 32)
        Me.BunifuCustomLabel1.TabIndex = 11
        Me.BunifuCustomLabel1.Text = "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbx_pac
        '
        Me.cbx_pac.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbx_pac.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbx_pac.Checked = True
        Me.cbx_pac.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbx_pac.ForeColor = System.Drawing.Color.White
        Me.cbx_pac.Location = New System.Drawing.Point(386, 255)
        Me.cbx_pac.Name = "cbx_pac"
        Me.cbx_pac.Size = New System.Drawing.Size(20, 20)
        Me.cbx_pac.TabIndex = 14
        '
        'cbx_adm
        '
        Me.cbx_adm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbx_adm.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbx_adm.Checked = True
        Me.cbx_adm.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbx_adm.ForeColor = System.Drawing.Color.White
        Me.cbx_adm.Location = New System.Drawing.Point(299, 255)
        Me.cbx_adm.Name = "cbx_adm"
        Me.cbx_adm.Size = New System.Drawing.Size(20, 20)
        Me.cbx_adm.TabIndex = 10
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(707, 449)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.cbx_pac)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.cbx_adm)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents txt_usuario As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents cbx_pac As ns1.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents cbx_adm As ns1.BunifuCheckbox
End Class
