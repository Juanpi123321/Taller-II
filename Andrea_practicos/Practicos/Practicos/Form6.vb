Imports System.Text.RegularExpressions
Imports System.Drawing.Imaging
Imports System.IO

Public Class Form6
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFoto.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\Alumno\Downloads"
        OpenFileDialog1.Filter = "tex files (*.txt)|*.txt|All files (*.*)|*.*"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Dim a As String
            a = Directory.GetCurrentDirectory()
            TextBox4.Text = a
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar.Click
        Dim sexo1 As String
        If RBmujer.Checked = True Then
            sexo1 = "Mujer"
        Else
            sexo1 = "Hombre"
        End If
        Dim a As String
        a = Directory.GetCurrentDirectory()
        TextBox4.Text = a
        DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, DateTimePicker1.Text, sexo1, "Eliminar", TextBox3.Text, PictureBox1.Image, a)
        If Val(TextBox3.Text) < 50 Then
            DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim t As String
        t = TextBox1.Text '
        If t <> "" Then
            Mid(t, 1, 1) = UCase(Mid(t, 1, 1))
            For i = 1 To Len(t) - 1
                If Mid(t, i, 2) = Chr(13) + Chr(10) Then
                    Mid(t, i + 2, 1) = UCase(Mid(t, i + 2, 1))
                End If
                If Mid(t, i, 1) = " " Then
                    Mid(t, i + 1, 1) = UCase(Mid(t, i + 1, 1))
                End If
            Next
            TextBox1.Text = t
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        PictureBox1.Image = DataGridView1.Item(6, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(5, i).Value
        TextBox4.Text = DataGridView1.Item(7, i).Value
    End Sub

    Private Sub clickBoton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.CurrentCell.ColumnIndex = 4) Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Esta seguro de eliminar el cliente ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")
            If MsgBoxResult.Yes = ask Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))
            End If
        End If
    End Sub
End Class