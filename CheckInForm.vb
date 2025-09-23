Public Class CheckInForm

    Public Property MainFormReference As Form1
    Public Property SelectedFloor As Integer
    Public Property SelectedSlot As String

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Helpers.PanelNaRound(CheckInPanel, 30)

        If SelectedFloor > 0 AndAlso Not String.IsNullOrEmpty(SelectedSlot) Then
            ToolStripDropDownButton1.Text = $"Floor {SelectedFloor}, Slot {SelectedSlot}"
        End If

    End Sub

    Private Sub CheckInPanel_Resize(sender As Object, e As EventArgs) Handles CheckInPanel.Resize
        Helpers.PanelNaRound(CheckInPanel, 30)
        CenterPanel2()
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


        'SlotLabel.Text = "Selected: Floor " & selectedFloor & ", Slot " & selectedSlot
        ToolStripDropDownButton1.Text = "Floor " & selectedFloor & ", Slot " & selectedSlot
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        If ParkingLotController.IsSlotOccupied(selectedFloor, selectedSlot) Then
            MessageBox.Show("The selected slot is already occupied. Please choose a different slot.", "Slot Occupied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PlateNoValid(PlateNoTextBox.Text) = False Then
            Return
        End If

        If OwnerValid(OwnerTextBox.Text) = False Then
            Return
        End If

        If selectedSlot Is Nothing Or selectedSlot = "" Then
            MessageBox.Show("Please select a slot.", "No Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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

    Private Sub PlateNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlateNoTextBox.TextChanged
        Dim tb As TextBox = CType(sender, TextBox)

        Dim selectionStart As Integer = tb.SelectionStart

        tb.Text = tb.Text.ToUpper()

        tb.SelectionStart = selectionStart
    End Sub

    Private Sub PlateNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PlateNoTextBox.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub


    Private Function PlateNoValid(PlateNo As String)
        PlateNo = PlateNo.Trim().ToUpper()
        Dim platePattern As String = "^[A-Z]{3}\s?\d{3,4}$|^[A-Z]{2}\s?\d{4}$|^\d{3,4}\s?[A-Z]{2,3}$"

        If Not System.Text.RegularExpressions.Regex.IsMatch(PlateNo, platePattern) Then
            MessageBox.Show("Invalid plate number format. Example: ABC 123, ABC 1234, AB 1234, or 123 AB", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PlateNoTextBox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub OwnerTextBox_TextChanged(sender As Object, e As EventArgs) Handles OwnerTextBox.TextChanged

    End Sub

    Private Sub OwnerTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OwnerTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If
    End Sub

    Private Function OwnerValid(Owner As String)
        Owner = Owner.Trim().ToUpper()
        Dim ownerPattern As String = "^[A-Za-z]+(?:[.,]?[ ]?[A-Za-z]+){1,20}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(Owner, ownerPattern) Then
            MessageBox.Show("Invalid owner name format. Only letters, commas, periods, and no multi spaces are allowed. Atleast 2 Characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CenterPanel2()
        Panel2.Left = (CheckInPanel.Width - Panel2.Width - 100) \ 2
        'Panel2.Top = (CheckInPanel.Height - Panel2.Height) \ 2
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        Label2.Left = (Panel1.Width - Label2.Width) \ 2
        Label2.Top = (Panel1.Height - Label2.Height) \ 2
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
