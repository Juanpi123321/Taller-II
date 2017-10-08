Public Class FormularioStock
    Private Sub FormularioStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        If DataGridStock.Item(0, fila).Value = "" Or TNombre.Text = "     ************" Then
            MsgBox("Seleccione un producto para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim categoria As String = DataGridStock.Item(3, fila).Value
            Dim descripcion As String = DataGridStock.Item(0, fila).Value
            Dim precio As Integer = Integer.Parse(DataGridStock.Item(2, fila).Value)
            Dim cantidad As Integer = 1
            Dim importe As Double = precio * cantidad
            FormularioFactura.DataGridFactura.Rows.Add(cantidad, categoria, descripcion, precio, importe)
            FormularioFactura.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub FormularioStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Agrego todo manualmente hasta que tenga Base de Datos
        'DataGridStock.Rows.Add("Pc Bronze Ultra", "10", "9000", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc Bronze", "4", "8000", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc RaidMax Viper", "24", "9500", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc RaidMax Cobra", "30", "10000", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Acer Aspire E 15", "45", "20500", "Notebook")
        'DataGridStock.Rows.Add("Hp Gamer Omen", "12", "28000", "Notebook")
        'DataGridStock.Rows.Add("Pc Bangho Gamer", "20", "18000", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc Master Race", "10", "13800", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc NZXT Guardian", "25", "10000", "Desktop-Escritorio")
        'DataGridStock.Rows.Add("Pc Circuit Planet", "15", "9000", "Desktop-Escritorio")

        AccesoDatos.cargarProductos(DataGridStock)


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
    End Sub

    Private Sub DataGridStock_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStock.CellEnter
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        TNombre.Text = DataGridStock.Item(1, fila).Value
        Dim procesador As String = ""
        Dim placamadre As String = ""
        Dim ram As String = ""
        Dim placavideo As String = ""
        Dim discorigido As String = ""
        Dim gabinete As String = ""
        Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gabinete.jpg"
        'Select Case fila
        'Case 0
        ' procesador = "Intel Core i5 3.0GHz"
        '  placamadre = "Asus (1151) Z170-e"
        '   ram = "HyperX 8GB DDR3 1866Mhz"
        '    placavideo = "MSI GTX 1060 GAMING GDDR5"
        '     discorigido = "Seagate BarraCuda 3.5 1TB"
        '      gabinete = "Sentey Kron Gs-6005"
        '       imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\pc-bronze-ultra.jpg"
        'End Select
        TProcesador.Text = procesador
        TPlacaMadre.Text = placamadre
        TRam.Text = ram
        TStock.Text = DataGridStock.Item(3, fila).Value
        TCategoria.Text = DataGridStock.Item(4, fila).Value
        TPlacaVideo.Text = placavideo
        TDiscoRigido.Text = discorigido
        TGabinete.Text = gabinete
        TPrecio.Text = "$ " + System.Convert.ToString(DataGridStock.Item(2, fila).Value)
        'TPrecio.Text = "$ " + ToString(DataGridStock.Item(2, fila).Value)
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

        'Hago esto xq sino cuando llega a la ultima fila me da error
        If TStock.Text <> "" Then
            If Integer.Parse(TStock.Text) <= 10 Then
                DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Red
            End If
        Else
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
        End If

    End Sub

End Class