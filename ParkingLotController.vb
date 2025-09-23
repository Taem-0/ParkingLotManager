Imports MySql.Data.MySqlClient

Public Class ParkingLotController

    Private Shared ReadOnly connectionString As String = "server=localhost;user id=root;password=;database=parkinglotdb;port=3306;"

    Public Shared Sub checkInParkingLot(status As String, plateNumber As String, owner As String, entry As DateTime, floor As Integer, slot As String)

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using cmd As New MySqlCommand("UPDATE parkingslots SET Status = @status, PlateNumber = @platenumber, Owner = @owner, Entry = @entry WHERE Floor = @floor AND slot = @slot", connection)

                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@platenumber", plateNumber)
                cmd.Parameters.AddWithValue("@owner", owner)
                cmd.Parameters.AddWithValue("@entry", entry)
                cmd.Parameters.AddWithValue("@floor", floor)
                cmd.Parameters.AddWithValue("@slot", slot)

                cmd.ExecuteNonQuery()

            End Using

            connection.Close()
        End Using
    End Sub

    Public Shared Sub checkOutParkingLot(idToCheckOut As Integer)

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using cmd As New MySqlCommand("UPDATE parkingslots SET Status = @status, PlateNumber = @platenumber, Owner = @owner, Entry = @entry WHERE ID = @id", connection)

                cmd.Parameters.AddWithValue("@status", "Available")
                cmd.Parameters.AddWithValue("@platenumber", DBNull.Value)
                cmd.Parameters.AddWithValue("@owner", DBNull.Value)
                cmd.Parameters.AddWithValue("@entry", DBNull.Value)
                cmd.Parameters.AddWithValue("@id", idToCheckOut)

                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub
End Class
