Imports MySql.Data.MySqlClient

Public Class Formulario5

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conexion As New MySqlConnection("data source=localhost;database=practico_5")
        Dim Adaptador As MySqlDataAdapter
        Dim TablaDatos As DataTable
        Dim ConsultaSQL As String

        Try
            ConsultaSQL = "SELECT Apellido,Nombre,fechanac as Fecha_Nacimiento,Sexo,Saldo,Foto FROM personas"
            Adaptador = New MySqlDataAdapter(ConsultaSQL, Conexion)
            TablaDatos = New DataTable
            Adaptador.Fill(TablaDatos)
            DataGridView1.DataSource = TablaDatos

        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

End Class