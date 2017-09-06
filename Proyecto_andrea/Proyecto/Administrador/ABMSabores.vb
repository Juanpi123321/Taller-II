Public Class ABMSabores

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tdesc_sabor.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        'eliminar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de eliminar el Producto ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        'editar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de editar el Sabor ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            Dim row As DataGridViewRow = DataGridView1.CurrentRow

            If (row Is Nothing) Then Return

            row.Cells(1).Value = Tdesc_sabor.Text

            BAgregarSabor.Enabled = True
            Tid.Clear()
            Tdesc_sabor.Clear()
            


        End If
    End Sub

    Private Sub Tid_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tid.MouseMove

    End Sub

    Private Sub Tid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tid.TextChanged

    End Sub

    Private Sub Tid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tid.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub Tdesc_sabor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tdesc_sabor.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub BAgregarSabor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregarSabor.Click
        If Tid.Text = "" Or Tdesc_sabor.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else

            DataGridView1.Rows.Add(Tid.Text, Tdesc_sabor.Text)

        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'editar elementos al datagridview

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Tid.Text = DataGridView1.Item(0, i).Value
        Tdesc_sabor.Text = DataGridView1.Item(1, i).Value
        

        BAgregarSabor.Enabled = False
    End Sub
End Class