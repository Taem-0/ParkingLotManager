Imports MySql.Data.MySqlClient

Public Class HistoryControl

    Dim db As New DBmanager()


    Private Sub HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadHistoryDataGrid()

        Helpers.GridNaRound(HistoryDataGrid, 30)
        Helpers.PanelNaRound(HistoryToolPanel, 15)

        HistoryDataGrid.ReadOnly = True

    End Sub

    Private Sub HistoryControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DeleteButton.Left = (MyBase.Width - DeleteButton.Width) \ 2
    End Sub



    Private Sub HistoryToolPanel_Resize(sender As Object, e As EventArgs) Handles HistoryToolPanel.Resize
        Helpers.PanelNaRound(HistoryToolPanel, 15)
    End Sub

    Private Sub HistoryDataGrid_Resize(sender As Object, e As EventArgs) Handles HistoryDataGrid.Resize
        Helpers.GridNaRound(HistoryDataGrid, 30)
    End Sub

    Public Sub LoadHistoryDataGrid()
        HistoryDataGrid.DataSource = db.LoadHistoryDB

        If HistoryDataGrid.Columns.Contains("HistoryID") Then
            HistoryDataGrid.Columns("HistoryID").Visible = False
        End If

        If HistoryDataGrid.Columns.Contains("SlotID") Then
            HistoryDataGrid.Columns("SlotID").Visible = False
        End If

        HistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        HistoryDataGrid.RowHeadersVisible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub HistoryToolPanel_Paint(sender As Object, e As EventArgs) Handles HistoryToolPanel.Resize
        Label1.Left = (HistoryToolPanel.Width - Label1.Width) \ 2
        Label1.Top = (HistoryToolPanel.Height - Label1.Height) \ 2
    End Sub

    Private Sub HistoryDataGrid_selectionChanged(sender As Object, e As EventArgs) Handles HistoryDataGrid.SelectionChanged
        DeleteButton.Visible = (HistoryDataGrid.CurrentRow IsNot Nothing)
    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If HistoryDataGrid.CurrentRow Is Nothing Then
            DeleteButton.Visible = False

            MessageBox.Show("Please select a history entry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        DeleteButton.Visible = True


        Dim row As DataGridViewRow = HistoryDataGrid.CurrentRow
        Dim historyID As Object = row.Cells("HistoryID").Value
        Dim slotID As Object = row.Cells("Slot").Value
        Dim Floor As Object = row.Cells("Floor").Value

        If historyID Is Nothing OrElse IsDBNull(historyID) Then
            MessageBox.Show("Invalid row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this history entry?: " & vbNewLine & "( Floor " & Floor & " ,Slot " & slotID & ")", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New MySqlConnection(InitializeDatabase.ConnString_Table)
                connection.Open()
                Using cmd As New MySqlCommand("DELETE FROM parkinghistory WHERE HistoryID = @id", connection)
                    cmd.Parameters.AddWithValue("@id", historyID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh the grid
            LoadHistoryDataGrid()
            MessageBox.Show("History entry deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting history entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

End Class
