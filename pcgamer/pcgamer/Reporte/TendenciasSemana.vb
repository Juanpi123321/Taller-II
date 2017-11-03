Public Class TendenciasSemana
    Private Sub TendenciasSemana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Tendencias' Puede moverla o quitarla según sea necesario.
        Me.TendenciasTableAdapter.Fill(Me.DataSet1.Tendencias, "15-10-2017", "03-11-2017")
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub TendenciasSemana_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormTendencias.Close()
    End Sub
End Class