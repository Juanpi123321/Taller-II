Public Class ABMProductos

    Private Sub ABMProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tid.TextChanged, TStock.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSabor2.TextChanged

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSabor3.TextChanged

    End Sub

    Private Sub Tid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tid.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TStock.KeyPress
        Funciones.validar_numeros(sender, e)
    End Sub

    Private Sub TSabor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSabor1.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSabor2.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSabor3.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub TSabor4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSabor4.KeyPress
        Funciones.validar_letra(sender, e)
    End Sub

    Private Sub BImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImagen.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\Alumno\Downloads"
        OpenFileDialog1.Filter = "imagenes files (*.jpg)|*.png|All files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BAgregarProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregarProd.Click
        If Tid.Text = "" Or CBtipoprod.Text = "" Or TSabor1.Text = "" Or TStock.Text = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        Else

            DataGridView1.Rows.Add(Tid.Text, CBtipoprod.Text, TSabor1.Text, TSabor2.Text, TSabor3.Text, TSabor4.Text,
            TStock.Text, PictureBox1.Image)

        End If
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        'eliminar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de eliminar el Producto ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

        End If
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        'editar elementos al datagridview
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta seguro de editar el Producto ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            Dim row As DataGridViewRow = DataGridView1.CurrentRow

            If (row Is Nothing) Then Return

            row.Cells(1).Value = CBtipoprod.Text
            row.Cells(2).Value = TSabor1.Text
            row.Cells(3).Value = TSabor2.Text
            row.Cells(4).Value = TSabor3.Text
            row.Cells(5).Value = TSabor4.Text
            row.Cells(6).Value = TStock.Text
            row.Cells(7).Value = PictureBox1.Image
            BAgregarProd.Enabled = True
            Tid.Clear()
            TSabor1.Clear()
            TSabor2.Clear()
            TSabor3.Clear()
            TSabor4.Clear()
            TStock.Clear()
            

        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'editar elementos al datagridview

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Tid.Text = DataGridView1.Item(0, i).Value
        CBtipoprod.Text = DataGridView1.Item(1, i).Value
        TSabor1.Text = DataGridView1.Item(2, i).Value
        TSabor2.Text = DataGridView1.Item(3, i).Value
        TSabor3.Text = DataGridView1.Item(4, i).Value
        TSabor4.Text = DataGridView1.Item(5, i).Value
        TStock.Text = DataGridView1.Item(6, i).Value
        PictureBox1.Image = DataGridView1.Item(7, i).Value

        BAgregarProd.Enabled = False
    End Sub

    Private Sub CBtipoprod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBtipoprod.KeyPress
        If CBtipoprod.Text = "palito" Then
            TSabor3.Enabled = True
            LSabor1.BackColor = Color.Red
        End If
    End Sub

    Private Sub CBtipoprod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtipoprod.SelectedIndexChanged
       
        
    End Sub

    Private Sub CBtipoprod_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtipoprod.SelectedValueChanged
        





    End Sub
End Class