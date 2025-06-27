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

        query = "update login set last_login = getdate() ,last_login_detail = '" & lastLogin & "' where user_id = '" & Userid.Text.Trim & "'"
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
        query = "Select * from login where user_id = '" & Userid.Text.Trim & "' and user_active = 0"
        cc.Ks_Out(query, data, flag, Error_msg)


        If flag = 0 Then
            If data.Tables(0).Rows.Count = 0 Then
                MsgBox("Invalid User Name")
                Userid.Text = ""
                Userid.Focus()
            Else
                UserName.Text = (data.Tables(0).Rows(0)("User_name")).ToString()
                Usr = UserName.Text.ToString()
                txtLastlog.Text = (data.Tables(0).Rows(0)("Last_login")).ToString()

                Pass = (data.Tables(0).Rows(0)("pass")).ToString()
                PasswordTextBox.Focus()

            End If
        Else
            MsgBox(Error_msg)
            Application.Exit()
        End If
    

    End Sub
End Class
