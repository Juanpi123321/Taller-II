Public Class FormularioSuperAdmin
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Abandonar la Sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar Sesion")
        If MsgBoxResult.Yes = respuesta Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
    End Sub

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        FormularioSuperUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub BRoles_Click(sender As Object, e As EventArgs) Handles BRoles.Click
        MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
    End Sub
End Class