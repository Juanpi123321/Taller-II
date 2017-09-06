Imports System.Text.RegularExpressions

Public Class Form4

    Private Sub TDni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TDni.Validating
        Dim val As Integer = 0
        If Not Integer.TryParse(TDni.Text, val) Then
            ErrorProvider2.SetError(TDni, "solo numeros")
            e.Cancel = True
        Else
            ErrorProvider2.SetError(TDni, "")
        End If
    End Sub
   

    Private Sub TApellido1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TApellido1.Validating

        'solo texto valida despues de  salir
        If (Regex.IsMatch(TApellido1.Text, "[a-z]")) = False Then
            MsgBox("Solo letras de la a-z")
            e.Cancel = True
        End If
    End Sub
    Private Sub TNombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre1.KeyPress
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub


    Private Sub RBVaron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked = True Then
            PictureBox1.Image = My.Resources.images
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked = True Then
            PictureBox1.Image = My.Resources.mujer
        End If
    End Sub

    Private Sub TApellido1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TApellido1.TextChanged

    End Sub

    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        LModificar.Text = TNombre1.Text & " " & TApellido1.Text
        Dim ask As MsgBoxResult
        If Trim(TDni.Text) = "" Or Trim(TApellido1.Text) = "" Or Trim(TNombre1.Text) = "" Then

            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else
            ask = MsgBox("Seguro que desea insertar un nuevo cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar insercion")
            If MsgBoxResult.Yes = ask Then
                MsgBox("el cliente " & TNombre1.Text & " " & TApellido1.Text & " se inserto correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "guardar")
            Else
                MsgBox("insercion cancelada", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Guardar")
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta apunto de eliminar el cliente: " & TNombre1.Text & " " & TApellido1.Text, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "confirmar Eliminacion")

        If MsgBoxResult.Yes = ask Then
            MsgBox("el cliente " & TNombre1.Text & " " & TApellido1.Text & " se elimino correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminar")
            TDni.Clear()
            TApellido1.Clear()
            TNombre1.Clear()
            TTelefono.Clear()
            LModificar.Text = "Modificar"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class