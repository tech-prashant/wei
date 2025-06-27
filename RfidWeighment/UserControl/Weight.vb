
Imports System.IO.Ports
Public Class Weight

    ' Method to open the serial port connection
    Public Sub OpenPort(ByVal portName As String, ByVal baudRate As Integer, ByVal parity As Parity, ByVal dataBits As Integer, ByVal stopBits As StopBits)
        Try
            ' Set up serial port properties
            serialPort1.PortName = portName
            serialPort1.BaudRate = baudRate
            serialPort1.Parity = parity
            serialPort1.DataBits = dataBits
            serialPort1.StopBits = stopBits
            serialPort1.Handshake = Handshake.None

            ' Open the serial port
            serialPort1.Open()
            Console.WriteLine("Serial port opened successfully.")
        Catch ex As Exception
            Console.WriteLine("Error opening serial port: " & ex.Message)
        End Try
    End Sub

    ' Method to close the serial port connection
    Public Sub ClosePort()
        Try
            If serialPort1.IsOpen Then
                serialPort1.Close()
                Console.WriteLine("Serial port closed.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error closing serial port: " & ex.Message)
        End Try
    End Sub

    ' Method to read data from the serial port
    Public Sub ReadData()
        Try
            If serialPort1.IsOpen Then
                Dim data As String = serialPort1.ReadLine()
                Console.WriteLine("Received Data: " & data)
            End If
        Catch ex As Exception
            Console.WriteLine("Error reading data: " & ex.Message)
        End Try
    End Sub



End Class
