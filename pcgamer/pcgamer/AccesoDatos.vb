Public Class AccesoDatos
    Shared ctx As New pcgamerEntities
#Region "Cliente"
    Shared Sub cargarClientes(grid As DataGridView)
        Dim datos = (From c In ctx.clientes
                     Select Id = c.Id_cliente, Apellidos = c.apellidos, Nombres = c.nombres, DNI = c.dni,
                         Fecha_Registro = c.fecharegistro, Estado = c.estado).ToList
        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
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

    Shared Sub AgregarCliente(cliente As clientes)
        ctx.clientes.Add(cliente)
        ctx.SaveChanges()
    End Sub

    Shared Sub buscarCliente(busqueda As String, filtro As Integer, grid As DataGridView)
        Dim datos = (From c In ctx.clientes
                     Select Id = c.Id_cliente, Apellidos = c.apellidos, Nombres = c.nombres, DNI = c.dni,
                         Fecha_Registro = c.fecharegistro, Estado = c.estado).ToList
        Select Case filtro
            Case 0
                datos = (From c In ctx.clientes
                         Where c.nombres.Contains(busqueda) Or c.apellidos.Contains(busqueda)
                         Select Id = c.Id_cliente, Apellidos = c.apellidos, Nombres = c.nombres, DNI = c.dni,
                         Fecha_Registro = c.fecharegistro, Estado = c.estado).ToList
            Case 1
                datos = (From c In ctx.clientes
                         Where c.dni.ToString.Contains(busqueda)
                         Select Id = c.Id_cliente, Apellidos = c.apellidos, Nombres = c.nombres, DNI = c.dni,
                         Fecha_Registro = c.fecharegistro, Estado = c.estado).ToList
        End Select

        grid.DataSource = datos
        'oculta el Id_cliente
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Sub EliminarCliente(id_cliente As Integer, estado As Integer)
        Dim cliente = (From c In ctx.clientes
                       Where c.Id_cliente = id_cliente
                       Select c
                  ).SingleOrDefault
        cliente.estado = estado
        ctx.SaveChanges()
    End Sub

    Shared Function existeCliente(dni As String) As Boolean
        Dim existe As Boolean = True
        Dim datos = (From c In ctx.clientes
                     Where c.dni = dni
                     Select Id_cliente = c.Id_cliente, Nombre = c.nombres).SingleOrDefault
        If datos Is Nothing Then
            existe = False
        End If
        Return existe
    End Function

    Shared Function existeEmailCliente(email As String) As Boolean
        Dim existe As Boolean = True
        Dim datos = (From c In ctx.clientes
                     Where c.email = email
                     Select Id_cliente = c.Id_cliente, Nombre = c.nombres).SingleOrDefault
        If datos Is Nothing Then
            existe = False
        End If
        Return existe
    End Function
#End Region

