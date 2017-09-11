﻿Imports System.Text.RegularExpressions

Public Class FormularioCliente
    Private Sub FormularioCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
    End Sub

    Private Sub BAgregar_Click_1(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim ask As MsgBoxResult
        msg = "Debe completar los campos obligatorios!"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        title = "Error"
        If TNombre.Text = "" Or TApellido.Text = "" Or TDni.Text = "" Or TDomicilio.Text = "" Or TEmail.Text = "" Then
            ask = MsgBox(msg, style, title)
        Else
            msg = "El Cliente se ha registrado correctamente"
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information
            title = "Registro Exitoso"
            ask = MsgBox(msg, style, title)
            FormularioVendedor.Show()
            Me.Close()
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
        If (e.Handled = True) Then
            ErrorProvider1.SetError(TNombre, "Porfavor ingrese solo letras")
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
        If (e.Handled = True) Then
            ErrorProvider1.SetError(TApellido, "Porfavor ingrese solo letras")
        End If
    End Sub

    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(TDni, "Porfavor ingrese solo numeros")
        End If
    End Sub

    'Private Sub TDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
    '   SoloNumeros(e)
    'If Integer.Parse(Me.Usuario.Text) < 0 Or Integer.Parse(Me.Usuario.Text) > 255 Then
    '       MessageBox.Show("Numero ingresado fuera del rango")
    'End If
    'End Sub

    Private Sub FechaReg_ValueChanged(sender As Object, e As EventArgs) Handles FechaReg.ValueChanged
        FechaReg.Value = Now
    End Sub

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click
        FormularioFactura.Show()
        Me.Hide()
    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(TTelefono, "Porfavor ingrese solo numeros")
        End If
    End Sub
End Class