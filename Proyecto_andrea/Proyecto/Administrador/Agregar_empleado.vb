Public Class Agregar_empleado

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar_ven.Click
        If Tcuil_vend.Text = "" Or Tape_vend.Text = "" Or Tcuil_vend.Text = "" Or Tdir_vend.Text = "" Or Ttel_vend.Text = "" Or
              Tsueldo_vend.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else

            DGvVendedor.Rows.Add(Tid_vend.Text, Tcuil_vend.Text, Tnom_vend.Text, Tape1_vend.Text, Tdir_vend.Text, Ttel_vend.Text,
            Date_ingreso.Text, Tsueldo_vend.Text)

        End If
    End Sub

   

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        'editar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de editar el cliente ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            Dim row As DataGridViewRow = DGVVendedor.CurrentRow

            If (row Is Nothing) Then Return
            row.Cells(0).Value = Tid_vend.Text
            row.Cells(1).Value = Tcuil_vend.Text
            row.Cells(2).Value = Tnom_vend.Text
            row.Cells(3).Value = Tape_vend.Text
            row.Cells(4).Value = Tdir_vend.Text
            row.Cells(5).Value = Ttel_vend.Text
            row.Cells(6).Value = Date_ingreso.Text
            row.Cells(7).Value = Tsueldo_vend.Text
            BAgregar_ven.Enabled = True
            Tid_vend.Clear()
            Tcuil_vend.Clear()
            Tnom_vend.Clear()
            Tape_vend.Clear()
            Tdir_vend.Clear()
            Ttel_vend.Clear()
            Tsueldo_vend.Clear()


        End If
    End Sub

    Private Sub DGVVendedor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVVendedor.CellClick, DataGridView1.CellClick
        'editar elementos al datagridview

        Dim i As Integer
        i = DGVVendedor.CurrentRow.Index
        Tid_vend.Text = DGVVendedor.Item(0, i).Value
        Tcuil_vend.Text = DGVVendedor.Item(1, i).Value
        Tnom_vend.Text = DGVVendedor.Item(2, i).Value
        Tape_vend.Text = DGVVendedor.Item(3, i).Value
        Tdir_vend.Text = DGVVendedor.Item(4, i).Value
        Ttel_vend.Text = DGVVendedor.Item(5, i).Value
        Date_ingreso.Text = DGVVendedor.Item(6, i).Value
        Tsueldo_vend.Text = DGVVendedor.Item(7, i).Value

        BAgregar_ven.Enabled = False
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        'eliminar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de eliminar al vendedor ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            DGVVendedor.Rows.Remove(DGVVendedor.Rows(DGVVendedor.SelectedCells.Item(0).RowIndex))

        End If
    End Sub

    Private Sub GroupBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Funciones.pintar(sender, e)
    End Sub

    Private Sub GroupBox2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupBox2.Paint
        Funciones.pintar(sender, e)
    End Sub

    
    Private Sub Tid_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tid_vend.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Tcuil_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tcuil_vend.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Ttel_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttel_vend.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Tsueldo_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tsueldo_vend.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Tnom_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnom_vend.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub Tape_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tape_vend.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub Tcuil1_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tcuil1_vend.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Tape1_vend_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tape1_vend.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub Tcuil1_vend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcuil1_vend.TextChanged

    End Sub

    Private Sub LDir_vend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDir_vend.Click

    End Sub

    Private Sub Tsueldo_vend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsueldo_vend.TextChanged

    End Sub

    Private Sub Date_ingreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_ingreso.ValueChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Tape1_vend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tape1_vend.TextChanged

    End Sub

    Private Sub BBuscar_ven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBuscar_ven.Click

    End Sub
End Class