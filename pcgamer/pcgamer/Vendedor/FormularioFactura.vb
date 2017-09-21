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

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea cancelar la Factura?", MsgBoxStyle.YesNo +
            MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Cancelar Factura")
        If MsgBoxResult.Yes = respuesta Then
            FormularioVendedor.Show()
            Me.Close()
        End If
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
            FormularioVendedor.Show()
            Me.Close()
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
    End Sub
End Class