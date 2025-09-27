Imports System.Windows.Forms.VisualStyles

Public Class AddProductForm

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxProductCategory.Text = "Choose category"
        ComboBoxProductCategory.Items.Add("Electronics")
        ComboBoxProductCategory.Items.Add("Furniture")
        ComboBoxProductCategory.Items.Add("Stationery")
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        ' First, validate ALL inputs before processing
        If String.IsNullOrWhiteSpace(TextBoxProductName.Text) Then
            MessageBox.Show("Please enter a product name", "Product name is empty.")
            TextBoxProductName.Focus()
            Return
        End If

        If ComboBoxProductCategory.Text = "Choose category" Then
            MessageBox.Show("Please select a category", "Category not selected.")
            ComboBoxProductCategory.Focus()
            Return
        End If

        ' Validate Price - must be a valid decimal
        Dim price As Decimal
        If Not Decimal.TryParse(TextBoxProductPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price (numbers and decimal point only)", "Invalid Price")
            TextBoxProductPrice.Focus()
            Return
        End If

        ' Validate Stock - must be a valid integer
        Dim stock As Integer
        If Not Integer.TryParse(TextBoxProductStock.Text, stock) Then
            MessageBox.Show("Please enter a valid stock quantity (whole numbers only)", "Invalid Stock")
            TextBoxProductStock.Focus()
            Return
        End If

        ' Additional validation: stock shouldn't be negative
        If stock < 0 Then
            MessageBox.Show("Stock quantity cannot be negative", "Invalid Stock")
            TextBoxProductStock.Focus()
            Return
        End If

        ' Only if ALL validations pass, get the values and call the method
        Dim name As String = TextBoxProductName.Text.Trim()
        Dim category As String = ComboBoxProductCategory.Text

        DataAccess.AddProduct(name, category, price, stock)
        MessageBox.Show("Product added successfully!")
        Me.Close()
    End Sub
End Class