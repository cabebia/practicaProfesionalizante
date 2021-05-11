Imports System.IO
Imports System.Data
Imports MySql.Data.MySqlClient

Module MySQL
   'REEMPLACE LA INFO EXPRESADA ENTRE COMILLAS DOBLES 
    Dim DataBaseIP As String = "127.0.0.1"
    Dim DataBaseUser As String = "root"
    Dim DataBasePassword As String = "german2598"
    Dim DataBaseName As String = "pp1"

    Dim Constr As String = "server=" & DataBaseIP & ";uid=" & DataBaseUser & ";password=" & DataBasePassword & ";database=" & DataBaseName
    Dim Con As New MySqlConnection(Constr)

    Public Function Leer(ByVal Str_Sql As String) As DataTable

        Dim Comando As New MySqlCommand(Str_Sql, Con)

        Try

            If Not Con Is Nothing Then

                Con.Close()

            End If

            Con.Open()

            Dim Dt As New DataTable
            Dim Da As New MySqlDataAdapter(Str_Sql, Con)
            Dim Res As Integer = Comando.ExecuteNonQuery()
            Dim Cmd As New MySqlCommandBuilder(Da)

            Da.Fill(Dt)

            Return Dt ' Retornamos el datatable con la información leída. Luego hay que trabajar sobre este retorno
            Exit Function

        Catch ex As Exception

            MsgBox(ex.Message)
            Dim Dt As New DataTable
            Return Dt ' Retornamos un datable vacío para saber cuando no se lleyó nada (Dt.Rows.Count = 0)
            Exit Function

        Finally

            Con.Close()
            Comando = Nothing

        End Try

    End Function

    Public Function Query(ByVal Str_SQL As String) As String

        Dim comando As New MySqlCommand(Str_SQL, Con)

        Try

            If Not Con Is Nothing Then

                Con.Close()

            End If

            Con.Open()

            Dim Da As New MySqlDataAdapter(Str_SQL, Con)
            Dim Dt As New DataTable
            Dim res As Integer

            If UCase(Left(Str_SQL, 6)) = "INSERT" Then ' Trabajamos sobre el String Str_SQL

                'Formateamos Str_SQL para poder obtener la tabla 
                Dim empezar As Integer = InStr(Str_SQL, "INTO ") + 5
                Dim terminar As Integer = InStr(Str_SQL, " (") - empezar
                Dim tabla As String = Mid(Str_SQL, empezar, terminar) ' Obtenemos la tabla
                Dim Dau As New MySqlDataAdapter("SELECT LAST_INSERT_ID() from " & tabla, Con) ' Obtenemos el útlimo registro

                'Ejecutamos comando
                Dim res1 As Integer = comando.ExecuteNonQuery()
                Dim Cmd As New MySqlCommandBuilder(Dau)

                'llenamos la tabla 
                Dau.Fill(Dt)

                If Dt.Rows.Count = 0 Then

                    MsgBox("NO PUDE OBTENER EL ID")

                Else

                    res = Dt.Rows(0).ItemArray(0).ToString

                End If

                Dt.Clear()

            Else

                res = comando.ExecuteNonQuery()

            End If

            Return res.ToString

        Catch ex As Exception

            MsgBox(ex.Message)
            Dim Res As Integer = 0
            Return Res

        Finally

            Con.Close()
            comando = Nothing

        End Try

    End Function

End Module
