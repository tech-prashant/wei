<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeighment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItmCd = New System.Windows.Forms.TextBox()
        Me.txtPartyCd = New System.Windows.Forms.TextBox()
        Me.txtTransCd = New System.Windows.Forms.TextBox()
        Me.txtItmDesc = New System.Windows.Forms.TextBox()
        Me.txtPartDesc = New System.Windows.Forms.TextBox()
        Me.txtTransDesc = New System.Windows.Forms.TextBox()
        Me.txtVehicle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstWeight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGrTr = New System.Windows.Forms.TextBox()
        Me.txtTrxNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbWmntType = New System.Windows.Forms.ComboBox()
        Me.txtChallanNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLrNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtfirstTime = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtfirstDate = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtsecTime = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtsecDate = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtLrDate = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtChlDate = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnNetWeight = New System.Windows.Forms.Button()
        Me.txtNetWt = New System.Windows.Forms.TextBox()
        Me.txtSecondWt = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtlocName = New System.Windows.Forms.TextBox()
        Me.txtLoccd = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Weight1 = New RfidWeighment.Weight()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Party Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Transporter Code"
        '
        'txtItmCd
        '
        Me.txtItmCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtItmCd.Location = New System.Drawing.Point(151, 231)
        Me.txtItmCd.Name = "txtItmCd"
        Me.txtItmCd.Size = New System.Drawing.Size(132, 26)
        Me.txtItmCd.TabIndex = 6
        '
        'txtPartyCd
        '
        Me.txtPartyCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPartyCd.Location = New System.Drawing.Point(151, 263)
        Me.txtPartyCd.Name = "txtPartyCd"
        Me.txtPartyCd.Size = New System.Drawing.Size(132, 26)
        Me.txtPartyCd.TabIndex = 7
        '
        'txtTransCd
        '
        Me.txtTransCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTransCd.Location = New System.Drawing.Point(151, 296)
        Me.txtTransCd.Name = "txtTransCd"
        Me.txtTransCd.Size = New System.Drawing.Size(132, 26)
        Me.txtTransCd.TabIndex = 8
        '
        'txtItmDesc
        '
        Me.txtItmDesc.Enabled = False
        Me.txtItmDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtItmDesc.Location = New System.Drawing.Point(289, 231)
        Me.txtItmDesc.Name = "txtItmDesc"
        Me.txtItmDesc.Size = New System.Drawing.Size(315, 26)
        Me.txtItmDesc.TabIndex = 9
        '
        'txtPartDesc
        '
        Me.txtPartDesc.Enabled = False
        Me.txtPartDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPartDesc.Location = New System.Drawing.Point(289, 263)
        Me.txtPartDesc.Name = "txtPartDesc"
        Me.txtPartDesc.Size = New System.Drawing.Size(315, 26)
        Me.txtPartDesc.TabIndex = 10
        '
        'txtTransDesc
        '
        Me.txtTransDesc.Enabled = False
        Me.txtTransDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTransDesc.Location = New System.Drawing.Point(289, 296)
        Me.txtTransDesc.Name = "txtTransDesc"
        Me.txtTransDesc.Size = New System.Drawing.Size(315, 26)
        Me.txtTransDesc.TabIndex = 11
        '
        'txtVehicle
        '
        Me.txtVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtVehicle.Location = New System.Drawing.Point(151, 197)
        Me.txtVehicle.Name = "txtVehicle"
        Me.txtVehicle.Size = New System.Drawing.Size(132, 26)
        Me.txtVehicle.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Vehicle"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(611, 66)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(490, 524)
        Me.DataGridView1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(787, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Pending Vehicle List"
        '
        'txtFirstWeight
        '
        Me.txtFirstWeight.Enabled = False
        Me.txtFirstWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFirstWeight.Location = New System.Drawing.Point(447, 7)
        Me.txtFirstWeight.Name = "txtFirstWeight"
        Me.txtFirstWeight.Size = New System.Drawing.Size(110, 26)
        Me.txtFirstWeight.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Net Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Second Weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "First Weight"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Kg"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(563, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Kg"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(563, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Kg"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 22.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(100, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(445, 40)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "G R O S S   W E I G H M E N T"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(304, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 20)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Gross/Tare*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(305, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Txn Number "
        '
        'txtGrTr
        '
        Me.txtGrTr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrTr.Location = New System.Drawing.Point(432, 195)
        Me.txtGrTr.Name = "txtGrTr"
        Me.txtGrTr.Size = New System.Drawing.Size(172, 26)
        Me.txtGrTr.TabIndex = 32
        '
        'txtTrxNo
        '
        Me.txtTrxNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrxNo.Location = New System.Drawing.Point(433, 163)
        Me.txtTrxNo.Name = "txtTrxNo"
        Me.txtTrxNo.Size = New System.Drawing.Size(172, 26)
        Me.txtTrxNo.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(9, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "WMNT Type"
        '
        'cmbWmntType
        '
        Me.cmbWmntType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWmntType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbWmntType.Items.AddRange(New Object() {"Select", "Inward", "Outward"})
        Me.cmbWmntType.Location = New System.Drawing.Point(152, 158)
        Me.cmbWmntType.Name = "cmbWmntType"
        Me.cmbWmntType.Size = New System.Drawing.Size(110, 28)
        Me.cmbWmntType.TabIndex = 35
        '
        'txtChallanNo
        '
        Me.txtChallanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtChallanNo.Location = New System.Drawing.Point(152, 363)
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(132, 26)
        Me.txtChallanNo.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 369)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 20)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Challan No."
        '
        'txtLrNo
        '
        Me.txtLrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLrNo.Location = New System.Drawing.Point(152, 395)
        Me.txtLrNo.Name = "txtLrNo"
        Me.txtLrNo.Size = New System.Drawing.Size(132, 26)
        Me.txtLrNo.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 401)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 20)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "LR No."
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtRemarks.Location = New System.Drawing.Point(152, 429)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(452, 26)
        Me.txtRemarks.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 429)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Remarks"
        '
        'txtfirstTime
        '
        Me.txtfirstTime.Enabled = False
        Me.txtfirstTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtfirstTime.Location = New System.Drawing.Point(434, 461)
        Me.txtfirstTime.Name = "txtfirstTime"
        Me.txtfirstTime.Size = New System.Drawing.Size(171, 26)
        Me.txtfirstTime.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(291, 468)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "1st Weight Time"
        '
        'txtfirstDate
        '
        Me.txtfirstDate.Enabled = False
        Me.txtfirstDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtfirstDate.Location = New System.Drawing.Point(153, 461)
        Me.txtfirstDate.Name = "txtfirstDate"
        Me.txtfirstDate.Size = New System.Drawing.Size(132, 26)
        Me.txtfirstDate.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Enabled = False
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 468)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 20)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "1st Weight Date"
        '
        'txtsecTime
        '
        Me.txtsecTime.Enabled = False
        Me.txtsecTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtsecTime.Location = New System.Drawing.Point(433, 497)
        Me.txtsecTime.Name = "txtsecTime"
        Me.txtsecTime.Size = New System.Drawing.Size(171, 26)
        Me.txtsecTime.TabIndex = 49
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(291, 499)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 20)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "2nd Weight Time"
        '
        'txtsecDate
        '
        Me.txtsecDate.Enabled = False
        Me.txtsecDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtsecDate.Location = New System.Drawing.Point(152, 495)
        Me.txtsecDate.Name = "txtsecDate"
        Me.txtsecDate.Size = New System.Drawing.Size(132, 26)
        Me.txtsecDate.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 497)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 20)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "2nd Weight Date"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(61, 536)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 54)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "Insert"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(238, 536)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(142, 54)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(415, 536)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 54)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtLrDate
        '
        Me.txtLrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLrDate.Location = New System.Drawing.Point(433, 395)
        Me.txtLrDate.Name = "txtLrDate"
        Me.txtLrDate.Size = New System.Drawing.Size(171, 26)
        Me.txtLrDate.TabIndex = 56
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(305, 401)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 20)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Lr Date"
        '
        'txtChlDate
        '
        Me.txtChlDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtChlDate.Location = New System.Drawing.Point(432, 363)
        Me.txtChlDate.Name = "txtChlDate"
        Me.txtChlDate.Size = New System.Drawing.Size(171, 26)
        Me.txtChlDate.TabIndex = 54
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(309, 369)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 20)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Challan Date"
        '
        'btnNetWeight
        '
        Me.btnNetWeight.BackColor = System.Drawing.Color.PaleGreen
        Me.btnNetWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNetWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNetWeight.Location = New System.Drawing.Point(610, 17)
        Me.btnNetWeight.Name = "btnNetWeight"
        Me.btnNetWeight.Size = New System.Drawing.Size(158, 43)
        Me.btnNetWeight.TabIndex = 57
        Me.btnNetWeight.Text = "Net Weight"
        Me.btnNetWeight.UseVisualStyleBackColor = False
        '
        'txtNetWt
        '
        Me.txtNetWt.Enabled = False
        Me.txtNetWt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNetWt.Location = New System.Drawing.Point(447, 61)
        Me.txtNetWt.Name = "txtNetWt"
        Me.txtNetWt.Size = New System.Drawing.Size(110, 26)
        Me.txtNetWt.TabIndex = 58
        '
        'txtSecondWt
        '
        Me.txtSecondWt.Enabled = False
        Me.txtSecondWt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSecondWt.Location = New System.Drawing.Point(447, 34)
        Me.txtSecondWt.Name = "txtSecondWt"
        Me.txtSecondWt.Size = New System.Drawing.Size(110, 26)
        Me.txtSecondWt.TabIndex = 59
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(959, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(142, 54)
        Me.btnPrint.TabIndex = 60
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txtlocName
        '
        Me.txtlocName.Enabled = False
        Me.txtlocName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtlocName.Location = New System.Drawing.Point(289, 330)
        Me.txtlocName.Name = "txtlocName"
        Me.txtlocName.Size = New System.Drawing.Size(315, 26)
        Me.txtlocName.TabIndex = 63
        '
        'txtLoccd
        '
        Me.txtLoccd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLoccd.Location = New System.Drawing.Point(151, 330)
        Me.txtLoccd.Name = "txtLoccd"
        Me.txtLoccd.Size = New System.Drawing.Size(132, 26)
        Me.txtLoccd.TabIndex = 62
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(-3, 333)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 20)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Location Code"
        '
        'Weight1
        '
        Me.Weight1.Location = New System.Drawing.Point(12, 0)
        Me.Weight1.Name = "Weight1"
        Me.Weight1.Size = New System.Drawing.Size(294, 97)
        Me.Weight1.TabIndex = 0
        '
        'FrmWeighment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1112, 602)
        Me.Controls.Add(Me.txtlocName)
        Me.Controls.Add(Me.txtLoccd)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtSecondWt)
        Me.Controls.Add(Me.txtNetWt)
        Me.Controls.Add(Me.btnNetWeight)
        Me.Controls.Add(Me.txtLrDate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtChlDate)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtsecTime)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtsecDate)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtfirstTime)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtfirstDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtLrNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtChallanNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbWmntType)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTrxNo)
        Me.Controls.Add(Me.txtGrTr)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFirstWeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtVehicle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransDesc)
        Me.Controls.Add(Me.txtPartDesc)
        Me.Controls.Add(Me.txtItmDesc)
        Me.Controls.Add(Me.txtTransCd)
        Me.Controls.Add(Me.txtPartyCd)
        Me.Controls.Add(Me.txtItmCd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Weight1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWeighment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Weighment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Weight1 As RfidWeighment.Weight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItmCd As System.Windows.Forms.TextBox
    Friend WithEvents txtPartyCd As System.Windows.Forms.TextBox
    Friend WithEvents txtTransCd As System.Windows.Forms.TextBox
    Friend WithEvents txtItmDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPartDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGrTr As System.Windows.Forms.TextBox
    Friend WithEvents txtTrxNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbWmntType As System.Windows.Forms.ComboBox
    Friend WithEvents txtChallanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtfirstTime As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtfirstDate As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtsecTime As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtsecDate As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtLrDate As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtChlDate As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnNetWeight As System.Windows.Forms.Button
    Friend WithEvents txtNetWt As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondWt As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtlocName As System.Windows.Forms.TextBox
    Friend WithEvents txtLoccd As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
