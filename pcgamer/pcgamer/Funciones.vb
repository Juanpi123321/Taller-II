Module Funciones

    Function ValidarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Function ValidarDNI(ByVal DNI As Long) As Boolean
        Dim respuesta As Boolean
        If DNI < 3000000 Or DNI > 99999999 Then
            respuesta = False
        Else
            respuesta = True
        End If
        Return respuesta
    End Function

End Module
