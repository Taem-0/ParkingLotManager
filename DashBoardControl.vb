

Public Class DashBoardControl

    Public Property ParentFormReference As Form1
    Private checkInForm As CheckInForm
    Private history As New HistoryControl

    Dim db As New DBmanager()

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        OccupiesSlotsPanel.Left = (Panel1.Width - OccupiesSlotsPanel.Width) \ 2
        OccupiesSlotsPanel.Top = (Panel1.Height - OccupiesSlotsPanel.Height) \ 2

    End Sub

    Private Sub DashBoardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataGrid()

        Helpers.PanelNaRound(TotalLotsPanel, 15)
        Helpers.PanelNaRound(OccupiesSlotsPanel, 15)
        Helpers.PanelNaRound(EmptyLotsPanel, 15)
        Helpers.GridNaRound(ParkingLotDataGrid, 15)


    End Sub

    Private Sub ParkingLotDataGrid_Resize(sender As Object, e As EventArgs) Handles ParkingLotDataGrid.Resize
        Helpers.GridNaRound(ParkingLotDataGrid, 30)
    End Sub

    Public Sub LoadDataGrid()
        ParkingLotDataGrid.DataSource = db.LoadDB
        ParkingLotDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        ParkingLotDataGrid.RowHeadersVisible = False

        Labels()
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs)
        CheckIn()
    End Sub

    Private Sub CheckIn()
        If ParentFormReference IsNot Nothing Then

            ParentFormReference.MainPanel.Controls.Clear()


            checkInForm = New CheckInForm()
            checkInForm.Dock = DockStyle.Fill

            checkInForm.MainFormReference = ParentFormReference

            ParentFormReference.MainPanel.Controls.Add(checkInForm)

        End If
    End Sub


    Private Sub ProcessCheckOut()

        Dim row As DataGridViewRow = ParkingLotDataGrid.CurrentRow

        Try
            Dim idToCheckOut As Integer = Convert.ToInt32(row.Cells("ID").Value)
            ParkingLotController.checkOutParkingLot(idToCheckOut)

        Catch ex As Exception
            MessageBox.Show("cant delete empty row")
        End Try

        LoadDataGrid()

    End Sub

    Private Sub ProcessHistory()

        Dim row As DataGridViewRow = ParkingLotDataGrid.CurrentRow

        Dim slotID As Integer = Convert.ToInt32(row.Cells("ID").Value)
        Dim plateNumber As String = row.Cells("PlateNumber").Value.ToString
        Dim owner As String = row.Cells("Owner").Value.ToString

        Dim entry As DateTime
        If row.Cells("Entry").Value Is Nothing OrElse IsDBNull(row.Cells("Entry").Value) Then
            Exit Sub
        Else
            entry = Convert.ToDateTime(row.Cells("Entry").Value)
        End If

        Dim floor As Integer = Convert.ToInt32(row.Cells("Floor").Value)
        Dim slot As String = row.Cells("Slot").Value.ToString
        Dim exitTime As DateTime = DateTime.Now
        Dim duration As TimeSpan = Helpers.calculateDuration(entry, exitTime)
        Dim fee As Decimal = Helpers.calculateFee(duration)

        ParkingHistoryController.postHistoryParkingLot(slotID, plateNumber, owner, entry, floor, slot, exitTime, duration, fee)

    End Sub

    Private Sub Labels()

        Dim occupiedCount As Integer = 0
        Dim availableCount As Integer = 0


        For Each row As DataGridViewRow In ParkingLotDataGrid.Rows

            If row.Cells("Status").Value IsNot Nothing AndAlso row.Cells("Status").Value.ToString = "Occupied" Then
                occupiedCount += 1
            End If

            If row.Cells("Status").Value IsNot Nothing AndAlso row.Cells("Status").Value.ToString = "Available" Then
                availableCount += 1
            End If


        Next

        FreeSlots.Text = availableCount.ToString
        OccupiedSlots.Text = occupiedCount.ToString
        TotalSNumber.Text = "32"



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckIn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProcessHistory()

        ProcessCheckOut()

        history.LoadHistoryDataGrid()
    End Sub
End Class
