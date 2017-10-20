Imports System.Text.RegularExpressions
Imports System.IO

Public Class FormularioSuperUsuario
    Private Sub FormularioSuperUsuario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        redirigirMenu(Me.Tag)
    End Sub

    Dim DNIvalidate As Boolean
    Dim Emailvalidate As Boolean

    Private Sub limpiar()
        TApellido.Clear()
        TNombre.Clear()
        TDNI.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
        TUsuario.Clear()
        TContrasena.Clear()
        CBSexo.SelectedIndex = 0
        RRolVendedor.Checked = False
        RRolAdmin.Checked = False
        RRolSuper.Checked = False
        FechaIngreso.Value = Now
        PBImagen.ImageLocation = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources\usuario.jpg"
    End Sub

    Private Sub habilitar()
        TApellido.ReadOnly = False
        TNombre.ReadOnly = False
        TDNI.ReadOnly = False
        TDomicilio.ReadOnly = False
        TTelefono.ReadOnly = False
        TEmail.ReadOnly = False
        TUsuario.ReadOnly = False
        TContrasena.ReadOnly = False
        RRolVendedor.Enabled = True
        RRolAdmin.Enabled = True
        RRolSuper.Enabled = True
    End Sub

    Private Sub deshabilitar()
        TApellido.ReadOnly = True
        TNombre.ReadOnly = True
        TDNI.ReadOnly = True
        TDomicilio.ReadOnly = True
        TTelefono.ReadOnly = True
        TEmail.ReadOnly = True
        TUsuario.ReadOnly = True
        TContrasena.ReadOnly=true
        RRolVendedor.Enabled = False
        RRolAdmin.Enabled = False
        RRolSuper.Enabled = False
    End Sub

    Private Sub bloquear()
        TBuscar.Enabled = False
        CBBuscar.Enabled = False
        DataGridUsuario.Enabled = False
        'esta loco funciona alrevez nose xq
        CBSexo.Enabled = True
    End Sub

    Private Sub desbloquear()
        TBuscar.Enabled = True
        CBBuscar.Enabled = True
        DataGridUsuario.Enabled = True
        'esta loco funciona alrevez nose xq
        CBSexo.Enabled = False
    End Sub

    Private Sub cargarRol(rol As String)
        If rol = "Vendedor" Then
            RRolVendedor.Checked = True
        ElseIf rol = "Administrador" Then
            RRolAdmin.Checked = True
        Else
            RRolSuper.Checked = True
        End If
    End Sub

    Private Sub cargarDetalle(usuario As usuarios, persona As personas)
        TApellido.Text = persona.apellidos
        TNombre.Text = persona.nombres
        TDNI.Text = persona.dni
        TDomicilio.Text = persona.domicilio
        TTelefono.Text = persona.telefono
        TEmail.Text = persona.email
        If persona.sexo = "M" Then
            CBSexo.SelectedIndex = 1
        ElseIf persona.sexo = "F" Then
            CBSexo.SelectedIndex = 2
        Else
            CBSexo.SelectedIndex = 3
        End If
        TUsuario.Text = usuario.usuario
        TContrasena.Text = usuario.contrasena
        FechaIngreso.Value = usuario.fechaingreso

        If persona.imagen Is Nothing Then
            PBImagen.Image = Image.FromFile("D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources\sin-imagen.png")
        Else
            PBImagen.ImageLocation = persona.imagen
            PBImagen.Image = Image.FromFile(persona.imagen)
        End If
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub cargarUsuarios()
        AccesoDatos.cargarUsuarios(DataGridUsuario)
        DataGridUsuario.ClearSelection()

        TApellido.Clear()
        TNombre.Clear()
        TDNI.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
        CBSexo.SelectedIndex = 0
        TUsuario.Clear()
        TContrasena.Clear()
        RRolVendedor.Checked = False
        RRolAdmin.Checked = False
        RRolSuper.Checked = False
        CBBuscar.SelectedIndex = 0
        PBImagen.ImageLocation = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources\usuario.jpg"
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub FormularioSuperUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
#Region "bloquear movimiento del form"
            CenterToScreen()
            Xpos = Location.X
            Ypos = Location.Y
