Imports System.Drawing.Drawing2D

Public Class DashBoardControl

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        OccupiesSlotsPanel.Left = (Panel1.Width - OccupiesSlotsPanel.Width) \ 2
        OccupiesSlotsPanel.Top = (Panel1.Height - OccupiesSlotsPanel.Height) \ 2

    End Sub

    Private Sub DashBoardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden

        Helpers.PanelNaRound(TotalLotsPanel, 15)
        Helpers.PanelNaRound(OccupiesSlotsPanel, 15)
        Helpers.PanelNaRound(EmptyLotsPanel, 15)
        Helpers.GridNaRound(ParkingLotDataGrid, 15)
    End Sub

    Private Sub ParkingLotDataGrid_Resize(sender As Object, e As EventArgs) Handles ParkingLotDataGrid.Resize
        Helpers.GridNaRound(ParkingLotDataGrid, 30)
    End Sub


End Class
