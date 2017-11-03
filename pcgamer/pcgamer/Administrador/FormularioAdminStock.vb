﻿Imports System.IO
Public Class FormularioAdminStock
    Private Sub FormularioAdminStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Si desde factura se dirigio al formulario de cliente y cerro esa ventana, redirige hacia la factura
        ''Si nunca entro a factura LApeyNom va a tener el valor x defecto '-'
        If FormularioFactura.LApeyNom.Text = "-" Then
            redirigirMenu(Me.Tag)
        Else
            'Le aviso el tipo de rol
            FormularioFactura.Show()
        End If
        Me.Dispose()
    End Sub

    Private Sub limpiar()
        TNombre.Clear()
        TProcesador.SelectedIndex = -1
        TPlacaMadre.SelectedIndex = -1
        TRam.SelectedIndex = -1
        TStock.Text = 0
        TCategoria.SelectedIndex = -1
        TPlacaVideo.SelectedIndex = -1
        TDiscoRigido.SelectedIndex = -1
        TGabinete.SelectedIndex = -1
        TPrecio.Text = 0
        PBImagen.Image = Nothing
        PBImagen.ImageLocation = Nothing

    End Sub

    Private Sub habilitar()
        TNombre.ReadOnly = False
        TProcesador.DropDownStyle = ComboBoxStyle.DropDownList
        TPlacaMadre.DropDownStyle = ComboBoxStyle.DropDownList
        TRam.DropDownStyle = ComboBoxStyle.DropDownList
        TStock.ReadOnly = False
        TCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        TPlacaVideo.DropDownStyle = ComboBoxStyle.DropDownList
        TDiscoRigido.DropDownStyle = ComboBoxStyle.DropDownList
        TGabinete.DropDownStyle = ComboBoxStyle.DropDownList
        TPrecio.ReadOnly = False
    End Sub

    Private Sub deshabilitar()
        TNombre.ReadOnly = True
        TProcesador.DropDownStyle = ComboBoxStyle.Simple
        TPlacaMadre.DropDownStyle = ComboBoxStyle.Simple
        TRam.DropDownStyle = ComboBoxStyle.Simple
        TStock.ReadOnly = True
        TCategoria.DropDownStyle = ComboBoxStyle.Simple
        TPlacaVideo.DropDownStyle = ComboBoxStyle.Simple
        TDiscoRigido.DropDownStyle = ComboBoxStyle.Simple
        TGabinete.DropDownStyle = ComboBoxStyle.Simple
        TPrecio.ReadOnly = True
    End Sub

    Private Sub bloquear()
        TBuscar.Enabled = False
        CBBuscar.Enabled = False
        DataGridStock.Enabled = False
    End Sub

    Private Sub desbloquear()
        TBuscar.Enabled = True
        CBBuscar.Enabled = True
        DataGridStock.Enabled = True
    End Sub

    Private Sub cargarComboBoxs()
        Try
            AccesoDatos.cargarCBoxs(TProcesador, TPlacaMadre, TRam, TPlacaVideo, TDiscoRigido, TGabinete, TCategoria)
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema, la base de datos no se pudo cargar correctamente", MsgBoxStyle.DefaultButton2 +
                   MsgBoxStyle.Exclamation, "Fallo al cargar Productos")
        End Try
    End Sub

    Private Sub cargarDetalle(producto As productos)
        TNombre.Text = producto.nombre
        TProcesador.SelectedIndex = producto.c1_procesador_id - 1
        TPlacaMadre.SelectedIndex = producto.c2_placamadre_id - 1
        TRam.SelectedIndex = producto.c3_ram_id - 1
        TStock.Text = producto.stock
        TCategoria.SelectedIndex = producto.categoria_id - 1
        TPlacaVideo.SelectedIndex = producto.c4_placavideo_id - 1
        TDiscoRigido.SelectedIndex = producto.c5_discorigido_id - 1
        TGabinete.SelectedIndex = producto.c6_gabinete_id - 1
        TPrecio.Text = producto.precio

        If producto.imagen Is Nothing Or producto.imagen = "no-disponible" Then
            PBImagen.Image = Image.FromFile("D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources\sin-imagen.png")
        Else
            PBImagen.ImageLocation = producto.imagen
            'PBImagen.Image = Image.FromFile(producto.imagen)
        End If
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub cargarProductos()
        cargarComboBoxs()
        If DataGridStock.Tag = "SoloActivos" Then
            AccesoDatos.cargarProductosActivos(DataGridStock)
        Else
            AccesoDatos.cargarProductos(DataGridStock)
        End If
        DataGridStock.ClearSelection()
        deshabilitar()
        DataGridStock.DefaultCellStyle.ForeColor = Color.Black

        'Cuando abro que no aparezca ningun valor
        TNombre.Clear()
        TProcesador.SelectedIndex = -1
        TPlacaMadre.SelectedIndex = -1
        TRam.SelectedIndex = -1
        TStock.Clear()
        TCategoria.SelectedIndex = -1
        TPlacaVideo.SelectedIndex = -1
        TDiscoRigido.SelectedIndex = -1
        TGabinete.SelectedIndex = -1
        TPrecio.Clear()
        Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gabinete.jpg"
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

        CBBuscar.SelectedIndex = 0
    End Sub

    Private Xpos, Ypos

    Private Sub FormularioStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
