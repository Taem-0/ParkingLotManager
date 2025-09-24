<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckInPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PlateNumberLabel = New System.Windows.Forms.Label()
        Me.ExButton = New System.Windows.Forms.Button()
        Me.PlateNoTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.CheckInPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.axiom_pattern
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 93)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(294, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UPDATE"
        '
        'CheckInPanel
        '
        Me.CheckInPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckInPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckInPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.axiom_pattern
        Me.CheckInPanel.Controls.Add(Me.Panel2)
        Me.CheckInPanel.Location = New System.Drawing.Point(0, 124)
        Me.CheckInPanel.Name = "CheckInPanel"
        Me.CheckInPanel.Size = New System.Drawing.Size(752, 476)
        Me.CheckInPanel.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PlateNumberLabel)
        Me.Panel2.Controls.Add(Me.ExButton)
        Me.Panel2.Controls.Add(Me.PlateNoTextBox)
        Me.Panel2.Controls.Add(Me.ConfirmButton)
        Me.Panel2.Controls.Add(Me.OwnerLabel)
        Me.Panel2.Controls.Add(Me.OwnerTextBox)
        Me.Panel2.Location = New System.Drawing.Point(167, 24)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 375)
        Me.Panel2.TabIndex = 11
        '
        'PlateNumberLabel
        '
        Me.PlateNumberLabel.AutoSize = True
        Me.PlateNumberLabel.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNumberLabel.Location = New System.Drawing.Point(-2, 45)
        Me.PlateNumberLabel.Name = "PlateNumberLabel"
        Me.PlateNumberLabel.Size = New System.Drawing.Size(151, 26)
        Me.PlateNumberLabel.TabIndex = 0
        Me.PlateNumberLabel.Text = "Plate No. : "
        '
        'ExButton
        '
        Me.ExButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExButton.Location = New System.Drawing.Point(286, 192)
        Me.ExButton.Name = "ExButton"
        Me.ExButton.Size = New System.Drawing.Size(92, 29)
        Me.ExButton.TabIndex = 9
        Me.ExButton.Text = "Cancel"
        Me.ExButton.UseVisualStyleBackColor = False
        '
        'PlateNoTextBox
        '
        Me.PlateNoTextBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNoTextBox.Location = New System.Drawing.Point(148, 45)
        Me.PlateNoTextBox.Name = "PlateNoTextBox"
        Me.PlateNoTextBox.Size = New System.Drawing.Size(260, 27)
        Me.PlateNoTextBox.TabIndex = 1
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmButton.Location = New System.Drawing.Point(163, 192)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(92, 29)
        Me.ConfirmButton.TabIndex = 8
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwnerLabel.Location = New System.Drawing.Point(37, 93)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(112, 26)
        Me.OwnerLabel.TabIndex = 2
        Me.OwnerLabel.Text = "Owner: "
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwnerTextBox.Location = New System.Drawing.Point(148, 96)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(260, 27)
        Me.OwnerTextBox.TabIndex = 3
        '
        'UpdateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckInPanel)
        Me.Name = "UpdateControl"
        Me.Size = New System.Drawing.Size(752, 649)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CheckInPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckInPanel As Panel
    Friend WithEvents PlateNumberLabel As Label
    Friend WithEvents PlateNoTextBox As TextBox
    Friend WithEvents OwnerTextBox As TextBox
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents ExButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
