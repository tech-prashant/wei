Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.ValueType
Imports System.Data.OleDb
Public Class ConnectionClass

    Public Function Conection(ByVal query As String) As Tuple(Of DataSet, Boolean, String)
      
        Dim dataSet As New DataSet()

        Dim isError As Boolean = False
        Dim errorMessage As String = String.Empty

        path = Application.StartupPath

        filePath = path + "\Conn.Fil"


        Using reader As New StreamReader(filePath)

            Dim line As String = reader.ReadLine()
            Dim columns() As String = line.Split("|")

            Server_name = columns(0)
            database_name = columns(1)
            id = columns(2)
            Pass = columns(3)
            Db_Type = columns(4)
            DBFILEName = columns(5)
        End Using
        If Db_Type = 1 Then
            Dim connectionString As String = "Server=" + Server_name + ";Database=" + database_name + ";User Id= " + id + " ;Password=" + Pass + ";"

            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    Using command As New SqlCommand(query.ToUpper(), connection)
                        If query.Trim().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase) Then
                            Using adapter As New SqlDataAdapter(command)
                                adapter.Fill(dataSet)
                            End Using
                        Else
                            command.ExecuteNonQuery()
                        End If
                    End Using
                Catch ex As Exception
                    isError = True
                    errorMessage = ex.Message
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            ' Define the connection string (modify the path to your database)
            Dim appPath As String = Application.StartupPath

            ' Combine the application path with the relative path to your database
            Dim databasePath As String = System.IO.Path.Combine(appPath, DBFILEName)

            ' Define the connection string using the application directory path
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databasePath & ";Persist Security Info=False;"
            ' Create a new OleDbConnection object
            Using connection As New OleDbConnection(connectionString)
                Try
                    ' Open the connection
                    connection.Open()

                    ' Create a command object with the query
                    Using command As New OleDbCommand(query, connection)
                        ' Check if the query is a SELECT statement
                        If query.Trim().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase) Then
                            ' If it's a SELECT, execute the query and fill the dataset
                            If dataSet IsNot Nothing Then
                                Using adapter As New OleDbDataAdapter(command)
                                    adapter.Fill(dataSet)
                                End Using
                            End If
                        Else
                            ' For non-SELECT queries (INSERT, UPDATE, DELETE), execute the query without a dataset
                            command.ExecuteNonQuery()
                        End If
                    End Using

                Catch ex As Exception
                    ' Catch any exceptions and set the error flags
                    isError = True
                    errorMessage = ex.Message

                Finally
                    ' Ensure the connection is always closed
                    connection.Close()
                End Try
            End Using
        End If


        Return Tuple.Create(dataSet, isError, errorMessage)

    End Function



    
    Public Sub Ks_Out(ByVal Query As String, ByRef Data As DataSet, ByRef Err As Byte, ByRef Err_msg As String)

        Dim result = Conection(Query)

        If result.Item2 Then
            Err = 1
            Err_msg = result.Item3

        Else
            Err = 0
            Err_msg = result.Item3
            Data = result.Item1
        End If

    End Sub


    Public Function Get_LoginDetail() As String

        
        Get_LoginDetail = ""
        Get_LoginDetail = Usr + " | " + Environment.MachineName + " | " + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss")
        Return Get_LoginDetail

    End Function
End Class
