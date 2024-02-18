Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class employee

    Dim connectionString As String = "Data Source=DESKTOP-3KRKVUB;Initial Catalog=redroosterfarm;Integrated Security=True"


    ' Load employee data into the DataGridView when the form loads
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
    End Sub

    ' Function to load employee data into the DataGridView
    Private Sub LoadEmployeeData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT UserId, Username, Password, UserRole, Email, Age, Contact FROM users"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim ds As New DataSet()
                    adapter.Fill(ds, "users")
                    empDataGridView.DataSource = ds.Tables("users")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message)
        End Try
    End Sub

    ' Function to add a new employee to the users table
    Private Sub AddEmployee(username As String, password As String, userRole As String, email As String, age As Integer, contact As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO users (Username, Password, UserRole, Email, Age, Contact) VALUES (@Username, @Password, @UserRole, @Email, @Age, @Contact)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@UserRole", userRole)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Contact", contact)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show(" added successfully.")
            LoadEmployeeData() ' Refresh DataGridView after adding employee
        Catch ex As Exception
            MessageBox.Show("Error adding : " & ex.Message)
        End Try
    End Sub

    ' Function to delete an employee from the users table
    Private Sub DeleteEmployee(userId As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM users WHERE UserId = @UserId"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserId", userId)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show(" deleted successfully.")
            LoadEmployeeData() ' Refresh DataGridView after deleting employee
        Catch ex As Exception
            MessageBox.Show("Error deleting : " & ex.Message)
        End Try
    End Sub

    ' Function to edit an employee in the users table
    Private Sub EditEmployee(userId As Integer, username As String, password As String, userRole As String, email As String, age As Integer, contact As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE users SET Username = @Username, Password = @Password, UserRole = @UserRole, Email = @Email, Age = @Age, Contact = @Contact WHERE UserId = @UserId"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserId", userId)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@UserRole", userRole)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Contact", contact)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show(" Updated Successfully.")
            LoadEmployeeData() ' Refresh DataGridView after updating employee
        Catch ex As Exception
            MessageBox.Show("Error Updating : " & ex.Message)
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        ' Call the AddEmployee function with the provided values
        AddEmployee(untxt.Text, pswtxt.Text, urcom.Text, emailtxt.Text, Convert.ToInt32(agetxt.Text), contxt.Text)
    End Sub

    ' Event handler for Delete button click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        ' Check if a row is selected in the DataGridView
        If empDataGridView.SelectedRows.Count > 0 Then
            ' Get the UserId of the selected row
            Dim userId As Integer = Convert.ToInt32(empDataGridView.SelectedRows(0).Cells("UserId").Value)
            ' Call the DeleteEmployee function with the selected UserId
            DeleteEmployee(userId)
        Else
            MessageBox.Show("Please select an employee to delete.")
        End If
    End Sub

    ' Event handler for Edit button click
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        ' Check if a row is selected in the DataGridView
        If empDataGridView.SelectedRows.Count > 0 Then
            ' Get the values from the selected row
            Dim userId As Integer = Convert.ToInt32(empDataGridView.SelectedRows(0).Cells("UserId").Value)
            Dim username As String = untxt.Text
            Dim password As String = pswtxt.Text
            Dim userRole As String = urcom.Text
            Dim email As String = emailtxt.Text
            Dim age As Integer = Convert.ToInt32(agetxt.Text)
            Dim contact As String = contxt.Text

            ' Call the EditEmployee function with the updated values
            EditEmployee(userId, username, password, userRole, email, age, contact)
        Else
            MessageBox.Show("Please select an recoard to edit.")
        End If
    End Sub



    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub urcom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles urcom.SelectedIndexChanged

    End Sub

    Private Sub empDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles empDataGridView.CellContentClick

    End Sub

    Private Sub empDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles empDataGridView.CellClick
        If e.RowIndex >= 0 Then
            ' Get values from the clicked row

            Dim username As String = empDataGridView.Rows(e.RowIndex).Cells("Username").Value.ToString()
            Dim password As String = empDataGridView.Rows(e.RowIndex).Cells("Password").Value.ToString()
            Dim userRole As String = empDataGridView.Rows(e.RowIndex).Cells("UserRole").Value.ToString()
            Dim email As String = empDataGridView.Rows(e.RowIndex).Cells("Email").Value.ToString()
            Dim age As Integer = Convert.ToInt32(empDataGridView.Rows(e.RowIndex).Cells("Age").Value)
            Dim contact As String = empDataGridView.Rows(e.RowIndex).Cells("Contact").Value.ToString()

            ' Populate text fields with the values from the clicked row

            untxt.Text = username
            pswtxt.Text = password
            urcom.Text = userRole
            emailtxt.Text = email
            agetxt.Text = age.ToString()
            contxt.Text = contact
        End If
    End Sub
End Class