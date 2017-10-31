Public Class FormularioAdminInforme
    Private Sub FormularioAdminInforme_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        redirigirMenu(Me.Tag)
    End Sub

    Private Sub cargarFacturas()
        cargarComboBoxs()
        AccesoDatos.cargarFacturas(DataGridFacturas)
        DataGridFacturas.ClearSelection()
        DataGridFacturas.DefaultCellStyle.ForeColor = Color.Black
        BVerDetalle.Visible = False
        CBBuscar.SelectedIndex = 0
    End Sub

    Private Sub cargarComboBoxs()
        Try
            AccesoDatos.cargarCBoxs(CBDesde, CBHasta)
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema, la base de datos no se pudo cargar correctamente", MsgBoxStyle.DefaultButton2 +
                   MsgBoxStyle.Exclamation, "Fallo al cargar Fechas")
        End Try
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioAdminInforme_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub

#End Region
    Private Sub FormularioAdminInforme_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
#Region "bloquear movimiento del form"
            CenterToScreen()
            Xpos = Location.X
            Ypos = Location.Y
#End Region
            'La leyenda de abajo
            LRol.Text = Me.Tag + ": " + LApeyNom.Tag

            cargarFacturas()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, la lista de facturas no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        End Try
    End Sub

    Private Sub BVerDetalle_Click(sender As Object, e As EventArgs) Handles BVerDetalle.Click
        If DataGridFacturas.CurrentRow Is Nothing Then
            MsgBox("Error, las fechas seleccionadas son incorrectas", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Filtrado incorrecto")
        Else
            Dim fila As Integer = DataGridFacturas.CurrentRow.Index
        Dim id_producto As Integer = DataGridFacturas.Item(0, fila).Value
        DetalleFactura.Tag = id_producto
        DetalleFactura.ShowDialog()
        End If
    End Sub

    Private Sub DataGridFacturas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFacturas.CellEnter
        BVerDetalle.Visible = True
    End Sub

    Private Sub BVer_Click(sender As Object, e As EventArgs) Handles BVer.Click
        If CBDesde.Text > CBHasta.Text Then
            MsgBox("Error, las fechas seleccionadas son incorrectas", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Filtrado incorrecto")
        Else
            AccesoDatos.filtrarFecha(CBDesde.Text, CBHasta.Text, DataGridFacturas)
        End If

    End Sub

    Private Sub BEstadisticas_Click(sender As Object, e As EventArgs) Handles BEstadisticas.Click
        'Le aviso el tipo de rol
        FormularioEstadisticas.Tag = Me.Tag
        FormularioEstadisticas.LApeyNom.Tag = LApeyNom.Tag
        FormularioEstadisticas.Show()
        Me.Hide()
    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        'le paso lo qe se escribe, el numero del combobox buscar seleccionado y el datagrid
        AccesoDatos.buscarFacturas(sender.text, CBBuscar.SelectedIndex, DataGridFacturas, CBDesde.Text, CBHasta.Text)
    End Sub
End Class