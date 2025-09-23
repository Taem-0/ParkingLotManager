<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DB_stat = New System.Windows.Forms.Label()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.ParkingViewButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TotalLotsPanel = New System.Windows.Forms.Panel()
        Me.DashBoardButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.axiom_pattern
        Me.Panel1.Controls.Add(Me.DB_stat)
        Me.Panel1.Controls.Add(Me.HistoryButton)
        Me.Panel1.Controls.Add(Me.ParkingViewButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DashBoardButton)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 651)
        Me.Panel1.TabIndex = 0
        '
        'DB_stat
        '
        Me.DB_stat.AutoSize = True
        Me.DB_stat.BackColor = System.Drawing.Color.Transparent
        Me.DB_stat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DB_stat.Location = New System.Drawing.Point(0, 618)
        Me.DB_stat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DB_stat.Name = "DB_stat"
        Me.DB_stat.Padding = New System.Windows.Forms.Padding(8, 0, 0, 20)
        Me.DB_stat.Size = New System.Drawing.Size(53, 33)
        Me.DB_stat.TabIndex = 5
        Me.DB_stat.Text = "DB_stat"
        '
        'HistoryButton
        '
        Me.HistoryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.Location = New System.Drawing.Point(10, 262)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(181, 38)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "HISTORY"
        Me.HistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'ParkingViewButton
        '
        Me.ParkingViewButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParkingViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ParkingViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ParkingViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParkingViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParkingViewButton.Location = New System.Drawing.Point(10, 197)
        Me.ParkingViewButton.Name = "ParkingViewButton"
        Me.ParkingViewButton.Size = New System.Drawing.Size(181, 38)
        Me.ParkingViewButton.TabIndex = 2
        Me.ParkingViewButton.Text = "PARKING VIEW"
        Me.ParkingViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ParkingViewButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.TotalLotsPanel)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 119)
        Me.Panel3.TabIndex = 0
        '
        'TotalLotsPanel
        '
        Me.TotalLotsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalLotsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TotalLotsPanel.BackgroundImage = CType(resources.GetObject("TotalLotsPanel.BackgroundImage"), System.Drawing.Image)
        Me.TotalLotsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TotalLotsPanel.Location = New System.Drawing.Point(11, 30)
        Me.TotalLotsPanel.Name = "TotalLotsPanel"
        Me.TotalLotsPanel.Size = New System.Drawing.Size(181, 70)
        Me.TotalLotsPanel.TabIndex = 3
        '
        'DashBoardButton
        '
        Me.DashBoardButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBoardButton.Location = New System.Drawing.Point(10, 136)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.Size = New System.Drawing.Size(181, 38)
        Me.DashBoardButton.TabIndex = 1
        Me.DashBoardButton.Text = "DASHBOARD"
        Me.DashBoardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DashBoardButton.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.axiom_pattern
        Me.MainPanel.Location = New System.Drawing.Point(208, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(776, 651)
        Me.MainPanel.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(989, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARKABLE "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashBoardButton As Button
    Friend WithEvents Panel3 As Panel
    Public WithEvents MainPanel As Panel
    Friend WithEvents ParkingViewButton As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents DB_stat As Label
    Friend WithEvents TotalLotsPanel As Panel
End Class
