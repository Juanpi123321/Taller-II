Public Class VentasxProducto
    Private Sub VentasxProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaMin = AccesoDatos.FechaMin
        Dim fechaMax = AccesoDatos.FechaMax
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VentasxProducto' Puede moverla o quitarla según sea necesario.
        Me.VentasxProductoTableAdapter.Fill(Me.DataSet1.VentasxProducto, fechaMin, fechaMax)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class