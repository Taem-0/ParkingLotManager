Public Class Form1


    Public dash As New DashBoardControl()
    Private history As New HistoryControl()
    Private parkingView As New ParkingViewControl()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashBoard()
    End Sub

    Private Sub DashBoardButton_Click(sender As Object, e As EventArgs) Handles DashBoardButton.Click
        LoadDashBoard()
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        LoadHistory()
    End Sub

    Private Sub ParkingViewButton_Click(sender As Object, e As EventArgs) Handles ParkingViewButton.Click
        LoadParkingView()
    End Sub


    'Mga paraan:  

    Public Sub LoadDashBoard()
        MainPanel.Controls.Clear()
        dash.ParentFormReference = Me
        dash.Dock = DockStyle.Fill
        MainPanel.Controls.Add(dash)
    End Sub

    Private Sub LoadHistory()
        MainPanel.Controls.Clear()
        history.Dock = DockStyle.Fill
        MainPanel.Controls.Add(history)
    End Sub

    Private Sub LoadParkingView()
        MainPanel.Controls.Clear()
        parkingView.Dock = DockStyle.Fill
        MainPanel.Controls.Add(parkingView)

    End Sub

End Class
