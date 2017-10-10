Public Class FormularioStock
    Private Sub FormularioStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Si desde factura se dirigio al formulario de stock y cerro esa ventana, redirige hacia la factura
        If FormularioFactura.DataGridFactura.CurrentRow Is Nothing And FormularioFactura.TCliente.Text = "" Then
            FormularioVendedor.Show()
        Else
            FormularioFactura.Show()
        End If

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
        cargarDetalle(producto)
    End Sub

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click
        If DataGridStock.CurrentRow Is Nothing Or TNombre.Text = "     ************" Then
            MsgBox("Seleccione un producto para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
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
                FormularioFactura.Show()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
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

End Class