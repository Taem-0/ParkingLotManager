Imports MySql.Data.MySqlClient

Public Class ParkingViewControl

    Public Shared CurrentFloor As Integer = 1

    Private Sub ParkingViewControl_Load(sender As Object, e As EventArgs)
        'Helpers.PanelNaRound(FloorSelectionPanel, 15)
        'Helpers.PanelNaRound(StatusPanel, 15)

    End Sub

    Public Sub RefreshParkingSlots(selectedFloor As Integer)
        Using connection As New MySqlConnection(InitializeDatabase.ConnString_Table)
            connection.Open()

            Using cmd As New MySqlCommand("SELECT Slot, Status FROM parkingslots WHERE Floor = @floor", connection)
                cmd.Parameters.AddWithValue("@floor", selectedFloor)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim slotName As String = reader("Slot").ToString()
                        Dim status As String = reader("Status").ToString()

                        Dim ctrl As Control = Me.Controls.Find(slotName, True).FirstOrDefault()

                        If ctrl IsNot Nothing Then
                            ctrl.BackColor = If(status = "Occupied",
                                ColorTranslator.FromHtml("#ff8080"),
                                ColorTranslator.FromHtml("#80ff80"))
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub ParkingViewControl_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParkingSlots(CurrentFloor)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click

    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click

    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click

    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click

    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click

    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click

    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click

    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click

    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click

    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click

    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click

    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click

    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click

    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click

    End Sub
    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click

    End Sub

    Private Sub FloorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles Panel1.Resize
        ToolStrip1.Left = (Panel1.Width - ToolStrip1.Width) \ 2
        ToolStrip1.Top = (Panel1.Height - ToolStrip1.Height) \ 2

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        CurrentFloor = 1
        RefreshParkingSlots(CurrentFloor)
        ToolStripDropDownButton1.Text = "Floor 1"
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        CurrentFloor = 2
        RefreshParkingSlots(CurrentFloor)
        ToolStripDropDownButton1.Text = "Floor 2"
    End Sub

End Class
