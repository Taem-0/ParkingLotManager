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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RolesPermissionButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.HistoryButton)
        Me.Panel1.Controls.Add(Me.ParkingViewButton)
        Me.Panel1.Controls.Add(Me.DashBoardButton)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 651)
        Me.Panel1.TabIndex = 0
        '
        'RolesPermissionButton
        '
        Me.RolesPermissionButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RolesPermissionButton.FlatAppearance.BorderSize = 0
        Me.RolesPermissionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RolesPermissionButton.Location = New System.Drawing.Point(0, 348)
        Me.RolesPermissionButton.Name = "RolesPermissionButton"
        Me.RolesPermissionButton.Size = New System.Drawing.Size(202, 38)
        Me.RolesPermissionButton.TabIndex = 6
        Me.RolesPermissionButton.Text = "ROLES and PERMISSION"
        Me.RolesPermissionButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 119)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TitlePlaceHolder"
        '
        'HistoryButton
        '
        Me.HistoryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryButton.FlatAppearance.BorderSize = 0
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Location = New System.Drawing.Point(0, 264)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(202, 38)
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
        Me.ParkingViewButton.Location = New System.Drawing.Point(0, 200)
        Me.ParkingViewButton.Name = "ParkingViewButton"
        Me.ParkingViewButton.Size = New System.Drawing.Size(202, 38)
        Me.ParkingViewButton.TabIndex = 2
        Me.ParkingViewButton.Text = "PARKING VIEW"
        Me.ParkingViewButton.UseVisualStyleBackColor = True
        '
        'DashBoardButton
        '
        Me.DashBoardButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DashBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBoardButton.Location = New System.Drawing.Point(0, 137)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.Size = New System.Drawing.Size(201, 38)
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
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(217, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(753, 651)
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
