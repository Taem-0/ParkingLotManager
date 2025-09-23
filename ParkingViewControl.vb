Imports MySql.Data.MySqlClient

Public Class ParkingViewControl

    Public Property ParentFormReference As Form1
    Private checkInForm As CheckInForm

    Public Shared CurrentFloor As Integer = 1

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
    Private Sub OpenCheckInForm(slot As String)
        If ParentFormReference IsNot Nothing Then
            ParentFormReference.MainPanel.Controls.Clear()

            checkInForm = New CheckInForm()
            checkInForm.SelectedFloor = CurrentFloor
            checkInForm.SelectedSlot = slot
            checkInForm.Dock = DockStyle.Fill
            checkInForm.MainFormReference = ParentFormReference

            ParentFormReference.MainPanel.Controls.Add(checkInForm)
        End If
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.DoubleClick
        If A1.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A1 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A1")
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.DoubleClick
        If A2.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A2 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A2")
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.DoubleClick
        If A3.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A3 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A3")
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.DoubleClick
        If A4.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A4 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A4")
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.DoubleClick
        If A5.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A5 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A5")
    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.DoubleClick
        If A6.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A6 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A6")
    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.DoubleClick
        If A7.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A7 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A7")
    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.DoubleClick
        If A8.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot A8 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("A8")
    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.DoubleClick
        If B1.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B1 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B1")
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.DoubleClick
        If B2.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B2 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B2")
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.DoubleClick
        If B3.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B3 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B3")
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.DoubleClick
        If B4.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B4 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B4")
    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.DoubleClick
        If B5.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B5 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B5")
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.DoubleClick
        If B6.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B6 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B6")
    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.DoubleClick
        If B7.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B7 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B7")
    End Sub
    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.DoubleClick
        If B8.BackColor = ColorTranslator.FromHtml("#ff8080") Then
            MessageBox.Show("Slot B8 is already occupied.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenCheckInForm("B8")
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