#End Region
            cargarUsuarios()
            BEliminar.Visible = False
            'La leyenda de abajo
            LRol.Text = Me.Tag + ": " + LApeyNom.Tag
            BGenerarUsuario.Tag = "False"
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, la lista de usuarios no se pudo cargar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Error al cargar Datagrid")
        End Try
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridUsuario.CurrentRow Is Nothing Then
            MsgBox("Seleccione un usuario para poder editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Edicion Invalida")
        ElseIf DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el usuario esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        Else
            BCambiarImagen.Visible = True
            BNuevo.Visible = False
            BEditar.Visible = False
            BEliminar.Visible = False
            BCancelar.Visible = True
            BGuardar.Visible = True
            bloquear()
            habilitar()
            TDni_Validated(sender, e)
            TEmail_Validated(sender, e)
            'no le permito que cambie su rol
            RRolVendedor.Enabled = False
            RRolAdmin.Enabled = False
            RRolSuper.Enabled = False
            TUsuario.ReadOnly = True
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TDNI.Text = "" Or TDomicilio.Text = "" Or TEmail.Text = "" Or
            TUsuario.Text = "" Then
            MsgBox("Debe completar los campos obligatorios!", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Registro Incompleto")
        ElseIf DNIvalidate = False Then
            MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
        ElseIf Emailvalidate = False Then
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        ElseIf CBSexo.SelectedIndex = 0 Then
            MsgBox("Seleccione un tipo de Sexo", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Sexo invalido")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridUsuario.CurrentRow.Index
            respuesta = MsgBox("¿Esta seguro que desea guardar los cambios realizados??",
                       MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Usuario")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    Dim id_usuario As Integer = DataGridUsuario.CurrentRow().Cells(0).Value
                    Dim sexo As Char = determinarSexo()
                    Dim rol As String = determinarRol()
                    AccesoDatos.ActualizarUsuario(id_usuario, TNombre.Text, TApellido.Text, TDNI.Text,
                                     TDomicilio.Text, TTelefono.Text, TEmail.Text, rol,
                                                  sexo, TUsuario.Text, TContrasena.Text, PBImagen.ImageLocation)
                    AccesoDatos.cargarUsuarios(DataGridUsuario)
                    MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                                   MsgBoxStyle.Information, "Modificacion exitosa")
                Catch ex As Exception
                    MsgBox("Lo sentimos ha ocurrido un evento inesperado, el usuario no pudo ser registrado",
                      MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Error al registrar")
                Finally
                    BCambiarImagen.Visible = False
                    BNuevo.Visible = True
                    BCancelar.Visible = False
                    BGuardar.Visible = False
                    BEditar.Visible = True
                    BEliminar.Visible = True
                    desbloquear()
                    deshabilitar()
                End Try
            End If
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
        BNuevo.Visible = True
        BCambiarImagen.Visible = False
        BCancelar.Visible = False
        BAgregar.Visible = False
        BGuardar.Visible = False
        BEditar.Visible = True
        BEliminar.Visible = True

        PBOk.Visible = False
        BGenerarUsuario.Visible = False
        TUsuario.Visible = True
        TContrasena.Visible = True
        LUsuario.Visible = True
        LContrasena.Visible = True

        desbloquear()
        deshabilitar()
        limpiar()
    End Sub

    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TDni_Validated(sender As Object, e As EventArgs) Handles TDNI.Validated
        If TDNI.Text <> "" Then
            If Long.Parse(TDNI.Text) < 3000000 Or Long.Parse(TDNI.Text) > 99999999 Then
                MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
                DNIvalidate = False
            Else
                DNIvalidate = True
            End If
        End If
    End Sub
    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub
    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        Dim re As New Regex("[^a-zA-Z_ \b]", RegexOptions.IgnoreCase)
        e.Handled = re.IsMatch(e.KeyChar)
    End Sub

    Private Sub DataGridUsuario_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuario.CellEnter
        Dim fila As Integer = DataGridUsuario.CurrentRow.Index
        Dim id_usuario As Integer = DataGridUsuario.Item(0, fila).Value
        Dim usuario As usuarios = AccesoDatos.capturarUsuario(id_usuario)
        Dim persona As personas = AccesoDatos.capturarPersona(usuario.persona_id)
        habilitar()
        cargarRol(DataGridUsuario.Item(4, fila).Value)
        cargarDetalle(usuario, persona)
        deshabilitar()

        If DataGridUsuario.Item(5, fila).Value = 0 Then
            BAlta.Visible = True
            BEliminar.Visible = False
        Else
            BAlta.Visible = False
            BEliminar.Visible = True
        End If

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If DataGridUsuario.CurrentRow Is Nothing Then
            MsgBox("Seleccione un usuario para eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridUsuario.CurrentRow.Index
            'Pregunta si el fondo es gris o si el estado es 0
            If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Or DataGridUsuario.CurrentRow().Cells(5).Value = 0 Then
                MsgBox("El usuario ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminacion invalida")
            Else
                respuesta = MsgBox("¿Esta seguro que desea Eliminar al usuario " + TNombre.Text + " " + TApellido.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminar Usuario")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_usuario As Integer = DataGridUsuario.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarUsuario(id_usuario, "0")
                        AccesoDatos.cargarUsuarios(DataGridUsuario)
                        MsgBox("El usuario se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el usuario no se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        If DataGridUsuario.CurrentRow Is Nothing Then
            MsgBox("Seleccione un usuario para dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            Dim respuesta As MsgBoxResult
            Dim fila As Integer = DataGridUsuario.CurrentRow.Index
            If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
                respuesta = MsgBox("¿Esta seguro que desea Dar de Alta al usuario " + TNombre.Text + " " + TApellido.Text + "??",
                               MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Usuario")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim id_usuario As Integer = DataGridUsuario.CurrentRow().Cells(0).Value
                        AccesoDatos.EliminarUsuario(id_usuario, "1")
                        AccesoDatos.cargarUsuarios(DataGridUsuario)
                        MsgBox("El usuario se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un problema, el usuario no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
                    End Try
                End If
            Else
                MsgBox("El usuario ya esta dado de Alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta Invalida")
            End If
        End If
    End Sub

    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        'le paso lo qe se escribe, el numero del combobox buscar seleccionado y el datagrid
        AccesoDatos.buscarUsuario(sender.text, CBBuscar.SelectedIndex, DataGridUsuario)
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        limpiar()
        BGenerarUsuario.Visible = True
        TUsuario.Visible = False
        TContrasena.Visible = False
        LUsuario.Visible = False
        LContrasena.Visible = False

        Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\usuario.jpg"
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage
        bloquear()
        habilitar()
        BGenerarUsuario.Tag = "False" 'inicializo la variable

        BCambiarImagen.Visible = True
        BAgregar.Visible = True
        BCancelar.Visible = True
        BEditar.Visible = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        PBImagen.Image = Nothing
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim respuesta As MsgBoxResult
        If TNombre.Text = "" Or TApellido.Text = "" Or TDNI.Text = "" Or TDomicilio.Text = "" Or TEmail.Text = "" Or
            LUsuario.Tag = "False" Then
            MsgBox("Debe completar los campos obligatorios!", MsgBoxStyle.DefaultButton2 +
        MsgBoxStyle.Critical, "Registro Incompleto")
        ElseIf DNIvalidate = False Then
            MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "DNI invalido")
        ElseIf Emailvalidate = False Then
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        ElseIf CBSexo.SelectedIndex = 0 Then
            MsgBox("Seleccione un tipo de Sexo", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Sexo invalido")
        ElseIf LUsuario.Text = "False" Then
            MsgBox("Seleccione el boton 'Generar Usuario' para que se le puedo otorgar un usuario y contraseña", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Usuario no generado")
        Else
            If AccesoDatos.existePersona(TDNI.Text) Then
                MsgBox("Ya existe un Usuario registrado con el DNI '" + TDNI.Text + "'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "DNI en uso")
            ElseIf AccesoDatos.existeEmailPersona(TEmail.Text) Then
                MsgBox("Ya existe un Usuario registrado con el Email '" + TEmail.Text + "'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "Email en uso")
            ElseIf BGenerarUsuario.Tag <> "True" Then
                MsgBox("Debe generar un usuario y contraseña antes de continuar, haga click en el boton 'Generar Usuario'", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "Generar Usuario")
            Else
                If PBImagen.ImageLocation = Nothing Or PBImagen.ImageLocation = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources\usuario.jpg" Then
                    MsgBox("El usuario se va a registrar sin ninguna imagen", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Imagen no detectada")
                End If
                respuesta = MsgBox("¿Esta seguro que desea agregar al usuario??",
                                               MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Agregar Usuario")
                If MsgBoxResult.Yes = respuesta Then
                    Try
                        Dim rol As Integer = determinarRol()
                        Dim sexo As Char = determinarSexo()
                        Dim ultimo_id_persona As Integer
                        ultimo_id_persona = AccesoDatos.AgregarPersona(New personas() With {
                                                       .nombres = TNombre.Text,
                                                       .apellidos = TApellido.Text,
                                                       .email = TEmail.Text,
                                                       .domicilio = TDomicilio.Text,
                                                       .dni = TDNI.Text,
                                                       .imagen = PBImagen.ImageLocation,
                                                       .rol_id = rol,
                                                       .telefono = TTelefono.Text,
                                                       .sexo = sexo
                                                       })
                        AccesoDatos.AgregarUsuario(New usuarios() With {
                                                       .usuario = TUsuario.Tag,
                                                       .contrasena = TContrasena.Tag,
                                                       .persona_id = ultimo_id_persona,
                                                       .estado = 1,
                                                       .fechaingreso = FechaIngreso.Value
                                                       })

                        cargarUsuarios()
                        MsgBox("El Usuario se ha registrado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Registro Exitoso")
                        'Catch ex As Exception
                        '   MsgBox("Lo sentimos ha ocurrido un evento inesperado, el usuario no pudo ser registrado",
                        '  MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Error al registrar")
                    Finally
                        BCancelar.Visible = False
                        BAgregar.Visible = False
                        BCambiarImagen.Visible = False
                        BNuevo.Visible = True

                        BGuardar.Visible = False
                        BEditar.Visible = True
                        BEliminar.Visible = True
                        limpiar()
                        desbloquear()
                        deshabilitar()

                        PBOk.Visible = False
                        BGenerarUsuario.Visible = False
                        TUsuario.Visible = True
                        TContrasena.Visible = True
                        LUsuario.Visible = True
                        LContrasena.Visible = True
                    End Try
            End If
        End If
        End If
    End Sub

    Private Function determinarRol() As Integer
        Dim rol As Integer
        If RRolSuper.Checked = True Then
            rol = 3
        ElseIf RRolAdmin.Checked = True Then
            rol = 2
        Else
            rol = 1
        End If
        Return rol
    End Function

    Private Function determinarSexo() As Char
        Dim sexo As Char
        If CBSexo.SelectedIndex = 1 Then
            sexo = "M"
        ElseIf CBSexo.SelectedIndex = 2 Then
            sexo = "F"
        Else sexo = "O"
        End If
        Return sexo
    End Function

    Private Sub TEmail_Validated(sender As Object, e As EventArgs) Handles TEmail.Validated
        If ValidarEmail(TEmail.Text) = False Then
            Emailvalidate = False
            MsgBox("Ingrese un Email valido", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Email invalido")
        Else
            Emailvalidate = True
        End If
    End Sub

    Private Sub DataGridUsuario_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridUsuario.RowStateChanged
        For Each Row As DataGridViewRow In DataGridUsuario.Rows
            If Row.Cells(5).Value = "0" Then
                Row.DefaultCellStyle.BackColor = Color.Gray
            End If
        Next
    End Sub

    Private Sub BCambiarImagen_Click(sender As Object, e As EventArgs) Handles BCambiarImagen.Click
        OpenFileDialog1.InitialDirectory = "D:\Usuarios\Alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\pcgamer\Resources"
        OpenFileDialog1.Filter = "Todos los archivos|*.*|Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PBImagen.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BGenerarUsuario_Click(sender As Object, e As EventArgs) Handles BGenerarUsuario.Click, PBOk.Click
        If RRolSuper.Checked = False And RRolAdmin.Checked = False And RRolVendedor.Checked = False Then
            MsgBox("Debe asignar primero un rol al usuario", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Critical, "Rol no detectado")
        Else
            Dim rol As Integer = determinarRol()
            FormularioGenerarUsuario.Tag = rol
            Me.Opacity = 0.6
            FormularioGenerarUsuario.ShowDialog()
            BGenerarUsuario.Tag = "True"
            PBOk.Visible = True
            BGenerarUsuario.Visible = False
            RRolVendedor.Enabled = False
            RRolAdmin.Enabled = False
            RRolSuper.Enabled = False
            Me.Opacity = 1
        End If
    End Sub


    Private Sub TContrasena_MouseHover(sender As Object, e As EventArgs) Handles TContrasena.MouseHover
        TContrasena.UseSystemPasswordChar = False
    End Sub
    Private Sub TContrasena_MouseLeave(sender As Object, e As EventArgs) Handles TContrasena.MouseLeave
        TContrasena.UseSystemPasswordChar = True
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioSuperUsuario_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region
End Class