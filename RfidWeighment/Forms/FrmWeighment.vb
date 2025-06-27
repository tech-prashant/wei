Public Class FrmWeighment

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
        cmbWmntType.SelectedIndex = 0
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

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
End Class