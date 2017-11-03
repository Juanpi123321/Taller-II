Public Class FormTendencias
    Private Sub BTendenciaSemana_Click(sender As Object, e As EventArgs) Handles BTendenciaSemana.Click
        Me.Cursor = Cursors.WaitCursor
        TendenciasSemana.ShowDialog()
    End Sub

    Private Sub BTendenciaMes_Click(sender As Object, e As EventArgs) Handles BTendenciaMes.Click
        Me.Cursor = Cursors.WaitCursor
        TendenciasMes.ShowDialog()
    End Sub

    Private Sub FormTendencias_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Cursor = Cursors.Arrow
    End Sub
End Class