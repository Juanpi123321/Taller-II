Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '  e.Handled = True
        '   ErrorProvider1.SetError(TDni, "solo numeros")
        'End If
    End Sub

    Private Sub TDni_Validating(sender As Object, e As CancelEventArgs) Handles TDni.Validating
        'Dim val As Integer = 0
        'If Not Integer.TryParse(TDni.Text, val) Then
        'ErrorProvider1.SetError(TDni, "solo numeros")
        'e.Cancel = True
        'Else
        'ErrorProvider1.SetError(TDni, "")
        'End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub
End Class