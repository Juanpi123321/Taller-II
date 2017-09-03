Public Class Login
    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim ask As MsgBoxResult
        msg = "Debe Completar todos los campos!"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        title = "Error"
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            ask = MsgBox(msg, style, title)
        Else
            FormularioVendedor.Show()
            Me.Close()
        End If
    End Sub

End Class
