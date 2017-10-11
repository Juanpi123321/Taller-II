Public Class FormularioAdminStock
    Private Sub FormularioAdminStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioAdministrador.Show()
    End Sub

    Private Sub limpiar()
        TNombre.Clear()
        'TProcesador.Clear()
        'TPlacaMadre.Clear()
        'TRam.Clear()
        TStock.Clear()
        'TPlacaVideo.Clear()
        'TDiscoRigido.Clear()
        'TGabinete.Clear()
        TPrecio.Clear()
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

    Private Sub cargarDetalle(producto As productos)
        TNombre.Text = producto.nombre
        TProcesador.Text = producto.c1_procesador.c1_descripcion
        TPlacaMadre.Text = producto.c2_placamadre.c2_descripcion
        TRam.Text = producto.c3_ram.c3_descripcion
        TStock.Text = producto.stock
        TCategoria.Text = producto.categoria.descripcion_categoria
        TPlacaVideo.Text = producto.c4_placavideo.c4_descripcion
        TDiscoRigido.Text = producto.c5_discorigido.c5_descripcion
        TGabinete.Text = producto.c6_gabinete.c6_descripcion
        TPrecio.Text = "$ " + System.Convert.ToString(producto.precio)

        'Cambiar por direccion del producto
        Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gabinete.jpg"
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub FormularioStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AccesoDatos.cargarProductos(DataGridStock)
            DataGridStock.ClearSelection()

            'Cuando abro que no aparezca ningun valor
            TNombre.Text = "     ************"
            TProcesador.Text = "     ************"
            TPlacaMadre.Text = "     ************"
            TRam.Text = "     ************"
            TStock.Text = "     ************"
            TCategoria.Text = "     ************"
            TPlacaVideo.Text = "     ************"
            TDiscoRigido.Text = "     ************"
            TGabinete.Text = "     ************"
            TPrecio.Text = "     ************"
            Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gabinete.jpg"
            PBImagen.Image = Image.FromFile(imagen)
            Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

            CBBuscar.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Ha ocurrido un error, la lista de producto no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        End Try
    End Sub

    Private Sub DataGridStock_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStock.CellEnter
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        Dim id_producto As Integer = DataGridStock.Item(0, fila).Value
        Dim producto As productos = AccesoDatos.capturarProducto(id_producto)
        deshabilitar()
        cargarDetalle(producto)

        If DataGridStock.Item(5, fila).Value = 0 Then
            BAlta.Visible = True
            BBaja.Visible = False
        Else
            BAlta.Visible = False
            BBaja.Visible = True
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridStock.CurrentRow Is Nothing Then
            MsgBox("Seleccione un producto para poder editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Edicion Invalida")
        ElseIf DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el producto esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        Else
            BNuevo.Visible = False
            BGuardar.Visible = True
            BCancelar.Visible = True
            bloquear()
            habilitar()
        End If
    End Sub

    'falta agregar que valide todos los campos
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TNombre.Text = "" Or TStock.Text = "" Or TPrecio.Text = "" Or TCategoria.SelectedIndex = 0 Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Campos incompletos")
        Else
            Dim fila As Integer = DataGridStock.CurrentRow.Index
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea Editar al producto " + TNombre.Text + "??",
                               MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Producto")
            If MsgBoxResult.Yes = respuesta Then
                Dim id_producto As Integer = DataGridStock.CurrentRow().Cells(0).Value
                Dim fecharegistro As Date = DataGridStock.CurrentRow.Cells(4).Value
                AccesoDatos.ActualizarProducto(id_producto, TNombre.Text, TProcesador.SelectedIndex, TPlacaMadre.SelectedIndex,
                                 TRam.SelectedIndex, TPlacaVideo.SelectedIndex, TDiscoRigido.SelectedIndex, TGabinete.SelectedIndex,
                                 TPrecio.Text, TStock.Text, TCategoria.SelectedIndex)
                AccesoDatos.cargarProductos(DataGridStock)
                MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                               MsgBoxStyle.Information, "Modificacion exitosa")
            Else
                MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                                   MsgBoxStyle.Information, "Operacion Cancelada")
            End If
            BNuevo.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            desbloquear()
            deshabilitar()
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BNuevo.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
        desbloquear()
        deshabilitar()
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
    End Sub

    Private Sub BBaja_Click(sender As Object, e As EventArgs) Handles BBaja.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        If DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("El producto ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Baja invalida")
        Else
            If TNombre.Text = "     ************" Then
                MsgBox("Seleccione un producto para dar de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
            Else
                respuesta = MsgBox("¿Esta seguro que desea Eliminar al producto " + TNombre.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Baja Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray
                        MsgBox("El producto se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el product se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        If DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            respuesta = MsgBox("¿Esta seguro que desea Dar de Alta al producto??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Producto")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    MsgBox("El producto se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un problema, el producto no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
                End Try
            End If
        Else
            MsgBox("El producto ya esta dado de Alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta Invalida")
        End If

    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        limpiar()
        habilitar()

        BAgregar.Visible = True
        BCancelarAgregar.Visible = True
        BEditar.Visible = False
        BNuevo.Visible = False
    End Sub

    Private Sub BCancelarGuardar_Click(sender As Object, e As EventArgs) Handles BCancelarAgregar.Click
        BAgregar.Visible = False
        BCancelarAgregar.Visible = False
        BEditar.Visible = True
        BNuevo.Visible = True
        deshabilitar()
        MsgBox("No se ha agregado ningun producto", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Try
            If TNombre.Text = "" Or TStock.Text = "" Or TPrecio.Text = "" Or TCategoria.Text = "" Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Campos incompletos")
            Else
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Esta seguro que desea agregar el producto??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Agregar Producto")
                If MsgBoxResult.Yes = respuesta Then
                    Dim fila As Integer = DataGridStock.CurrentRow.Index
                    Dim nombre As String = TNombre.Text
                    Dim stock As String = TStock.Text
                    Dim precio As String = TPrecio.Text
                    Dim categoria As String = TCategoria.Text
                    DataGridStock.Rows.Add(nombre, stock, precio, categoria)
                    MsgBox("El producto se ha agregado correctamente", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion exitosa")
                Else
                    MsgBox("El producto no se ha agregado", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
                End If
                BAgregar.Visible = False
                BCancelarAgregar.Visible = False
                BEditar.Visible = True
                BNuevo.Visible = True
                deshabilitar()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema, el producto no se pudo agregar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Agregar")
            BAgregar.Visible = False
            BCancelarAgregar.Visible = False
            BEditar.Visible = True
            BNuevo.Visible = True
            deshabilitar()
        End Try
    End Sub

    Private Sub TStock_KeyPress(sender As Object, e As KeyPressEventArgs)
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
        AccesoDatos.buscarProducto(sender.text, CBBuscar.SelectedIndex, DataGridStock)
    End Sub

    Private Sub CBBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscar.SelectedIndexChanged
        'le paso lo qe se escribe, el numero del combobox buscar seleccionado y el datagrid
        AccesoDatos.buscarProducto(sender.text, CBBuscar.SelectedIndex, DataGridStock)
    End Sub

    'si el estado es 0 (esta dado de baja) entonces lo marca en gris, sino esta dado de baja y el stock es menor a 10 lo marca de rojo
    Private Sub DataGridStock_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridStock.RowStateChanged
        For Each Row As DataGridViewRow In DataGridStock.Rows
            If Row.Cells(5).Value = "0" Then
                Row.DefaultCellStyle.BackColor = Color.Gray
            ElseIf Row.Cells(3).Value < 11 Then
                Row.DefaultCellStyle.BackColor = Color.Red
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

End Class