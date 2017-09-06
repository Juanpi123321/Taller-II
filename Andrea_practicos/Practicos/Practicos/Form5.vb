Imports System.Text.RegularExpressions
Public Class Form5

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else

            Dim cont As Integer = Val(TextBox1.Text)
            Do While cont <= Val(TextBox2.Text)
                ListBox1.Items.Add(cont)
                cont = cont + 1
            Loop
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim text As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = text.IsMatch(e.KeyChar)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim textos As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = textos.IsMatch(e.KeyChar)

    End Sub

    Private Sub BPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrueba.Click
        Dim min As Integer
        min = Val(TPrueba.Text)
        If (min Mod 2 = 0) Then

            TPrueba.Text = "Es par"
        Else
            TPrueba.Text = "Es impar"

        End If
    End Sub

    Private Sub BPares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPares.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else
            Dim par As Integer = Val(TextBox1.Text)
            Do While par <= Val(TextBox2.Text)
                If (par Mod 2 = 0) Then

                    ListBox1.Items.Add(par)
                End If
                par = par + 1
            Loop
        End If
    End Sub

    Private Sub BImpares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImpares.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else
            Dim impar As Integer = Val(TextBox1.Text)
            Do While impar <= Val(TextBox2.Text)
                If (impar Mod 2 <> 0) Then
                    ListBox1.Items.Add(impar)
                End If
                impar = impar + 1
            Loop
        End If
    End Sub

    Private Sub BPrimos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrimos.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then

            MsgBox("Debe completar todos los campos", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")

        Else

            Dim a As Integer = 0
            Dim n As Integer
            n = Val(TextBox1.Text)
            Do While n <= Val(TextBox2.Text)
                For i As Integer = 1 To n + 1
                    If (n Mod i = 0) Then
                        a = a + 1
                    End If
                Next i
                If Not (a <> 2) Then
                    ListBox1.Items.Add(n)
                End If
                n = n + 1
            Loop
        End If
    End Sub

End Class