#Region "bloquear movimiento del form"
            CenterToScreen()
            Xpos = Location.X
            Ypos = Location.Y
#End Region
            DataGridStock.Tag = "VerTodos"
            'si es vendedor no le permito editar ni agregar un prod nuevo y le muestro solo los prod activos
            If Me.Tag = "Vendedor" Then
                PBlogo2.Visible = True
                BAgregarFactura.Visible = True
                BEditar.Visible = False
                BNuevo.Visible = False
                DataGridStock.Tag = "SoloActivos"
                TBuscar.Tag = "1"
            Else
                TBuscar.Tag = "0" 'busca todos
                BSoloActivos.Visible = True
                BVerTodos.Visible = True
            End If
            'La leyenda de abajo
            LRol.Text = Me.Tag + ": " + LApeyNom.Tag

            cargarProductos()
            BBaja.Visible = False
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, la lista de productos no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        End Try
    End Sub

#Region "bloquear movimiento del form"
    Private Sub FormularioAdminStock_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region

    Private Sub DataGridStock_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStock.CellEnter
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        Dim id_producto As Integer = DataGridStock.Item(0, fila).Value
        Dim producto As productos = AccesoDatos.capturarProducto(id_producto)
        cargarDetalle(producto)

        If Me.Tag <> "Vendedor" Then
            If DataGridStock.Item(5, fila).Value = 0 Then
                BAlta.Visible = True
                BBaja.Visible = False
            Else
                BAlta.Visible = False
                BBaja.Visible = True
            End If
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridStock.CurrentRow Is Nothing Then
            MsgBox("Seleccione un producto para poder editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Edicion Invalida")
        ElseIf DataGridStock.CurrentRow.Cells(5).Value = "0" Then
            MsgBox("No es posible editar, el producto esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        Else
            BNuevo.Visible = False
            BGuardar.Visible = True
            BCancelar.Visible = True
            BBaja.Visible = False
            BAlta.Visible = False
            BCambiarImagen.Visible = True
            bloquear()
            habilitar()
            BSoloActivos.Visible = False
            BVerTodos.Visible = False
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Try
            If TNombre.Text = "" Or TProcesador.Text = "" Or TPlacaMadre.Text = "" Or TRam.Text = "" Or TStock.Text = "" Or
                TCategoria.Text = "" Or TPlacaVideo.Text = "" Or TDiscoRigido.Text = "" Or TGabinete.Text = "" Or TPrecio.Text = "" Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Campos incompletos")
            Else
                Dim respuesta As MsgBoxResult
                Dim fila As Integer = DataGridStock.CurrentRow.Index
                respuesta = MsgBox("¿Esta seguro que desea Editar al producto " + TNombre.Text + "??",
                                       MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Dim id_producto As Integer = DataGridStock.CurrentRow().Cells(0).Value
                    AccesoDatos.ActualizarProducto(id_producto, TNombre.Text, TProcesador.SelectedIndex, TPlacaMadre.SelectedIndex,
                                             TRam.SelectedIndex, TPlacaVideo.SelectedIndex, TDiscoRigido.SelectedIndex, TGabinete.SelectedIndex,
                                             TPrecio.Text, TStock.Text, TCategoria.SelectedIndex, PBImagen.ImageLocation)
                    AccesoDatos.cargarProductosActivos(DataGridStock)
                    BNuevo.Visible = True
                    BGuardar.Visible = False
                    BCancelar.Visible = False
                    BCambiarImagen.Visible = False
                    desbloquear()
                    deshabilitar()
                    If Me.Tag <> "Vendedor" Then
                        BSoloActivos.Visible = True
                        BVerTodos.Visible = True
                    End If
                    MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                                           MsgBoxStyle.Information, "Modificacion exitosa")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema, el producto no se pudo guardar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Modificar")
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BNuevo.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        BCambiarImagen.Visible = False
        desbloquear()
        deshabilitar()
        limpiar()
        If Me.Tag <> "Vendedor" Then
            BSoloActivos.Visible = True
            BVerTodos.Visible = True
        End If
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
    End Sub

    Private Sub BBaja_Click(sender As Object, e As EventArgs) Handles BBaja.Click
        If DataGridStock.CurrentRow Is Nothing Then
            MsgBox("Seleccione un producto para poder dar de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridStock.CurrentRow.Index
            'Pregunta si el fondo es gris o si el estado es 0
            If DataGridStock.CurrentRow().Cells(5).Value = 0 Then
                MsgBox("El producto ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Baja invalida")
            Else
                respuesta = MsgBox("¿Esta seguro que desea Eliminar al producto " + TNombre.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Baja Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_producto As Integer = DataGridStock.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarProducto(id_producto, "0")
                        AccesoDatos.cargarProductosActivos(DataGridStock)
                        MsgBox("El producto se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el producto no se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        If DataGridStock.CurrentRow Is Nothing Then
            MsgBox("Seleccione un producto para poder dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridStock.CurrentRow.Index
            'Pregunta si el estado es 1
            If DataGridStock.CurrentRow().Cells(5).Value = 1 Then
                MsgBox("El producto ya esta dado de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
            Else
                respuesta = MsgBox("¿Esta seguro que desea dar de alta al producto " + TNombre.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_producto As Integer = DataGridStock.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarProducto(id_producto, "1")
                        AccesoDatos.cargarProductosActivos(DataGridStock)
                        MsgBox("El producto se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el producto no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al dar Alta")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        limpiar()
        bloquear()
        habilitar()

        BAgregar.Visible = True
        BCancelarAgregar.Visible = True
        BEditar.Visible = False
        BNuevo.Visible = False
        BBaja.Visible = False
        BAlta.Visible = False
        BCambiarImagen.Visible = True
        BSoloActivos.Visible = False
        BVerTodos.Visible = False
    End Sub

    Private Sub BCancelarAgregar_Click(sender As Object, e As EventArgs) Handles BCancelarAgregar.Click
        desbloquear()
        deshabilitar()

        BAgregar.Visible = False
        BCancelarAgregar.Visible = False
        BEditar.Visible = True
        BNuevo.Visible = True
        BCambiarImagen.Visible = False
        limpiar()
        If Me.Tag <> "Vendedor" Then
            BSoloActivos.Visible = True
            BVerTodos.Visible = True
        End If
        MsgBox("No se ha agregado ningun producto", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TNombre.Text = "" Or TProcesador.Text = "" Or TPlacaMadre.Text = "" Or TRam.Text = "" Or TStock.Text = "" Or
                TCategoria.Text = "" Or TPlacaVideo.Text = "" Or TDiscoRigido.Text = "" Or TGabinete.Text = "" Or TPrecio.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Campos incompletos")
        Else
            If TPrecio.Text = 0 Then
                MsgBox("El precio no puede ser 0", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Precio incorrecto")
            ElseIf AccesoDatos.existeProducto(TNombre.Text) Then
                MsgBox("Ya existe un producto registrado con el nombre '" + TNombre.Text + "'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "Nombre en uso")
            Else
                If TStock.Text = 0 Then
                    MsgBox("El producto se va a registrar sin ningun valor de stock", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Stock no detectado")
                End If
                If PBImagen.ImageLocation = Nothing Then
                    MsgBox("El producto se va a registrar sin ninguna imagen", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Imagen no detectada")
                End If
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Esta seguro que desea agregar el producto??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Agregar Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        AccesoDatos.AgregarProducto(New productos() With
                                               {.nombre = TNombre.Text,
                                               .c1_procesador_id = TProcesador.SelectedIndex + 1,
                                               .c2_placamadre_id = TPlacaMadre.SelectedIndex + 1,
                                               .c3_ram_id = TRam.SelectedIndex + 1,
                                               .stock = TStock.Text,
                                               .categoria_id = TCategoria.SelectedIndex + 1,
                                               .c4_placavideo_id = TPlacaMadre.SelectedIndex + 1,
                                               .c5_discorigido_id = TDiscoRigido.SelectedIndex + 1,
                                               .c6_gabinete_id = TGabinete.SelectedIndex + 1,
                                               .precio = TPrecio.Text,
                                               .imagen = PBImagen.ImageLocation,
                                               .estado = 1
                                               })

                        MsgBox("El producto se ha registrado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Registro Exitoso")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el producto no se pudo agregar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Agregar")
                    Finally
                        limpiar()
                        cargarProductos()
                        desbloquear()
                        deshabilitar()

                        BAgregar.Visible = False
                        BCancelarAgregar.Visible = False
                        BEditar.Visible = True
                        BNuevo.Visible = True
                        BCambiarImagen.Visible = False
                        If Me.Tag <> "Vendedor" Then
                            BSoloActivos.Visible = True
                            BVerTodos.Visible = True
                        End If
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub TStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStock.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecio.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        'le paso lo qe se escribe, el numero del combobox buscar seleccionado y el datagrid
        AccesoDatos.buscarProducto(sender.text, CBBuscar.SelectedIndex, DataGridStock, TBuscar.Tag)
    End Sub

    'si el estado es 0 (esta dado de baja) entonces lo marca en gris, sino esta dado de baja y el stock es menor a 10 lo marca de rojo
    Private Sub DataGridStock_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridStock.RowStateChanged
        For Each Row As DataGridViewRow In DataGridStock.Rows
            If Row.Cells(5).Value = "0" Then
                Row.DefaultCellStyle.BackColor = Color.Gray
            ElseIf Row.Cells(3).Value < 11 Then
                Row.DefaultCellStyle.BackColor = Color.Red
            Else
                Row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub


#Region "bloquear combobox"
    Private Sub TProcesador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TProcesador.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TPlacaMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPlacaMadre.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TRam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TRam.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCategoria.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TPlacaVideo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPlacaVideo.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TDiscoRigido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDiscoRigido.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TGabinete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TGabinete.KeyPress
        'si esta habilitado para escribir habilita tmb su campo
        If TNombre.ReadOnly = False And TStock.ReadOnly = False And TPrecio.ReadOnly = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click, DataGridStock.CellMouseDoubleClick
        If Me.Tag = "Vendedor" Then     'si no es vendedor no puede agregar a factura, no aparece el boton
            If DataGridStock.CurrentRow Is Nothing Then
                MsgBox("Seleccione un producto para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
            Else
                If DataGridStock.CurrentRow.Cells(5).Value = "0" Then
                    MsgBox("No es posible agregar a factura, el producto esta dado de baja", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Exclamation, "Operacion invalida")
                Else
                    If Integer.Parse(TStock.Text) = 0 Then
                        MsgBox("El producto no puede cargarse a la factura, no existe stock disponible",
                               MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Stock no disponible")
                    Else
                        Dim fila As Integer = DataGridStock.CurrentRow.Index
                        Dim id_producto As Integer = DataGridStock.Item(0, fila).Value

                        'Verifica si existe el producto en la grilla de factura
                        Dim existe As Boolean = FormularioFactura.DataGridFactura.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells(0).Value) = id_producto)
                        If existe Then
                            MsgBox("El producto ya se encuentra cargado en la factura, para agregar mas de uno, modifique el valor del campo 'Cantidad'",
                                   MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Producto existente en Factura")
                        Else
                            Dim producto As productos = AccesoDatos.capturarProducto(id_producto)
                            Dim categoria As String = producto.categoria.descripcion_categoria
                            Dim nombre As String = producto.nombre
                            Dim precio As Decimal = producto.precio
                            Dim cantidad As Integer = 1
                            Dim importe As Decimal = precio * cantidad
                            Dim stock As Integer = producto.stock
                            FormularioFactura.DataGridFactura.Rows.Add(id_producto, cantidad, categoria, nombre, precio, importe, stock)
                        End If
                        'Le aviso el tipo de rol
                        FormularioFactura.Tag = Me.Tag
                        FormularioFactura.LApeyNom.Tag = LApeyNom.Tag
                        'le paso el id usuario para cuando genere la factura no tenga qe buscar
                        FormularioFactura.LTitulo.Tag = LTitulo.Tag
                        FormularioFactura.Show()
                        Me.Dispose()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BSoloActivos_Click(sender As Object, e As EventArgs) Handles BSoloActivos.Click
        DataGridStock.Tag = "SoloActivos"
        TBuscar.Tag = "1"
        cargarProductos()
    End Sub

    Private Sub BVerTodos_Click(sender As Object, e As EventArgs) Handles BVerTodos.Click
        DataGridStock.Tag = "VerTodos"
        TBuscar.Tag = "0"
        cargarProductos()
    End Sub

    Private Sub BCambiarImagen_Click(sender As Object, e As EventArgs) Handles BCambiarImagen.Click
        OpenFileDialog1.InitialDirectory = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources"
        OpenFileDialog1.Filter = "Todos los archivos|*.*|Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PBImagen.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

End Class