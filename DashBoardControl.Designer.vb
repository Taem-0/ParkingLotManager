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
        Me.ParkingLotDataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TotalLotsPanel = New System.Windows.Forms.Panel()
        Me.TotalSNumber = New System.Windows.Forms.Label()
        Me.EmptyLotsPanel = New System.Windows.Forms.Panel()
        Me.FreeNumber = New System.Windows.Forms.Label()
        Me.OccupiesSlotsPanel = New System.Windows.Forms.Panel()
        Me.OccupiedNumber = New System.Windows.Forms.Label()
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
        Me.ParkingLotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParkingLotDataGrid.Location = New System.Drawing.Point(0, 153)
        Me.ParkingLotDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ParkingLotDataGrid.Name = "ParkingLotDataGrid"
        Me.ParkingLotDataGrid.RowHeadersWidth = 51
        Me.ParkingLotDataGrid.Size = New System.Drawing.Size(1003, 586)
        Me.ParkingLotDataGrid.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, 118)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(201, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripLabel1.Text = "Check In"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel2.Text = "Check Out"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TotalLotsPanel)
        Me.Panel1.Controls.Add(Me.EmptyLotsPanel)
        Me.Panel1.Controls.Add(Me.OccupiesSlotsPanel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 114)
        Me.Panel1.TabIndex = 2
        '
        'TotalLotsPanel
        '
        Me.TotalLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalLotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.TotalLotsPanel.Controls.Add(Me.TotalSNumber)
        Me.TotalLotsPanel.Location = New System.Drawing.Point(92, 14)
        Me.TotalLotsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalLotsPanel.Name = "TotalLotsPanel"
        Me.TotalLotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.TotalLotsPanel.TabIndex = 1
        '
        'TotalSNumber
        '
        Me.TotalSNumber.AutoSize = True
        Me.TotalSNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSNumber.Location = New System.Drawing.Point(60, 23)
        Me.TotalSNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalSNumber.Name = "TotalSNumber"
        Me.TotalSNumber.Size = New System.Drawing.Size(136, 31)
        Me.TotalSNumber.TabIndex = 3
        Me.TotalSNumber.Text = "TotalSlots"
        '
        'EmptyLotsPanel
        '
        Me.EmptyLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmptyLotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.EmptyLotsPanel.Controls.Add(Me.FreeNumber)
        Me.EmptyLotsPanel.Location = New System.Drawing.Point(641, 14)
        Me.EmptyLotsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmptyLotsPanel.Name = "EmptyLotsPanel"
        Me.EmptyLotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.EmptyLotsPanel.TabIndex = 1
        '
        'FreeNumber
        '
        Me.FreeNumber.AutoSize = True
        Me.FreeNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeNumber.Location = New System.Drawing.Point(32, 23)
        Me.FreeNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FreeNumber.Name = "FreeNumber"
        Me.FreeNumber.Size = New System.Drawing.Size(190, 31)
        Me.FreeNumber.TabIndex = 5
        Me.FreeNumber.Text = "OccupiedSlots"
        '
        'OccupiesSlotsPanel
        '
        Me.OccupiesSlotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OccupiesSlotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.OccupiesSlotsPanel.Controls.Add(Me.OccupiedNumber)
        Me.OccupiesSlotsPanel.Location = New System.Drawing.Point(367, 14)
        Me.OccupiesSlotsPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OccupiesSlotsPanel.Name = "OccupiesSlotsPanel"
        Me.OccupiesSlotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.OccupiesSlotsPanel.TabIndex = 0
        '
        'OccupiedNumber
        '
        Me.OccupiedNumber.AutoSize = True
        Me.OccupiedNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupiedNumber.Location = New System.Drawing.Point(64, 23)
        Me.OccupiedNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OccupiedNumber.Name = "OccupiedNumber"
        Me.OccupiedNumber.Size = New System.Drawing.Size(131, 31)
        Me.OccupiedNumber.TabIndex = 4
        Me.OccupiedNumber.Text = "FreeSlots"
        '
        'DashBoardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ParkingLotDataGrid)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DashBoardControl"
        Me.Size = New System.Drawing.Size(1003, 799)
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OccupiesSlotsPanel As Panel
    Friend WithEvents TotalLotsPanel As Panel
    Friend WithEvents EmptyLotsPanel As Panel
    Friend WithEvents TotalSNumber As Label
    Friend WithEvents FreeNumber As Label
    Friend WithEvents OccupiedNumber As Label
End Class
