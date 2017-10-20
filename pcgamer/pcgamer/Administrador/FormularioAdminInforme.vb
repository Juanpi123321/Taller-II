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
        'Try
#Region "bloquear movimiento del form"
        CenterToScreen()
            Xpos = Location.X
            Ypos = Location.Y
#End Region
            'La leyenda de abajo
            LRol.Text = Me.Tag + ": " + LApeyNom.Tag

            cargarFacturas()
            'Catch ex As Exception
        ' MsgBox("Ha ocurrido un error, la lista de facturas no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        'End Try
    End Sub

    Private Sub DataGridFacturas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFacturas.CellEnter
        BVerDetalle.Visible = True
    End Sub
End Class