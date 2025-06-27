Public Class FrmBrowser
    Private query As String
    Private itemHeader As String
    Private add_allow As Int16
    Private modify_allow As Int16
    Private delete_allow As Int16
    Private code As TextBox
    Private Desc As TextBox
    Dim cc As New ConnectionClass()
    Dim Pass As String

    Dim data As DataSet
    Dim flag As Byte
    Dim Error_msg As String
    Public Sub New(ByVal itemData As String, ByRef code As TextBox, ByRef name As TextBox)
        ' Initialize the form with itemData and itemHeader

        Dim columns() As String = itemData.Split("|")

        InitializeComponent()
        Me.query = columns(0)
        Me.itemHeader = columns(1)
        Me.add_allow = Val(columns(2))
        Me.modify_allow = Val(columns(3))
        Me.delete_allow = Val(columns(4))
        Me.code = code
        Me.Desc = name
    End Sub
    Private Sub FrmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnAdd, "Add")
        toolTip.SetToolTip(btnDelete, "Delete")
        toolTip.SetToolTip(BtnModify, "Modify")
        toolTip.SetToolTip(btnExit, "Exit")

        CustomizeDataGridView()

        ' Add the DataGridView to the form
        dataGrid.Dock = DockStyle.Fill


        If add_allow <> 1 Then btnAdd.Enabled = False
        If modify_allow <> 1 Then BtnModify.Enabled = False
        If delete_allow <> 1 Then btnDelete.Enabled = False

        cc.Ks_Out(query, data, flag, Error_msg)
        dataGrid.DataSource = Nothing
        If data.Tables(0).Rows.Count > 0 Then

            dataGrid.DataSource = data.Tables(0)
        End If
        '   FrmBrowser()

    End Sub
    Private Sub CustomizeDataGridView()
        ' Make the column headers bold
        dataGrid.ColumnHeadersDefaultCellStyle.Font = New Font(dataGrid.Font, FontStyle.Bold)

        ' Set background color for headers (optional)
        dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray

        ' Set text color for headers (optional)
        dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        ' Customize the default cell style for data fields (rows)
        dataGrid.DefaultCellStyle.BackColor = Color.AliceBlue
        dataGrid.DefaultCellStyle.ForeColor = Color.DarkBlue

        ' You can also modify column-specific styles (optional)
        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        ' Open Add Master Form
        'Dim addForm As New MasterForm()
        'addForm.ShowDialog()
        RefreshGrid()
    End Sub

    ' Modify Button Click Event
    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModify.Click
        ' Get selected row index
        Dim selectedRow As DataGridViewRow = dataGrid.CurrentRow
        If selectedRow IsNot Nothing Then
            ' Open Modify Master Form with selected record
            Dim id As Integer = selectedRow.Cells("ID").Value
            Dim name As String = selectedRow.Cells("Name").Value.ToString()
            '  Dim modifyForm As New MasterForm(id, name)
            '   modifyForm.ShowDialog()
            RefreshGrid()
        End If
    End Sub

    ' Delete Button Click Event
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        ' Get selected row index
        Dim selectedRow As DataGridViewRow = dataGrid.CurrentRow
        If selectedRow IsNot Nothing Then
            ' Remove record from the DataTable
            Dim id As Integer = selectedRow.Cells("ID").Value
            'Dim rowToDelete As DataRow = DataTable.Rows.Find(id)
            'If rowToDelete IsNot Nothing Then
            '    rowToDelete.Delete()
            'End If
            RefreshGrid()
        End If
    End Sub
    Private Sub RefreshGrid()
        dataGrid.DataSource = Nothing
        '  dataGrid.DataSource = DataTable
    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick
        Dim row As DataGridViewRow = dataGrid.Rows(e.RowIndex)

        ' Retrieve the values from the selected row
        Dim id As String = Convert.ToString(row.Cells("Code").Value)
        Dim name As String = Convert.ToString(row.Cells("Detail").Value)

        code.Text = id
        Desc.Text = name
        Me.Close()
    End Sub
End Class