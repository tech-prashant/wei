Public Class MainFrom

   
    Private Sub MainFrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        

    End Sub
    Private Sub CloseAllChildForms()
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub
    Private Sub GATEENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GATEENTRYToolStripMenuItem.Click
      
        CloseAllChildForms()

        Dim existingForm As FrmTokenEntry = IsFormOpen(Of FrmTokenEntry)()
        If existingForm Is Nothing Then
            Dim childForm1 As New FrmTokenEntry()
            childForm1.MdiParent = Me
            childForm1.Show()
        Else
            existingForm.BringToFront()
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub WEIGHINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WEIGHINGToolStripMenuItem.Click
       
        CloseAllChildForms()
        Dim existingForm As FrmWeighment = IsFormOpen(Of FrmWeighment)()
        If existingForm Is Nothing Then
            Dim childForm2 As New FrmWeighment()
            childForm2.MdiParent = Me
            childForm2.Show()

        Else
            existingForm.BringToFront()
        End If

    End Sub

    ' Method to check if a specific form type is already open
    Private Function IsFormOpen(Of T As {Form, New})() As T
        For Each frm As Form In Me.MdiChildren
            If TypeOf frm Is T Then
                Return CType(frm, T)
            End If
        Next
        Return Nothing
    End Function


   
    Private Sub CONFIGURATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONFIGURATIONToolStripMenuItem.Click

    End Sub
End Class