Imports System.Text.RegularExpressions
Public Class Form3

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNya.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDni.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LApellido.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDni.TextChanged

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TApellido.TextChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub


    Private Sub TDni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TDni.Validating
        Dim val As Integer = 0
        If Not Integer.TryParse(TDni.Text, val) Then
            ErrorProvider1.SetError(TDni, "solo numeros")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TDni, "")
        End If
    End Sub

    Private Sub TApellido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TApellido.Validating

        'solo texto valida despues de  salir
        If (Regex.IsMatch(TApellido.Text, "[a-z]")) = False Then
            MsgBox("Solo letras de la a-z")
            e.Cancel = True
        End If
    End Sub

    Private Sub TGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TGuardar.Click
        LModificar.Text = TNombre.Text & " " & TApellido.Text
        Dim ask As MsgBoxResult
        If Trim(TDni.Text) = "" Or Trim(TApellido.Text) = "" Or Trim(TNombre.Text) = "" Then

            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else
            ask = MsgBox("Seguro que desea insertar un nuevo cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar insercion")
            If MsgBoxResult.Yes = ask Then
                MsgBox("el cliente " & TNombre.Text & " " & TApellido.Text & " se inserto correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "guardar")
            Else
                MsgBox("insercion cancelada", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Guardar")
            End If
        End If

    End Sub

    Private Sub TEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEliminar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta apunto de eliminar el cliente: " & TNombre.Text & " " & TApellido.Text, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            MsgBox("el cliente " & TNombre.Text & " " & TApellido.Text & " se elimino correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminar")
            TDni.Clear()
            TApellido.Clear()
            TNombre.Clear()
            LModificar.Text = "Modificar"
        End If

    End Sub
End Class