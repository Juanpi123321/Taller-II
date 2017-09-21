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
        BCargar.Hide()
        BSeleccionarCliente.Hide()
    End Sub

    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        Dim respuesta As MsgBoxResult

        If TCliente.Text = "" Or TDNI.Text = "" Then
            respuesta = MsgBox("Debe agregar un Cliente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Cliente Invalido")
            'Pregunta si la primera fila esta vacia
        ElseIf DataGridView1.Item(1, 0).Value = "" Then
            respuesta = MsgBox("Debe agregar un Producto", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Producto Invalido")
        Else
            respuesta = MsgBox("La factura se ha generado correctamente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Facturacion exitosa")
            'lo destruye de la memoria
            Me.Dispose()
            FormularioVendedor.Show()
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim cantidad1 As Integer = 1
        Dim precio1 As Double = 7999.99
        Dim importe1 As Double = precio1 * cantidad1
        Dim cantidad2 As Integer = 3
        Dim precio2 As Double = 9999.99
        Dim importe2 As Double = precio2 * cantidad2
        DataGridView1.Rows.Add(cantidad1, "Desktop-Escritorio", "Pc Bronze", precio1, importe1)
        DataGridView1.Rows.Add(cantidad2, "Desktop-Escritorio", "Pc RaidMax Cobra", precio2, importe2)
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        Try
            Dim fila As Integer = DataGridView1.CurrentRow.Index
            If DataGridView1.Item(1, 0).Value = "" Or DataGridView1.Item(1, fila).Value = "" Then
                respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Critical, "Eliminacion Invalida")
            Else
                respuesta = MsgBox("¿Esta seguro de eliminar el Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Confirmar Eliminacion")
                If MsgBoxResult.Yes = respuesta Then
                    DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))
                End If
            End If
        Catch ex As Exception
            respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Modificacion Invalida")
        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim fila As Integer = DataGridView1.CurrentRow.Index
        Dim respuesta As MsgBoxResult
        Try
            If Integer.Parse(DataGridView1.Item(0, fila).Value) = 0 Then
                DataGridView1.Item(0, fila).Value = 1
                respuesta = MsgBox("La cantidad de producto no puede ser 0", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Critical, "Cantidad Invalida")
            Else
                DataGridView1.Item(4, fila).Value = Integer.Parse(DataGridView1.Item(0, fila).Value) * Double.Parse(DataGridView1.Item(3, fila).Value)
            End If
        Catch ex As Exception
            respuesta = MsgBox("Error, no hay productos seleccionados", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Critical, "Modificacion Invalida")
        End Try
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

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'si no esta cargada la fila no deja que modifique la cantidad
        If DataGridView1.Item(1, fila).Value = "" Then
            AddHandler e.Control.KeyPress, AddressOf No_Modificar
        End If
    End Sub

    Private Sub No_Modificar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Celda As DataGridViewCell = Me.DataGridView1.CurrentCell()
        e.Handled = True
    End Sub

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Celda As DataGridViewCell = Me.DataGridView1.CurrentCell()
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

End Class