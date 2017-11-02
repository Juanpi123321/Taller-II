Public Class ReporteFactura
    Private Sub ReporteFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteFactura' Puede moverla o quitarla según sea necesario.
        'MsgBox("1")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "1")
        'MsgBox("2")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "2")
        'MsgBox("3")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "3")
        'MsgBox("4")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "4")
        'MsgBox("5")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "5")
        'MsgBox("6")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "6")
        'MsgBox("7")
        'Me.ReporteFacturaTableAdapter.Fill(Me.DataSet1.ReporteFactura, "7")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class