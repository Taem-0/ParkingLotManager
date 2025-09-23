Imports MySql.Data.MySqlClient

Public Class ParkingHistoryController

    Private Shared ReadOnly connectionString As String = "server=localhost;user id=root;password=;database=parkinglotdb;port=3306;"

    Public Shared Sub postHistoryParkingLot(slotID As Integer, plateNumber As String, owner As String, entry As DateTime, floor As Integer, slot As String, exitTime As DateTime, duration As TimeSpan, fee As Decimal)

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using cmd As New MySqlCommand("INSERT INTO parkinghistory (SlotID, PlateNumber, Owner, Entry, Floor, Slot, ExitTime, Duration, Fee) VALUES (@slotID, @platenumber, @owner, @entry, @floor, @slot, @exitTime, @duration, @fee)", connection)

                cmd.Parameters.AddWithValue("@slotID", slotID)
                cmd.Parameters.AddWithValue("@platenumber", plateNumber)
                cmd.Parameters.AddWithValue("@owner", owner)
                cmd.Parameters.AddWithValue("@entry", entry)
                cmd.Parameters.AddWithValue("@floor", floor)
                cmd.Parameters.AddWithValue("@slot", slot)
                cmd.Parameters.AddWithValue("@exitTime", exitTime)
                cmd.Parameters.AddWithValue("@duration", duration)
                cmd.Parameters.AddWithValue("@fee", fee)

                cmd.ExecuteNonQuery()

            End Using

            connection.Close()
        End Using
    End Sub

End Class
