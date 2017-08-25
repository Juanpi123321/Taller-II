Public Class Formulario1
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TextBox3.Text = (TextBox1.Text & " " & TextBox2.Text)
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox3.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub
End Class
