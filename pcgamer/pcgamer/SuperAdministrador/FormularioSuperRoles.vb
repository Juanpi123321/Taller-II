Public Class FormularioSuperRoles
    Private Sub FormularioSuperRoles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        redirigirMenu(Me.Tag)
    End Sub

    Private Sub defectoSuper()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True

        CheckBox16.Checked = True
        CheckBox15.Checked = True
        CheckBox14.Checked = True
        CheckBox13.Checked = True

        CheckBox28.Checked = True
        CheckBox27.Checked = True
        CheckBox26.Checked = True
        CheckBox25.Checked = True

        CheckBox37.Checked = True

        CheckBox40.Checked = True
    End Sub

    Private Sub defectoAdmin()
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        CheckBox20.Checked = True
        CheckBox19.Checked = True
        CheckBox18.Checked = True
        CheckBox17.Checked = True

        CheckBox32.Checked = True
        CheckBox31.Checked = True
        CheckBox30.Checked = True
        CheckBox29.Checked = True

        CheckBox38.Checked = False

        CheckBox42.Checked = True
    End Sub

    Private Sub defectoVendedor()
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False

        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = True

        CheckBox36.Checked = True
        CheckBox35.Checked = False
        CheckBox34.Checked = True
        CheckBox33.Checked = True

        CheckBox39.Checked = False

        CheckBox43.Checked = False
    End Sub

    Private Sub FormularioSuperRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckBox4.Width = 60
#Region "bloquear movimiento del form"
        CenterToScreen()
        Xpos = Location.X
        Ypos = Location.Y
#End Region
        'La leyenda de abajo
        LRol.Text = Me.Tag + ": " + LApeyNom.Tag
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Operacion Cancelada")
        Me.Close()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea guardar los cambios realizados??",
                           MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Gestion de Roles")
        If MsgBoxResult.Yes = respuesta Then
            MsgBox("Se ha modificado correctamente", MsgBoxStyle.DefaultButton2 +
                           MsgBoxStyle.Information, "Modificacion exitosa")
        Else
            MsgBox("No se han realizado cambios", MsgBoxStyle.DefaultButton2 +
                       MsgBoxStyle.Information, "Operacion Cancelada")
        End If
        Me.Close()
    End Sub

    Private Sub BDefecto_Click(sender As Object, e As EventArgs) Handles BDefecto.Click
        defectoSuper()
        defectoAdmin()
        defectoVendedor()
    End Sub

#Region "bloquear movimiento del form"
    Private Xpos, Ypos
    Private Sub FormularioSuperRoles_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Xpos > 0 Then
            Location = New Point(Xpos, Ypos)
        End If
    End Sub
#End Region
End Class