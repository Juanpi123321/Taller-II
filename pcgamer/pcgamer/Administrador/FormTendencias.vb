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

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub Login_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
    End Sub
#End Region
End Class