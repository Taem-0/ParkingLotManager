Public Class HistoryControl

    Dim db As New DBmanager()


    Private Sub HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadHistoryDataGrid()

        Helpers.GridNaRound(HistoryDataGrid, 30)
        Helpers.PanelNaRound(HistoryToolPanel, 15)


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

End Class
