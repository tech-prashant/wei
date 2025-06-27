Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class Player

    <DllImport("user32.dll")>
    Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function GetClientRect(ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    Public Sub play_video(ByVal rtsp As String)

        'Media.URL = rtsp
        'Media.Ctlcontrols.play()
    End Sub

    Public Sub stop_video()

        '  Media.Ctlcontrols.stop()
    End Sub

    Public Sub pause_video()

        '  Media.Ctlcontrols.pause()
    End Sub

    Public Sub capture_video(ByVal name As String, ByRef err_flg As Byte)
        '    Call CaptureImage(Media, name, err_flg)
    End Sub
    Private Sub CaptureImage(ByVal control As Control, ByVal Name As String, ByRef err_flg As Byte)
        Dim rect As New RECT()
        GetClientRect(control.Handle, rect)
        Dim width As Integer = rect.Right - rect.Left
        Dim height As Integer = rect.Bottom - rect.Top

        Dim hDC As IntPtr = GetWindowDC(control.Handle)
        Dim bmp As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim hdcBmp As IntPtr = g.GetHdc()
            BitBlt(hdcBmp, 0, 0, width, height, hDC, 0, 0, SRCCOPY)
            g.ReleaseHdc(hdcBmp)
        End Using
        ReleaseDC(control.Handle, hDC)

        ' Save the captured image to a file
        bmp.Save(Name, ImageFormat.Png)
        Dim filePath As String = Application.StartupPath
        filePath = filePath + "\" + Name + ".Png"
        ' Check if the file exists
        If File.Exists(filePath) Then
            err_flg = 0
        Else
            err_flg = 1
        End If
    End Sub


    <DllImport("gdi32.dll")>
    Public Shared Function BitBlt(ByVal hDestDC As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As IntPtr, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As UInteger) As Boolean
    End Function

    Public Const SRCCOPY As UInteger = &HCC0020
End Class
