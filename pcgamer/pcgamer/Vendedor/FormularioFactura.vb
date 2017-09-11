Public Class FormularioFactura

    Private Sub FormularioFactura_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub FormularioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TCliente.Text <> "" Then
            BSeleccionarCliente.Hide()
        End If
        TFechaHora.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click, BSeleccionarCliente.Click
        FormularioCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BCargar_Click(sender As Object, e As EventArgs) Handles BCargar.Click
        TCliente.Text = "ALFONSO, Pedro"
        TDNI.Text = "11324123"
        TDireccion.Text = "9 de Julio 2781 Corrientes Capital"
        TTelefono.Text = "-"
        BCargar.Hide()
        BSeleccionarCliente.Hide()
    End Sub

End Class