Public Class FormularioEstadisticas
    Private Sub BFormaPago_Click(sender As Object, e As EventArgs) Handles BFormaPago.Click
        VentasFormaPago.ShowDialog()
    End Sub

    Private Sub BProducto_Click(sender As Object, e As EventArgs) Handles BProducto.Click
        VentasxProducto.ShowDialog()
    End Sub

    Private Sub BVendedor_Click(sender As Object, e As EventArgs) Handles BVendedor.Click
        VentasxVendedor.ShowDialog()
    End Sub

    Private Sub BProdxCategoria_Click(sender As Object, e As EventArgs) Handles BProdxCategoria.Click
        ProdxCategoria.ShowDialog()
    End Sub

    Private Sub BTendencias_Click(sender As Object, e As EventArgs) Handles BTendencias.Click
        FormTendencias.ShowDialog()
    End Sub

    Private Sub FormularioEstadisticas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioAdminInforme.Show()
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioAdminInforme_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region

    Private Sub FormularioEstadisticas_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        'La leyenda de abajo
        LRol.Text = Me.Tag + ": " + LApeyNom.Tag
    End Sub
End Class