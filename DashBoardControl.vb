

Public Class DashBoardControl

    Public Property ParentFormReference As Form1
    Private checkInForm As CheckInForm
    Private history As New HistoryControl
    Private Current_Fee As Decimal = 0D

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

        ParkingLotDataGrid.ReadOnly = True


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

        Current_Fee = fee

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

    Private Sub CheckIN_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckIn()
    End Sub

    Private Sub CheckOUT_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProcessHistory()

        ProcessCheckOut()

        history.LoadHistoryDataGrid()


        If Not Current_Fee = 0D Then
            MessageBox.Show("Checked Out Successfully!" & vbCrLf &
                        "Total Fee: ₱" & Current_Fee.ToString("F2"), "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Current_Fee = 0D
    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ParkingLotDataGrid.CellFormatting
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If e.RowIndex < 0 Then Return

        Dim status As Object = dgv.Rows(e.RowIndex).Cells(3).Value

        If status Is Nothing Then Return

        Select Case status.ToString()
            Case "Occupied"
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF8080")
            Case "Available"
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#80FF80")
            Case "Reserved"
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8080FF")
            Case Else
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End Select
        If e.ColumnIndex = 6 Then
            e.CellStyle.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        End If
    End Sub
    Private Sub ParkingLotDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParkingLotDataGrid.CellContentClick

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If ParkingLotDataGrid.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = ParkingLotDataGrid.CurrentRow


        Dim plate As String = If(row.Cells("PlateNumber").Value, String.Empty).ToString().Trim()
        Dim owner As String = If(row.Cells("Owner").Value, String.Empty).ToString().Trim()

        If String.IsNullOrEmpty(plate) OrElse String.IsNullOrEmpty(owner) Then
            MessageBox.Show("Selected row has no Plate Number or Owner. Cannot update.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim idValue = row.Cells("ID").Value
        Dim slotId As Integer = 0
        If idValue Is Nothing OrElse IsDBNull(idValue) OrElse Not Integer.TryParse(idValue.ToString(), slotId) Then
            MessageBox.Show("Selected record does not have a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim upd As New UpdateControl()
        upd.MainFormReference = ParentFormReference
        upd.SlotID = slotId
        upd.PlateNo = plate
        upd.OwnerName = owner

        If ParentFormReference IsNot Nothing Then
            ParentFormReference.MainPanel.Controls.Clear()
            upd.Dock = DockStyle.Fill
            ParentFormReference.MainPanel.Controls.Add(upd)
        Else
            Me.Parent.Controls.Clear()
            upd.Dock = DockStyle.Fill
            Me.Parent.Controls.Add(upd)
        End If
    End Sub



End Class
