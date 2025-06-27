Imports System.Data
Public Class LoginForm
    Dim cc As New ConnectionClass()
    Dim Pass As String
    Dim query As String
    Dim data As DataSet
    Dim flag As Byte
    Dim Error_msg As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Pass <> PasswordTextBox.Text Then
            MsgBox("wrong Password")
            PasswordTextBox.Text = ""
            PasswordTextBox.Focus()
            Exit Sub
        End If
        Dim lastLogin = cc.Get_LoginDetail()

        query = "update USERS set U_lastlogin = Date(),U_LOG = '" & Environment.MachineName & "' where U_LOGIN = '" & Userid.Text.Trim & "'"
        cc.Ks_Out(query, data, flag, Error_msg)

        Dim mf As New MainFrom()
        mf.ShowDialog()
        Me.Close()


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  System.Threading.Thread.Sleep(2000)

        Dim path As String
        path = Application.StartupPath
        splash.Image = Image.FromFile(path + "\icon.png")

        Userid.Focus()

    End Sub

    Private Sub Userid_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Userid.Validated
   
        If Userid.Text.Trim() = "" Then
            Exit Sub
        End If
        PasswordTextBox.Focus()
        query = "Select * from USERS where U_LOGIN = '" & Userid.Text.Trim & "' and U_STATUS = 0 "
        cc.Ks_Out(query, data, flag, Error_msg)


        If flag = 0 Then
            If data.Tables(0).Rows.Count = 0 Then
                MsgBox("Invalid User Name")
                Userid.Text = ""
                Userid.Focus()
            Else

                If (Convert.ToDateTime(data.Tables(0).Rows(0)("U_VALIDITY")).ToString() < DateTime.Now) Then

                    MsgBox(" User Name Expire Contact Admin")
                    Userid.Text = ""
                    Userid.Focus()
                End If

                UserName.Text = (data.Tables(0).Rows(0)("U_NAME")).ToString()
                Usr = UserName.Text.ToString()
                txtLastlog.Text = (data.Tables(0).Rows(0)("U_LASTLOGIN"))

                Pass = (data.Tables(0).Rows(0)("U_PASS")).ToString()
                PasswordTextBox.Focus()

                End If
        Else
                MsgBox(Error_msg)
                Application.Exit()
        End If
    

    End Sub
End Class
