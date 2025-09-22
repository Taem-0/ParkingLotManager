<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoryControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryControl))
        Me.HistoryDataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SortByLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SortByDropDown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.FilterLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolPanel = New System.Windows.Forms.Panel()
        CType(Me.HistoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.HistoryToolPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistoryDataGrid
        '
        Me.HistoryDataGrid.AllowUserToOrderColumns = True
        Me.HistoryDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.HistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryDataGrid.Location = New System.Drawing.Point(0, 78)
        Me.HistoryDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HistoryDataGrid.Name = "HistoryDataGrid"
        Me.HistoryDataGrid.RowHeadersWidth = 51
        Me.HistoryDataGrid.Size = New System.Drawing.Size(1003, 661)
        Me.HistoryDataGrid.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortByLabel, Me.SortByDropDown})
        Me.ToolStrip1.Location = New System.Drawing.Point(910, 10)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(76, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SortByLabel
        '
        Me.SortByLabel.Name = "SortByLabel"
        Me.SortByLabel.Size = New System.Drawing.Size(59, 22)
        Me.SortByLabel.Text = "Sort By:"
        '
        'SortByDropDown
        '
        Me.SortByDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SortByDropDown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DurationToolStripMenuItem, Me.DateToolStripMenuItem, Me.SlotToolStripMenuItem})
        Me.SortByDropDown.Image = CType(resources.GetObject("SortByDropDown.Image"), System.Drawing.Image)
        Me.SortByDropDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SortByDropDown.Name = "SortByDropDown"
        Me.SortByDropDown.Size = New System.Drawing.Size(14, 22)
        '
        'DurationToolStripMenuItem
        '
        Me.DurationToolStripMenuItem.Name = "DurationToolStripMenuItem"
        Me.DurationToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.DurationToolStripMenuItem.Text = "Duration"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.DateToolStripMenuItem.Text = "Date"
        '
        'SlotToolStripMenuItem
        '
        Me.SlotToolStripMenuItem.Name = "SlotToolStripMenuItem"
        Me.SlotToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.SlotToolStripMenuItem.Text = "Slot No."
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterLabel, Me.ToolStripDropDownButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(829, 10)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(62, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'FilterLabel
        '
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(45, 22)
        Me.FilterLabel.Text = "Filter:"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(14, 22)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 26)
        Me.ToolStripMenuItem1.Text = "Vehicle Type"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 26)
        Me.ToolStripMenuItem2.Text = "Floor"
        '
        'HistoryToolPanel
        '
        Me.HistoryToolPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryToolPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.HistoryToolPanel.Controls.Add(Me.ToolStrip2)
        Me.HistoryToolPanel.Controls.Add(Me.ToolStrip1)
        Me.HistoryToolPanel.Location = New System.Drawing.Point(0, 20)
        Me.HistoryToolPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HistoryToolPanel.Name = "HistoryToolPanel"
        Me.HistoryToolPanel.Size = New System.Drawing.Size(1003, 50)
        Me.HistoryToolPanel.TabIndex = 1
        '
        'HistoryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Controls.Add(Me.HistoryToolPanel)
        Me.Controls.Add(Me.HistoryDataGrid)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HistoryControl"
        Me.Size = New System.Drawing.Size(1003, 799)
        CType(Me.HistoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.HistoryToolPanel.ResumeLayout(False)
        Me.HistoryToolPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HistoryDataGrid As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SortByLabel As ToolStripLabel
    Friend WithEvents SortByDropDown As ToolStripDropDownButton
    Friend WithEvents DurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SlotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents FilterLabel As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HistoryToolPanel As Panel
End Class