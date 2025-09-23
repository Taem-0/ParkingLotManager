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
        Me.ParkingLotDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ParkingLotDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParkingLotDataGrid.Location = New System.Drawing.Point(0, 153)
        Me.ParkingLotDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.ParkingLotDataGrid.Name = "ParkingLotDataGrid"
        Me.ParkingLotDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ParkingLotDataGrid.RowHeadersVisible = False
        Me.ParkingLotDataGrid.RowHeadersWidth = 51
        Me.ParkingLotDataGrid.Size = New System.Drawing.Size(1003, 586)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 114)
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
        Me.TotalLotsPanel.Location = New System.Drawing.Point(92, 14)
        Me.TotalLotsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalLotsPanel.Name = "TotalLotsPanel"
        Me.TotalLotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.TotalLotsPanel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Slots"
        '
        'TotalSNumber
        '
        Me.TotalSNumber.AutoSize = True
        Me.TotalSNumber.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSNumber.ForeColor = System.Drawing.Color.Transparent
        Me.TotalSNumber.Location = New System.Drawing.Point(23, 10)
        Me.TotalSNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalSNumber.Name = "TotalSNumber"
        Me.TotalSNumber.Size = New System.Drawing.Size(72, 45)
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
        Me.EmptyLotsPanel.Location = New System.Drawing.Point(641, 14)
        Me.EmptyLotsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.EmptyLotsPanel.Name = "EmptyLotsPanel"
        Me.EmptyLotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.EmptyLotsPanel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(22, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Occupied Slots"
        '
        'OccupiedSlots
        '
        Me.OccupiedSlots.AutoSize = True
        Me.OccupiedSlots.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupiedSlots.ForeColor = System.Drawing.Color.White
        Me.OccupiedSlots.Location = New System.Drawing.Point(28, 10)
        Me.OccupiedSlots.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OccupiedSlots.Name = "OccupiedSlots"
        Me.OccupiedSlots.Size = New System.Drawing.Size(46, 45)
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
        Me.OccupiesSlotsPanel.Location = New System.Drawing.Point(367, 14)
        Me.OccupiesSlotsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.OccupiesSlotsPanel.Name = "OccupiesSlotsPanel"
        Me.OccupiesSlotsPanel.Size = New System.Drawing.Size(267, 86)
        Me.OccupiesSlotsPanel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Free Slots"
        '
        'FreeSlots
        '
        Me.FreeSlots.AutoSize = True
        Me.FreeSlots.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSlots.ForeColor = System.Drawing.Color.White
        Me.FreeSlots.Location = New System.Drawing.Point(24, 10)
        Me.FreeSlots.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FreeSlots.Name = "FreeSlots"
        Me.FreeSlots.Size = New System.Drawing.Size(46, 45)
        Me.FreeSlots.TabIndex = 4
        Me.FreeSlots.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check In   →"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(641, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 62)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Check Out ←"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 737)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(100, 0, 100, 0)
        Me.Panel2.Size = New System.Drawing.Size(1003, 62)
        Me.Panel2.TabIndex = 5
        '
        'DashBoardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ParkingLotDataGrid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashBoardControl"
        Me.Size = New System.Drawing.Size(1003, 799)
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
End Class
