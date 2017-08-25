Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Formulario3
    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(TDni, "solo numeros")
        End If

    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
        If (e.Handled = True) Then
            ErrorProvider1.SetError(TApellido, "solo letras")
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
        If (e.Handled = True) Then
            ErrorProvider1.SetError(TNombre, "solo letras")
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim ask As MsgBoxResult
        msg = "Debe Completar todos los campos"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        title = "Error"
        If TDni.Text = "" Or TNombre.Text = "" Or TApellido.Text = "" Then
            ask = MsgBox(msg, style, title)
        Else
            LModificar.Text = (TNombre.Text & " " & TApellido.Text)
            msg = "Seguro que desea insertar un nuevo Cliente?"
            style = MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
            'MsgBoxStyle.DefaultButton1 Indica el boton por defecto
            title = "Confirmacion Insercion"
            ask = MsgBox(msg, style, title)
            If ask = vbYes Then
                msg = "El Cliente: " + LModificar.Text + " se inserto Correctamente"
                style = MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information
                title = "Guardar"
                ask = MsgBox(msg, style, title)
            Else
                LModificar.Text = "modificar"
            End If
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim ask As MsgBoxResult
        msg = "Debe guardar el Cliente antes de poder eliminarlo"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        title = "Error"
        If LModificar.Text = "modificar" Then
            ask = MsgBox(msg, style, title)
        Else
            msg = "Esta apunto de eliminar el Cliente: " + LModificar.Text
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
            title = "Confirmar Eliminación"
            ask = MsgBox(msg, style, title)
            If ask = vbYes Then
                msg = "El Cliente: " + LModificar.Text + " se elimino correctamente"
                style = MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information
                title = "Eliminar"
                TDni.Clear()
                TApellido.Clear()
                TNombre.Clear()
                TTelefono.Clear()
                CBTarjeta1.Checked = False
                CBTarjeta2.Checked = False
                CBTarjeta3.Checked = False
                ask = MsgBox(msg, style, title)
                LModificar.Text = "modificar"
            End If
        End If
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.usuario_hombre2

    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.usuario_mujer3

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

End Class