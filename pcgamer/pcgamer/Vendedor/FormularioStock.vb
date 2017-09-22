﻿Public Class FormularioStock
    Private Sub FormularioStock_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub BGenerarFactura_Click(sender As Object, e As EventArgs) Handles BGenerarFactura.Click
        Dim fila As Integer = DataGridStock.CurrentRow.Index
        If DataGridStock.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un producto para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            FormularioFactura.Show()
            Me.Hide()
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
        TPrecio.Text = "$ " + DataGridStock.Item(3, fila).Value
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