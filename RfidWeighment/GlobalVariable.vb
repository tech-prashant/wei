Module GlobalVariable
    Public Usr As String
    Public GlobalVariable2 As Integer
    Public GlobalVariable3 As Boolean

    Public path As String
    Public filePath As String
    Dim mFormData As String

    Public Server_name, database_name, id, Pass, Db_Type As String


    Public Sub Show_Help(ByRef code As TextBox, ByRef Desc As TextBox, ByVal Table As String, Optional ByVal Condition As String = "")


        '  Dim dayOfWeek As Integer = 3 ' For example, 1 = Sunday, 2 = Monday, etc.

        Select Case Table
            Case "ItemMaster"
                mFormData = "Select ItemCode as Code, Description as Detail from Item where ActiveFlag = 0 |Item Master |1|1|0"

            Case 2
                Console.WriteLine("It's Monday.")
            Case 3
                Console.WriteLine("It's Tuesday.")
            Case 4
                Console.WriteLine("It's Wednesday.")
            Case 5
                Console.WriteLine("It's Thursday.")
            Case 6
                Console.WriteLine("It's Friday.")
            Case 7
                Console.WriteLine("It's Saturday.")
            Case Else
                Console.WriteLine("Invalid day.")
        End Select

        Dim frmBrowser As New FrmBrowser(mFormData, code, Desc)
        frmBrowser.Show()

    End Sub
       
End Module
