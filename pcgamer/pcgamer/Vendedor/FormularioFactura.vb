Public Class FormularioFactura

    Private Sub FormularioFactura_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub FormularioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TCliente.Text <> "" Then
            BSeleccionarCliente.Hide()
        End If
        TFechaHora.Text = String.Format("{0:G}", DateTime.Now)




    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click, BSeleccionarCliente.Click
        FormularioCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BCargar_Click(sender As Object, e As EventArgs) Handles BCargar.Click
        TCliente.Text = "ALFONSO, Pedro"
        TDNI.Text = "11324123"
        TDireccion.Text = "9 de Julio 2781 Corrientes Capital"
        TTelefono.Text = "-"
        BCargar.Visible = False
        BSeleccionarCliente.Visible = False
        BEditar.Visible = True
    End Sub

    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        Dim respuesta As MsgBoxResult

        If TCliente.Text = "" Or TDNI.Text = "" Then
            respuesta = MsgBox("Debe agregar un Cliente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Cliente Invalido")
            'Pregunta si la primera fila esta vacia
        ElseIf DataGridFactura.Item(1, 0).Value = "" Then
            respuesta = MsgBox("Debe agregar un Producto", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Producto Invalido")
        Else
            respuesta = MsgBox("La factura se ha generado correctamente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Facturacion exitosa")
            'destruye de la memoria
            Me.Dispose()
            FormularioVendedor.Show()
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        FormularioStock.Show()
        Me.Hide()
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        Try
            Dim fila As Integer = DataGridFactura.CurrentRow.Index
            If DataGridFactura.Item(1, 0).Value = "" Or DataGridFactura.Item(1, fila).Value = "" Then
                respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Critical, "Eliminacion Invalida")
            Else
                respuesta = MsgBox("¿Esta seguro de eliminar el Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Confirmar Eliminacion")
                If MsgBoxResult.Yes = respuesta Then
                    DataGridFactura.Rows.Remove(DataGridFactura.Rows(DataGridFactura.SelectedCells.Item(0).RowIndex))
                End If
            End If
        Catch ex As Exception
            respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Modificacion Invalida")
        End Try
    End Sub

    Private Sub DataGridFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFactura.CellEndEdit
        Dim fila As Integer = DataGridFactura.CurrentRow.Index
        Try
            If Integer.Parse(DataGridFactura.Item(0, fila).Value) = 0 Or DataGridFactura.Item(0, fila).Value = "" Then
                MsgBox("La cantidad de producto debe ser como minimo 1", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Critical, "Cantidad Invalida")
                DataGridFactura.Item(0, fila).Value = 1
            End If
            DataGridFactura.Item(4, fila).Value = Integer.Parse(DataGridFactura.Item(0, fila).Value) * Double.Parse(DataGridFactura.Item(3, fila).Value)

            If DataGridFactura.Item(0, fila).Value = "" And DataGridFactura.Item(1, fila).Value <> "" Then
                DataGridFactura.Item(0, fila).Value = 1
            End If
        Catch ex As Exception
            'MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
            'MsgBoxStyle.Critical, "Modificacion Invalida")
        End Try

        Dim total As Double = 0
        Dim fila2 As DataGridViewRow = New DataGridViewRow
        For Each fila2 In DataGridFactura.Rows
            total = total + Convert.ToDouble(fila2.Cells(3).Value)
        Next
        TTotal.Text = Convert.ToString(total)
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

    Private Sub DataGridFactura_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridFactura.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
        Dim fila As Integer = DataGridFactura.CurrentRow.Index

        'si no esta cargada la fila no deja que modifique la cantidad
        If DataGridFactura.Item(1, fila).Value = "" Then
            AddHandler e.Control.KeyPress, AddressOf No_Modificar
        End If
    End Sub

    Private Sub No_Modificar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Celda As DataGridViewCell = Me.DataGridFactura.CurrentCell()
        e.Handled = True
    End Sub

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Celda As DataGridViewCell = Me.DataGridFactura.CurrentCell()
        If Celda.ColumnIndex = 0 Then
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

    Private Sub DataGridFactura_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFactura.CellValidated
        Dim total As Double = 0
        Dim fila2 As DataGridViewRow = New DataGridViewRow
        For Each fila2 In DataGridFactura.Rows
            total = total + Convert.ToDouble(fila2.Cells(3).Value)
        Next
        TTotal.Text = Convert.ToString(total)
    End Sub

End Class