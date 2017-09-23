Imports System.Text.RegularExpressions

Public Class FormularioSuperUsuario
    Private Sub FormularioSuperUsuario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormularioSuperAdmin.Show()
    End Sub

    Dim DNIvalidate As Boolean = True
    Dim Emailvalidate As Boolean

    Private Sub habilitar()
        TApellido.ReadOnly = False
        TNombre.ReadOnly = False
        TDNI.ReadOnly = False
        TDomicilio.ReadOnly = False
        TTelefono.ReadOnly = False
        TEmail.ReadOnly = False
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
        RRolVendedor.Enabled = False
        RRolAdmin.Enabled = False
        RRolSuper.Enabled = False
    End Sub

    Private Sub FechaReg_ValueChanged(sender As Object, e As EventArgs) Handles FechaReg.ValueChanged
        FechaReg.Value = Now
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        TNombre.Clear()
        TApellido.Clear()
        TDNI.Clear()
        TDomicilio.Clear()
        TTelefono.Clear()
        TEmail.Clear()
        RRolVendedor.Checked = True
        RRolAdmin.Checked = False
        RRolSuper.Checked = False
    End Sub

    Private Sub FormularioSuperUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridUsuario.Rows.Add("0001", "Gallardo", "Marcelo", "25332121", "Administrador", "21/09/2017 10:09")
        DataGridUsuario.Rows.Add("0002", "Trump", "Donald", "10123341", "Vendedor", "21/09/2017 17:41")
        DataGridUsuario.Rows.Add("0003", "Martinez", "Pity", "40112858", "Vendedor", "22/09/2017 11:01")
        DataGridUsuario.Rows.Add("0004", "Tinelli", "Marcelo", "15020491", "Vendedor", "23/09/2017 09:33")
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim fila As Integer = DataGridUsuario.CurrentRow.Index
        If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("No es posible editar, el usuario esta dado de baja", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Operacion invalida")
        ElseIf DataGridUsuario.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un usuario para editar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            BEditar.Visible = False
            BEliminar.Visible = False
            BCancelar.Visible = True
            BGuardar.Visible = True
            habilitar()
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TDNI.Text = "" Then
            MsgBox("Debe ingresar un nro de DNI para poder continuar ", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Critical, "Operacion Invalida")
        Else
            Dim dni As Long = Long.Parse(TDNI.Text)
            Dim fila As Integer = DataGridUsuario.CurrentRow.Index
            Dim rol As String = DataGridUsuario.Item(4, fila).Value
            If ValidarDNI(dni) Then
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Esta seguro que desea guardar los cambios realizados??",
                                   MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Editar Usuario")
                If MsgBoxResult.Yes = respuesta Then
                    DataGridUsuario.Item(1, fila).Value = TApellido.Text
                    DataGridUsuario.Item(2, fila).Value = TNombre.Text
                    DataGridUsuario.Item(3, fila).Value = TDNI.Text
                    If RRolVendedor.Checked = True Then
                        rol = "Vendedor"
                    ElseIf RRolAdmin.Checked = True Then
                        rol = "Administrador"
                    Else
                        rol = "Super Administrador"
                    End If
                    DataGridUsuario.Item(4, fila).Value = rol
                    MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                                   MsgBoxStyle.Information, "Modificacion exitosa")
                End If

                BEditar.Visible = True
                BEliminar.Visible = True
                BCancelar.Visible = False
                BGuardar.Visible = False
                deshabilitar()
            Else
                MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "DNI invalido")
                DNIvalidate = False
            End If
        End If

    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        BEditar.Visible = True
        BEliminar.Visible = True
        BCancelar.Visible = False
        BGuardar.Visible = False
        deshabilitar()
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
    End Sub



    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDNI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TDni_Validated(sender As Object, e As EventArgs) Handles TDNI.Validated
        Dim dni As Long
        If TDNI.Text <> "" Then
            dni = TDNI.Text
            If Not ValidarDNI(dni) Then
                MsgBox("Ingrese un DNI valido", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "DNI invalido")
            End If
        Else
            MsgBox("Ingrese un nro de DNI para poder continuar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "DNI invalido")
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
        TApellido.Text = DataGridUsuario.Item(1, fila).Value
        TNombre.Text = DataGridUsuario.Item(2, fila).Value
        TDNI.Text = DataGridUsuario.Item(3, fila).Value
        Dim rol As String = DataGridUsuario.Item(4, fila).Value
        If rol = "Vendedor" Then
            RRolVendedor.Checked = True
        ElseIf rol = "Administrador" Then
            RRolAdmin.Checked = True
        Else
            RRolSuper.Checked = True
        End If

        Dim domicilio As String = "-"
        Dim telefono As String = "-"
        Dim email As String = "-"
        Dim imagen As String = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\usuario.jpg"
        Select Case fila
            Case 0
                domicilio = "B° Nuñez Buenos Aires"
                telefono = "01199850312"
                email = "marcelitogallardo@hotmail.com"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\marcelo-gallardo.jpg"

            Case 1
                domicilio = "Queens - New York (USA)"
                telefono = "-"
                email = "donald-trump@outlook.com"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\donald-trump.jpg"
            Case 2
                domicilio = "Guaymallén Mendonza"
                telefono = "3782123461"
                email = "pitymartinez@gmail.com"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\pity.jpg"
            Case 3
                domicilio = "Bolivar Buenos Aires"
                telefono = "0112212388"
                email = "cuervotinelli@hotmail.com"
                imagen = "D:\Usuarios\Alumno\Imágenes\imagenes de donde subo\usuarios\marcelo-tinelli.jpg"
        End Select
        TDomicilio.Text = domicilio
        TTelefono.Text = telefono
        TEmail.Text = email
        PBImagen.Image = Image.FromFile(imagen)
        Me.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage

        If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            BAlta.Visible = True
            BEliminar.Visible = False
        Else
            BAlta.Visible = False
            BEliminar.Visible = True
        End If

        If BCancelar.Visible = True Or BGuardar.Visible = True Then
            MsgBox("Debe finalizar la edicion antes de continuar", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Exclamation, "Edicion Usuario")
            BEditar.Visible = True
            BEliminar.Visible = True
            BCancelar.Visible = False
            BGuardar.Visible = False
            deshabilitar()
        End If
    End Sub


    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridUsuario.CurrentRow.Index
        If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            MsgBox("El usuario ya esta dado de baja", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminacion invalida")
        ElseIf DataGridUsuario.Item(1, fila).Value = "" Then
            MsgBox("Seleccione un usuario para eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Operacion Invalida")
        Else
            respuesta = MsgBox("¿Esta seguro que desea Eliminar al usuario " + TNombre.Text + " " + TApellido.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Eliminar Usuario")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray
                    MsgBox("El usuario se ha eliminado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminacion exitosa")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un problema, el usuario no se pudo eliminar", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Fallo al Eliminar")
                End Try
            End If
        End If
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        Dim respuesta As MsgBoxResult
        Dim fila As Integer = DataGridUsuario.CurrentRow.Index
        If DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.Gray Then
            respuesta = MsgBox("¿Esta seguro que desea Dar de Alta al usuario " + TNombre.Text + " " + TApellido.Text + "??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Alta Usuario")
            If MsgBoxResult.Yes = respuesta Then
                Try
                    DataGridUsuario.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    MsgBox("El usuario se ha dado de alta correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta exitosa")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un problema, el usuario no se pudo dar de alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Alta invalida")
                End Try
            End If
        Else
            MsgBox("El usuario ya esta dado de Alta", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Alta Invalida")
        End If
    End Sub

End Class