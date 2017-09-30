Imports System.Text.RegularExpressions

Public Class FormularioAdminCliente
    Private Sub FormularioAdminCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioAdministrador.Show()
    End Sub

    Dim DNIvalidate As Boolean
    Dim Emailvalidate As Boolean

    Private Sub limpiar()
        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
    End Sub

    Private Sub habilitar()
        TBApellido.ReadOnly = False
        TBNombre.ReadOnly = False
        TBDNI.ReadOnly = False
        TBDomicilio.ReadOnly = False
        TBTelefono.ReadOnly = False
        TBEmail.ReadOnly = False
    End Sub

    Private Sub deshabilitar()
        TBApellido.ReadOnly = True
        TBNombre.ReadOnly = True
        TBDNI.ReadOnly = True
        TBDomicilio.ReadOnly = True
        TBTelefono.ReadOnly = True
        TBEmail.ReadOnly = True
    End Sub

    'Si estan habilitados los campos para modificar y hace click en otro lado
    Private Sub cancelarAgregarEditar()
        If BCancelar.Visible = True Or BGuardar.Visible = True Then
            MsgBox("Debe finalizar la edicion antes de continuar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion cancelada")
            BEliminar.Visible = True
            BCancelar.Visible = False
            BGuardar.Visible = False
            deshabilitar()
        End If

    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        limpiar()
    End Sub

    Private Sub BAgregar_Click_1(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TDni.Text = "" Or TDomicilio.Text = "" Or TEmail.Text = "" Then
            MsgBox("Debe completar los campos obligatorios!", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Registro Incompleto")
        ElseIf DNIvalidate = False Then
            MsgBox("Ingrese un DNI valido")
        ElseIf Emailvalidate = False Then
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Try
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Esta seguro que desea Dar de agregar al cliente??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Cliente")
                If MsgBoxResult.Yes = respuesta Then
                    DataGridCliente.Rows.Add("0005", TApellido.Text, TNombre.Text, TDni.Text, FechaReg.Value)
                    limpiar()
                    MsgBox("El Cliente se ha registrado correctamente", MsgBoxStyle.DefaultButton2 +
            MsgBoxStyle.Information, "Registro Exitoso")
                Else
                    MsgBox("No se ha agregado el cliente", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
                End If
            Catch ex As Exception
                MsgBox("Lo sentimos ha ocurrido un evento inesperado, el cliente no pudo ser registrado",
            MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Error al registrar")
            End Try
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
    Private Sub TDni_Validated(sender As Object, e As EventArgs) Handles TDni.Validated
        If TDni.Text <> "" Then
            If Long.Parse(TDni.Text) < 3000000 Or Long.Parse(TDni.Text) > 99999999 Then
                MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
                ErrorProvider1.SetError(TDni, "DNI invalido")
                DNIvalidate = False
            Else
                DNIvalidate = True
            End If
        End If
    End Sub

    Private Sub FechaReg_ValueChanged(sender As Object, e As EventArgs) Handles FechaReg.ValueChanged
        FechaReg.Value = Now
    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(TTelefono, "Porfavor ingrese solo numeros")
        End If
    End Sub

    Private Sub TEmail_Validated(sender As Object, e As EventArgs) Handles TEmail.Validated
        If Funciones.ValidarEmail(TEmail.Text) = False Then
            ErrorProvider1.SetError(TEmail, "Porfavor ingrese un mail valido")
            Emailvalidate = False
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Emailvalidate = True
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el cliente esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        ElseIf DataGridCliente.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un cliente para editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            BEliminar.Visible = False
            BCancelar.Visible = True
            BGuardar.Visible = True
            habilitar()
        End If
    End Sub

    Private Sub FormularioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridCliente.Rows.Add("0001", "Gimenez", "Susana", "20932571", "21/09/2017 10:09")
        DataGridCliente.Rows.Add("0002", "Casan", "Moria", "22826341", "21/09/2017 17:41")
        DataGridCliente.Rows.Add("0003", "Rial", "Jorge", "40219352", "22/09/2017 11:01")
        DataGridCliente.Rows.Add("0004", "Lobato", "Zulma", "15946471", "23/09/2017 09:33")
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea guardar los cambios realizados??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Cliente")
        If MsgBoxResult.Yes = respuesta Then
            Dim fila As Integer = DataGridCliente.CurrentRow.Index
            DataGridCliente.Item(1, fila).Value = TBApellido.Text
            DataGridCliente.Item(2, fila).Value = TBNombre.Text
            DataGridCliente.Item(3, fila).Value = TBDNI.Text
            MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Modificacion exitosa")
        End If
        BEliminar.Visible = True
        BCancelar.Visible = False
        BGuardar.Visible = False
        deshabilitar()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BEliminar.Visible = True
        BCancelar.Visible = False
        BGuardar.Visible = False
        deshabilitar()
    End Sub

    Private Sub DataGridCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCliente.CellEnter
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        TBApellido.Text = DataGridCliente.Item(1, fila).Value
        TBNombre.Text = DataGridCliente.Item(2, fila).Value
        TBDNI.Text = DataGridCliente.Item(3, fila).Value
        Dim domicilio As String = "-"
        Dim telefono As String = "-"
        Dim email As String = "-"
        Select Case fila
            Case 0
                domicilio = "Palermo Buenos Aires"
                telefono = "01191234312"
                email = "sugimenez@hotmail.com"
            Case 1
                domicilio = "Parque Leloir Buenos Aires"
                telefono = "-"
                email = "moria-casan@outlook.com"
            Case 2
                domicilio = "Munro Buenos Aires"
                telefono = "0112234142"
                email = "jorgericardorial@gmail.com"
            Case 3
                domicilio = "Barrio Serantes Corrientes"
                telefono = "3795129043"
                email = "zulmita@hotmail.com"
        End Select
        TBDomicilio.Text = domicilio
        TBTelefono.Text = telefono
        TBEmail.Text = email

        If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            BAlta.Visible = True
        Else
            BAlta.Visible = False
        End If

        cancelarAgregarEditar()

    End Sub

    Private Sub TBDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBDNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TBDni_Validated(sender As Object, e As EventArgs) Handles TBDNI.Validated
        If TBDNI.Text <> "" Then
            If Long.Parse(TBDNI.Text) < 3000000 Or Long.Parse(TBDNI.Text) > 99999999 Then
                MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
                DNIvalidate = False
            Else
                DNIvalidate = True
            End If
        End If
    End Sub
    Private Sub TBNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub
    Private Sub TBApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellido.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("El cliente ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminacion invalida")
        ElseIf DataGridCliente.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un cliente para eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            respuesta = MsgBox("¿Esta seguro que desea Eliminar al cliente " + TBNombre.Text + " " + TBApellido.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminar Cliente")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray
                    MsgBox("El cliente se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un problema, el cliente no se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                End Try
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            respuesta = MsgBox("¿Esta seguro que desea Dar de Alta al cliente " + TBNombre.Text + " " + TBApellido.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Cliente")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    MsgBox("El cliente se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un problema, el cliente no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
                End Try
            End If
        Else
            MsgBox("El cliente ya esta dado de Alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta Invalida")
        End If

    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        cancelarAgregarEditar()
    End Sub

    Private Sub CBBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscar.SelectedIndexChanged
        cancelarAgregarEditar()
    End Sub
End Class