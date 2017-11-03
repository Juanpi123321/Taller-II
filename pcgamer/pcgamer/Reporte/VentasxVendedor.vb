Public Class VentasxVendedor
    Private Sub VentasxVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaMin = AccesoDatos.FechaMin
        Dim fechaMax = AccesoDatos.FechaMax
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VentasxVendedor' Puede moverla o quitarla según sea necesario.
        Me.VentasxVendedorTableAdapter.Fill(Me.DataSet1.VentasxVendedor, fechaMin, fechaMax)
        Me.ReportViewer1.RefreshReport
    End Sub
End Class