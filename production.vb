Imports System.Data.SqlClient

Imports System.Windows.Forms
Public Class production


    Dim connectionString As String = "Data Source=DESKTOP-3KRKVUB;Initial Catalog=redroosterfarm;Integrated Security=True"

    Private Sub ProductionForm_Load(sender As Object, e As EventArgs)
        LoadProductionData()
    End Sub

    Private Sub LoadProductionData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT pro_id, pro_name, pro_type, pro_weight, pro_loc, pro_temp, pro_price FROM production"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim ds As New DataSet()
                    adapter.Fill(ds, "production")
                    proDataGridView.DataSource = ds.Tables("production")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading production data: " & ex.Message)
        End Try
    End Sub

    Private Sub AddProduction(proName As String, proType As String, proWeight As Decimal, proLoc As String, proTemp As Decimal, proNote As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO production (pro_name, pro_type, pro_weight, pro_loc, pro_temp, pro_price) VALUES (@proName, @proType, @proWeight, @proLoc, @proTemp, @proNote)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proName", proName)
                    cmd.Parameters.AddWithValue("@proType", proType)
                    cmd.Parameters.AddWithValue("@proWeight", proWeight)
                    cmd.Parameters.AddWithValue("@proLoc", proLoc)
                    cmd.Parameters.AddWithValue("@proTemp", proTemp)
                    cmd.Parameters.AddWithValue("@proNote", proNote)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Production added successfully.")
            LoadProductionData()
        Catch ex As Exception
            MessageBox.Show("Error adding production: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateProduction(proID As Integer, proName As String, proType As String, proWeight As Decimal, proLoc As String, proTemp As Decimal, proNote As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE production SET pro_name = @proName, pro_type = @proType, pro_weight = @proWeight, pro_loc = @proLoc, pro_temp = @proTemp, pro_price = @proNote WHERE pro_id = @proID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proID", proID)
                    cmd.Parameters.AddWithValue("@proName", proName)
                    cmd.Parameters.AddWithValue("@proType", proType)
                    cmd.Parameters.AddWithValue("@proWeight", proWeight)
                    cmd.Parameters.AddWithValue("@proLoc", proLoc)
                    cmd.Parameters.AddWithValue("@proTemp", proTemp)
                    cmd.Parameters.AddWithValue("@proNote", proNote)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Production updated successfully.")
            LoadProductionData()
        Catch ex As Exception
            MessageBox.Show("Error updating production: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteProduction(proID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM production WHERE pro_id = @proID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proID", proID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Production deleted successfully.")
            LoadProductionData()
        Catch ex As Exception
            MessageBox.Show("Error deleting production: " & ex.Message)
        End Try
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        ' Call the AddProduction function with the provided values
        AddProduction(pntxt.Text, ptypetxt.Text, Convert.ToDecimal(pweitxt.Text), plcmb.Text, Convert.ToDecimal(ptemptxt.Text), pnotetxt.Text)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        ' Check if a row is selected in the DataGridView
        If proDataGridView.SelectedRows.Count > 0 Then
            ' Get values from the selected row
            Dim proID As Integer = Convert.ToInt32(proDataGridView.SelectedRows(0).Cells("pro_id").Value)
            Dim proName As String = pntxt.Text
            Dim proType As String = ptypetxt.Text
            Dim proWeight As Decimal = Convert.ToDecimal(pweitxt.Text)
            Dim proLoc As String = plcmb.Text
            Dim proTemp As Decimal = Convert.ToDecimal(ptemptxt.Text)
            Dim proNote As String = pnotetxt.Text

            ' Call the UpdateProduction function with the updated values
            UpdateProduction(proID, proName, proType, proWeight, proLoc, proTemp, proNote)
        Else
            MessageBox.Show("Please select a production to update.")
        End If
    End Sub



    Private Sub productionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles proDataGridView.CellClick
        If e.RowIndex >= 0 Then
            ' Get values from the clicked row
            pntxt.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_name").Value.ToString()
            ptypetxt.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_type").Value.ToString()
            pweitxt.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_weight").Value.ToString()
            plcmb.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_loc").Value.ToString()
            ptemptxt.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_temp").Value.ToString()
            pnotetxt.Text = proDataGridView.Rows(e.RowIndex).Cells("pro_price").Value.ToString()
        End If
    End Sub

    Private Sub production_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        ' Check if a row is selected in the DataGridView
        If proDataGridView.SelectedRows.Count > 0 Then
            ' Get the proID of the selected row
            Dim proID As Integer = Convert.ToInt32(proDataGridView.SelectedRows(0).Cells("pro_id").Value)
            ' Call the DeleteProduction function with the selected proID
            DeleteProduction(proID)
        Else
            MessageBox.Show("Please select a production to delete.")
        End If
    End Sub
End Class