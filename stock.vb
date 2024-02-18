Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class stock

    Dim connectionString As String = "Data Source=DESKTOP-3KRKVUB;Initial Catalog=redroosterfarm;Integrated Security=True"

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductionTypes()

        LoadStockData()
    End Sub



    Private Sub LoadProductionTypes()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT DISTINCT pro_type FROM production"
                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            protype_cmb.Items.Add(reader("pro_type").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading production types: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadProductionNames(proType As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT pro_name FROM production WHERE pro_type = @proType"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proType", proType)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        proname_cmb.Items.Clear()
                        While reader.Read()
                            proname_cmb.Items.Add(reader("pro_name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading production names: " & ex.Message)
        End Try
    End Sub




    Private Sub LoadStockData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM stock"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim ds As New DataSet()
                    adapter.Fill(ds, "stock")
                    stockDataGridView.DataSource = ds.Tables("stock")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading stock data: " & ex.Message)
        End Try
    End Sub


    Private Function CalculateCost(quantity As Integer, price As Decimal) As Decimal
        Return quantity * price
    End Function

    Private Sub AddStock(proType As String, proName As String, quantity As Integer, expireDate As Date, refOfficer As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO stock (pro_type, pro_name, quantity, cost, expire_date, ref_officer) VALUES (@proType, @proName, @quantity, @cost, @expireDate, @refOfficer)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proType", proType)
                    cmd.Parameters.AddWithValue("@proName", proName)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    Dim price As Decimal = GetProductPrice(proName)
                    Dim cost As Decimal = CalculateCost(quantity, price)
                    cmd.Parameters.AddWithValue("@cost", cost)
                    cmd.Parameters.AddWithValue("@expireDate", expireDate)
                    cmd.Parameters.AddWithValue("@refOfficer", refOfficer)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Stock added successfully.")
            LoadStockData()
        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message)
        End Try
    End Sub

    Private Function GetProductPrice(proName As String) As Decimal
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT pro_price FROM production WHERE pro_name = @proName"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@proName", proName)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Return Convert.ToDecimal(result)
                    Else
                        ' Handle the case where the query returned no result or a NULL value
                        MessageBox.Show("No price found for the product.")
                        Return 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting product price: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Sub UpdateStock(stockID As Integer, proType As String, proName As String, quantity As Integer, expireDate As Date, refOfficer As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE stock SET pro_type = @proType, pro_name = @proName, quantity = @quantity, cost = @cost, expire_date = @expireDate, ref_officer = @refOfficer WHERE stock_id = @stockID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@stockID", stockID)
                    cmd.Parameters.AddWithValue("@proType", proType)
                    cmd.Parameters.AddWithValue("@proName", proName)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    Dim price As Decimal = GetProductPrice(proName)
                    Dim cost As Decimal = CalculateCost(quantity, price)
                    cmd.Parameters.AddWithValue("@cost", cost)
                    cmd.Parameters.AddWithValue("@expireDate", expireDate)
                    cmd.Parameters.AddWithValue("@refOfficer", refOfficer)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Stock updated successfully.")
            LoadStockData()
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteStock(stockID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM stock WHERE stock_id = @stockID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@stockID", stockID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Stock deleted successfully.")
            LoadStockData()
        Catch ex As Exception
            MessageBox.Show("Error deleting stock: " & ex.Message)
        End Try
    End Sub

    Private Sub proTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles protype_cmb.SelectedIndexChanged
        If protype_cmb.SelectedIndex <> -1 Then
            Dim selectedType As String = protype_cmb.SelectedItem.ToString()
            LoadProductionNames(selectedType)
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim proType As String = protype_cmb.SelectedItem.ToString()
        Dim proName As String = proname_cmb.SelectedItem.ToString()
        Dim quantity As Integer = Convert.ToInt32(quantitycmb.Text)
        Dim expireDate As Date = expd_txt.Value
        Dim refOfficer As String = reftxt.Text

        AddStock(proType, proName, quantity, expireDate, refOfficer)
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If stockDataGridView.SelectedRows.Count > 0 Then
            Dim stockID As Integer = Convert.ToInt32(stockDataGridView.SelectedRows(0).Cells("stock_id").Value)
            Dim proType As String = protype_cmb.SelectedItem.ToString()
            Dim proName As String = proname_cmb.SelectedItem.ToString()
            Dim quantity As Integer = Convert.ToInt32(quantitycmb.Text)
            Dim expireDate As Date = expd_txt.Value
            Dim refOfficer As String = reftxt.Text
        End If
    End Sub
    Private Sub exptxt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub proname_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proname_cmb.SelectedIndexChanged
        If protype_cmb.SelectedIndex <> -1 AndAlso proname_cmb.SelectedIndex <> -1 AndAlso Not String.IsNullOrEmpty(quantitycmb.Text) Then
            CalculateAndPopulateCost()
        End If
    End Sub

    Private Sub quantitycmb_ValueChanged(sender As Object, e As EventArgs) Handles quantitycmb.ValueChanged
        If protype_cmb.SelectedIndex <> -1 AndAlso proname_cmb.SelectedIndex <> -1 AndAlso Not String.IsNullOrEmpty(quantitycmb.Text) Then
            CalculateAndPopulateCost()
        End If
    End Sub

    Private Sub CalculateAndPopulateCost()
        Try
            Dim proType As String = protype_cmb.SelectedItem.ToString()
            Dim proName As String = proname_cmb.SelectedItem.ToString()
            Dim quantity As Integer = Convert.ToInt32(quantitycmb.Text)

            ' Get the price for the selected product
            Dim price As Decimal = GetProductPrice(proName)

            ' Calculate the cost based on the quantity and price
            Dim cost As Decimal = CalculateCost(quantity, price)

            ' Populate the cost field
            costtxt.Text = cost.ToString()
        Catch ex As Exception
            MessageBox.Show("Error calculating cost: " & ex.Message)
        End Try
    End Sub

    Private Sub costtxt_TextChanged(sender As Object, e As EventArgs) Handles costtxt.TextChanged

    End Sub
End Class
