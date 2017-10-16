Imports System.ComponentModel

Public Class FormularioFactura

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Celda As DataGridViewCell = Me.DataGridFactura.CurrentCell()
        If Celda.ColumnIndex = 1 Then
            If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then
                If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Else
                If e.KeyChar = "0"c Then
                    e.Handled = True
                Else
                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub calcularTotal()
        Dim total As Decimal = 0
        If DataGridFactura.CurrentRow Is Nothing Then
            total = 0
        Else
            Dim fila As DataGridViewRow = New DataGridViewRow
            For Each fila In DataGridFactura.Rows
                total = total + fila.Cells(5).Value
            Next
        End If
        TTotal.Text = Convert.ToString(total)
    End Sub

    Private Sub FormularioFactura_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub FormularioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        TFechaHora.Text = String.Format("{0:G}", DateTime.Now)
        LApeyNom.Text = LApeyNom.Tag

        AccesoDatos.cargarFormaPago(CBFormaPago)
        CBFormaPago.SelectedIndex = 0
    End Sub

    Private Sub BBuscarCliente_Click(sender As Object, e As EventArgs) Handles BBuscarCliente.Click
        'Le aviso el tipo de rol
        FormularioAdminCliente.Tag = Me.Tag
        FormularioAdminCliente.LApeyNom.Tag = LApeyNom.Tag
        FormularioAdminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        Dim respuesta As MsgBoxResult

        If TCliente.Text = "" Or TDNI.Text = "" Then
            respuesta = MsgBox("Debe agregar un Cliente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Cliente Invalido")
            'Pregunta si la primera fila esta vacia
        ElseIf DataGridFactura.CurrentRow Is Nothing Then
            respuesta = MsgBox("Debe agregar un Producto", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Producto Invalido")
        Else
            respuesta = MsgBox("¿Esta seguro que desea imprimir la Factura?", MsgBoxStyle.YesNo +
            MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Generar Factura")
            If MsgBoxResult.Yes = respuesta Then
                respuesta = MsgBox("La factura se ha generado correctamente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Facturacion exitosa")
                'destruye de la memoria
                Me.Dispose()
                FormularioVendedor.Show()
            End If
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'Le aviso el tipo de rol
        FormularioAdminStock.Tag = Me.Tag
        FormularioAdminStock.LApeyNom.Tag = LApeyNom.Tag
        FormularioAdminStock.Show()
        Me.Hide()
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        If DataGridFactura.CurrentRow Is Nothing Then
            respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
                               MsgBoxStyle.Critical, "Eliminacion Invalida")
        Else
            Dim fila As Integer = DataGridFactura.CurrentRow.Index
            respuesta = MsgBox("¿Esta seguro de eliminar el Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Confirmar Eliminacion")
            If MsgBoxResult.Yes = respuesta Then
                DataGridFactura.Rows.Remove(DataGridFactura.Rows(DataGridFactura.SelectedCells.Item(0).RowIndex))
            End If
        End If
    End Sub

    Private Sub FormularioFactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea cancelar la Factura?", MsgBoxStyle.YesNo +
            MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Cancelar Factura")
        If MsgBoxResult.Yes = respuesta Then
            Me.Hide()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub DataGridFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFactura.CellEndEdit
        Dim fila As Integer = DataGridFactura.CurrentRow.Index
        If DataGridFactura.Item(1, fila).Value = 0 Then
            MsgBox("La cantidad de producto debe ser como minimo 1", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Cantidad Invalida")
            DataGridFactura.Item(1, fila).Value = 1
        End If
        Dim importe As Decimal = DataGridFactura.Item(1, fila).Value * DataGridFactura.Item(4, fila).Value
        DataGridFactura.Item(5, fila).Value = importe

        calcularTotal()
    End Sub

    Private Sub DataGridFactura_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridFactura.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub

    Private Sub DataGridFactura_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridFactura.RowStateChanged
        calcularTotal()
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioFactura_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region
End Class