Public Class AccesoDatos
    Shared ctx As New pcgamerEntities

    Shared Sub cargarProductos(grid As DataGridView)
        '     Dim datos = (From p In ctx.productos
        '                   Where p.estado = 1 Select Id = p.Id_producto, c1 = p.c1_procesador_id, c2 = p.c2_placamadre_id, c3 = p.c3_ram_id,
        '          c4 = p.c4_placavideo_id, c5 = p.c5_discorigido_id, c6 = p.c6_gabinete_id, precio = p.precio,
        'stock = p.stock, categoria = p.categoria_id, imagen = p.imagen, estado = p.estado).ToList

        Dim datos = (From p In ctx.productos
                     Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio,
Stock = p.stock, Categoria = p.categoria_id, Estado = p.estado).ToList

        grid.DataSource = datos

        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False

    End Sub
End Class
