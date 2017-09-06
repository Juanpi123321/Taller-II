Imports System.Text.RegularExpressions
Imports System.Drawing.Imaging
Imports System.IO
Module Funciones
    Public Sub pintar(ByVal sender As Object,
 ByVal e As PaintEventArgs)

        ' Establecemos el color del borde
        '
        Dim borderColor As Color = Color.Black

        ' Referenciamos el control GroupBox
        '
        Dim gb As GroupBox = DirectCast(sender, GroupBox)

        Dim tSize As Size = _
           TextRenderer.MeasureText(gb.Text, gb.Font)

        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = CInt((borderRect.Y + (tSize.Height / 2)))
        borderRect.Height = _
           CInt((borderRect.Height - (tSize.Height / 2)))
        ControlPaint.DrawBorder(e.Graphics, borderRect, _
                                borderColor, ButtonBorderStyle.Solid)

        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height

        e.Graphics.FillRectangle( _
           New SolidBrush(gb.BackColor), textRect)

        e.Graphics.DrawString( _
           gb.Text, gb.Font, New SolidBrush(gb.ForeColor), textRect)

    End Sub
    Public Sub validar_numeros(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo Numeros de  0-9", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        End If

    End Sub

    Public Sub validar_letra(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)

        If Not Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo letras de  a-z", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "error")
        End If
    End Sub

End Module
