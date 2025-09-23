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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HistoryDataGrid = New System.Windows.Forms.DataGridView()
        Me.HistoryToolPanel = New System.Windows.Forms.Panel()
        CType(Me.HistoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HistoryDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.HistoryDataGrid.Location = New System.Drawing.Point(0, 78)
        Me.HistoryDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HistoryDataGrid.Name = "HistoryDataGrid"
        Me.HistoryDataGrid.RowHeadersWidth = 51
        Me.HistoryDataGrid.Size = New System.Drawing.Size(1003, 661)
        Me.HistoryDataGrid.TabIndex = 0
        '
        'HistoryToolPanel
        '
        Me.HistoryToolPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryToolPanel.BackColor = System.Drawing.Color.Transparent
        Me.HistoryToolPanel.BackgroundImage = Global.ParkingLotManager.My.Resources.Resources.Untitled
        Me.HistoryToolPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HistoryToolPanel.Location = New System.Drawing.Point(4, 20)
        Me.HistoryToolPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.HistoryToolPanel.Name = "HistoryToolPanel"
        Me.HistoryToolPanel.Size = New System.Drawing.Size(995, 50)
        Me.HistoryToolPanel.TabIndex = 1
        '
        'HistoryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.HistoryToolPanel)
        Me.Controls.Add(Me.HistoryDataGrid)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HistoryControl"
        Me.Size = New System.Drawing.Size(1003, 799)
        CType(Me.HistoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HistoryDataGrid As DataGridView
    Friend WithEvents HistoryToolPanel As Panel
End Class