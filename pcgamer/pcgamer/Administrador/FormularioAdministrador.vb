Public Class FormularioAdministrador
    Private Sub BVendedor_Click(sender As Object, e As EventArgs)
        FormularioVendedor.Show()
        Me.Close()
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        FormularioAdminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BStock_Click(sender As Object, e As EventArgs) Handles BStock.Click
        FormularioAdminStock.Show()
        Me.Hide()
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Abandonar la Sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar Sesion")
        If MsgBoxResult.Yes = respuesta Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BInformes_Click(sender As Object, e As EventArgs) Handles BInformes.Click
        MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
    End Sub

    Private Xpos, Ypos

#Region "bloquear movimiento del form"
    Private Sub FormularioAdministrador_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
    Private Sub FormularioAdministrador_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
    End Sub
#End Region
End Class