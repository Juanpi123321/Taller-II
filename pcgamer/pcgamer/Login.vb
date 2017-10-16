Public Class Login

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            MsgBox("Debe completar todos los campos!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
        Else
            If TUsuario.Text = "superadmin" Then
                'Le aviso el tipo de rol
                FormularioSuperAdmin.Tag = "SuperAdministrador"
                FormularioSuperAdmin.Show()
                Me.Close()
            ElseIf TUsuario.Text = "admin" Then
                'Le aviso el tipo de rol
                FormularioAdministrador.Tag = "Administrador"
                FormularioAdministrador.LApeyNom.Tag = TUsuario.Text
                FormularioAdministrador.Show()
                Me.Close()
            ElseIf TUsuario.Text = "vendedor" Then
                'Le aviso el tipo de rol
                FormularioVendedor.Tag = "Vendedor"
                FormularioVendedor.LApeyNom.Tag = TUsuario.Text
                FormularioVendedor.Show()
                Me.Close()
            Else
                MsgBox("Nombre de usuario invalido", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
                TUsuario.Text = ""
                TContrasena.Text = ""
            End If
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
