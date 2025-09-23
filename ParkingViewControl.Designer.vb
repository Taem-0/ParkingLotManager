<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParkingViewControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParkingViewControl))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.B8 = New System.Windows.Forms.Label()
        Me.B4 = New System.Windows.Forms.Label()
        Me.B7 = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.Label()
        Me.B6 = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.Label()
        Me.B5 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.A8 = New System.Windows.Forms.Label()
        Me.A4 = New System.Windows.Forms.Label()
        Me.A7 = New System.Windows.Forms.Label()
        Me.A3 = New System.Windows.Forms.Label()
        Me.A6 = New System.Windows.Forms.Label()
        Me.A2 = New System.Windows.Forms.Label()
        Me.A5 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EntryLabel = New System.Windows.Forms.Label()
        Me.ExitLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 114)
        Me.Panel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(230, 22)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(427, 67)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripDropDownButton1.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(385, 64)
        Me.ToolStripDropDownButton1.Text = "Floor 1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(50, 1, 0, 1)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(441, 64)
        Me.ToolStripMenuItem2.Tag = "1"
        Me.ToolStripMenuItem2.Text = "1st Floor"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(391, 64)
        Me.ToolStripMenuItem3.Tag = "2"
        Me.ToolStripMenuItem3.Text = "2nd Floor"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.B8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.B4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.B7, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.B3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.B6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.B2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.B5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.B1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(585, 143)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(258, 286)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'B8
        '
        Me.B8.AutoSize = True
        Me.B8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B8.Location = New System.Drawing.Point(133, 214)
        Me.B8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(120, 71)
        Me.B8.TabIndex = 9
        Me.B8.Text = "B8"
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B4.Location = New System.Drawing.Point(5, 214)
        Me.B4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(119, 71)
        Me.B4.TabIndex = 8
        Me.B4.Text = "B4"
        '
        'B7
        '
        Me.B7.AutoSize = True
        Me.B7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B7.Location = New System.Drawing.Point(133, 143)
        Me.B7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(120, 70)
        Me.B7.TabIndex = 7
        Me.B7.Text = "B7"
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B3.Location = New System.Drawing.Point(5, 143)
        Me.B3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(119, 70)
        Me.B3.TabIndex = 6
        Me.B3.Text = "B3"
        '
        'B6
        '
        Me.B6.AutoSize = True
        Me.B6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B6.Location = New System.Drawing.Point(133, 72)
        Me.B6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(120, 70)
        Me.B6.TabIndex = 5
        Me.B6.Text = "B6"
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B2.Location = New System.Drawing.Point(5, 72)
        Me.B2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(119, 70)
        Me.B2.TabIndex = 4
        Me.B2.Text = "B2"
        '
        'B5
        '
        Me.B5.AutoSize = True
        Me.B5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B5.Location = New System.Drawing.Point(133, 1)
        Me.B5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(120, 70)
        Me.B5.TabIndex = 3
        Me.B5.Text = "B5"
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B1.Location = New System.Drawing.Point(5, 1)
        Me.B1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(119, 70)
        Me.B1.TabIndex = 2
        Me.B1.Text = "B1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.A8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.A4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.A7, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A6, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.A1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(156, 143)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(257, 286)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'A8
        '
        Me.A8.AutoSize = True
        Me.A8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A8.Location = New System.Drawing.Point(133, 214)
        Me.A8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A8.Name = "A8"
        Me.A8.Size = New System.Drawing.Size(119, 71)
        Me.A8.TabIndex = 7
        Me.A8.Text = "A8"
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A4.Location = New System.Drawing.Point(5, 214)
        Me.A4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(119, 71)
        Me.A4.TabIndex = 6
        Me.A4.Text = "A4"
        '
        'A7
        '
        Me.A7.AutoSize = True
        Me.A7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A7.Location = New System.Drawing.Point(133, 143)
        Me.A7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A7.Name = "A7"
        Me.A7.Size = New System.Drawing.Size(119, 70)
        Me.A7.TabIndex = 5
        Me.A7.Text = "A7"
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A3.Location = New System.Drawing.Point(5, 143)
        Me.A3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(119, 70)
        Me.A3.TabIndex = 4
        Me.A3.Text = "A3"
        '
        'A6
        '
        Me.A6.AutoSize = True
        Me.A6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A6.Location = New System.Drawing.Point(133, 72)
        Me.A6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A6.Name = "A6"
        Me.A6.Size = New System.Drawing.Size(119, 70)
        Me.A6.TabIndex = 3
        Me.A6.Text = "A6"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A2.Location = New System.Drawing.Point(5, 72)
        Me.A2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(119, 70)
        Me.A2.TabIndex = 2
        Me.A2.Text = "A2"
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A5.Location = New System.Drawing.Point(133, 1)
        Me.A5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(119, 70)
        Me.A5.TabIndex = 1
        Me.A5.Text = "A5"
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A1.Location = New System.Drawing.Point(5, 1)
        Me.A1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(119, 70)
        Me.A1.TabIndex = 0
        Me.A1.Text = "A1"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15957!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.46277!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35638!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59575!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42553!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.7395!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.21008!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05042!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1003, 586)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel3.Location = New System.Drawing.Point(985, 32)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(17, 63)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(985, 476)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(17, 63)
        Me.Panel4.TabIndex = 3
        '
        'EntryLabel
        '
        Me.EntryLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryLabel.AutoSize = True
        Me.EntryLabel.Location = New System.Drawing.Point(936, 58)
        Me.EntryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EntryLabel.Name = "EntryLabel"
        Me.EntryLabel.Size = New System.Drawing.Size(37, 16)
        Me.EntryLabel.TabIndex = 4
        Me.EntryLabel.Text = "Entry"
        '
        'ExitLabel
        '
        Me.ExitLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitLabel.AutoSize = True
        Me.ExitLabel.Location = New System.Drawing.Point(936, 503)
        Me.ExitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExitLabel.Name = "ExitLabel"
        Me.ExitLabel.Size = New System.Drawing.Size(28, 16)
        Me.ExitLabel.TabIndex = 5
        Me.ExitLabel.Text = "Exit"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.ExitLabel)
        Me.Panel2.Controls.Add(Me.EntryLabel)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 153)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1003, 586)
        Me.Panel2.TabIndex = 2
        '
        'ParkingViewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ParkingViewControl"
        Me.Size = New System.Drawing.Size(1003, 799)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents B8 As Label
    Friend WithEvents B4 As Label
    Friend WithEvents B7 As Label
    Friend WithEvents B3 As Label
    Friend WithEvents B6 As Label
    Friend WithEvents B2 As Label
    Friend WithEvents B5 As Label
    Friend WithEvents B1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents A8 As Label
    Friend WithEvents A4 As Label
    Friend WithEvents A7 As Label
    Friend WithEvents A3 As Label
    Friend WithEvents A6 As Label
    Friend WithEvents A2 As Label
    Friend WithEvents A5 As Label
    Friend WithEvents A1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents EntryLabel As Label
    Friend WithEvents ExitLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
