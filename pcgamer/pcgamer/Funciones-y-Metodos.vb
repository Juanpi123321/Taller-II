Imports System.Data.SqlClient
Module Funciones_y_Metodos

    'De acuerdo al tipo de rol redirige
    Public Sub redirigirMenu(ByVal rol As String)
        If rol = "SuperAdministrador" Then
            FormularioSuperAdmin.Show()
        ElseIf rol = "Administrador" Then
            FormularioAdministrador.Show()
        ElseIf rol = "Vendedor" Then
            FormularioVendedor.Show()
        Else
            MsgBox("Tipo de ROL desconocido")
        End If
    End Sub

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

    Function backup(p_nombre_copia As String) As Boolean
        Dim resultado = False
        Dim conexion As New SqlConnection("Data Source=JUANPINETBOOK20\SQLEXPRESS;Initial Catalog=pc_gamer;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework")
        Dim comando_consulta As String = "BACKUP DATABASE [pc_gamer] TO  DISK = N'D:\usuarios\alumno\Documentos\Visual Studio 2017\Projects\Taller-II\pcgamer\Backup\" + p_nombre_copia + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'pc_gamer-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        Dim cmd As SqlCommand = New SqlCommand(comando_consulta, conexion)
        Try
            conexion.Open()
            cmd.ExecuteNonQuery()
            resultado = True
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return resultado
    End Function

End Module
