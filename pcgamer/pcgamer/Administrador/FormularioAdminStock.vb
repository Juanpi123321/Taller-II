Public Class FormularioAdminStock
    Private Sub FormularioAdminStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioAdministrador.Show()
    End Sub

    Private Sub limpiar()
        TNombre.Clear()
        TProcesador.Clear()
        TPlacaMadre.Clear()
        TRam.Clear()
        TStock.Clear()
        TPlacaVideo.Clear()
        TDiscoRigido.Clear()
        TGabinete.Clear()
        TPrecio.Clear()
    End Sub

    Private Sub habilitar()
        TNombre.ReadOnly = False
        TProcesador.ReadOnly = False
        TPlacaMadre.ReadOnly = False
        TRam.ReadOnly = False
        TStock.ReadOnly = False
        TCategoria.Enabled = True
        TPlacaVideo.ReadOnly = False
        TDiscoRigido.ReadOnly = False
        TGabinete.ReadOnly = False
        TPrecio.ReadOnly = False
    End Sub

    Private Sub deshabilitar()
        TNombre.ReadOnly = True
        TProcesador.ReadOnly = True
        TPlacaMadre.ReadOnly = True
        TRam.ReadOnly = True
        TStock.ReadOnly = True
        TCategoria.Enabled = False
        TPlacaVideo.ReadOnly = True
        TDiscoRigido.ReadOnly = True
        TGabinete.ReadOnly = True
        TPrecio.ReadOnly = True
    End Sub

    'Si estan habilitados los campos para modificar y hace click en otro lado
    Private Sub cancelarAgregarEditar()
        If BCancelar.Visible = True Or BGuardar.Visible = True Or BCancelarAgregar.Visible = True Or BAgregar.Visible = True Then
            MsgBox("Debe finalizar la edicion antes de continuar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion Cancelada")
            BNuevo.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            BCancelarAgregar.Visible = False
            BAgregar.Visible = False
            BEditar.Visible = True
            deshabilitar()
        End If

    End Sub

    Private Sub FormularioStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Agrego todo manualmente hasta que tenga Base de Datos
        DataGridStock.Rows.Add("0001", "Pc Bronze Ultra", "10", "8999.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0002", "Pc Bronze", "4", "7999.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0003", "Pc RaidMax Viper", "24", "9499.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0004", "Pc RaidMax Cobra", "30", "9999.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0005", "Acer Aspire E 15", "45", "20499.99", "Notebook")
        DataGridStock.Rows.Add("0006", "Hp Gamer Omen", "12", "27999.99", "Notebook")
        DataGridStock.Rows.Add("0007", "Pc Bangho Gamer", "20", "17999.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0008", "Pc Master Race", "10", "13799.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0009", "Pc NZXT Guardian", "25", "9999.99", "Desktop-Escritorio")
        DataGridStock.Rows.Add("0010", "Pc Circuit Planet", "15", "8999.99", "Desktop-Escritorio")

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
        Select Case fila
            Case 0
                procesador = "Intel Core i5 3.0GHz"
                placamadre = "Asus (1151) Z170-e"
                ram = "HyperX 8GB DDR3 1866Mhz"
                placavideo = "MSI GTX 1060 GAMING GDDR5"
                discorigido = "Seagate BarraCuda 3.5 1TB"
                gabinete = "Sentey Kron Gs-6005"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\pc-bronze-ultra.jpg"

            Case 1
                procesador = "Intel Core i3-6100 3.7GHz"
                placamadre = "Asrock H110M-HDV"
                ram = "HyperX 4GB DDR3 1866Mhz"
                placavideo = "Asus GeForce GTX 1040"
                discorigido = "WD Blue 1TB SATA3"
                gabinete = "Nfortec Pegasus LED Azul"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\pc-bronze.jpg"
            Case 2
                procesador = "AMD APU Series A10 7860k"
                placamadre = "Gigabyte Chipset A68 - USB3.0"
                ram = "HyperX 8GB DDR3 1866Mhz"
                placavideo = "Asus GeForce GTX 1040"
                discorigido = "Toshiba 1TB SATA3"
                gabinete = "RaidMax Viper"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gamer-raidmax-viper.jpg"
            Case 3
                procesador = "AMD FX8320"
                placamadre = "ASUS M578L-M"
                ram = "HyperX 8GB DDR3 1866Mhz"
                placavideo = "ASUS Radeon R9 Strix 4GB"
                discorigido = "WD Blue 1TB SATA3"
                gabinete = "RaidMax Cobra"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\gamer-raidmax-cobra-z-black-red.jpg"
            Case 4
                procesador = "Intel Core I5-7200U"
                placamadre = "NBMML11002 (RF)"
                ram = "DDR4 6 GB (estándar)"
                placavideo = "Intel HD 620"
                discorigido = "1TB Toshiba SATA3"
                gabinete = "-"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\Acer Aspire E 15.jpg"
            Case 5
                procesador = "Intel Core i7 de 2,8 Ghz Turbo Boost"
                placamadre = "15-ce002la"
                ram = "Memoria 12 GB DDR4 de SDRAM"
                placavideo = "NVIDIA GeForce GTX 1050"
                discorigido = "1TB 7200 RPM SATA"
                gabinete = "-"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\Gamer-Hp-Omen-15-ax205la.jpg"
        End Select
        TProcesador.Text = procesador
        TPlacaMadre.Text = placamadre
        TRam.Text = ram
        TStock.Text = DataGridStock.Item(2, fila).Value
        TCategoria.Text = DataGridStock.Item(4, fila).Value
        TPlacaVideo.Text = placavideo
        TDiscoRigido.Text = discorigido
        TGabinete.Text = gabinete
        TPrecio.Text = DataGridStock.Item(3, fila).Value
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

        'Hago esto xq sino cuando llega a la ultima fila me da error
        If TStock.Text <> "" And DataGridStock.CurrentRow.DefaultCellStyle.BackColor <> Color.Gray Then
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

        cancelarAgregarEditar()

        If DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            BAlta.Visible = True
            BBaja.Visible = False
        Else
            BAlta.Visible = False
            BBaja.Visible = True
        End If

    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        If DataGridStock.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el producto esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        ElseIf DataGridStock.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un producto para editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            BNuevo.Visible = False
            BGuardar.Visible = True
            BCancelar.Visible = True
            habilitar()
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Editar al producto " + TNombre.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Producto")
        If MsgBoxResult.Yes = respuesta Then
            DataGridStock.Item(1, fila).Value = TNombre.Text
            DataGridStock.Item(2, fila).Value = TStock.Text
            DataGridStock.Item(3, fila).Value = TPrecio.Text
            DataGridStock.Item(4, fila).Value = TCategoria.Text

            BNuevo.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            deshabilitar()
            MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Modificacion exitosa")
        Else
            BNuevo.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            deshabilitar()
            MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BNuevo.Visible = True
        BGuardar.Visible = False
        BCancelar.Visible = False
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
                    DataGridStock.Rows.Add("0011", nombre, stock, precio, categoria)
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
        cancelarAgregarEditar()
    End Sub

    Private Sub CBBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscar.SelectedIndexChanged
        cancelarAgregarEditar()
    End Sub
End Class