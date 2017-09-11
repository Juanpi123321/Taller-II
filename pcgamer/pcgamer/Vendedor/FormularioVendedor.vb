Public Class FormularioVendedor
    Private Sub BFactura_Click(sender As Object, e As EventArgs) Handles BFactura.Click
        FormularioFactura.Show()
        Me.Hide()
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        FormularioCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BStock_Click(sender As Object, e As EventArgs) Handles BStock.Click
        FormularioStock.Show()
        Me.Hide()
    End Sub

    Private Sub BAdmin_Click(sender As Object, e As EventArgs) Handles BAdmin.Click
        FormularioAdministrador.Show()
        Me.Hide()
    End Sub

End Class