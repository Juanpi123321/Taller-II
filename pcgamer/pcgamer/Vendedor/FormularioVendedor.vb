Public Class FormularioVendedor
    Private Sub FormularioVendedor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioFactura.Close()
    End Sub

    Private Sub BFactura_Click(sender As Object, e As EventArgs) Handles BFactura.Click
        'Le aviso el tipo de rol
        FormularioFactura.Tag = Me.Tag
        FormularioFactura.LApeyNom.Tag = LApeyNom.Tag
        'le paso el id usuario para cuando genere la factura no tenga qe buscar
        FormularioFactura.LTitulo.Tag = LTitulo.Tag
        FormularioFactura.Show()
        Me.Hide()
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        'Le aviso el tipo de rol
        FormularioAdminCliente.Tag = Me.Tag
        FormularioAdminCliente.LApeyNom.Tag = LApeyNom.Tag
        'le paso el id usuario para cuando genere la factura no tenga qe buscar
        FormularioAdminCliente.LTitulo.Tag = LTitulo.Tag
        FormularioAdminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BStock_Click(sender As Object, e As EventArgs) Handles BStock.Click
        'Le aviso el tipo de rol
        FormularioAdminStock.Tag = Me.Tag
        FormularioAdminStock.LApeyNom.Tag = LApeyNom.Tag
        'le paso el id usuario para cuando genere la factura no tenga qe buscar
        FormularioAdminStock.LTitulo.Tag = LTitulo.Tag
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

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioVendedor_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub

    Private Sub FormularioVendedor_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        'La leyenda de abajo
        LRol.Text = Me.Tag + ": " + LApeyNom.Tag
    End Sub
#End Region
End Class