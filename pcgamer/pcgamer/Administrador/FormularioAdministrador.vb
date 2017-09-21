Public Class FormularioAdministrador
    Private Sub BVendedor_Click(sender As Object, e As EventArgs) Handles BVendedor.Click
        FormularioVendedor.Show()
        Me.Hide()
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        FormularioAdminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BStock_Click(sender As Object, e As EventArgs) Handles BStock.Click
        FormularioAdminStock.Show()
        Me.Hide()
    End Sub

End Class