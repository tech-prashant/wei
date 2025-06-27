Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
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