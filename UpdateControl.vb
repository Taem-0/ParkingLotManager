Imports System.Text.RegularExpressions

Public Class UpdateControl

    Public Property MainFormReference As Form1


    Public Property SlotID As Integer
    Public Property PlateNo As String
    Public Property OwnerName As String

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)


        PlateNoTextBox.Text = If(PlateNo, String.Empty)
        OwnerTextBox.Text = If(OwnerName, String.Empty)


        AddHandler ConfirmButton.Click, AddressOf ConfirmButton_Click
        AddHandler ExButton.Click, AddressOf ExButton_Click


        AddHandler PlateNoTextBox.TextChanged, AddressOf PlateNoTextBox_TextChanged
        AddHandler PlateNoTextBox.KeyDown, AddressOf PlateNoTextBox_KeyDown
        AddHandler OwnerTextBox.KeyDown, AddressOf OwnerTextBox_KeyDown
        AddHandler OwnerTextBox.KeyPress, AddressOf OwnerTextBox_KeyPress
    End Sub


    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        If Not PlateNoValid(PlateNoTextBox.Text) Then Return
        If Not OwnerValid(OwnerTextBox.Text) Then Return


        Try
            ProcessUpdate()
            MessageBox.Show("Updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try


        If Me.Parent IsNot Nothing Then Me.Parent.Controls.Remove(Me)

        If MainFormReference IsNot Nothing Then
            MainFormReference.dash?.LoadDataGrid()
            MainFormReference.LoadDashBoard()
        End If
    End Sub



    Private Sub ExButton_Click(sender As Object, e As EventArgs)
        If Me.Parent IsNot Nothing Then Me.Parent.Controls.Remove(Me)
        If MainFormReference IsNot Nothing Then MainFormReference.LoadDashBoard()
    End Sub


    Private Sub ProcessUpdate()
        Dim plateNumber As String = PlateNoTextBox.Text.Trim().ToUpper()
        Dim owner As String = OwnerTextBox.Text.Trim().ToUpper()


        If SlotID <= 0 Then
            Throw New InvalidOperationException("SlotID is not set. Dashboard must supply SlotID before loading UpdateControl.")
        End If


        ParkingLotController.UpdateParkingLotRecord(SlotID, plateNumber, owner)
    End Sub


    Private Function PlateNoValid(plate As String) As Boolean
        plate = plate.Trim().ToUpper()
        Dim platePattern As String = "^[A-Z]{3}\s?\d{3,4}$|^[A-Z]{2}\s?\d{4}$|^\d{3,4}\s?[A-Z]{2,3}$"

        If Not Regex.IsMatch(plate, platePattern) Then
            MessageBox.Show("Invalid plate number format. Example: ABC 123, ABC 1234, AB 1234, or 123 AB", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PlateNoTextBox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function OwnerValid(owner As String) As Boolean
        owner = owner.Trim().ToUpper()
        Dim ownerPattern As String = "^[A-Za-z]+(?:[.,]?[ ][A-Za-z]+){0,19}$"
        Dim spamPattern As String = "(.)\1{3,}"

        If owner.Length < 2 Or owner.Length > 50 Then
            MessageBox.Show("Driver name must be between 2 and 50 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        If owner.Contains("  ") Then
            MessageBox.Show("Driver name cannot contain multiple spaces in a row.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        If Not Char.IsLetter(owner(0)) Then
            MessageBox.Show("Driver name must start with a letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        If Regex.IsMatch(owner, spamPattern) Then
            MessageBox.Show("Invalid owner name. Cannot input 3 same characters in a row.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        If Not Regex.IsMatch(owner, ownerPattern) Then
            MessageBox.Show("Invalid owner name format. Only letters, spaces, periods, and commas are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OwnerTextBox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub PlateNoTextBox_TextChanged(sender As Object, e As EventArgs)
        Dim tb As TextBox = CType(sender, TextBox)
        Dim selStart = tb.SelectionStart
        tb.Text = tb.Text.ToUpper()
        tb.SelectionStart = Math.Min(selStart, tb.Text.Length)
    End Sub

    Private Sub PlateNoTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ConfirmButton.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
            ExButton.PerformClick()
        End If
    End Sub

    Private Sub OwnerTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ConfirmButton.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
            ExButton.PerformClick()
        End If
    End Sub

    Private Sub OwnerTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If
    End Sub

End Class
