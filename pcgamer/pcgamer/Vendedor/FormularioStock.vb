Public Class FormularioStock
    Private Sub FormularioStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub BGenerarFactura_Click(sender As Object, e As EventArgs) Handles BGenerarFactura.Click
        FormularioFactura.Show()
        Me.Hide()
    End Sub
End Class