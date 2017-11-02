Imports System.Data.SqlClient
Public Class FormularioSuperAdmin

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        Me.Cursor = Cursors.WaitCursor
        'Le aviso el tipo de rol
        FormularioSuperUsuario.Tag = Me.Tag
        FormularioSuperUsuario.LApeyNom.Tag = LApeyNom.Tag
        FormularioSuperUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub BRoles_Click(sender As Object, e As EventArgs) Handles BRoles.Click
        verificarAcceso()
    End Sub

    Dim conexion As New SqlConnection("Data Source=JUANPINETBOOK20\SQLEXPRESS;Initial Catalog=pc_gamer;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework")
    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        'Verifica la autenticidad del superadministrador, en caso de que deje abierto o de alguna manera alguna persona extraña acceda al sistema
#Region "verificar acceso"
        verificarAcceso2()
#End Region
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
                                        If (LCase(TUsuario.Text) = "superadministrador1") And (TContrasena.Text) = "s123" Then
                                            MsgBox("Maneje con cautela los permisos otorgados a los usuarios", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Acceso Autorizado")
                                            'Le aviso el tipo de rol
                                            FormularioSuperRoles.Tag = Me.Tag
                                            FormularioSuperRoles.LApeyNom.Tag = LApeyNom.Tag
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
    Private Sub verificarAcceso2()
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
                                        If (LCase(TUsuario.Text) = "superadministrador1") And (TContrasena.Text) = "s123" Then
                                            Dim respuesta As MsgBoxResult
                                            respuesta = MsgBox("¿Esta seguro que desea realizar una Copia de Seguridad?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Realizar Backup")
                                            If MsgBoxResult.Yes = respuesta Then
                                                Dim nombre_copia As String = ("pcgamer_" & Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" &
                Date.Today.Year.ToString & "-" & Date.Now.Hour.ToString & "-" & Date.Now.Minute.ToString & "-" &
                Date.Now.Second.ToString)
                                                Dim comando_consulta As String = "BACKUP DATABASE [pc_gamer] TO  DISK = N'D:\usuarios\alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\Backup\" + nombre_copia + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'pc_gamer-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
                                                Dim cmd As SqlCommand = New SqlCommand(comando_consulta, conexion)
                                                Try
                                                    conexion.Open()
                                                    cmd.ExecuteNonQuery()
                                                    MsgBox("La copia de seguridad se ha generado correctamente", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Backup Exitoso")
                                                Catch ex As Exception
                                                    MsgBox("Ha ocurrido un error, no se pudo generar la copia de seguridad", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Backup Exitoso")
                                                Finally
                                                    conexion.Close()
                                                    conexion.Dispose()
                                                End Try
                                            End If
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

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea Abandonar la Sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Cerrar Sesion")
        If MsgBoxResult.Yes = respuesta Then
            Login.Show()
            Me.Close()
        End If
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioAdministrador_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub

    Private Sub FormularioAdministrador_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        'La leyenda de abajo
        LRol.Text = Me.Tag + ": " + LApeyNom.Tag
    End Sub

#End Region
    Private Sub FormularioSuperAdmin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Cursor = Cursors.Arrow
    End Sub
End Class