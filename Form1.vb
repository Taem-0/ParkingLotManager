Public Class Form1


    Public dash As New DashBoardControl()
    Private history As New HistoryControl()
    Private parkingView As New ParkingViewControl()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase.InitializeTABLE()
        LoadDashBoard()
        DB_Status()
    End Sub

    Private Sub DashBoardButton_Click(sender As Object, e As EventArgs) Handles DashBoardButton.Click
        LoadDashBoard()
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        LoadHistory()
    End Sub

    Private Sub ParkingViewButton_Click(sender As Object, e As EventArgs) Handles ParkingViewButton.Click
        LoadParkingView()
        parkingView.RefreshParkingSlots(ParkingViewControl.CurrentFloor)
    End Sub


    'Mga paraan:  

    Public Sub LoadDashBoard()
        MainPanel.Controls.Clear()
        dash.ParentFormReference = Me
        dash.Dock = DockStyle.Fill
        MainPanel.Controls.Add(dash)
    End Sub

    Private Sub LoadHistory()
        history.LoadHistoryDataGrid()
        MainPanel.Controls.Clear()
        history.Dock = DockStyle.Fill
        MainPanel.Controls.Add(history)
    End Sub

    Private Sub LoadParkingView()
        MainPanel.Controls.Clear()
        parkingView.Dock = DockStyle.Fill
        MainPanel.Controls.Add(parkingView)

    End Sub

    Private Sub DB_Status()
        If InitializeDatabase.Database_Success = True Then
            DB_stat.Text = "Database Connected"
        Else
            DB_stat.Text = "Database Not Connected"
        End If
    End Sub
End Class
