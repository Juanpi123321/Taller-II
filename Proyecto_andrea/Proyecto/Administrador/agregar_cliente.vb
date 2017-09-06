
Public Class agregar_cliente

    Private Sub TApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    



    Private Sub agregar_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Funciones.pintar(sender, e)
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCuil.TextChanged

    End Sub


    Private Sub TNombre_BorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TNombre.BorderStyleChanged

    End Sub


    Private Sub TCuil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCuil.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub TNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub


    Private Sub Ttel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttel.KeyPress
        Funciones.validar_numeros(sender, e)

    End Sub

    Private Sub TCuil1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCuil1.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub


    Private Sub TApellido1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido1.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TCuil.Text = "" Or Tdireccion.Text = "" Or Ttel.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else

            DataGridView1.Rows.Add(TId.Text, TCuil.Text, TNombre.Text, TApellido.Text, Tdireccion.Text, Ttel.Text,
            DateTimePicker1.Text)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'editar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de editar el cliente ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            Dim row As DataGridViewRow = DataGridView1.CurrentRow

            If (row Is Nothing) Then Return

            row.Cells(1).Value = TCuil.Text
            row.Cells(2).Value = TNombre.Text
            row.Cells(3).Value = TApellido.Text
            row.Cells(4).Value = Tdireccion.Text
            row.Cells(5).Value = Ttel.Text
            row.Cells(6).Value = DateTimePicker1.Text
            Button1.Enabled = True
            TId.Clear()
            TCuil.Clear()
            TNombre.Clear()
            TApellido.Clear()
            Tdireccion.Clear()
            Ttel.Clear()


        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'eliminar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de eliminar el cliente ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

        End If

    End Sub

    Private Sub TId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TId.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub



    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView2.CellClick
        'editar elementos al datagridview

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TId.Text = DataGridView1.Item(0, i).Value
        TCuil.Text = DataGridView1.Item(1, i).Value
        TNombre.Text = DataGridView1.Item(2, i).Value
        TApellido.Text = DataGridView1.Item(3, i).Value
        Tdireccion.Text = DataGridView1.Item(4, i).Value
        Ttel.Text = DataGridView1.Item(5, i).Value
        DateTimePicker1.Text = DataGridView1.Item(6, i).Value

        Button1.Enabled = False
    End Sub


    Private Sub GroupBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Funciones.pintar(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView2.CellContentClick

    End Sub

    Private Sub LCuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCuil.Click

    End Sub

    Private Sub TNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNombre.TextChanged

    End Sub

    Private Sub LTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LTelefono.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class