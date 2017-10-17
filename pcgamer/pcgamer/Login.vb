Public Class Login

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            MsgBox("Debe completar todos los campos!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
        ElseIf AccesoDatos.validarIngreso(LCase(TUsuario.Text), LCase(TContrasena.Text)) Then
            If BIngresar.Tag = "baja" Then 'significa que el estado de ese usuario es 0
                MsgBox("Lo lamento el usuario ha sido dado de baja, contactese con el SuperAdministrador", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Critical, "Acceso No Autorizado")
            Else
                MsgBox("Bienvenido a Pc-Gamer", MsgBoxStyle.Information, "Acceso Autorizado")
                If Me.Tag = "SuperAdministrador" Then
                    'Le aviso el tipo de rol
                    FormularioSuperAdmin.Tag = Me.Tag
                    FormularioSuperAdmin.LApeyNom.Tag = LUsuario.Tag
                    FormularioSuperAdmin.Show()
                ElseIf Me.Tag = "Administrador" Then
                    'Le aviso el tipo de rol
                    FormularioAdministrador.Tag = Me.Tag
                    FormularioAdministrador.LApeyNom.Tag = LUsuario.Tag
                    FormularioAdministrador.Show()
                ElseIf Me.Tag = "Vendedor" Then
                    'Le aviso el tipo de rol
                    FormularioVendedor.Tag = Me.Tag
                    FormularioVendedor.LApeyNom.Tag = LUsuario.Tag
                    'le paso el id usuario para cuando genere la factura no tenga qe buscar
                    FormularioVendedor.LTitulo.Tag = LTitulo.Tag
                    FormularioVendedor.Show()
                End If
                Me.Close()
            End If
        Else
            MsgBox("Nombre de usuario y/o contraseña invalidos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
            TUsuario.Text = ""
            TContrasena.Text = ""
        End If
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub Login_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        Me.AcceptButton = BIngresar
    End Sub
#End Region
End Class
