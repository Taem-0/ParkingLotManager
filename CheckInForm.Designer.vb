<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckInForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckInPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExButton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A5ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A6ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A7ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A8ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.A1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B5ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B6ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B7ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.B8ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.PlateNoTextBox = New System.Windows.Forms.TextBox()
        Me.PlateNumberLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckInPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 114)
        Me.Panel1.TabIndex = 2
        '
        'CheckInPanel
        '
        Me.CheckInPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckInPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckInPanel.Controls.Add(Me.Panel2)
        Me.CheckInPanel.Location = New System.Drawing.Point(0, 153)
        Me.CheckInPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckInPanel.Name = "CheckInPanel"
        Me.CheckInPanel.Size = New System.Drawing.Size(1003, 586)
        Me.CheckInPanel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Parking Slot:"
        '
        'ExButton
        '
        Me.ExButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExButton.Location = New System.Drawing.Point(382, 236)
        Me.ExButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExButton.Name = "ExButton"
        Me.ExButton.Size = New System.Drawing.Size(122, 36)
        Me.ExButton.TabIndex = 9
        Me.ExButton.Text = "Cancel"
        Me.ExButton.UseVisualStyleBackColor = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ConfirmButton.Location = New System.Drawing.Point(217, 236)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(122, 36)
        Me.ConfirmButton.TabIndex = 8
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(197, 170)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(294, 27)
        Me.ToolStrip1.TabIndex = 7
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
        Me.ToolStripDropDownButton1.Padding = New System.Windows.Forms.Padding(100, 0, 0, 0)
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(291, 24)
        Me.ToolStripDropDownButton1.Text = ".        Select Floor             ."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.A1ToolStripMenuItem, Me.A2ToolStripMenuItem, Me.A3ToolStripMenuItem, Me.A4ToolStripMenuItem, Me.A5ToolStripMenuItem, Me.A6ToolStripMenuItem, Me.A7ToolStripMenuItem, Me.A8ToolStripMenuItem, Me.B1ToolStripMenuItem, Me.B2ToolStripMenuItem, Me.B3ToolStripMenuItem, Me.B4ToolStripMenuItem, Me.B5ToolStripMenuItem, Me.B6ToolStripMenuItem, Me.B7ToolStripMenuItem, Me.B8ToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 26)
        Me.ToolStripMenuItem2.Tag = "1"
        Me.ToolStripMenuItem2.Text = "1st Floor"
        '
        'A1ToolStripMenuItem
        '
        Me.A1ToolStripMenuItem.Name = "A1ToolStripMenuItem"
        Me.A1ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A1ToolStripMenuItem.Text = "A1"
        '
        'A2ToolStripMenuItem
        '
        Me.A2ToolStripMenuItem.Name = "A2ToolStripMenuItem"
        Me.A2ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A2ToolStripMenuItem.Text = "A2"
        '
        'A3ToolStripMenuItem
        '
        Me.A3ToolStripMenuItem.Name = "A3ToolStripMenuItem"
        Me.A3ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A3ToolStripMenuItem.Text = "A3"
        '
        'A4ToolStripMenuItem
        '
        Me.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem"
        Me.A4ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A4ToolStripMenuItem.Text = "A4"
        '
        'A5ToolStripMenuItem
        '
        Me.A5ToolStripMenuItem.Name = "A5ToolStripMenuItem"
        Me.A5ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A5ToolStripMenuItem.Text = "A5"
        '
        'A6ToolStripMenuItem
        '
        Me.A6ToolStripMenuItem.Name = "A6ToolStripMenuItem"
        Me.A6ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A6ToolStripMenuItem.Text = "A6"
        '
        'A7ToolStripMenuItem
        '
        Me.A7ToolStripMenuItem.Name = "A7ToolStripMenuItem"
        Me.A7ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A7ToolStripMenuItem.Text = "A7"
        '
        'A8ToolStripMenuItem
        '
        Me.A8ToolStripMenuItem.Name = "A8ToolStripMenuItem"
        Me.A8ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.A8ToolStripMenuItem.Text = "A8"
        '
        'B1ToolStripMenuItem
        '
        Me.B1ToolStripMenuItem.Name = "B1ToolStripMenuItem"
        Me.B1ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B1ToolStripMenuItem.Text = "B1"
        '
        'B2ToolStripMenuItem
        '
        Me.B2ToolStripMenuItem.Name = "B2ToolStripMenuItem"
        Me.B2ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B2ToolStripMenuItem.Text = "B2"
        '
        'B3ToolStripMenuItem
        '
        Me.B3ToolStripMenuItem.Name = "B3ToolStripMenuItem"
        Me.B3ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B3ToolStripMenuItem.Text = "B3"
        '
        'B4ToolStripMenuItem
        '
        Me.B4ToolStripMenuItem.Name = "B4ToolStripMenuItem"
        Me.B4ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B4ToolStripMenuItem.Text = "B4"
        '
        'B5ToolStripMenuItem
        '
        Me.B5ToolStripMenuItem.Name = "B5ToolStripMenuItem"
        Me.B5ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B5ToolStripMenuItem.Text = "B5"
        '
        'B6ToolStripMenuItem
        '
        Me.B6ToolStripMenuItem.Name = "B6ToolStripMenuItem"
        Me.B6ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B6ToolStripMenuItem.Text = "B6"
        '
        'B7ToolStripMenuItem
        '
        Me.B7ToolStripMenuItem.Name = "B7ToolStripMenuItem"
        Me.B7ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B7ToolStripMenuItem.Text = "B7"
        '
        'B8ToolStripMenuItem
        '
        Me.B8ToolStripMenuItem.Name = "B8ToolStripMenuItem"
        Me.B8ToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.B8ToolStripMenuItem.Text = "B8"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.A1ToolStripMenuItem1, Me.A2ToolStripMenuItem1, Me.A3ToolStripMenuItem1, Me.A4ToolStripMenuItem1, Me.A5ToolStripMenuItem1, Me.A6ToolStripMenuItem1, Me.A7ToolStripMenuItem1, Me.A8ToolStripMenuItem1, Me.A1ToolStripMenuItem2, Me.B2ToolStripMenuItem1, Me.B3ToolStripMenuItem1, Me.B4ToolStripMenuItem1, Me.B5ToolStripMenuItem1, Me.B6ToolStripMenuItem1, Me.B7ToolStripMenuItem1, Me.B8ToolStripMenuItem1})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 26)
        Me.ToolStripMenuItem3.Tag = "2"
        Me.ToolStripMenuItem3.Text = "2nd Floor"
        '
        'A1ToolStripMenuItem1
        '
        Me.A1ToolStripMenuItem1.Name = "A1ToolStripMenuItem1"
        Me.A1ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A1ToolStripMenuItem1.Text = "A1"
        '
        'A2ToolStripMenuItem1
        '
        Me.A2ToolStripMenuItem1.Name = "A2ToolStripMenuItem1"
        Me.A2ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A2ToolStripMenuItem1.Text = "A2"
        '
        'A3ToolStripMenuItem1
        '
        Me.A3ToolStripMenuItem1.Name = "A3ToolStripMenuItem1"
        Me.A3ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A3ToolStripMenuItem1.Text = "A3"
        '
        'A4ToolStripMenuItem1
        '
        Me.A4ToolStripMenuItem1.Name = "A4ToolStripMenuItem1"
        Me.A4ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A4ToolStripMenuItem1.Text = "A4"
        '
        'A5ToolStripMenuItem1
        '
        Me.A5ToolStripMenuItem1.Name = "A5ToolStripMenuItem1"
        Me.A5ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A5ToolStripMenuItem1.Text = "A5"
        '
        'A6ToolStripMenuItem1
        '
        Me.A6ToolStripMenuItem1.Name = "A6ToolStripMenuItem1"
        Me.A6ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A6ToolStripMenuItem1.Text = "A6"
        '
        'A7ToolStripMenuItem1
        '
        Me.A7ToolStripMenuItem1.Name = "A7ToolStripMenuItem1"
        Me.A7ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A7ToolStripMenuItem1.Text = "A7"
        '
        'A8ToolStripMenuItem1
        '
        Me.A8ToolStripMenuItem1.Name = "A8ToolStripMenuItem1"
        Me.A8ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.A8ToolStripMenuItem1.Text = "A8"
        '
        'A1ToolStripMenuItem2
        '
        Me.A1ToolStripMenuItem2.Name = "A1ToolStripMenuItem2"
        Me.A1ToolStripMenuItem2.Size = New System.Drawing.Size(110, 26)
        Me.A1ToolStripMenuItem2.Text = "B1"
        '
        'B2ToolStripMenuItem1
        '
        Me.B2ToolStripMenuItem1.Name = "B2ToolStripMenuItem1"
        Me.B2ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B2ToolStripMenuItem1.Text = "B2"
        '
        'B3ToolStripMenuItem1
        '
        Me.B3ToolStripMenuItem1.Name = "B3ToolStripMenuItem1"
        Me.B3ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B3ToolStripMenuItem1.Text = "B3"
        '
        'B4ToolStripMenuItem1
        '
        Me.B4ToolStripMenuItem1.Name = "B4ToolStripMenuItem1"
        Me.B4ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B4ToolStripMenuItem1.Text = "B4"
        '
        'B5ToolStripMenuItem1
        '
        Me.B5ToolStripMenuItem1.Name = "B5ToolStripMenuItem1"
        Me.B5ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B5ToolStripMenuItem1.Text = "B5"
        '
        'B6ToolStripMenuItem1
        '
        Me.B6ToolStripMenuItem1.Name = "B6ToolStripMenuItem1"
        Me.B6ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B6ToolStripMenuItem1.Text = "B6"
        '
        'B7ToolStripMenuItem1
        '
        Me.B7ToolStripMenuItem1.Name = "B7ToolStripMenuItem1"
        Me.B7ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B7ToolStripMenuItem1.Text = "B7"
        '
        'B8ToolStripMenuItem1
        '
        Me.B8ToolStripMenuItem1.Name = "B8ToolStripMenuItem1"
        Me.B8ToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.B8ToolStripMenuItem1.Text = "B8"
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwnerTextBox.Location = New System.Drawing.Point(197, 118)
        Me.OwnerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(345, 32)
        Me.OwnerTextBox.TabIndex = 3
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwnerLabel.Location = New System.Drawing.Point(49, 115)
        Me.OwnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(140, 34)
        Me.OwnerLabel.TabIndex = 2
        Me.OwnerLabel.Text = "Owner: "
        '
        'PlateNoTextBox
        '
        Me.PlateNoTextBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNoTextBox.Location = New System.Drawing.Point(197, 55)
        Me.PlateNoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlateNoTextBox.Name = "PlateNoTextBox"
        Me.PlateNoTextBox.Size = New System.Drawing.Size(345, 32)
        Me.PlateNoTextBox.TabIndex = 1
        '
        'PlateNumberLabel
        '
        Me.PlateNumberLabel.AutoSize = True
        Me.PlateNumberLabel.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNumberLabel.Location = New System.Drawing.Point(8, 55)
        Me.PlateNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlateNumberLabel.Name = "PlateNumberLabel"
        Me.PlateNumberLabel.Size = New System.Drawing.Size(191, 34)
        Me.PlateNumberLabel.TabIndex = 0
        Me.PlateNumberLabel.Text = "Plate No. : "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PlateNumberLabel)
        Me.Panel2.Controls.Add(Me.ExButton)
        Me.Panel2.Controls.Add(Me.PlateNoTextBox)
        Me.Panel2.Controls.Add(Me.ConfirmButton)
        Me.Panel2.Controls.Add(Me.OwnerLabel)
        Me.Panel2.Controls.Add(Me.OwnerTextBox)
        Me.Panel2.Location = New System.Drawing.Point(203, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 376)
        Me.Panel2.TabIndex = 11
        '
        'CheckInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckInPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CheckInForm"
        Me.Size = New System.Drawing.Size(1003, 799)
        Me.CheckInPanel.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents A1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents A2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A4ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A5ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A6ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A7ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A8ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A1ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents B2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B4ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B5ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B6ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B7ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents B8ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents A1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
