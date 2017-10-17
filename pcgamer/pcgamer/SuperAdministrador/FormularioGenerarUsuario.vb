Public Class FormularioGenerarUsuario
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
    End Sub

    Private Sub FormularioGenerarUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        'CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        Try
            Dim rol As Integer = Integer.Parse(Me.Tag)
            AccesoDatos.generarUsuario(rol)
            TUsuario.Text = TUsuario.Tag
            TContrasena.Text = TContrasena.Tag
            FormularioSuperUsuario.TUsuario.Tag = TUsuario.Tag
            FormularioSuperUsuario.TContrasena.Tag = TContrasena.Tag
        Catch ex As Exception
            MsgBox("Ha ocurrido un error el Nombre de usuario no se pudo generar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Error al generar Usuario")
        End Try
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioGenerarUsuario_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region
End Class