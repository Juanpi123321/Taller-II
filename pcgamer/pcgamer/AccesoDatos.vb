Public Class AccesoDatos
    Shared ctx As New pcgamerEntities

    Shared Sub cargarProductos(grid As DataGridView)
        '     Dim datos = (From p In ctx.productos
        '                   Where p.estado = 1 Select Id = p.Id_producto, c1 = p.c1_procesador_id, c2 = p.c2_placamadre_id, c3 = p.c3_ram_id,
        '          c4 = p.c4_placavideo_id, c5 = p.c5_discorigido_id, c6 = p.c6_gabinete_id, precio = p.precio,
        'stock = p.stock, categoria = p.categoria_id, imagen = p.imagen, estado = p.estado).ToList

        Dim datos = (From p In ctx.productos
                     Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                         Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList

        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Function capturarProducto(id As Integer) As productos
        Dim producto = (From p In ctx.productos
                        Where p.Id_producto = id
                        Select p).SingleOrDefault
        Return producto
    End Function

    Shared Sub cargarClientes(grid As DataGridView)
        Dim datos = (From c In ctx.clientes
                     Select Id = c.Id_cliente, Apellidos = c.apellidos, Nombres = c.nombres, DNI = c.dni,
                         Fecha_Registro = c.fecharegistro).ToList
        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
    End Sub

    Shared Function capturarCliente(id As Integer) As clientes
        Dim cliente = (From p In ctx.clientes
                       Where p.Id_cliente = id
                       Select p).SingleOrDefault
        Return cliente
    End Function

    Shared Sub ActualizarCliente(id_cliente As Integer, nombres As String, apellidos As String, dni As Integer,
                                 domicilio As String, telefono As String, email As String, fecharegistro As Date)
        Dim cliente = (From c In ctx.clientes
                       Where c.Id_cliente = id_cliente
                       Select c).SingleOrDefault
        With cliente
            .nombres = nombres
            .apellidos = apellidos
            .dni = dni
            .domicilio = domicilio
            .telefono = telefono
            .email = email
            .fecharegistro = fecharegistro
        End With
        ctx.SaveChanges()
    End Sub

    Shared Sub cargarFormaPago(formapago As ComboBox)
        Dim datos = (From fp In ctx.forma_pago
                     Select descripcion_formapago = fp.descripcion_formapago).ToList
        formapago.DataSource = datos
    End Sub

    Shared Sub AgregarCliente(cliente As clientes)
        ctx.clientes.Add(cliente)
        ctx.SaveChanges()
    End Sub
End Class
