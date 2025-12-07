<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagar_consulta
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
        Me.btn_comprar = New Guna.UI.WinForms.GunaButton()
        Me.cmb_metodo_pag = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_valor_consulta = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel4 = New Guna.UI.WinForms.GunaLinePanel()
        Me.SuspendLayout()
        '
        'btn_comprar
        '
        Me.btn_comprar.AnimationHoverSpeed = 0.07!
        Me.btn_comprar.AnimationSpeed = 0.03!
        Me.btn_comprar.BackColor = System.Drawing.Color.Transparent
        Me.btn_comprar.BaseColor = System.Drawing.Color.Navy
        Me.btn_comprar.BorderColor = System.Drawing.Color.Black
        Me.btn_comprar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_comprar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_comprar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprar.ForeColor = System.Drawing.Color.White
        Me.btn_comprar.Image = Nothing
        Me.btn_comprar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_comprar.Location = New System.Drawing.Point(106, 213)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_comprar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_comprar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_comprar.OnHoverImage = Nothing
        Me.btn_comprar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_comprar.Radius = 4
        Me.btn_comprar.Size = New System.Drawing.Size(256, 33)
        Me.btn_comprar.TabIndex = 32
        Me.btn_comprar.Text = "Finalizar compra"
        Me.btn_comprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_metodo_pag
        '
        Me.cmb_metodo_pag.BackColor = System.Drawing.Color.Transparent
        Me.cmb_metodo_pag.BaseColor = System.Drawing.Color.White
        Me.cmb_metodo_pag.BorderColor = System.Drawing.Color.Silver
        Me.cmb_metodo_pag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_metodo_pag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_metodo_pag.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_metodo_pag.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_metodo_pag.ForeColor = System.Drawing.Color.Black
        Me.cmb_metodo_pag.FormattingEnabled = True
        Me.cmb_metodo_pag.Location = New System.Drawing.Point(105, 154)
        Me.cmb_metodo_pag.Name = "cmb_metodo_pag"
        Me.cmb_metodo_pag.OnHoverItemBaseColor = System.Drawing.Color.Navy
        Me.cmb_metodo_pag.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_metodo_pag.Radius = 4
        Me.cmb_metodo_pag.Size = New System.Drawing.Size(257, 26)
        Me.cmb_metodo_pag.TabIndex = 31
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(103, 135)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(129, 15)
        Me.GunaLabel2.TabIndex = 30
        Me.GunaLabel2.Text = "Método de Pagamento"
        '
        'cmb_valor_consulta
        '
        Me.cmb_valor_consulta.BackColor = System.Drawing.Color.Transparent
        Me.cmb_valor_consulta.BaseColor = System.Drawing.Color.White
        Me.cmb_valor_consulta.BorderColor = System.Drawing.Color.Silver
        Me.cmb_valor_consulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_valor_consulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_valor_consulta.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_valor_consulta.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_valor_consulta.ForeColor = System.Drawing.Color.Black
        Me.cmb_valor_consulta.FormattingEnabled = True
        Me.cmb_valor_consulta.Location = New System.Drawing.Point(105, 100)
        Me.cmb_valor_consulta.Name = "cmb_valor_consulta"
        Me.cmb_valor_consulta.OnHoverItemBaseColor = System.Drawing.Color.Navy
        Me.cmb_valor_consulta.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_valor_consulta.Radius = 4
        Me.cmb_valor_consulta.Size = New System.Drawing.Size(257, 26)
        Me.cmb_valor_consulta.TabIndex = 29
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(103, 82)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(99, 15)
        Me.GunaLabel1.TabIndex = 28
        Me.GunaLabel1.Text = "Valor da Consulta"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Navy
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(22, 311)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(417, 11)
        Me.GunaLinePanel1.TabIndex = 33
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.Navy
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(22, 12)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(417, 11)
        Me.GunaLinePanel2.TabIndex = 34
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.BackColor = System.Drawing.Color.Navy
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.Location = New System.Drawing.Point(22, 22)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(10, 297)
        Me.GunaLinePanel3.TabIndex = 0
        '
        'GunaLinePanel4
        '
        Me.GunaLinePanel4.BackColor = System.Drawing.Color.Navy
        Me.GunaLinePanel4.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel4.Location = New System.Drawing.Point(429, 22)
        Me.GunaLinePanel4.Name = "GunaLinePanel4"
        Me.GunaLinePanel4.Size = New System.Drawing.Size(10, 297)
        Me.GunaLinePanel4.TabIndex = 35
        '
        'pagar_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(460, 344)
        Me.Controls.Add(Me.GunaLinePanel4)
        Me.Controls.Add(Me.GunaLinePanel3)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.btn_comprar)
        Me.Controls.Add(Me.cmb_metodo_pag)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.cmb_valor_consulta)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pagar_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pagar_consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_comprar As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmb_metodo_pag As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_valor_consulta As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLinePanel4 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
End Class
