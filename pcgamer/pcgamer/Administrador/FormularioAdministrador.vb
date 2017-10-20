Public Class FormularioAdministrador

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        Me.Cursor = Cursors.WaitCursor
        'Le aviso el tipo de rol
        FormularioAdminCliente.Tag = Me.Tag
        FormularioAdminCliente.LApeyNom.Tag = LApeyNom.Tag
        FormularioAdminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BStock_Click(sender As Object, e As EventArgs) Handles BStock.Click
        Me.Cursor = Cursors.WaitCursor
        'Le aviso el tipo de rol
        FormularioAdminStock.Tag = Me.Tag
        FormularioAdminStock.LApeyNom.Tag = LApeyNom.Tag
        FormularioAdminStock.Show()
        Me.Hide()
    End Sub

    Private Sub BInformes_Click(sender As Object, e As EventArgs) Handles BInformes.Click
        'MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
        Me.Cursor = Cursors.WaitCursor
        'Le aviso el tipo de rol
        FormularioAdminInforme.Tag = Me.Tag
        FormularioAdminInforme.LApeyNom.Tag = LApeyNom.Tag
        FormularioAdminInforme.Show()
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

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
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
        'La leyenda de abajo
        LRol.Text = Me.Tag + ": " + LApeyNom.Tag
    End Sub

#End Region
    Private Sub FormularioAdministrador_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Cursor = Cursors.Arrow
    End Sub

End Class