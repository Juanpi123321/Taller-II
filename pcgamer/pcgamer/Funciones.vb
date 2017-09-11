Module Funciones
    ' Public Function DNIvalido(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

    'If e.KeyChar = Convert.ToChar(8) Then Exit Function
    'If IsNumeric(e.KeyChar) <> True Then
    '       e.Handled = True
    'End If
    'Return e.Handled

    'End Function

    Function ValidarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

End Module
