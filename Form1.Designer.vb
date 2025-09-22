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
        Me.RolesPermissionButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.ParkingViewButton = New System.Windows.Forms.Button()
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
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RolesPermissionButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.HistoryButton)
        Me.Panel1.Controls.Add(Me.ParkingViewButton)
        Me.Panel1.Controls.Add(Me.DashBoardButton)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 801)
        Me.Panel1.TabIndex = 0
        '
        'RolesPermissionButton
        '
        Me.RolesPermissionButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RolesPermissionButton.FlatAppearance.BorderSize = 0
        Me.RolesPermissionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RolesPermissionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RolesPermissionButton.Location = New System.Drawing.Point(0, 428)
        Me.RolesPermissionButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RolesPermissionButton.Name = "RolesPermissionButton"
        Me.RolesPermissionButton.Size = New System.Drawing.Size(269, 47)
        Me.RolesPermissionButton.TabIndex = 6
        Me.RolesPermissionButton.Text = "ROLES and PERMISSION"
        Me.RolesPermissionButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Black
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
        Me.Label1.Location = New System.Drawing.Point(49, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TitlePlaceHolder"
        '
        'HistoryButton
        '
        Me.HistoryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryButton.FlatAppearance.BorderSize = 0
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.HistoryButton.Location = New System.Drawing.Point(0, 325)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(269, 47)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "HISTORY"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'ParkingViewButton
        '
        Me.ParkingViewButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParkingViewButton.FlatAppearance.BorderSize = 0
        Me.ParkingViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParkingViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ParkingViewButton.Location = New System.Drawing.Point(0, 246)
        Me.ParkingViewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ParkingViewButton.Name = "ParkingViewButton"
        Me.ParkingViewButton.Size = New System.Drawing.Size(269, 47)
        Me.ParkingViewButton.TabIndex = 2
        Me.ParkingViewButton.Text = "PARKING VIEW"
        Me.ParkingViewButton.UseVisualStyleBackColor = True
        '
        'DashBoardButton
        '
        Me.DashBoardButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashBoardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.DashBoardButton.Location = New System.Drawing.Point(0, 169)
        Me.DashBoardButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.Size = New System.Drawing.Size(268, 47)
        Me.DashBoardButton.TabIndex = 1
        Me.DashBoardButton.Text = "DASHBOARD"
        Me.DashBoardButton.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(265, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1061, 801)
        Me.MainPanel.TabIndex = 2
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ParkingViewButton As Button
    Friend WithEvents DashBoardButton As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RolesPermissionButton As Button
    Public WithEvents MainPanel As Panel
End Class
