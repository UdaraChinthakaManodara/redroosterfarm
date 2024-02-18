Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class staff

    Private connectionString As String = "Data Source=DESKTOP-3KRKVUB;Initial Catalog=redroosterfarm;Integrated Security=True"
    Private connection As New SqlConnection(connectionString)
    Private adapter As New SqlDataAdapter()
    Private dt As New DataTable()

    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If ValidateFields() Then
            Dim query As String = "INSERT INTO StaffTable (FirstName, LastName, DOB, Gender, Address, Age, Department, Contact, Salary) VALUES (@FirstName, @LastName, @DOB, @Gender, @Address, @Age, @Department, @Contact, @Salary)"

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@FirstName", st_fname.Text)
                cmd.Parameters.AddWithValue("@LastName", st_Lname.Text)
                cmd.Parameters.AddWithValue("@DOB", st_dob.Value)
                cmd.Parameters.AddWithValue("@Gender", st_gencmb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Address", st_addrs.Text)
                cmd.Parameters.AddWithValue("@Age", st_age.Text)
                cmd.Parameters.AddWithValue("@Department", st_depcmb.Text)
                cmd.Parameters.AddWithValue("@Contact", st_con.Text)
                cmd.Parameters.AddWithValue("@Salary", st_sal.Text)

                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            LoadData()
            ClearFields()
        End If
    End Sub


    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If stfDataGridView.SelectedRows.Count > 0 Then

            If ValidateFields() Then
                ' ... (previous code for updating)  Dim staffID As Integer = Convert.ToInt32(stfDataGridView.SelectedRows(0).Cells("StaffID").Value)
                Dim query As String = "UPDATE StaffTable SET FirstName = @FirstName, LastName = @LastName, DOB = @DOB, Gender = @Gender, Address = @Address, Age = @Age, Department = @Department, Contact = @Contact, Salary = @Salary WHERE StaffID = @StaffID"

                Using cmd As New SqlCommand(query, connection)

                    cmd.Parameters.AddWithValue("@FirstName", st_fname.Text)
                    cmd.Parameters.AddWithValue("@LastName", st_Lname.Text)
                    cmd.Parameters.AddWithValue("@DOB", st_dob.Value)
                    cmd.Parameters.AddWithValue("@Gender", st_gencmb.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Address", st_gencmb.Text)
                    cmd.Parameters.AddWithValue("@Age", st_age.Text)
                    cmd.Parameters.AddWithValue("@Department", st_depcmb.Text)
                    cmd.Parameters.AddWithValue("@Contact", st_con.Text)
                    cmd.Parameters.AddWithValue("@Salary", st_sal.Text)

                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If
        Else
            MessageBox.Show("Please select a row to update.")
        End If

    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If stfDataGridView.SelectedRows.Count > 0 Then
            Dim staffID As Integer = Convert.ToInt32(stfDataGridView.SelectedRows(0).Cells("StaffID").Value)
            Dim query As String = "DELETE FROM StaffTable WHERE StaffID = @StaffID"

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@StaffID", staffID)

                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            LoadData()
            ClearFields()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub


    Private Sub LoadData()
        dt.Clear()
        Dim query As String = "SELECT * FROM StaffTable"
        adapter = New SqlDataAdapter(query, connection)
        adapter.Fill(dt)

        stfDataGridView.DataSource = dt
    End Sub


    Private Sub ClearFields()
        st_fname.Text = ""
        st_Lname.Text = ""
        st_dob.Value = DateTime.Now
        st_gencmb.SelectedIndex = -1
        st_addrs.Text = ""
        st_age.Text = ""
        st_depcmb.Text = ""
        st_con.Text = ""
        st_sal.Text = ""
    End Sub
    Private Function ValidateFields() As Boolean
        ' Basic validation for required fields
        If String.IsNullOrWhiteSpace(st_fname.Text) OrElse
        String.IsNullOrWhiteSpace(st_Lname.Text) OrElse
        st_dob.Value = DateTime.Now OrElse
        st_gencmb.SelectedIndex = -1 OrElse
        String.IsNullOrWhiteSpace(st_addrs.Text) OrElse
        String.IsNullOrWhiteSpace(st_age.Text) OrElse
        String.IsNullOrWhiteSpace(st_depcmb.Text) OrElse
        String.IsNullOrWhiteSpace(st_con.Text) OrElse
        String.IsNullOrWhiteSpace(st_sal.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Additional validation for age (assuming age is a numeric value)
        Dim age As Integer
        If Not Integer.TryParse(st_age.Text, age) OrElse age < 18 Then
            MessageBox.Show("Age must be a valid number and should be 18 or above.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Additional validation for contact number
        Dim contactRegex As New Regex("^\d{10}$") ' Assuming a 10-digit contact number
        If Not contactRegex.IsMatch(st_con.Text) Then
            MessageBox.Show("Contact number must be a 10-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Additional validation logic can be added here if needed
        ' Additional validation for date of birth
        If st_dob.Value > DateTime.Now Then
            MessageBox.Show("Date of Birth cannot be set to a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub SetParameters(command As SqlCommand)
        ' Set parameters for the SQL command based on the values in the UI
        command.Parameters.AddWithValue("@FirstName", st_fname.Text)
        command.Parameters.AddWithValue("@LastName", st_Lname.Text)
        command.Parameters.AddWithValue("@DOB", st_dob.Value)
        command.Parameters.AddWithValue("@Gender", st_gencmb.Text)
        command.Parameters.AddWithValue("@Address", st_addrs.Text)
        command.Parameters.AddWithValue("@Age", st_age.Text)
        command.Parameters.AddWithValue("@Department", st_depcmb.Text)
        command.Parameters.AddWithValue("@Contact", st_con.Text)
        command.Parameters.AddWithValue("@Salary", st_sal.Text)
    End Sub

    Private Sub stfDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stfDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = stfDataGridView.Rows(e.RowIndex)

            st_fname.Text = selectedRow.Cells("FirstName").Value.ToString()
            st_Lname.Text = selectedRow.Cells("LastName").Value.ToString()
            st_dob.Value = Convert.ToDateTime(selectedRow.Cells("DOB").Value)
            st_gencmb.SelectedItem = selectedRow.Cells("Gender").Value.ToString()
            st_addrs.Text = selectedRow.Cells("Address").Value.ToString()
            st_age.Text = selectedRow.Cells("Age").Value.ToString()
            st_depcmb.Text = selectedRow.Cells("Department").Value.ToString()
            st_con.Text = selectedRow.Cells("Contact").Value.ToString()
            st_sal.Text = selectedRow.Cells("Salary").Value.ToString()
        End If
    End Sub
End Class