Imports System.IO

Public Class Formulario5

    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        OpenFileDialog1.InitialDirectory = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\Practico1\Practico1\bin\Debug\Fotos"
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Dim ruta As String
            ruta = Directory.GetCurrentDirectory()
            TFoto.Text = ruta
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim sexo As String
        If RBHombre.Checked Then
            sexo = "Hombre"
        Else
            sexo = "Mujer"
        End If
        Dim eliminar As Button = New Button
        eliminar.Text = "Eliminar"
        DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, FechaNac.Value.ToShortDateString, sexo, eliminar.Text, TSaldo.Text, PictureBox1.Image, TFoto.Text)
        If Val(TSaldo.Text) < 50 Then
            DataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red
        End If

        'Limpiar formulario
        TNombre.Clear()
        TApellido.Clear()
        FechaNac.Value = New DateTime(1900, 1, 1)
        RBHombre.Checked = True
        TSaldo.Clear()
        TFoto.Clear()
        PictureBox1.Image = Image.FromFile("D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\Practico1\Practico1\bin\Debug\Fotos\default_user.jpg")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim fila As Integer = DataGridView1.CurrentRow.Index
        TApellido.Text = DataGridView1.Item(0, fila).Value
        TNombre.Text = DataGridView1.Item(1, fila).Value
        FechaNac.Value = DataGridView1.Item(2, fila).Value
        If DataGridView1.Item(3, fila).Value = "Hombre" Then
            RBHombre.Checked = True
        Else
            RBMujer.Checked = True
        End If
        TSaldo.Text = DataGridView1.Item(5, fila).Value
        PictureBox1.Image = DataGridView1.Item(6, fila).Value
        TFoto.Text = DataGridView1.Item(7, fila).Value
    End Sub

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Altura de las columnas
        DataGridView1.RowTemplate.Height = 50
    End Sub

    Private Sub ClickBoton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.CurrentCell.ColumnIndex = 4) Then
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro de eliminar el cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Confirmar Eliminacion")
            If MsgBoxResult.Yes = respuesta Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))
            End If
        End If
    End Sub


End Class