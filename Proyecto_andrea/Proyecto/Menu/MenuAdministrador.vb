Public Class MenuAdministrador

    Private Sub RegistrarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        agregar_cliente.Show()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Agregar_empleado.Show()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProductoToolStripMenuItem1.Click
        ABMProductos.Show()
    End Sub

    Private Sub ABMSaboresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMSaboresToolStripMenuItem.Click
        ABMSabores.Show()
    End Sub
End Class