Public Class ProdxCategoria
    Private Sub ProdxCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ProdxCategoria' Puede moverla o quitarla según sea necesario.
        Me.ProdxCategoriaTableAdapter.Fill(Me.DataSet1.ProdxCategoria)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class