#Region "Producto"
    Shared Sub cargarProductos(grid As DataGridView)
        Dim datos = (From p In ctx.productos
                     Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                         Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList

        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Sub cargarProductosActivos(grid As DataGridView)
        Dim datos = (From p In ctx.productos
                     Where p.estado = 1
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

    Shared Sub ActualizarProducto(id_producto As Integer, nombre As String, procesador As Integer, PlacaMadre As Integer,
                                 Ram As Integer, PlacaVideo As Integer, DiscoRigido As Integer, Gabinete As Integer,
                                 Precio As Integer, Stock As Integer, Categoria As Integer, imagen As String)
        Dim producto = (From p In ctx.productos
                        Where p.Id_producto = id_producto
                        Select p).SingleOrDefault
        With producto
            .nombre = nombre
            'le sumo 1 xq en el combobox el primer valor es 0
            .c1_procesador_id = procesador + 1
            .c2_placamadre_id = PlacaMadre + 1
            .c3_ram_id = Ram + 1
            .c4_placavideo_id = PlacaVideo + 1
            .c5_discorigido_id = DiscoRigido + 1
            .c6_gabinete_id = Gabinete + 1
            .precio = Precio
            .stock = Stock
            .categoria_id = Categoria + 1
            .imagen = imagen
            .estado = 1
        End With
        ctx.SaveChanges()
    End Sub

    Shared Sub AgregarProducto(producto As productos)
        ctx.productos.Add(producto)
        ctx.SaveChanges()
    End Sub

    Shared Sub buscarProducto(busqueda As String, filtro As Integer, grid As DataGridView)
        Dim datos = (From p In ctx.productos
                     Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
        Select Case filtro
            Case 0
                datos = (From p In ctx.productos
                         Where p.nombre.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 1
                datos = (From p In ctx.productos
                         Where p.categoria.descripcion_categoria.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 2
                datos = (From p In ctx.productos
                         Where p.c1_procesador.c1_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 3
                datos = (From p In ctx.productos
                         Where p.c2_placamadre.c2_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 4
                datos = (From p In ctx.productos
                         Where p.c3_ram.c3_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 5
                datos = (From p In ctx.productos
                         Where p.c4_placavideo.c4_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 6
                datos = (From p In ctx.productos
                         Where p.c5_discorigido.c5_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList
            Case 7
                datos = (From p In ctx.productos
                         Where p.c6_gabinete.c6_descripcion.Contains(busqueda)
                         Select Id = p.Id_producto, Nombre = p.nombre, Precio = p.precio, Stock = p.stock,
                                 Categoria = p.categoria.descripcion_categoria, Estado = p.estado).ToList

        End Select

        grid.DataSource = datos
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Sub EliminarProducto(id_producto As Integer, estado As Integer)
        Dim producto = (From p In ctx.productos
                        Where p.Id_producto = id_producto
                        Select p
                  ).SingleOrDefault
        producto.estado = estado
        ctx.SaveChanges()
    End Sub

    Shared Sub cargarCBoxs(cb1 As ComboBox, cb2 As ComboBox, cb3 As ComboBox, cb4 As ComboBox, cb5 As ComboBox, cb6 As ComboBox, cbCat As ComboBox)
        cb1.DataSource = ctx.c1_procesador.ToList()
        cb1.ValueMember = "c1_procesador1"
        cb1.DisplayMember = "c1_descripcion"

        cb2.DataSource = ctx.c2_placamadre.ToList()
        cb2.ValueMember = "c2_placamadre1"
        cb2.DisplayMember = "c2_descripcion"

        cb3.DataSource = ctx.c3_ram.ToList()
        cb3.ValueMember = "c3_ram1"
        cb3.DisplayMember = "c3_descripcion"

        cb4.DataSource = ctx.c4_placavideo.ToList()
        cb4.ValueMember = "c4_placaVideo1"
        cb4.DisplayMember = "c4_descripcion"

        cb5.DataSource = ctx.c5_discorigido.ToList()
        cb5.ValueMember = "c5_discoRigido1"
        cb5.DisplayMember = "c5_descripcion"

        cb6.DataSource = ctx.c6_gabinete.ToList()
        cb6.ValueMember = "c6_gabinete1"
        cb6.DisplayMember = "c6_descripcion"

        cbCat.DataSource = ctx.categoria.ToList()
        cbCat.ValueMember = "Id_categoria"
        cbCat.DisplayMember = "descripcion_categoria"
    End Sub

    Shared Function existeProducto(nombre As String) As Boolean
        Dim existe As Boolean = True
        Dim datos = (From p In ctx.productos
                     Where p.nombre = nombre
                     Select Id_producto = p.Id_producto, Nombre_Producto = p.nombre).SingleOrDefault
        If datos Is Nothing Then
            existe = False
        End If
        Return existe
    End Function

    Shared Sub descontarStockProducto(id_producto As Integer, cantidad As Integer)
        Dim producto = (From p In ctx.productos
                        Where p.Id_producto = id_producto
                        Select p).SingleOrDefault
        producto.stock = producto.stock - cantidad
        ctx.SaveChanges()
    End Sub
#End Region

#Region "Usuario"
    Shared Sub cargarUsuarios(grid As DataGridView)
        Dim datos = (From u In ctx.usuarios
                     Join p In ctx.personas On p.Id_persona Equals u.persona_id
                     Join r In ctx.rol On r.Id_rol Equals p.rol_id
                     Select Id_usuario = u.Id_usuario, Nombres = p.nombres, Apellidos = p.apellidos, DNI = p.dni,
                         Rol = p.rol.tipo_rol, Estado = u.estado, Fecha_Ingreso = u.fechaingreso).ToList
        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Function capturarUsuario(id As Integer) As usuarios
        Dim usuario = (From u In ctx.usuarios
                       Where u.Id_usuario = id
                       Select u).SingleOrDefault
        Return usuario
    End Function

    Shared Sub ActualizarUsuario(id_usuario As Integer, nombres As String, apellidos As String, dni As Integer,
                                 domicilio As String, telefono As String, email As String, rol As Integer,
                                 sexo As Char, p_usuario As String, p_contrasena As String, imagen As String)
        Dim usuario = (From u In ctx.usuarios
                       Where u.Id_usuario = id_usuario
                       Select u).SingleOrDefault
        Dim persona = (From p In ctx.personas
                       Where p.Id_persona = usuario.persona_id
                       Select p).SingleOrDefault

        usuario.usuario = p_usuario
        usuario.contrasena = p_contrasena
        With persona
            .nombres = nombres
            .apellidos = apellidos
            .email = email
            .domicilio = domicilio
            .dni = dni
            .rol_id = rol
            .imagen = imagen
            .telefono = telefono
            .sexo = sexo
        End With

        ctx.SaveChanges()
    End Sub

    Shared Sub AgregarUsuario(usuario As usuarios)
        ctx.usuarios.Add(usuario)
        ctx.SaveChanges()
    End Sub

    Shared Sub buscarUsuario(busqueda As String, filtro As Integer, grid As DataGridView)
        Dim datos = (From u In ctx.usuarios
                     Join p In ctx.personas On p.Id_persona Equals u.persona_id
                     Select Id_usuario = u.Id_usuario, Nombres = p.nombres, Apellidos = p.apellidos, DNI = p.dni,
                         Rol = p.rol.tipo_rol, Estado = u.estado, Fecha_Ingreso = u.fechaingreso).ToList
        Select Case filtro
            Case 0
                datos = (From u In ctx.usuarios
                         Join p In ctx.personas On p.Id_persona Equals u.persona_id
                         Where p.nombres.Contains(busqueda) Or p.apellidos.Contains(busqueda)
                         Select Id_usuario = u.Id_usuario, Nombres = p.nombres, Apellidos = p.apellidos, DNI = p.dni,
                         Rol = p.rol.tipo_rol, Estado = u.estado, Fecha_Ingreso = u.fechaingreso).ToList
            Case 1
                datos = (From u In ctx.usuarios
                         Join p In ctx.personas On p.Id_persona Equals u.persona_id
                         Where p.dni.ToString.Contains(busqueda)
                         Select Id_usuario = u.Id_usuario, Nombres = p.nombres, Apellidos = p.apellidos, DNI = p.dni,
                         Rol = p.rol.tipo_rol, Estado = u.estado, Fecha_Ingreso = u.fechaingreso).ToList
        End Select

        grid.DataSource = datos
        'oculta el Id_usuario
        grid.Columns(0).Visible = False
        grid.Columns(5).Visible = False
    End Sub

    Shared Sub EliminarUsuario(id_usuario As Integer, estado As Integer)
        Dim usuario = (From u In ctx.usuarios
                       Where u.Id_usuario = id_usuario
                       Select u
                  ).SingleOrDefault
        usuario.estado = estado
        ctx.SaveChanges()
    End Sub

    Shared Function validarIngreso(p_usuario As String, p_contrasena As String)
        Dim resultado As Boolean = False
        Dim usuario = (From u In ctx.usuarios
                       Join p In ctx.personas On p.Id_persona Equals u.persona_id
                       Join r In ctx.rol On r.Id_rol Equals p.rol_id
                       Where u.usuario = p_usuario
                       Select contrasena = u.contrasena, nombre = p.nombres, apellido = p.apellidos, rol = r.tipo_rol,
                           Id_usuario = u.Id_usuario, estado = u.estado).SingleOrDefault
        If usuario Is Nothing Then
            resultado = False
        ElseIf usuario.contrasena = p_contrasena Then
            resultado = True
            If usuario.estado = 0 Then
                Login.BIngresar.Tag = "baja" 'si esta dado de baja le aviso al Login que no le deje ingresar
            Else
                Login.BIngresar.Tag = ""
                Dim ApeyNom = UCase(usuario.apellido) & ", " & usuario.nombre
                Login.LUsuario.Tag = ApeyNom
                Login.Tag = usuario.rol
                Login.LTitulo.Tag = usuario.Id_usuario  'le paso el id usuario para cuando genere la factura no tenga qe buscar
            End If
        End If
            Return resultado
    End Function

    Shared Sub generarUsuario(p_rol As Integer)
        Dim numero = (From u In ctx.usuarios
                      Join p In ctx.personas On p.Id_persona Equals u.persona_id
                      Join r In ctx.rol On r.Id_rol Equals p.rol_id
                      Where p.rol_id = p_rol
                      Select Id_rol = p.rol_id, tipo = r.tipo_rol).Count
        numero = numero + 1
        Dim rol = (From r In ctx.rol
                   Where r.Id_rol = p_rol
                   Select tipoRol = r.tipo_rol).SingleOrDefault
        Dim usuario As String = LCase(rol) + (numero).ToString
        Dim contrasena As String = Left(usuario, 1) + "123"

        FormularioGenerarUsuario.TUsuario.Tag = usuario
        FormularioGenerarUsuario.TContrasena.Tag = contrasena
    End Sub
#Region "Persona"
    Shared Function AgregarPersona(persona As personas) As Integer
        ctx.personas.Add(persona)
        ctx.SaveChanges()
        Dim id_persona As Integer = persona.Id_persona
        Return id_persona
    End Function

    Shared Function capturarPersona(id As Integer) As personas
        Dim persona = (From p In ctx.personas
                       Where p.Id_persona = id
                       Select p).SingleOrDefault
        Return persona
    End Function

    Shared Function existePersona(dni As String) As Boolean
        Dim existe As Boolean = True
        Dim datos = (From p In ctx.personas
                     Where p.dni = dni
                     Select Id_persona = p.Id_persona, Nombre = p.nombres).SingleOrDefault
        If datos Is Nothing Then
            existe = False
        End If
        Return existe
    End Function
    Shared Function existeEmailPersona(email As String) As Boolean
        Dim existe As Boolean = True
        Dim datos = (From p In ctx.personas
                     Where p.email = email
                     Select Id_persona = p.Id_persona, Nombre = p.nombres).SingleOrDefault
        If datos Is Nothing Then
            existe = False
        End If
        Return existe
    End Function
#End Region

#End Region

#Region "Factura"

    Shared Function AgregarFactura(factura As factura) As Integer
        ctx.factura.Add(factura)
        ctx.SaveChanges()
        Dim id_factura As Integer = factura.Id_factura
        Return id_factura
    End Function

    Shared Sub AgregarFacturaDetalle(facturaDetalle As factura_detalle)
        ctx.factura_detalle.Add(facturaDetalle)
        Dim id_prod = facturaDetalle.producto_id
        Dim cantidad = facturaDetalle.cantidad
        descontarStockProducto(id_prod, cantidad)

        ctx.SaveChanges()
    End Sub

    Shared Sub cargarFormaPago(formaPago As ComboBox)
        formaPago.DataSource = ctx.forma_pago.ToList()
        formaPago.ValueMember = "Id_forma_pago"
        formaPago.DisplayMember = "descripcion_formapago"
    End Sub

    Shared Function ultimoIdFactura()
        Dim id = (From f In ctx.factura
                  Select f.Id_factura).Max
        Return id
    End Function

    Shared Sub cargarCBoxs(cbdesde As ComboBox, cbhasta As ComboBox)
        cbdesde.DataSource = (From f In ctx.factura
                              Select f.fecha).Distinct.ToList
        'cbdesde.ValueMember = "fecha"
        cbdesde.DisplayMember = "fecha"

        cbhasta.DataSource = ctx.factura.ToList
        cbhasta.DisplayMember = "fecha"
    End Sub

    Shared Sub cargarFacturas(grid As DataGridView)
        Dim datos = (From f In ctx.factura
                     Join c In ctx.clientes On c.Id_cliente Equals f.cliente_id
                     Join u In ctx.usuarios On u.Id_usuario Equals f.vendedor_id
                     Join pers In ctx.personas On pers.Id_persona Equals u.persona_id
                     Join fpago In ctx.forma_pago On fpago.Id_forma_pago Equals f.forma_pago_id
                     Select Id_factura = f.Id_factura, Cliente = c.apellidos + " " + c.nombres,
                         Fecha = f.fecha, Hora = f.hora, Vendedor = pers.apellidos + " " + pers.nombres,
                         Forma_Pago = fpago.descripcion_formapago).ToList

        'Join p In ctx.productos On p.Id_producto Equals fd.producto_id

        grid.DataSource = datos
        'oculta el Id_producto
        grid.Columns(0).Visible = False
    End Sub
#End Region
End Class
