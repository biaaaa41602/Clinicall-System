<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_inicio
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_inicio))
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(290, 97)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Navy
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.SteelBlue
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(861, 597)
        Me.GunaGradientPanel1.TabIndex = 4
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'uc_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Name = "uc_inicio"
        Me.Size = New System.Drawing.Size(861, 597)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
End Class
