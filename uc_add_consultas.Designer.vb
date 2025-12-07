<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_add_consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_add_consultas))
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.dtp_data = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cmb_medico = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_especialidade = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_marcar = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnl_resumo = New Guna.UI.WinForms.GunaPanel()
        Me.flp_horarios = New System.Windows.Forms.FlowLayoutPanel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lbl_titulohorario = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.lbl_resumoPac = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_resumoDataHora = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_resumoMedico = New Guna.UI.WinForms.GunaLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_cpf_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_pac_selecionado = New System.Windows.Forms.ToolStripLabel()
        Me.pnl_resumo.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(260, 289)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(31, 15)
        Me.GunaLabel3.TabIndex = 19
        Me.GunaLabel3.Text = "Data"
        '
        'dtp_data
        '
        Me.dtp_data.BackColor = System.Drawing.Color.Transparent
        Me.dtp_data.BaseColor = System.Drawing.Color.White
        Me.dtp_data.BorderColor = System.Drawing.Color.Silver
        Me.dtp_data.CustomFormat = Nothing
        Me.dtp_data.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_data.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_data.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_data.ForeColor = System.Drawing.Color.Black
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(256, 307)
        Me.dtp_data.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_data.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp_data.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_data.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_data.OnPressedColor = System.Drawing.Color.Black
        Me.dtp_data.Radius = 8
        Me.dtp_data.Size = New System.Drawing.Size(281, 30)
        Me.dtp_data.TabIndex = 18
        Me.dtp_data.Text = "06/11/2025"
        Me.dtp_data.Value = New Date(2025, 11, 6, 0, 0, 0, 0)
        '
        'cmb_medico
        '
        Me.cmb_medico.BackColor = System.Drawing.Color.Transparent
        Me.cmb_medico.BaseColor = System.Drawing.Color.White
        Me.cmb_medico.BorderColor = System.Drawing.Color.Silver
        Me.cmb_medico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medico.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_medico.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_medico.ForeColor = System.Drawing.Color.Black
        Me.cmb_medico.FormattingEnabled = True
        Me.cmb_medico.Location = New System.Drawing.Point(256, 258)
        Me.cmb_medico.Name = "cmb_medico"
        Me.cmb_medico.OnHoverItemBaseColor = System.Drawing.Color.Navy
        Me.cmb_medico.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_medico.Radius = 8
        Me.cmb_medico.Size = New System.Drawing.Size(281, 26)
        Me.cmb_medico.TabIndex = 17
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(260, 239)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = "Médico"
        '
        'cmb_especialidade
        '
        Me.cmb_especialidade.BackColor = System.Drawing.Color.Transparent
        Me.cmb_especialidade.BaseColor = System.Drawing.Color.White
        Me.cmb_especialidade.BorderColor = System.Drawing.Color.Silver
        Me.cmb_especialidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_especialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidade.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_especialidade.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_especialidade.ForeColor = System.Drawing.Color.Black
        Me.cmb_especialidade.FormattingEnabled = True
        Me.cmb_especialidade.Location = New System.Drawing.Point(256, 208)
        Me.cmb_especialidade.Name = "cmb_especialidade"
        Me.cmb_especialidade.OnHoverItemBaseColor = System.Drawing.Color.Navy
        Me.cmb_especialidade.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_especialidade.Radius = 8
        Me.cmb_especialidade.Size = New System.Drawing.Size(281, 26)
        Me.cmb_especialidade.TabIndex = 15
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(260, 190)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(78, 15)
        Me.GunaLabel1.TabIndex = 14
        Me.GunaLabel1.Text = "Especialidade"
        '
        'btn_marcar
        '
        Me.btn_marcar.AnimationHoverSpeed = 0.07!
        Me.btn_marcar.AnimationSpeed = 0.03!
        Me.btn_marcar.BackColor = System.Drawing.Color.Transparent
        Me.btn_marcar.BaseColor = System.Drawing.Color.Navy
        Me.btn_marcar.BorderColor = System.Drawing.Color.Black
        Me.btn_marcar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_marcar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_marcar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_marcar.ForeColor = System.Drawing.Color.White
        Me.btn_marcar.Image = Nothing
        Me.btn_marcar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_marcar.Location = New System.Drawing.Point(25, 406)
        Me.btn_marcar.Name = "btn_marcar"
        Me.btn_marcar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_marcar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_marcar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_marcar.OnHoverImage = Nothing
        Me.btn_marcar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_marcar.Radius = 8
        Me.btn_marcar.Size = New System.Drawing.Size(281, 33)
        Me.btn_marcar.TabIndex = 21
        Me.btn_marcar.Text = "Agendar Consulta"
        Me.btn_marcar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'pnl_resumo
        '
        Me.pnl_resumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_resumo.Controls.Add(Me.flp_horarios)
        Me.pnl_resumo.Controls.Add(Me.GunaPictureBox2)
        Me.pnl_resumo.Controls.Add(Me.GunaLabel4)
        Me.pnl_resumo.Controls.Add(Me.GunaPictureBox1)
        Me.pnl_resumo.Controls.Add(Me.lbl_titulohorario)
        Me.pnl_resumo.Controls.Add(Me.GunaLinePanel1)
        Me.pnl_resumo.Controls.Add(Me.btn_marcar)
        Me.pnl_resumo.Location = New System.Drawing.Point(229, 106)
        Me.pnl_resumo.Name = "pnl_resumo"
        Me.pnl_resumo.Size = New System.Drawing.Size(691, 477)
        Me.pnl_resumo.TabIndex = 23
        '
        'flp_horarios
        '
        Me.flp_horarios.AutoScroll = True
        Me.flp_horarios.Location = New System.Drawing.Point(394, 150)
        Me.flp_horarios.Name = "flp_horarios"
        Me.flp_horarios.Size = New System.Drawing.Size(235, 207)
        Me.flp_horarios.TabIndex = 27
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(25, 28)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 26
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Navy
        Me.GunaLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel4.Location = New System.Drawing.Point(27, 28)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(243, 30)
        Me.GunaLabel4.TabIndex = 24
        Me.GunaLabel4.Text = "     Novo Agendamento"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(354, 82)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(29, 27)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 25
        Me.GunaPictureBox1.TabStop = False
        '
        'lbl_titulohorario
        '
        Me.lbl_titulohorario.AutoSize = True
        Me.lbl_titulohorario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulohorario.ForeColor = System.Drawing.Color.Navy
        Me.lbl_titulohorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_titulohorario.Location = New System.Drawing.Point(389, 74)
        Me.lbl_titulohorario.Name = "lbl_titulohorario"
        Me.lbl_titulohorario.Size = New System.Drawing.Size(251, 25)
        Me.lbl_titulohorario.TabIndex = 24
        Me.lbl_titulohorario.Text = "Horários Disponíveis para :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLinePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaLinePanel1.Controls.Add(Me.lbl_resumoPac)
        Me.GunaLinePanel1.Controls.Add(Me.lbl_resumoDataHora)
        Me.GunaLinePanel1.Controls.Add(Me.lbl_resumoMedico)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(25, 247)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(281, 140)
        Me.GunaLinePanel1.TabIndex = 23
        '
        'lbl_resumoPac
        '
        Me.lbl_resumoPac.AutoSize = True
        Me.lbl_resumoPac.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_resumoPac.Location = New System.Drawing.Point(12, 22)
        Me.lbl_resumoPac.Name = "lbl_resumoPac"
        Me.lbl_resumoPac.Size = New System.Drawing.Size(69, 15)
        Me.lbl_resumoPac.TabIndex = 2
        Me.lbl_resumoPac.Text = "GunaLabel5"
        '
        'lbl_resumoDataHora
        '
        Me.lbl_resumoDataHora.AutoSize = True
        Me.lbl_resumoDataHora.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_resumoDataHora.Location = New System.Drawing.Point(12, 85)
        Me.lbl_resumoDataHora.Name = "lbl_resumoDataHora"
        Me.lbl_resumoDataHora.Size = New System.Drawing.Size(69, 15)
        Me.lbl_resumoDataHora.TabIndex = 1
        Me.lbl_resumoDataHora.Text = "GunaLabel6"
        '
        'lbl_resumoMedico
        '
        Me.lbl_resumoMedico.AutoSize = True
        Me.lbl_resumoMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_resumoMedico.Location = New System.Drawing.Point(12, 54)
        Me.lbl_resumoMedico.Name = "lbl_resumoMedico"
        Me.lbl_resumoMedico.Size = New System.Drawing.Size(69, 15)
        Me.lbl_resumoMedico.TabIndex = 0
        Me.lbl_resumoMedico.Text = "GunaLabel5"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_buscar, Me.ToolStripLabel3, Me.txt_cpf_busca, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripComboBox1, Me.lbl_pac_selecionado})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(943, 39)
        Me.ToolStrip2.TabIndex = 24
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_buscar
        '
        Me.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(23, 36)
        Me.btn_buscar.Text = "ToolStripButton1"
        Me.btn_buscar.ToolTipText = "Buscar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(157, 36)
        Me.ToolStripLabel3.Text = "Informe o CPF do paciente:"
        '
        'txt_cpf_busca
        '
        Me.txt_cpf_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cpf_busca.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_cpf_busca.Name = "txt_cpf_busca"
        Me.txt_cpf_busca.Size = New System.Drawing.Size(100, 39)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(58, 36)
        Me.ToolStripLabel4.Text = "Paciente:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(0, 36)
        '
        'lbl_pac_selecionado
        '
        Me.lbl_pac_selecionado.BackColor = System.Drawing.Color.White
        Me.lbl_pac_selecionado.ForeColor = System.Drawing.Color.White
        Me.lbl_pac_selecionado.ImageTransparentColor = System.Drawing.Color.White
        Me.lbl_pac_selecionado.Name = "lbl_pac_selecionado"
        Me.lbl_pac_selecionado.Size = New System.Drawing.Size(79, 36)
        Me.lbl_pac_selecionado.Text = "                        "
        '
        'uc_add_consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.cmb_medico)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.cmb_especialidade)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.pnl_resumo)
        Me.Name = "uc_add_consultas"
        Me.Size = New System.Drawing.Size(943, 592)
        Me.pnl_resumo.ResumeLayout(False)
        Me.pnl_resumo.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtp_data As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cmb_medico As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_especialidade As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_marcar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pnl_resumo As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_titulohorario As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents flp_horarios As FlowLayoutPanel
    Friend WithEvents lbl_resumoDataHora As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_resumoMedico As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txt_cpf_busca As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripLabel
    Friend WithEvents lbl_pac_selecionado As ToolStripLabel
    Friend WithEvents lbl_resumoPac As Guna.UI.WinForms.GunaLabel
End Class
