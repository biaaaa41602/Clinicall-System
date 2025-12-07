<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_visualizar_consulta
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_visualizar_consulta))
        Me.dgv_consultas = New ns1.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_buscarr = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_nomepesquisa = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_datafiltro = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_consultas
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_consultas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_consultas.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_consultas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_consultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_consultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.btn_excluir})
        Me.dgv_consultas.DoubleBuffered = True
        Me.dgv_consultas.EnableHeadersVisualStyles = False
        Me.dgv_consultas.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_consultas.HeaderBgColor = System.Drawing.Color.Navy
        Me.dgv_consultas.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_consultas.Location = New System.Drawing.Point(92, 66)
        Me.dgv_consultas.Name = "dgv_consultas"
        Me.dgv_consultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_consultas.Size = New System.Drawing.Size(951, 429)
        Me.dgv_consultas.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PACIENTE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "MÉDICO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "ESPECIALIDADE"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATA E HORÁRIO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "STATUS"
        Me.Column6.Items.AddRange(New Object() {"Realizada", "Em andamento", "Agendada"})
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btn_excluir
        '
        Me.btn_excluir.HeaderText = "EXCLUIR"
        Me.btn_excluir.Name = "btn_excluir"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_buscarr, Me.ToolStripLabel3, Me.txt_nomepesquisa, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.cmb_datafiltro})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(979, 25)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_buscarr
        '
        Me.btn_buscarr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscarr.ForeColor = System.Drawing.Color.White
        Me.btn_buscarr.Image = CType(resources.GetObject("btn_buscarr.Image"), System.Drawing.Image)
        Me.btn_buscarr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscarr.Name = "btn_buscarr"
        Me.btn_buscarr.Size = New System.Drawing.Size(23, 22)
        Me.btn_buscarr.Text = "ToolStripButton1"
        Me.btn_buscarr.ToolTipText = "Buscar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripLabel3.Text = "Informe um nome para pesquisa:"
        '
        'txt_nomepesquisa
        '
        Me.txt_nomepesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomepesquisa.Name = "txt_nomepesquisa"
        Me.txt_nomepesquisa.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel4.Text = "Selecione uma data:"
        '
        'cmb_datafiltro
        '
        Me.cmb_datafiltro.Name = "cmb_datafiltro"
        Me.cmb_datafiltro.Size = New System.Drawing.Size(100, 25)
        '
        'uc_visualizar_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.dgv_consultas)
        Me.Name = "uc_visualizar_consulta"
        Me.Size = New System.Drawing.Size(979, 659)
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_consultas As ns1.BunifuCustomDataGrid
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btn_buscarr As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txt_nomepesquisa As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents cmb_datafiltro As ToolStripComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents btn_excluir As DataGridViewButtonColumn
End Class
