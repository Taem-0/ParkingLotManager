Public Class HistoryControl
    Private Sub HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Helpers.GridNaRound(HistoryDataGrid, 30)
        Helpers.PanelNaRound(HistoryToolPanel, 15)
    End Sub

    Private Sub HistoryToolPanel_Resize(sender As Object, e As EventArgs) Handles HistoryToolPanel.Resize
        Helpers.PanelNaRound(HistoryToolPanel, 15)
    End Sub

    Private Sub HistoryDataGrid_Resize(sender As Object, e As EventArgs) Handles HistoryDataGrid.Resize
        Helpers.GridNaRound(HistoryDataGrid, 30)
    End Sub


End Class
