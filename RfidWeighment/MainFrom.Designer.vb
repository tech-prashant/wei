<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GATEENTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WEIGHINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONFIGURATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STWEIGHTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NDWEIGHTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOTALWEIGHTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 612)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1110, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel1.Text = "Date"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Time"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATABASEToolStripMenuItem, Me.GATEENTRYToolStripMenuItem, Me.WEIGHINGToolStripMenuItem, Me.CONFIGURATIONToolStripMenuItem, Me.REPRINTToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATABASEToolStripMenuItem
        '
        Me.DATABASEToolStripMenuItem.Name = "DATABASEToolStripMenuItem"
        Me.DATABASEToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DATABASEToolStripMenuItem.Text = "DATABASE"
        '
        'GATEENTRYToolStripMenuItem
        '
        Me.GATEENTRYToolStripMenuItem.Name = "GATEENTRYToolStripMenuItem"
        Me.GATEENTRYToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.GATEENTRYToolStripMenuItem.Text = "GATE ENTRY"
        '
        'WEIGHINGToolStripMenuItem
        '
        Me.WEIGHINGToolStripMenuItem.Name = "WEIGHINGToolStripMenuItem"
        Me.WEIGHINGToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.WEIGHINGToolStripMenuItem.Text = "WEIGHING"
        '
        'CONFIGURATIONToolStripMenuItem
        '
        Me.CONFIGURATIONToolStripMenuItem.Name = "CONFIGURATIONToolStripMenuItem"
        Me.CONFIGURATIONToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.CONFIGURATIONToolStripMenuItem.Text = "CONFIGURATION"
        '
        'REPRINTToolStripMenuItem
        '
        Me.REPRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STWEIGHTToolStripMenuItem, Me.NDWEIGHTToolStripMenuItem, Me.TOTALWEIGHTToolStripMenuItem})
        Me.REPRINTToolStripMenuItem.Name = "REPRINTToolStripMenuItem"
        Me.REPRINTToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.REPRINTToolStripMenuItem.Text = "REPRINT"
        '
        'STWEIGHTToolStripMenuItem
        '
        Me.STWEIGHTToolStripMenuItem.Name = "STWEIGHTToolStripMenuItem"
        Me.STWEIGHTToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.STWEIGHTToolStripMenuItem.Text = "1ST WEIGHT"
        '
        'NDWEIGHTToolStripMenuItem
        '
        Me.NDWEIGHTToolStripMenuItem.Name = "NDWEIGHTToolStripMenuItem"
        Me.NDWEIGHTToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NDWEIGHTToolStripMenuItem.Text = "2ND WEIGHT"
        '
        'TOTALWEIGHTToolStripMenuItem
        '
        Me.TOTALWEIGHTToolStripMenuItem.Name = "TOTALWEIGHTToolStripMenuItem"
        Me.TOTALWEIGHTToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TOTALWEIGHTToolStripMenuItem.Text = "TOTAL WEIGHT"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MainFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RfidWeighment.My.Resources.Resources.orange_truck_with_grain_is_wei_1536x1024
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1110, 634)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainFrom"
        Me.Text = "MainFrom"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GATEENTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WEIGHINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONFIGURATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPRINTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STWEIGHTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NDWEIGHTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOTALWEIGHTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
