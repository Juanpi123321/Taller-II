Public Class TendenciasMes
    Private Sub TendenciasMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mesAnterior = Today.AddMonths(-1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Tendencias' Puede moverla o quitarla según sea necesario.
        Me.TendenciasTableAdapter.Fill(Me.DataSet1.Tendencias, mesAnterior, Today)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TendenciasMes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormTendencias.Close()
    End Sub
End Class