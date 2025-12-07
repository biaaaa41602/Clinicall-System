<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tela_inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tela_inicial))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_entrar = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btn_sair = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.btn_entrar)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaGradientPanel1.Controls.Add(Me.btn_sair)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1052, 648)
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel2.Location = New System.Drawing.Point(673, 538)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(41, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Entrar"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(25, 72)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(54, 15)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Encerrar"
        '
        'btn_entrar
        '
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BaseColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BorderColor = System.Drawing.Color.Black
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_entrar.Location = New System.Drawing.Point(646, 466)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.Navy
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Size = New System.Drawing.Size(84, 87)
        Me.btn_entrar.TabIndex = 1
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(398, 104)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'btn_sair
        '
        Me.btn_sair.AnimationHoverSpeed = 0.07!
        Me.btn_sair.AnimationSpeed = 0.03!
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BaseColor = System.Drawing.Color.Transparent
        Me.btn_sair.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sair.FocusedColor = System.Drawing.Color.Aquamarine
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_sair.Location = New System.Drawing.Point(0, 0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.Color.Navy
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(101, 87)
        Me.btn_sair.TabIndex = 5
        '
        'tela_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1052, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "tela_inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tela_inicial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
