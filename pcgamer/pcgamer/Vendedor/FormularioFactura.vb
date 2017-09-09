Public Class FormularioFactura

    Private Sub FormularioFactura_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub FormularioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TCliente.Text <> "" Then
            BSeleccionarCliente.Hide()
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        FormularioCliente.Show()
        Me.Hide()
    End Sub
End Class