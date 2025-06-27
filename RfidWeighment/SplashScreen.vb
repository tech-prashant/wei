Imports System.IO

Imports System.Data.SqlClient
Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
        Dim path As String
        Dim filePath As String
        Dim Server_name, database_name, id, Pass As String
        path = Application.StartupPath
        Splash.Image = Image.FromFile(path + "\logo-color.png")
        filePath = path + "\Conn.Fil"


        Using reader As New StreamReader(filePath)

            Dim line As String = reader.ReadLine()
            Dim columns() As String = line.Split("|")

            Server_name = columns(0)
            database_name = columns(1)
            id = columns(2)
            Pass = columns(3)
        End Using

        Dim connectionString As String = "Server=" + Server_name + ";Database=" + database_name + ";User Id= " + id + " ;Password=" + Pass + ";"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Console.WriteLine("Connection Opened Successfully")
            Catch ex As SqlException

                MsgBox("SQL Error: " & ex.Message)
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
                Console.WriteLine("Connection Closed")
            End Try
        End Using

       Dim splashTimer As New Timer()
        splashTimer.Interval = 3000 ' 3 seconds
        AddHandler splashTimer.Tick, AddressOf SplashTimer_Tick
        splashTimer.Start()
    End Sub

    Private Sub SplashTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Timer).Stop()
        ' Close the splash screen and show the login form
        Me.Hide()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class
