Imports System.Text.RegularExpressions

Public Class FormularioCliente
    Private Sub FormularioCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioVendedor.Show()
    End Sub

    Dim DNIvalidate As Boolean
    Dim Emailvalidate As Boolean

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

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
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
                DataGridCliente.Rows.Add("0005", TApellido.Text, TNombre.Text, TDni.Text, FechaReg.Value)
                MsgBox("El Cliente se ha registrado correctamente", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Information, "Registro Exitoso")
                'Ir a tab2
                'FormularioVendedor.Show()
                'Me.Close()
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

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        If DataGridCliente.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un cliente para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            FormularioFactura.Show()
            Me.Hide()
        End If
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
        If DataGridCliente.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un cliente para poder editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Edicion Invalida")
        Else
            BAgregarFactura.Visible = False
            BCancelar.Visible = True
            BGuardar.Visible = True
            habilitar()
        End If
    End Sub

    Private Sub FormularioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridCliente.Rows.Add("0001", "Gallardo", "Marcelo", "25332121", "21/09/2017 10:09")
        DataGridCliente.Rows.Add("0002", "Trump", "Donald", "10123341", "21/09/2017 17:41")
        DataGridCliente.Rows.Add("0003", "Martinez", "Pity", "40112858", "22/09/2017 11:01")
        DataGridCliente.Rows.Add("0004", "Tinelli", "Marcelo", "15020491", "23/09/2017 09:33")
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro de modificar el Producto?", MsgBoxStyle.YesNo +
          MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Confirmar Modificacion")
            If MsgBoxResult.Yes = respuesta Then
                DataGridCliente.Item(1, fila).Value = TBApellido.Text
                DataGridCliente.Item(2, fila).Value = TBNombre.Text
                DataGridCliente.Item(3, fila).Value = TBDNI.Text
                BAgregarFactura.Visible = True
                BCancelar.Visible = False
                BGuardar.Visible = False
                deshabilitar()
                MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                               MsgBoxStyle.Information, "Modificacion exitosa")
            End If



    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BAgregarFactura.Visible = True
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
                domicilio = "B° Nuñez Buenos Aires"
                telefono = "01199850312"
                email = "marcelitogallardo@hotmail.com"

            Case 1
                domicilio = "Queens - New York (USA)"
                telefono = "-"
                email = "donald-trump@outlook.com"
            Case 2
                domicilio = "Guaymallén Mendonza"
                telefono = "3782123461"
                email = "pitymartinez@gmail.com"
            Case 3
                domicilio = "Bolivar Buenos Aires"
                telefono = "0112212388"
                email = "cuervotinelli@hotmail.com"
        End Select
        TBDomicilio.Text = domicilio
        TBTelefono.Text = telefono
        TBEmail.Text = email

        If BCancelar.Visible = True Or BGuardar.Visible = True Then
            MsgBox("Debe finalizar la edicion antes de continuar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Edicion Producto")
            BAgregarFactura.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            deshabilitar()
        End If
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

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged, CBBuscar.SelectedIndexChanged
        If BCancelar.Visible = True Or BGuardar.Visible = True Then
            MsgBox("Debe finalizar la edicion antes de continuar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Edicion Producto")
            BAgregarFactura.Visible = True
            BGuardar.Visible = False
            BCancelar.Visible = False
            deshabilitar()
        End If
    End Sub

End Class