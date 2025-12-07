Public Class pagar_consulta
    Public Property IdMedico As Integer
    Public Property IdPaciente As Integer
    Public Property DataConsulta As Date
    Public Property HoraConsulta As Date
    Public Property ValorConsulta As Decimal
    Public Property MetodoPagamento As String
    Private Sub pagar_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_valor_consulta.Items.Clear()
        cmb_valor_consulta.Items.Add(ValorConsulta.ToString("C")) ' add o valor da consulta formatado como moeda
        cmb_valor_consulta.SelectedIndex = 0

        cmb_metodo_pag.Items.Clear()
        cmb_metodo_pag.Items.AddRange(New String() {"PIX", "Cartão de Crédito/Débito", "Dinheiro"}) ' add os métodos de pagamento
        cmb_metodo_pag.SelectedIndex = 0
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        If cmb_metodo_pag.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecione um método de pagamento", "ATENÇÃO")
            Return
        End If

        MetodoPagamento = cmb_metodo_pag.SelectedItem.ToString()

        Dim dataAccessFormat As String = DataConsulta.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Dim horaAccessFormat As String = HoraConsulta.ToString("HH:mm")

        Dim sqlInsert As String =
            "INSERT INTO tb_consultas (id_medico, id_paciente, data_consulta, hora_consulta) " &    ' insere a consulta agendada no banco de dados
            $"VALUES ({IdMedico}, {IdPaciente}, #{dataAccessFormat}#, '{horaAccessFormat}')"

        Try
            db.Execute(sqlInsert)

            MessageBox.Show("Pagamento confirmado e consulta agendada com sucesso!", "*\0/*")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao finalizar a compra e agendar: " & ex.Message, "Erro Crítico")
        End Try
    End Sub
End Class