<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashBoardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ParkingLotDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLotsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalSNumber = New System.Windows.Forms.Label()
        Me.EmptyLotsPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OccupiedSlots = New System.Windows.Forms.Label()
        Me.OccupiesSlotsPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FreeSlots = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.ParkingLotDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TotalLotsPanel.SuspendLayout()
        Me.EmptyLotsPanel.SuspendLayout()
        Me.OccupiesSlotsPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ParkingLotDataGrid
        '
        Me.ParkingLotDataGrid.AllowUserToOrderColumns = True
        Me.ParkingLotDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParkingLotDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.ParkingLotDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ParkingLotDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ParkingLotDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ParkingLotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ParkingLotDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.ParkingLotDataGrid.Location = New System.Drawing.Point(0, 124)
        Me.ParkingLotDataGrid.Name = "ParkingLotDataGrid"
        Me.ParkingLotDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ParkingLotDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ParkingLotDataGrid.RowHeadersVisible = False
        Me.ParkingLotDataGrid.RowHeadersWidth = 51
        Me.ParkingLotDataGrid.Size = New System.Drawing.Size(752, 476)
        Me.ParkingLotDataGrid.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TotalLotsPanel)
        Me.Panel1.Controls.Add(Me.EmptyLotsPanel)
        Me.Panel1.Controls.Add(Me.OccupiesSlotsPanel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 93)
        Me.Panel1.TabIndex = 2
        '
        'TotalLotsPanel
        '
        Me.TotalLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalLotsPanel.BackColor = System.Drawing.Color.Transparent
        Me.TotalLotsPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.round_cube_sidebar
        Me.TotalLotsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TotalLotsPanel.Controls.Add(Me.Label1)
        Me.TotalLotsPanel.Controls.Add(Me.TotalSNumber)
        Me.TotalLotsPanel.Location = New System.Drawing.Point(69, 11)
        Me.TotalLotsPanel.Name = "TotalLotsPanel"
        Me.TotalLotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.TotalLotsPanel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Slots"
        '
        'TotalSNumber
        '
        Me.TotalSNumber.AutoSize = True
        Me.TotalSNumber.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSNumber.ForeColor = System.Drawing.Color.Transparent
        Me.TotalSNumber.Location = New System.Drawing.Point(17, 8)
        Me.TotalSNumber.Name = "TotalSNumber"
        Me.TotalSNumber.Size = New System.Drawing.Size(57, 36)
        Me.TotalSNumber.TabIndex = 3
        Me.TotalSNumber.Text = "32"
        '
        'EmptyLotsPanel
        '
        Me.EmptyLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmptyLotsPanel.BackColor = System.Drawing.Color.Transparent
        Me.EmptyLotsPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.round_cube3
        Me.EmptyLotsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmptyLotsPanel.Controls.Add(Me.Label3)
        Me.EmptyLotsPanel.Controls.Add(Me.OccupiedSlots)
        Me.EmptyLotsPanel.Location = New System.Drawing.Point(481, 11)
        Me.EmptyLotsPanel.Name = "EmptyLotsPanel"
        Me.EmptyLotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.EmptyLotsPanel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Occupied Slots"
        '
        'OccupiedSlots
        '
        Me.OccupiedSlots.AutoSize = True
        Me.OccupiedSlots.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupiedSlots.ForeColor = System.Drawing.Color.White
        Me.OccupiedSlots.Location = New System.Drawing.Point(21, 8)
        Me.OccupiedSlots.Name = "OccupiedSlots"
        Me.OccupiedSlots.Size = New System.Drawing.Size(36, 36)
        Me.OccupiedSlots.TabIndex = 5
        Me.OccupiedSlots.Text = "0"
        '
        'OccupiesSlotsPanel
        '
        Me.OccupiesSlotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OccupiesSlotsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OccupiesSlotsPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.round_cube2
        Me.OccupiesSlotsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OccupiesSlotsPanel.Controls.Add(Me.Label2)
        Me.OccupiesSlotsPanel.Controls.Add(Me.FreeSlots)
        Me.OccupiesSlotsPanel.Location = New System.Drawing.Point(275, 11)
        Me.OccupiesSlotsPanel.Name = "OccupiesSlotsPanel"
        Me.OccupiesSlotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.OccupiesSlotsPanel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Free Slots"
        '
        'FreeSlots
        '
        Me.FreeSlots.AutoSize = True
        Me.FreeSlots.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSlots.ForeColor = System.Drawing.Color.White
        Me.FreeSlots.Location = New System.Drawing.Point(18, 8)
        Me.FreeSlots.Name = "FreeSlots"
        Me.FreeSlots.Size = New System.Drawing.Size(36, 36)
        Me.FreeSlots.TabIndex = 4
        Me.FreeSlots.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 50)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check In   →"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(481, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 50)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Check Out ←"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UpdateButton)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 599)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.Panel2.Size = New System.Drawing.Size(752, 50)
        Me.Panel2.TabIndex = 5
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(304, 0)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(146, 50)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DashBoardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ParkingLotDataGrid)
        Me.Name = "DashBoardControl"
        Me.Size = New System.Drawing.Size(752, 649)
        CType(Me.ParkingLotDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TotalLotsPanel.ResumeLayout(False)
        Me.TotalLotsPanel.PerformLayout()
        Me.EmptyLotsPanel.ResumeLayout(False)
        Me.EmptyLotsPanel.PerformLayout()
        Me.OccupiesSlotsPanel.ResumeLayout(False)
        Me.OccupiesSlotsPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParkingLotDataGrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OccupiesSlotsPanel As Panel
    Friend WithEvents TotalLotsPanel As Panel
    Friend WithEvents EmptyLotsPanel As Panel
    Friend WithEvents TotalSNumber As Label
    Friend WithEvents OccupiedSlots As Label
    Friend WithEvents FreeSlots As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UpdateButton As Button
End Class
