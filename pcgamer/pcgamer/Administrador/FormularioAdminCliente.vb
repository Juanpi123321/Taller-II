Imports System.Text.RegularExpressions

Public Class FormularioAdminCliente
    Private Sub FormularioAdminCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Si desde factura se dirigio al formulario de cliente y cerro esa ventana, redirige hacia la factura
        ''Si nunca entro a factura LApeyNom va a tener el valor x defecto '-'
        If FormularioFactura.LApeyNom.Text = "-" Then
            redirigirMenu(Me.Tag)
        Else
            'Le aviso el tipo de rol
            FormularioFactura.Show()
        End If
        Me.Dispose()
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

    Private Sub bloquear()
        TBuscar.Enabled = False
        CBBuscar.Enabled = False
        DataGridCliente.Enabled = False
        TabPage1.Enabled = False
    End Sub

    Private Sub desbloquear()
        TBuscar.Enabled = True
        CBBuscar.Enabled = True
        DataGridCliente.Enabled = True
        TabPage1.Enabled = True
    End Sub

    Private Sub cargarDetalle(cliente As clientes)
        TBApellido.Text = cliente.apellidos
        TBNombre.Text = cliente.nombres
        TBDNI.Text = cliente.dni
        TBDomicilio.Text = cliente.domicilio
        TBTelefono.Text = cliente.telefono
        TBEmail.Text = cliente.email
    End Sub

    Private Sub cargarClientes()
        AccesoDatos.cargarClientes(DataGridCliente)
        DataGridCliente.ClearSelection()

        TBApellido.Clear()
        TBNombre.Clear()
        TBDNI.Clear()
        TBDomicilio.Clear()
        TBTelefono.Clear()
        TBEmail.Clear()

        CBBuscar.SelectedIndex = 0
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        limpiar()
    End Sub

    Private Sub BAgregar_Click_1(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TDni.Text = "" Or TDomicilio.Text = "" Or TEmail.Text = "" Then
            MsgBox("Debe completar los campos obligatorios!", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Registro Incompleto")
        ElseIf DNIvalidate = False Then
            MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
        ElseIf Emailvalidate = False Then
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            If AccesoDatos.existeCliente(TDni.Text) Then
                MsgBox("Ya existe un cliente registrado con el DNI '" + TDni.Text + "'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "DNI en uso")
            ElseIf AccesoDatos.existeEmailCliente(TEmail.Text) Then
                MsgBox("Ya existe un cliente registrado con el Email '" + TEmail.Text + "'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "Email en uso")
            Else
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Esta seguro que desea Dar de agregar al cliente??",
                       MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Cliente")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        AccesoDatos.AgregarCliente(New clientes() With
                                           {.nombres = TNombre.Text,
                                           .apellidos = TApellido.Text,
                                           .dni = TDni.Text,
                                           .domicilio = TDomicilio.Text,
                                           .telefono = TTelefono.Text,
                                           .email = TEmail.Text,
                                           .fecharegistro = FechaReg.Value,
                                           .estado = 1
                                           })
                        MsgBox("El Cliente se ha registrado correctamente", MsgBoxStyle.DefaultButton2 +
                            MsgBoxStyle.Information, "Registro Exitoso")
                    Catch ex As Exception
                        MsgBox("Lo sentimos ha ocurrido un evento inesperado, el cliente no pudo ser registrado",
                         MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Error al registrar")
                    Finally
                        limpiar()
                        cargarClientes()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        Dim re As New Regex("[^a-zA-ZñÑ_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
        If (e.Handled = True) Then
            ErrorProvider1.SetError(TNombre, "Porfavor ingrese solo letras")
        End If
    End Sub
    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        Dim re As New Regex("[^a-zA-ZñÑ_ \b]", RegexOptions.IgnoreCase)
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
        If ValidarEmail(TEmail.Text) = False Then
            ErrorProvider1.SetError(TEmail, "Porfavor ingrese un mail valido")
            Emailvalidate = False
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Emailvalidate = True
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridCliente.CurrentRow Is Nothing Then
            MsgBox("Seleccione un cliente para poder editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Edicion Invalida")
        ElseIf DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el cliente esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        Else
            BEliminar.Visible = False
            BCancelar.Visible = True
            BGuardar.Visible = True
            bloquear()
            habilitar()
            TBDni_Validated(sender, e)
            TBEmail_validated(sender, e)
        End If
    End Sub

    Private Xpos, Ypos
    Private Sub FormularioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
#Region "bloquear movimiento del form"
            CenterToScreen()
            Xpos = Location.X
            Ypos = Location.Y
#End Region
            If Me.Tag = "Vendedor" Then
                PBlogo2.Visible = True
                BAgregarFactura.Visible = True
                BEditar.Visible = False
            End If
            'La leyenda de abajo
            LRol.Text = Me.Tag
            LApeyNom.Text = LApeyNom.Tag

            cargarClientes()
            BEliminar.Visible = False
            BAlta.Visible = False
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, la lista de clientes no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        End Try
    End Sub

#Region "bloquear movimiento del form"
    Private Sub FormularioAdminStock_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TBNombre.Text = "" Or TBApellido.Text = "" Or TBDNI.Text = "" Or TBDomicilio.Text = "" Or TBEmail.Text = "" Then
            MsgBox("Debe completar los campos obligatorios!", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Registro Incompleto")
        ElseIf DNIvalidate = False Then
            MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
        ElseIf Emailvalidate = False Then
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea guardar los cambios realizados??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Cliente")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    Dim id_cliente As Integer = DataGridCliente.CurrentRow().Cells(0).Value
                    Dim fecharegistro As Date = DataGridCliente.CurrentRow.Cells(4).Value
                    AccesoDatos.ActualizarCliente(id_cliente, TBNombre.Text, TBApellido.Text, TBDNI.Text,
                                     TBDomicilio.Text, TBTelefono.Text, TBEmail.Text, fecharegistro)
                    AccesoDatos.cargarClientes(DataGridCliente)
                    MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                                   MsgBoxStyle.Information, "Modificacion exitosa")
                Catch ex As Exception
                    MsgBox("Lo sentimos ha ocurrido un evento inesperado, el cliente no pudo ser registrado",
                      MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Error al registrar")
                Finally
                    BEliminar.Visible = True
                    BCancelar.Visible = False
                    BGuardar.Visible = False
                    desbloquear()
                    deshabilitar()
                End Try
            End If
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
        BEliminar.Visible = True
        BCancelar.Visible = False
        BGuardar.Visible = False
        desbloquear()
        deshabilitar()
        limpiar()
    End Sub

    Private Sub DataGridCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCliente.CellEnter
        Dim fila As Integer = DataGridCliente.CurrentRow.Index
        Dim id_cliente As Integer = DataGridCliente.Item(0, fila).Value
        Dim cliente As clientes = AccesoDatos.capturarCliente(id_cliente)
        habilitar()
        cargarDetalle(cliente)
        deshabilitar()

        If Me.Tag <> "Vendedor" Then
            If DataGridCliente.Item(5, fila).Value = 0 Then
                BAlta.Visible = True
                BEliminar.Visible = False
            Else
                BAlta.Visible = False
                BEliminar.Visible = True
            End If
        End If

    End Sub

    Private Sub TBDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBDNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TBDni_Validated(sender As Object, e As EventArgs) Handles TBDNI.Validated
        If TBDNI.Text <> "       ********************" Then
            If TBDNI.Text <> "" Then
                If Long.Parse(TBDNI.Text) < 3000000 Or Long.Parse(TBDNI.Text) > 99999999 Then
                    MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "DNI invalido")
                    DNIvalidate = False
                Else
                    DNIvalidate = True
                End If
            End If
        End If
    End Sub
    Private Sub TBNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        Dim re As New Regex("[^a-zA-ZñÑ_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub
    Private Sub TBApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellido.KeyPress
        Dim re As New Regex("[^a-zA-ZñÑ_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub
    Private Sub TBEmail_Validated(sender As Object, e As EventArgs) Handles TBEmail.Validated
        If ValidarEmail(TBEmail.Text) = False Then
            Emailvalidate = False
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Emailvalidate = True
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If DataGridCliente.CurrentRow Is Nothing Then
            MsgBox("Seleccione un cliente para eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridCliente.CurrentRow.Index
            'Pregunta si el fondo es gris o si el estado es 0
            If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Or DataGridCliente.CurrentRow().Cells(5).Value = 0 Then
                MsgBox("El cliente ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminacion invalida")
            Else
                respuesta = MsgBox("¿Esta seguro que desea Eliminar al cliente " + TBNombre.Text + " " + TBApellido.Text + "??",
                               MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminar Cliente")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_cliente As Integer = DataGridCliente.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarCliente(id_cliente, "0")
                        AccesoDatos.cargarClientes(DataGridCliente)
                        MsgBox("El cliente se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el cliente no se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        If DataGridCliente.CurrentRow Is Nothing Then
            MsgBox("Seleccione un cliente para dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridCliente.CurrentRow.Index
            If DataGridCliente.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
                respuesta = MsgBox("¿Esta seguro que desea Dar de Alta al cliente " + TBNombre.Text + " " + TBApellido.Text + "??",
                               MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Cliente")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_cliente As Integer = DataGridCliente.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarCliente(id_cliente, "1")
                        AccesoDatos.cargarClientes(DataGridCliente)
                        MsgBox("El cliente se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el cliente no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
                    End Try
                End If
            Else
                MsgBox("El cliente ya esta dado de Alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta Invalida")
            End If
        End If
    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        'le paso lo qe se escribe, el numero del combobox buscar seleccionado y el datagrid
        AccesoDatos.buscarCliente(sender.text, CBBuscar.SelectedIndex, DataGridCliente)
    End Sub

    Private Sub BAgregarFactura_Click(sender As Object, e As EventArgs) Handles BAgregarFactura.Click
        If DataGridCliente.CurrentRow Is Nothing Then
            MsgBox("Seleccione un cliente para agregar a la factura", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim fila As Integer = DataGridCliente.CurrentRow.Index
            If DataGridCliente.Item(5, fila).Value = 0 Then
                MsgBox("El cliente seleccionado no puede agregarse a la factura porque ha sido dado de baja. Contactese con el Administrador", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
            Else
                FormularioFactura.TCliente.Text = TBApellido.Text + " " + TBNombre.Text
                FormularioFactura.TDNI.Text = TBDNI.Text
                FormularioFactura.TDomicilio.Text = TBDomicilio.Text
                FormularioFactura.TTelefono.Text = TBTelefono.Text
                'Le paso el id_cliente
                FormularioFactura.LCliente.Tag = DataGridCliente.Item(0, fila).Value
                'Le aviso el tipo de rol
                FormularioFactura.Tag = Me.Tag
                FormularioFactura.LApeyNom.Tag = LApeyNom.Tag
                FormularioFactura.Show()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub DataGridCliente_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridCliente.RowStateChanged
        For Each Row As DataGridViewRow In DataGridCliente.Rows
            If Row.Cells(5).Value = "0" Then
                Row.DefaultCellStyle.BackColor = Color.Gray
            End If
        Next
    End Sub

End Class