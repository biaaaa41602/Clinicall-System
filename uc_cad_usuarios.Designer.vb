<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_cad_usuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_cad_usuarios))
        Me.txt_cpff = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btn_salvar = New Guna.UI.WinForms.GunaButton()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_tell = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_planosaude = New Guna.UI.WinForms.GunaComboBox()
        Me.dtp_datanasc = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txt_email = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_nome = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_dados = New ns1.BunifuCustomDataGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cpff
        '
        Me.txt_cpff.BackColor = System.Drawing.Color.Transparent
        Me.txt_cpff.BaseColor = System.Drawing.Color.White
        Me.txt_cpff.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpff.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpff.FocusedBorderColor = System.Drawing.Color.Navy
        Me.txt_cpff.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpff.Location = New System.Drawing.Point(136, 189)
        Me.txt_cpff.Name = "txt_cpff"
        Me.txt_cpff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpff.Radius = 8
        Me.txt_cpff.SelectedText = ""
        Me.txt_cpff.Size = New System.Drawing.Size(314, 26)
        Me.txt_cpff.TabIndex = 58
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'btn_salvar
        '
        Me.btn_salvar.Animated = True
        Me.btn_salvar.AnimationHoverSpeed = 0.07!
        Me.btn_salvar.AnimationSpeed = 0.03!
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BaseColor = System.Drawing.Color.Blue
        Me.btn_salvar.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salvar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_salvar.Location = New System.Drawing.Point(831, 284)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.Navy
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Radius = 8
        Me.btn_salvar.Size = New System.Drawing.Size(97, 26)
        Me.btn_salvar.TabIndex = 53
        Me.btn_salvar.Text = "SALVAR"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Transparent
        Me.txt_senha.BaseColor = System.Drawing.Color.White
        Me.txt_senha.BorderColor = System.Drawing.Color.Silver
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_senha.FocusedBorderColor = System.Drawing.Color.Navy
        Me.txt_senha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha.Location = New System.Drawing.Point(520, 285)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha.Radius = 8
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(236, 26)
        Me.txt_senha.TabIndex = 52
        '
        'txt_tell
        '
        Me.txt_tell.BackColor = System.Drawing.Color.Transparent
        Me.txt_tell.BaseColor = System.Drawing.Color.White
        Me.txt_tell.BorderColor = System.Drawing.Color.Silver
        Me.txt_tell.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_tell.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_tell.FocusedBorderColor = System.Drawing.Color.Navy
        Me.txt_tell.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_tell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_tell.Location = New System.Drawing.Point(139, 284)
        Me.txt_tell.Name = "txt_tell"
        Me.txt_tell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_tell.Radius = 8
        Me.txt_tell.SelectedText = ""
        Me.txt_tell.Size = New System.Drawing.Size(311, 26)
        Me.txt_tell.TabIndex = 51
        '
        'cmb_planosaude
        '
        Me.cmb_planosaude.BackColor = System.Drawing.Color.Transparent
        Me.cmb_planosaude.BaseColor = System.Drawing.Color.White
        Me.cmb_planosaude.BorderColor = System.Drawing.Color.Silver
        Me.cmb_planosaude.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_planosaude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_planosaude.FocusedColor = System.Drawing.Color.Navy
        Me.cmb_planosaude.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_planosaude.ForeColor = System.Drawing.Color.Black
        Me.cmb_planosaude.FormattingEnabled = True
        Me.cmb_planosaude.Location = New System.Drawing.Point(521, 237)
        Me.cmb_planosaude.Name = "cmb_planosaude"
        Me.cmb_planosaude.OnHoverItemBaseColor = System.Drawing.Color.Navy
        Me.cmb_planosaude.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_planosaude.Radius = 8
        Me.cmb_planosaude.Size = New System.Drawing.Size(235, 26)
        Me.cmb_planosaude.TabIndex = 50
        '
        'dtp_datanasc
        '
        Me.dtp_datanasc.BackColor = System.Drawing.Color.Transparent
        Me.dtp_datanasc.BaseColor = System.Drawing.Color.White
        Me.dtp_datanasc.BorderColor = System.Drawing.Color.Silver
        Me.dtp_datanasc.CustomFormat = Nothing
        Me.dtp_datanasc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_datanasc.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_datanasc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_datanasc.ForeColor = System.Drawing.Color.Black
        Me.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_datanasc.Location = New System.Drawing.Point(522, 189)
        Me.dtp_datanasc.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_datanasc.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_datanasc.Name = "dtp_datanasc"
        Me.dtp_datanasc.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp_datanasc.OnHoverBorderColor = System.Drawing.Color.Navy
        Me.dtp_datanasc.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_datanasc.OnPressedColor = System.Drawing.Color.Black
        Me.dtp_datanasc.Radius = 8
        Me.dtp_datanasc.Size = New System.Drawing.Size(234, 26)
        Me.dtp_datanasc.TabIndex = 49
        Me.dtp_datanasc.Text = "05/11/2025"
        Me.dtp_datanasc.Value = New Date(2025, 11, 5, 0, 0, 0, 0)
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.Transparent
        Me.txt_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_email.BaseColor = System.Drawing.Color.White
        Me.txt_email.BorderColor = System.Drawing.Color.Silver
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_email.FocusedBorderColor = System.Drawing.Color.Navy
        Me.txt_email.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email.Location = New System.Drawing.Point(136, 237)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.Radius = 8
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(314, 26)
        Me.txt_email.TabIndex = 48
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.Transparent
        Me.txt_nome.BaseColor = System.Drawing.Color.White
        Me.txt_nome.BorderColor = System.Drawing.Color.Silver
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nome.FocusedBorderColor = System.Drawing.Color.Navy
        Me.txt_nome.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome.Location = New System.Drawing.Point(136, 141)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.Radius = 8
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.Size = New System.Drawing.Size(314, 26)
        Me.txt_nome.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(519, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Senha"
        '
        'dgv_dados
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_dados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column11, Me.Column3, Me.Column1, Me.Column9, Me.Column10})
        Me.dgv_dados.DoubleBuffered = True
        Me.dgv_dados.EnableHeadersVisualStyles = False
        Me.dgv_dados.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_dados.HeaderBgColor = System.Drawing.Color.Navy
        Me.dgv_dados.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_dados.Location = New System.Drawing.Point(91, 381)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados.RowHeadersWidth = 62
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_dados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_dados.Size = New System.Drawing.Size(929, 266)
        Me.dgv_dados.TabIndex = 44
        Me.dgv_dados.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(519, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Plano de Saúde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Data Nascimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 268)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "CPF "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nome/Login"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(822, 125)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 128)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 57
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'Column11
        '
        Me.Column11.HeaderText = "TIPO DE CADASTRO"
        Me.Column11.Items.AddRange(New Object() {"ADM", "Paciente"})
        Me.Column11.MinimumWidth = 8
        Me.Column11.Name = "Column11"
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME/LOGIN"
        Me.Column1.Name = "Column1"
        '
        'Column9
        '
        Me.Column9.HeaderText = "EXCLUIR"
        Me.Column9.MinimumWidth = 8
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "STATUS"
        Me.Column10.MinimumWidth = 8
        Me.Column10.Name = "Column10"
        '
        'uc_cad_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt_cpff)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_tell)
        Me.Controls.Add(Me.cmb_planosaude)
        Me.Controls.Add(Me.dtp_datanasc)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_cad_usuarios"
        Me.Size = New System.Drawing.Size(1109, 798)
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpff As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_tell As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmb_planosaude As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dtp_datanasc As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txt_email As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_nome As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_dados As ns1.BunifuCustomDataGrid
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewComboBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewButtonColumn
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
End Class
