Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class DBmanager
    Private ReadOnly connectionString As String = "server=localhost;user id=root;password=;database=parkinglotdb;port=3306;"

    Public Function LoadDB() As DataTable

        Dim query As String = "SELECT * from parkingslots"

        Dim data As New DataTable()

        Try
            Using connection As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, connection)

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(data)
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try

        Return data

    End Function


    Public Function LoadHistoryDB() As DataTable

        Dim query As String = "SELECT * FROM parkinghistory"

        Dim data As New DataTable

        Try
            Using connection As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, connection)

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(data)
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try

        Return data

    End Function

End Class
