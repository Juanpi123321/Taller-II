Public Class FormularioVendedor
    Private Sub FormularioVendedor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioCliente.Close()
        FormularioFactura.Close()
    End Sub

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
        Me.Close()
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Abandonar la Sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar Sesion")
        If MsgBoxResult.Yes = respuesta Then
            Login.Show()
            Me.Close()
        End If
    End Sub

End Class