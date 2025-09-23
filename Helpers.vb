Imports System.Drawing.Drawing2D
Imports System.Linq.Expressions

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

    Shared Function calculateDuration(startTime As DateTime, endTime As DateTime) As TimeSpan

        Dim duration As TimeSpan = endTime - startTime

        Return duration

    End Function

    Shared Function calculateFee(duration As TimeSpan) As Decimal

        Dim totalMinutes As Integer = CInt(duration.TotalMinutes)

        Select Case totalMinutes
            Case 0 To 30
                Return 50D
            Case 31 To 100
                Return 200D
            Case 61 To 120
                Return 400D
            Case Else
                Return 1000D
        End Select

    End Function

End Class
