Public Class FrmWeighment
    Dim cc As New ConnectionClass()
    Dim Pass As String
    Dim query As String
    Dim data As DataSet
    Dim flag As Byte
    Dim Error_msg As String
    Private Sub FrmWeighment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Weight1.OpenPort("COM1", 9600, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)

        ' Read data from the serial port
        Weight1.ReadData()

        ' Close the port after usage
        Weight1.ClosePort()
        BlankScreen()
    End Sub

  
   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Weight1.ClosePort()
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        BlankScreen()

    End Sub
  
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim query As String = ""
        query = "INSERT INTO TXN_INWARD ("
        query = query + "    INW_CHA_NUMBER, INW_GR_OPR_LOG, INW_PRO_CODE, INW_REMARKS, INW_LR_NUMBER,"
        query = query + "       INW_PAR_CODE, INW_TRA_CODE, INW_TXN_NUMBER, INW_VEH_NUMBER,"
        query = query + "       INW_TR_TIME, INW_TR_DATE, INW_TR_WEIGHT, INW_GR_DATE, INW_GR_TIME,"
        query = query + "      INW_GR_WEIGHT, INW_TR_DATETIME, INW_GR_DATETIME, INW_CAN_FLAG,"
        query = query + "      INW_LR_DATE, INW_LOC_CODE, INW_GR_WB_NO, INW_TR_WB_NO, INW_LOC_CODE, INW_GR_SHIFT, INW_TR_SHIFT"
        query = query + "   ) VALUES ("
        query = query + "      '" & txtChallanNo.Text & "', '" & txtGrTr.Text & "', '" & txtItmCd.Text & "', '" & txtRemarks.Text & "', '" & txtLrNo.Text & "',"
        query = query + "      '" & txtPartyCd.Text & "', '" & txtTransCd.Text & "', '" & txtTrxNo.Text & "', '" & txtVehicle.Text & "',"
        query = query + "   '" & txtfirstTime.Text & "', #" & txtfirstDate.Text & "#, '" & txtFirstWeight.Text & "', #" & txtsecDate.Text & "#, '" & txtsecTime.Text & "',"
        query = query + "     '" & txtSecondWt.Text & "', #" & txtfirstDate.Text & " " & txtfirstTime.Text & "#, #" & txtsecDate.Text & " " & txtsecTime.Text & "#, 0,"
        query = query + "   #" & txtLrDate.Text & "#, '" & txtLoccd.Text & "', '" & txtGrTr.Text & "', '" & txtGrTr.Text & "', '" & txtLoccd.Text & "', '', ''"
        query = query + "   "


        query = query + "  UPDATE TXN_INWARD SET "
        query = query + "     INW_CHA_NUMBER = '" & txtChallanNo.Text & "',"
        query = query + "  INW_GR_OPR_LOG = '" & txtGrTr.Text & "',"
        query = query + "  INW_PRO_CODE = '" & txtItmCd.Text & "',"
        query = query + "    INW_REMARKS = '" & txtRemarks.Text & "',"
        query = query + "    INW_LR_NUMBER = '" & txtLrNo.Text & "',"
        query = query + "  INW_PAR_CODE = '" & txtPartyCd.Text & "',"
        query = query + "    INW_TRA_CODE = '" & txtTransCd.Text & "',"
        query = query + "    INW_VEH_NUMBER = '" & txtVehicle.Text & "',"
        query = query + "  INW_TR_TIME = '" & txtfirstTime.Text & "',"
        query = query + "  INW_TR_DATE = #" & txtfirstDate.Text & "#,"
        query = query + "  INW_TR_WEIGHT = '" & txtFirstWeight.Text & "',"
        query = query + "    INW_GR_DATE = #" & txtsecDate.Text & "#,"
        query = query + "  INW_GR_TIME = '" & txtsecTime.Text & "',"
        query = query + "    INW_GR_WEIGHT = '" & txtSecondWt.Text & "',"
        query = query + "    INW_TR_DATETIME = #" & txtfirstDate.Text & " " & txtfirstTime.Text & "#,"
        query = query + "    INW_GR_DATETIME = #" & txtsecDate.Text & " " & txtsecTime.Text & "#,"
        query = query + "  INW_LR_DATE = #" & txtLrDate.Text & "#,"
        query = query + "    INW_LOC_CODE = '" & txtLoccd.Text & "',"
        query = query + "    INW_GR_WB_NO = '" & txtGrTr.Text & "',"
        query = query + "  INW_TR_WB_NO = '" & txtGrTr.Text & "',"
        query = query + "    INW_CAN_FLAG = 0,"
        query = query + "    INW_GR_SHIFT = '',"
        query = query + "    INW_TR_SHIFT = ''"
        query = query + "  WHERE INW_TXN_NUMBER = '" & txtTrxNo.Text & "'"

    End Sub

    Private Sub txtItmCd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItmCd.KeyDown
        If e.KeyCode = Keys.F1 Then
            ' Open the FormBrowser with sample data
            'Dim itemData As String = "Item"
            'Dim itemHeader As String = "Item Master"
            '  Dim frmBrowser As New FrmBrowser(itemData, itemHeader)
            '  frmBrowser.Show()
            Show_Help(txtItmCd, txtItmDesc, "ItemMaster")
        End If
    End Sub

   
    Private Sub txtItmCd_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItmCd.DoubleClick
        '  Dim itemData As String = "Item"
        '   Dim itemHeader As String = "Item Master"
        '     Dim frmBrowser As New FrmBrowser(itemData, itemHeader)
        '  frmBrowser.Show()

        Show_Help(txtItmCd, txtItmDesc, "ItemMaster")
    End Sub

    Private Sub cmbWmntType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWmntType.SelectedIndexChanged
        Dim QUERY As String = ""


        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        If cmbWmntType.SelectedIndex = 1 Then

            QUERY = "SELECT " & _
    "INW.INW_TXN_NUMBER AS TXN_NO, " & _
    "INW.INW_VEH_NUMBER AS VEHICLE_NO, " & _
       "PM.PAR_NAME AS PARTY_NAME, " & _
    "PR.PRO_NAME AS PRODUCT_NAME, " & _
    "LM.LOC_NAME AS LOCATION_NAME, " & _
    "TM.TRA_NAME AS TRANSPORTER_NAME, " & _
    "INW.INW_PRO_CODE AS PRODUCT_CODE, " & _
    "INW.INW_PAR_CODE AS PARTY_CODE, " & _
    "INW.INW_LOC_CODE AS LOCATION_CODE, " & _
    "INW.INW_TRA_CODE AS TRANSPORTER_CODE, " & _
    "INW.INW_CHA_NUMBER AS CHALLAN_NO, " & _
     "INW.INW_CHA_DATE AS CHALLAN_DATE, " & _
    "INW.INW_LR_NUMBER AS LR_NO, " & _
     "INW.INW_LR_DATE AS LR_DATE, " & _
    "INW.INW_REMARKS AS REMARKS, " & _
    "INW.INW_GR_WEIGHT AS GROSS_WEIGHT, " & _
    "INW.INW_GR_DATE AS GROSS_DATE, " & _
     "INW.INW_GR_TIME AS GROSS_TIME " & _
    "FROM ((((TXN_INWARD AS INW " & _
    "LEFT JOIN PARTY AS PM ON INW.INW_PAR_CODE = PM.PAR_CODE) " & _
    "LEFT JOIN PRODUCT AS PR ON INW.INW_PRO_CODE = PR.PRO_CODE) " & _
    "LEFT JOIN LOCATION AS LM ON INW.INW_LOC_CODE = LM.LOC_CODE) " & _
    "LEFT JOIN TRANSPORTER AS TM ON INW.INW_TRA_CODE = TM.TRA_CODE) " & _
    "WHERE INW.INW_TR_WEIGHT = 0 AND INW.INW_CAN_FLAG = 0"




        ElseIf cmbWmntType.SelectedIndex = 2 Then

            QUERY = "SELECT " & _
        "OUT.OUT_TXN_NUMBER AS TXN_NO, " & _
        "OUT.OUT_VEH_NUMBER AS VEHICLE_NO, " & _
        "PM.PAR_NAME AS PARTY_NAME, " & _
        "PR.PRO_NAME AS PRODUCT_NAME, " & _
        "LM.LOC_NAME AS LOCATION_NAME, " & _
        "TM.TRA_NAME AS TRANSPORTER_NAME, " & _
        "OUT.OUT_REMARKS AS REMARKS, " & _
        "OUT.OUT_TR_WEIGHT AS TARE_WEIGHT, " & _
        "OUT.OUT_TR_DATE AS TARE_DATE, " & _
         "OUT.OUT_TR_TIME AS TARE_TIME, " & _
        "OUT.OUT_CHA_NUMBER AS CHALLAN_NO, " & _
          "OUT.OUT_CHA_DATE AS CHALLAN_DATE, " & _
        "OUT.OUT_LR_NUMBER AS LR_NO, " & _
         "OUT.OUT_LR_DATE AS LR_DATE, " & _
        "OUT.OUT_PRO_CODE AS PRODUCT_CODE, " & _
        "OUT.OUT_PAR_CODE AS PARTY_CODE, " & _
        "OUT.OUT_LOC_CODE AS LOCATION_CODE, " & _
        "OUT.OUT_TRA_CODE AS TRANSPORTER_CODE " & _
        "FROM ((((TXN_OUTWARD AS OUT " & _
        "LEFT JOIN PARTY AS PM ON OUT.OUT_PAR_CODE = PM.PAR_CODE) " & _
        "LEFT JOIN PRODUCT AS PR ON OUT.OUT_PRO_CODE = PR.PRO_CODE) " & _
        "LEFT JOIN LOCATION AS LM ON OUT.OUT_LOC_CODE = LM.LOC_CODE) " & _
        "LEFT JOIN TRANSPORTER AS TM ON OUT.OUT_TRA_CODE = TM.TRA_CODE) " & _
        "WHERE OUT.OUT_GR_WEIGHT = 0 AND OUT.OUT_CAN_FLAG = 0"

        Else

            flag = 1
        End If
        cc.Ks_Out(QUERY, data, flag, Error_msg)
        If flag = 0 Then
            DataGridView1.DataSource = data.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            ' Read-only mode (optional)
            DataGridView1.ReadOnly = True
        Else
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()
        End If
    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtTrxNo.Text = row.Cells("TXN_NO").Value.ToString()
            txtVehicle.Text = row.Cells("VEHICLE_NO").Value.ToString()
            txtPartDesc.Text = row.Cells("PARTY_NAME").Value.ToString()
            txtItmDesc.Text = row.Cells("PRODUCT_NAME").Value.ToString()
            txtLoccd.Text = row.Cells("LOCATION_NAME").Value.ToString()
            txtTransCd.Text = row.Cells("TRANSPORTER_NAME").Value.ToString()
            txtRemarks.Text = row.Cells("REMARKS").Value.ToString()
            txtLrDate.Text = If(IsDBNull(row.Cells("LR_DATE").Value), "", Convert.ToDateTime(row.Cells("LR_DATE").Value).ToString("dd-MMM-yyyy"))
            txtChlDate.Text = If(IsDBNull(row.Cells("CHALLAN_DATE").Value), "", Convert.ToDateTime(row.Cells("CHALLAN_DATE").Value).ToString("dd-MMM-yyyy"))


            txtChallanNo.Text = row.Cells("CHALLAN_NO").Value.ToString()
            txtLrNo.Text = row.Cells("LR_NO").Value.ToString()
            txtItmCd.Text = row.Cells("PRODUCT_CODE").Value.ToString()
            txtPartyCd.Text = row.Cells("PARTY_CODE").Value.ToString()
            txtLoccd.Text = row.Cells("LOCATION_CODE").Value.ToString()
            txtTransDesc.Text = row.Cells("TRANSPORTER_CODE").Value.ToString()

            If cmbWmntType.SelectedIndex = 1 Then

                txtFirstWeight.Text = row.Cells("GROSS_WEIGHT").Value.ToString()
                txtfirstDate.Text = Convert.ToDateTime(row.Cells("GROSS_DATE").Value).ToString("dd-MMM-yyyy")
                txtfirstTime.Text = row.Cells("GROSS_TIME").Value.ToString()

            ElseIf cmbWmntType.SelectedIndex = 2 Then
                txtFirstWeight.Text = row.Cells("TARE_WEIGHT").Value.ToString()
                txtfirstDate.Text = Convert.ToDateTime(row.Cells("TARE_DATE").Value).ToString("dd-MMM-yyyy")
                txtfirstTime.Text = row.Cells("TARE_TIME").Value.ToString()
            End If


           
        End If
    End Sub
    Private Sub BlankScreen()
        txtChallanNo.Text = ""
        txtGrTr.Text = ""
        txtItmCd.Text = ""
        txtItmDesc.Text = ""
        txtLrNo.Text = ""
        txtPartDesc.Text = ""
        txtPartyCd.Text = ""
        txtTransCd.Text = ""
        txtTransDesc.Text = ""
        txtTrxNo.Text = ""
        txtVehicle.Text = ""
        txtfirstTime.Text = ""
        txtfirstDate.Text = ""
        txtFirstWeight.Text = ""
        txtsecDate.Text = ""
        txtsecTime.Text = ""
        txtNetWt.Text = ""
        txtSecondWt.Text = ""
        txtRemarks.Text = ""
        txtLrDate.Text = ""
        txtLoccd.Text = ""
        txtlocName.Text = ""
        txtSecondWt.Text = ""
        txtNetWt.Text = ""
        txtsecDate.Text = ""
        txtsecTime.Text = ""
        txtChlDate.Text = ""
        cmbWmntType.SelectedIndex = 0
    End Sub
End Class