Public Class CheckInForm

    Public Property MainFormReference As Form1
    Private selectedFloor As Integer
    Private selectedSlot As String

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Helpers.PanelNaRound(CheckInPanel, 30)
    End Sub

    Private Sub CheckInPanel_Resize(sender As Object, e As EventArgs) Handles CheckInPanel.Resize
        Helpers.PanelNaRound(CheckInPanel, 30)
    End Sub

    Private Sub ProcessCheckIn()

        Dim status As String = "Occupied"

        Dim plateNumber As String = PlateNoTextBox.Text

        Dim owner As String = OwnerTextBox.Text

        Dim entryDate As DateTime = DateTime.Now

        ParkingLotController.checkInParkingLot(status, plateNumber, owner, entryDate, selectedFloor, selectedSlot)


    End Sub

    Private Sub SlotItem_Click(sender As Object, e As EventArgs) _
        Handles A1ToolStripMenuItem.Click, A2ToolStripMenuItem.Click, A3ToolStripMenuItem.Click,
            A4ToolStripMenuItem.Click, A5ToolStripMenuItem.Click, A6ToolStripMenuItem.Click,
            A7ToolStripMenuItem.Click, A8ToolStripMenuItem.Click, B1ToolStripMenuItem.Click,
            B2ToolStripMenuItem.Click, B3ToolStripMenuItem.Click, B4ToolStripMenuItem.Click,
            B5ToolStripMenuItem.Click, B6ToolStripMenuItem.Click, B7ToolStripMenuItem.Click,
            B8ToolStripMenuItem.Click,
            A1ToolStripMenuItem1.Click, A2ToolStripMenuItem1.Click, A3ToolStripMenuItem1.Click,
            A4ToolStripMenuItem1.Click, A5ToolStripMenuItem1.Click, A6ToolStripMenuItem1.Click,
            A7ToolStripMenuItem1.Click, A8ToolStripMenuItem1.Click,
            A1ToolStripMenuItem2.Click, B2ToolStripMenuItem1.Click, B3ToolStripMenuItem1.Click,
            B4ToolStripMenuItem1.Click, B5ToolStripMenuItem1.Click, B6ToolStripMenuItem1.Click,
            B7ToolStripMenuItem1.Click, B8ToolStripMenuItem1.Click

        Dim clickedSlot As ToolStripMenuItem = CType(sender, ToolStripMenuItem)


        Dim parentFloor As ToolStripMenuItem = CType(clickedSlot.OwnerItem, ToolStripMenuItem)
        selectedFloor = CInt(parentFloor.Tag)


        selectedSlot = clickedSlot.Text


        SlotLabel.Text = "Selected: Floor " & selectedFloor & ", Slot " & selectedSlot
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        ProcessCheckIn()
        Me.Parent.Controls.Remove(Me)

        If MainFormReference IsNot Nothing Then
            MainFormReference.dash.LoadDataGrid()
            MainFormReference.LoadDashBoard()
        End If

    End Sub

    Private Sub ExButton_Click(sender As Object, e As EventArgs) Handles ExButton.Click

        Me.Parent.Controls.Remove(Me)

        If MainFormReference IsNot Nothing Then
            MainFormReference.LoadDashBoard()
        End If

    End Sub
End Class
