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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.ParkingViewButton = New System.Windows.Forms.Button()
        Me.RolesPermissionButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DashBoardButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.HistoryButton)
        Me.Panel1.Controls.Add(Me.ParkingViewButton)
        Me.Panel1.Controls.Add(Me.RolesPermissionButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DashBoardButton)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 801)
        Me.Panel1.TabIndex = 0
        '
        'HistoryButton
        '
        Me.HistoryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.Location = New System.Drawing.Point(13, 323)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(241, 47)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "HISTORY"
        Me.HistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'ParkingViewButton
        '
        Me.ParkingViewButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParkingViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ParkingViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParkingViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParkingViewButton.Location = New System.Drawing.Point(13, 243)
        Me.ParkingViewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ParkingViewButton.Name = "ParkingViewButton"
        Me.ParkingViewButton.Size = New System.Drawing.Size(241, 47)
        Me.ParkingViewButton.TabIndex = 2
        Me.ParkingViewButton.Text = "PARKING VIEW"
        Me.ParkingViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ParkingViewButton.UseVisualStyleBackColor = True
        '
        'RolesPermissionButton
        '
        Me.RolesPermissionButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RolesPermissionButton.FlatAppearance.BorderSize = 0
        Me.RolesPermissionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RolesPermissionButton.Location = New System.Drawing.Point(0, 428)
        Me.RolesPermissionButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RolesPermissionButton.Name = "RolesPermissionButton"
        Me.RolesPermissionButton.Size = New System.Drawing.Size(269, 47)
        Me.RolesPermissionButton.TabIndex = 4
        Me.RolesPermissionButton.Text = "ROLES and PERMISSION"
        Me.RolesPermissionButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 146)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TitlePlaceHolder"
        '
        'DashBoardButton
        '
        Me.DashBoardButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBoardButton.Location = New System.Drawing.Point(13, 168)
        Me.DashBoardButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.Size = New System.Drawing.Size(241, 47)
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
        Me.MainPanel.Location = New System.Drawing.Point(277, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1034, 801)
        Me.MainPanel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 758)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1319, 801)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashBoardButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RolesPermissionButton As Button
    Public WithEvents MainPanel As Panel
    Friend WithEvents ParkingViewButton As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents Label2 As Label
End Class
