Public Class VentasxVendedor
    Private Sub VentasxVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VentasxVendedor' Puede moverla o quitarla según sea necesario.
        Me.VentasxVendedorTableAdapter.Fill(Me.DataSet1.VentasxVendedor, "01-10-2017", "31-10-2017")

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class