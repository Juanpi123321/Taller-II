Public Class Login

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TUsuario.Text = "" Or TContrasena.Text = "" Then
            MsgBox("Debe completar todos los campos!", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
        ElseIf TUsuario.Text = "superadmin" Then
            'Le aviso el tipo de rol
            FormularioSuperAdmin.Tag = "SuperAdministrador"
            FormularioSuperAdmin.Show()
            Me.Close()
        ElseIf TUsuario.Text = "admin" Then
            'Le aviso el tipo de rol
            FormularioAdministrador.Tag = "Administrador"
            FormularioAdministrador.Show()
            Me.Close()
        ElseIf TUsuario.Text = "vendedor" Then
            'Le aviso el tipo de rol
            FormularioVendedor.Tag = "Vendedor"
            FormularioVendedor.Show()
            Me.Close()
        Else
            MsgBox("Nombre de usuario invalido", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Login Invalido")
            TUsuario.Text = ""
            TContrasena.Text = ""
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AcceptButton = BIngresar
    End Sub

End Class
