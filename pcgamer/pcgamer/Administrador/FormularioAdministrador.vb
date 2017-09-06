Public Class FormularioAdministrador
    Private Sub BVendedor_Click(sender As Object, e As EventArgs) Handles BVendedor.Click
        FormularioVendedor.Show()
        Me.Hide()
    End Sub
End Class