Imports System.Configuration
Imports System.Data.SqlClient

Public Class DataAccess
    Public Shared Function GetAllProducts()
        Dim dataTable As New DataTable
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ProductInventoryDB").ConnectionString
        Dim sqlQuery As String = "SELECT * FROM Products"

        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(sqlQuery, conn)
                adapter.Fill(dataTable)
            End Using
        End Using
        Return dataTable
    End Function

    Public Shared Sub AddProduct(name As String, category As String, price As Decimal, stock As Integer)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ProductInventoryDB").ConnectionString
        Dim sqlQuery As String = "INSERT INTO Products (ProductName, Category, Price, QuantityInStock) VALUES (@ProductName, @Category, @Price, @QuantityInStock);"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@ProductName", name)
                cmd.Parameters.AddWithValue("@Category", category)
                cmd.Parameters.AddWithValue("@Price", price)
                cmd.Parameters.AddWithValue("@QuantityInStock", stock)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub UpdateIsDiscontinuedStatus(productId As Integer, isDiscontinued As Boolean)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ProductInventoryDB").ConnectionString
        Dim sqlQuery As String = "UPDATE Products SET IsDiscontinued = @IsDiscontinued WHERE ProductID = @ProductId;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@IsDiscontinued", isDiscontinued)
                cmd.Parameters.AddWithValue("@ProductId", productId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub DeleteProduct(productId As Integer)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ProductInventoryDB").ConnectionString
        Dim sqlQuery As String = "DELETE FROM Products WHERE productID = @productId;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@ProductId", productId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
