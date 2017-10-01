
Public Class FormularioSuperAdmin

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Abandonar la Sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar Sesion")
        If MsgBoxResult.Yes = respuesta Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
    End Sub

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        FormularioSuperUsuario.Show()
        Me.Hide()
    End Sub

    'Verifica la autenticidad del superadministrador, en caso de que deje abierto o de alguna manera alguna persona extraña acceda al sistema y desee otorgarse permisos
    Private Sub verificarAcceso()
        Me.Opacity = 0.6
        Dim fuente As New System.Drawing.Font("Verdana", 10)
        Dim dialog As New Form With {
            .FormBorderStyle = FormBorderStyle.None,
            .Location = New Point(520, 210),
            .BackColor = Color.White,
            .StartPosition = FormStartPosition.Manual
            }
        Dim LTitulo As New Label() With {
            .Text = "ACCESO RESTRINGIDO",
            .Left = 20,
            .Top = 20,
            .Size = New Size(280, 40),
            .Font = New System.Drawing.Font("Verdana", 12, FontStyle.Bold)
        }
        Dim LLeyenda As New Label() With {
            .Text = "Ingrese Usuario y Contraseña",
            .Left = 20,
            .Top = 80,
            .Size = New Size(280, 40),
            .Font = fuente
        }
        Dim BCerrar As New Button With {
            .Text = "Cerrar",
            .Left = 30,
            .Top = 250,
            .Font = fuente,
            .Size = New Size(120, 30),
            .TabIndex = 3
            }
        Dim BIngresar As New Button With {
            .Text = "Ingresar",
            .Left = 160,
            .Top = 250,
            .Font = fuente,
            .Size = New Size(120, 30),
            .TabIndex = 4
            }
        Dim TUsuario As New TextBox With {
            .Left = 30,
            .Top = 130,
            .Size = New Size(250, 30),
            .Font = fuente,
            .TabIndex = 0
            }
        Dim TContrasena As New TextBox With {
            .Left = 30,
            .Top = 170,
            .Size = New Size(250, 30),
            .Font = fuente,
            .PasswordChar = "*"c,
            .TabIndex = 1
            }

        AddHandler BCerrar.Click, Sub(sender, args)
                                      dialog.Close()
                                  End Sub
        AddHandler BIngresar.Click, Sub(sender, args)
                                        If TUsuario.Text = "superadmin" And TContrasena.Text <> "" Then
                                            MsgBox("Maneje con cautela los permisos otorgados a los usuarios", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Acceso Autorizado")
                                            FormularioSuperRoles.Show()
                                            Me.Hide()
                                        Else
                                            MsgBox("Usuario y/o contraseña incorrecto", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Acceso Denegado")
                                        End If
                                        dialog.Close()
                                    End Sub

        dialog.Controls.Add(LTitulo)
        dialog.Controls.Add(LLeyenda)
        dialog.Controls.Add(BCerrar)
        dialog.Controls.Add(BIngresar)
        dialog.Controls.Add(TUsuario)
        dialog.Controls.Add(TContrasena)
        dialog.ShowDialog()
        Me.Opacity = 1
    End Sub

    Private Sub BRoles_Click(sender As Object, e As EventArgs) Handles BRoles.Click
        'MsgBox("Disponible para la segunda entrega, disculpe las molestias", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "No disponible")
        verificarAcceso()
    End Sub

End Class