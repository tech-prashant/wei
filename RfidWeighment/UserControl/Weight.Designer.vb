<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weight
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdwt = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'cmdwt
        '
        Me.cmdwt.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdwt.Location = New System.Drawing.Point(0, 0)
        Me.cmdwt.Name = "cmdwt"
        Me.cmdwt.Size = New System.Drawing.Size(294, 94)
        Me.cmdwt.TabIndex = 0
        Me.cmdwt.Text = "000000 KG"
        Me.cmdwt.UseVisualStyleBackColor = True
        '
        'Weight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdwt)
        Me.Name = "Weight"
        Me.Size = New System.Drawing.Size(294, 92)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdwt As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
