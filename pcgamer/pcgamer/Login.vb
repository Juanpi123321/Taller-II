Public Class Login
    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            MsgBox("Debe completar todos los campos!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
            'ElseIf TUsuario.Text = "vendedor" Then
        ElseIf TUsuario.Text = "v" Then
            FormularioVendedor.Show()
            Me.Close()
            'ElseIf TUsuario.Text = "admin" Then
        ElseIf TUsuario.Text = "a" Then
            FormularioAdministrador.Show()
            Me.Close()
            'ElseIf TUsuario.Text = "superadmin" Then
        ElseIf TUsuario.Text = "sa" Then
            FormularioSuperAdmin.Show()
            Me.Close()
        Else
            MsgBox("Nombre de usuario invalido", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
            TUsuario.Text = ""
            TContrasena.Text = ""
        End If
    End Sub

End Class
