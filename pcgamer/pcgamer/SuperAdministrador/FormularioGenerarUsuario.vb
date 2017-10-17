Public Class FormularioGenerarUsuario
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
    End Sub

    Private Sub FormularioGenerarUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim rol As Integer = Integer.Parse(Me.Tag)
            AccesoDatos.generarUsuario(rol)
            TUsuario.Text = TUsuario.Tag
            TContrasena.Text = TContrasena.Tag
        Catch ex As Exception
            MsgBox("Ha ocurrido un error el Nombre de usuario no se pudo generar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Error al generar Usuario")
        End Try
    End Sub

End Class