Public Class Login
    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            MsgBox("Debe completar todos los campos!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
        Else
            FormularioVendedor.Show()
            Me.Close()
        End If
    End Sub

End Class
