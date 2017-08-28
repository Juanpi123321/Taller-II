Public Class Formulario4

    Private Sub BGenerar_Click(sender As Object, e As EventArgs) Handles BGenerar.Click
        If (TDesde.Text >= THasta.Text) Or (TDesde.Text = "") Or (THasta.Text = "") Then
            MsgBox("Debe ingresar un numero menor y luego un numero mayor")
        Else
            LBFuncion.Items.Clear()
            Dim desde As Integer
            Dim hasta As Integer
            desde = Val(TDesde.Text)
            hasta = Val(THasta.Text)
            While (desde <= hasta)
                LBFuncion.Items.Add(desde)
                desde = desde + 1
            End While
        End If
    End Sub

    Private Sub TDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDesde.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(TDesde, "solo numeros")
        End If
    End Sub

    Private Sub THasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THasta.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(THasta, "solo numeros")
        End If
    End Sub

    Private Sub BPares_Click(sender As Object, e As EventArgs) Handles BPares.Click
        If (TDesde.Text >= THasta.Text) Or (TDesde.Text = "") Or (THasta.Text = "") Then
            MsgBox("Debe ingresar un numero menor y luego un numero mayor")
        Else
            LBFuncion.Items.Clear()
            Dim desde As Integer
            Dim hasta As Integer
            desde = Val(TDesde.Text)
            hasta = Val(THasta.Text)
            While (desde <= hasta)
                If (desde Mod 2 = 0) Then
                    LBFuncion.Items.Add(desde)
                End If
                desde = desde + 1
            End While
        End If
    End Sub

    Private Sub BImpares_Click(sender As Object, e As EventArgs) Handles BImpares.Click
        If (TDesde.Text >= THasta.Text) Or (TDesde.Text = "") Or (THasta.Text = "") Then
            MsgBox("Debe ingresar un numero menor y luego un numero mayor")
        Else
            LBFuncion.Items.Clear()
            Dim desde As Integer
            Dim hasta As Integer
            desde = Val(TDesde.Text)
            hasta = Val(THasta.Text)
            While (desde <= hasta)
                If (desde Mod 2 = 1) Then
                    LBFuncion.Items.Add(desde)
                End If
                desde = desde + 1
            End While
        End If
    End Sub

    Private Sub BPrimos_Click(sender As Object, e As EventArgs) Handles BPrimos.Click
        If (TDesde.Text >= THasta.Text) Or (TDesde.Text = "") Or (THasta.Text = "") Then
            MsgBox("Debe ingresar un numero menor y luego un numero mayor")
        Else
            LBFuncion.Items.Clear()
            Dim desde As Integer
            Dim hasta As Integer
            desde = Val(TDesde.Text)
            hasta = Val(THasta.Text)
            Dim bandera As Boolean
            Dim n As Integer
            Dim i As Integer
            For n = desde To hasta
                bandera = True
                For i = 2 To Math.Sqrt(n)
                    If n Mod i = 0 Then
                        bandera = False
                        Exit For
                    End If
                Next
                If bandera Then
                    LBFuncion.Items.Add(n)
                End If
            Next
        End If



    End Sub
End Class