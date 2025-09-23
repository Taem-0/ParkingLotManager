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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoardControl))
        Me.ParkingLotDataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CheckInButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CheckOutButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLotsPanel = New System.Windows.Forms.Panel()
        Me.TotalSNumber = New System.Windows.Forms.Label()
        Me.EmptyLotsPanel = New System.Windows.Forms.Panel()
        Me.OccupiedSlots = New System.Windows.Forms.Label()
        Me.OccupiesSlotsPanel = New System.Windows.Forms.Panel()
        Me.FreeSlots = New System.Windows.Forms.Label()
        CType(Me.ParkingLotDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TotalLotsPanel.SuspendLayout()
        Me.EmptyLotsPanel.SuspendLayout()
        Me.OccupiesSlotsPanel.SuspendLayout()
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
        Me.ParkingLotDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ParkingLotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Me.ParkingLotDataGrid.Location = New System.Drawing.Point(0, 124)
        Me.ParkingLotDataGrid.Name = "ParkingLotDataGrid"
        Me.ParkingLotDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ParkingLotDataGrid.RowHeadersVisible = False
        Me.ParkingLotDataGrid.RowHeadersWidth = 51
        Me.ParkingLotDataGrid.Size = New System.Drawing.Size(752, 476)
        Me.ParkingLotDataGrid.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInButton, Me.ToolStripLabel1, Me.CheckOutButton, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional

        Me.ToolStrip1.Size = New System.Drawing.Size(165, 25)

        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CheckInButton
        '
        Me.CheckInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckInButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(23, 22)
        Me.CheckInButton.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel1.Text = "Check In"
        '
        'CheckOutButton
        '
        Me.CheckOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckOutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(23, 22)
        Me.CheckOutButton.Text = "ToolStripButton2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel2.Text = "Check Out"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
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
        Me.TotalLotsPanel.BackgroundImage = CType(resources.GetObject("TotalLotsPanel.BackgroundImage"), System.Drawing.Image)
        Me.TotalLotsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TotalLotsPanel.Controls.Add(Me.TotalSNumber)

        Me.TotalLotsPanel.Location = New System.Drawing.Point(69, 11)
        Me.TotalLotsPanel.Name = "TotalLotsPanel"
        Me.TotalLotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.TotalLotsPanel.TabIndex = 1
        '
        'TotalSNumber
        '
        Me.TotalSNumber.AutoSize = True
        Me.TotalSNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSNumber.Location = New System.Drawing.Point(79, 19)
        Me.TotalSNumber.Name = "TotalSNumber"
        Me.TotalSNumber.Size = New System.Drawing.Size(36, 25)
        Me.TotalSNumber.TabIndex = 3
        Me.TotalSNumber.Text = "32"
        '
        'EmptyLotsPanel
        '
        Me.EmptyLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmptyLotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.EmptyLotsPanel.Controls.Add(Me.OccupiedSlots)
        Me.EmptyLotsPanel.Location = New System.Drawing.Point(481, 11)
        Me.EmptyLotsPanel.Name = "EmptyLotsPanel"
        Me.EmptyLotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.EmptyLotsPanel.TabIndex = 1
        '
        'OccupiedSlots
        '
        Me.OccupiedSlots.AutoSize = True
        Me.OccupiedSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupiedSlots.Location = New System.Drawing.Point(83, 19)
        Me.OccupiedSlots.Name = "OccupiedSlots"
        Me.OccupiedSlots.Size = New System.Drawing.Size(24, 25)
        Me.OccupiedSlots.TabIndex = 5
        Me.OccupiedSlots.Text = "0"
        '
        'OccupiesSlotsPanel
        '
        Me.OccupiesSlotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OccupiesSlotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.OccupiesSlotsPanel.Controls.Add(Me.FreeSlots)
        Me.OccupiesSlotsPanel.Location = New System.Drawing.Point(275, 11)
        Me.OccupiesSlotsPanel.Name = "OccupiesSlotsPanel"
        Me.OccupiesSlotsPanel.Size = New System.Drawing.Size(200, 70)
        Me.OccupiesSlotsPanel.TabIndex = 0
        '
        'FreeSlots
        '
        Me.FreeSlots.AutoSize = True
        Me.FreeSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSlots.Location = New System.Drawing.Point(89, 19)
        Me.FreeSlots.Name = "FreeSlots"
        Me.FreeSlots.Size = New System.Drawing.Size(24, 25)
        Me.FreeSlots.TabIndex = 4
        Me.FreeSlots.Text = "0"
        '
        'DashBoardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ParkingLotDataGrid)
        Me.Name = "DashBoardControl"
        Me.Size = New System.Drawing.Size(752, 649)
        CType(Me.ParkingLotDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TotalLotsPanel.ResumeLayout(False)
        Me.TotalLotsPanel.PerformLayout()
        Me.EmptyLotsPanel.ResumeLayout(False)
        Me.EmptyLotsPanel.PerformLayout()
        Me.OccupiesSlotsPanel.ResumeLayout(False)
        Me.OccupiesSlotsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ParkingLotDataGrid As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CheckInButton As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CheckOutButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OccupiesSlotsPanel As Panel
    Friend WithEvents TotalLotsPanel As Panel
    Friend WithEvents EmptyLotsPanel As Panel
    Friend WithEvents TotalSNumber As Label
    Friend WithEvents OccupiedSlots As Label
    Friend WithEvents FreeSlots As Label
End Class
