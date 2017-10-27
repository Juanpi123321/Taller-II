Public Class DetalleFactura
    Private Sub DetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.DataSet1.DetalleFactura, Me.Tag)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class