Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class login
    ' Connection string for the SQL Server database
    Dim connectionString As String = "Data Source=DESKTOP-3KRKVUB;Initial Catalog=redroosterfarm;Integrated Security=True"

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub logintxt_Click(sender As Object, e As EventArgs) Handles logintxt.Click
        Dim username As String = untxt.Text
        Dim password As String = pswtxt.Text


        Dim userRole As String = AuthenticateUser(username, password)

        If Not String.IsNullOrEmpty(userRole) Then
            MessageBox.Show("Welcome " & userRole & "!")
            ' Perform actions after successful login based on the user role.
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub




    Private Function AuthenticateUser(username As String, password As String) As String
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT UserRole FROM users WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim userRole As Object = cmd.ExecuteScalar()

                    If userRole IsNot Nothing Then
                        ' Return the user role as a string.
                        Return userRole.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions, log errors, etc.
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return String.Empty
    End Function


End Class