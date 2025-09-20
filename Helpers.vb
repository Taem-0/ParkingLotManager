Imports System.Drawing.Drawing2D

Public Class Helpers
    Shared Sub PanelNaRound(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)

        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)

        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)

        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        panel.Region = New Region(path)


    End Sub

    Shared Sub GridNaRound(panel As DataGridView, radius As Integer)
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)

        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)

        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)

        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        panel.Region = New Region(path)


    End Sub

    Shared Sub LayoutNaRound(panel As TableLayoutPanel, radius As Integer)
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)

        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)

        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)

        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        panel.Region = New Region(path)


    End Sub

End Class
