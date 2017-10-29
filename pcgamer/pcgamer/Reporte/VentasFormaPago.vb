Public Class VentasFormaPago
    Private Sub VentasFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VentasFormaPago' Puede moverla o quitarla según sea necesario.
        Me.VentasFormaPagoTableAdapter.Fill(Me.DataSet1.VentasFormaPago)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class