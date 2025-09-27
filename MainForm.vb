Imports System.Configuration

Public Class MainForm
    Private Sub ButtonShowAllProducts_Click(sender As Object, e As EventArgs) Handles ButtonShowAllProducts.Click
        LoadProductData()
    End Sub

    Private Sub LoadProductData()
        ProductsDataGridView.DataSource = DataAccess.GetAllProducts()
    End Sub

    Private Sub ButtonAddNewProductForm_Click(sender As Object, e As EventArgs) Handles ButtonAddNewProductForm.Click
        Dim addForm As New AddProductForm
        addForm.ShowDialog()
    End Sub

    Private Sub ProductsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProductsDataGridView.SelectionChanged
        If ProductsDataGridView.SelectedRows.Count > 0 Then
            ButtonToggleDiscontinuesStatus.Enabled = True
            ButtonDeleteProduct.Enabled = True
        Else
            ButtonToggleDiscontinuesStatus.Enabled = False
            ButtonDeleteProduct.Enabled = False
        End If
    End Sub

    Private Sub ButtonToggleDiscontinuesStatus_Click(sender As Object, e As EventArgs) Handles ButtonToggleDiscontinuesStatus.Click
        Dim currentStatus = ProductsDataGridView.SelectedRows(0).Cells("IsDiscontinued").Value
        Dim newStatus = Not currentStatus

        Dim productId = ProductsDataGridView.SelectedRows(0).Cells("ProductId").Value

        DataAccess.UpdateIsDiscontinuedStatus(productId, newStatus)

        ProductsDataGridView.DataSource = DataAccess.GetAllProducts()
    End Sub

    Private Sub ButtonDeleteProduct_Click(sender As Object, e As EventArgs) Handles ButtonDeleteProduct.Click
        Dim nameProduct As String = ProductsDataGridView.SelectedRows(0).Cells("ProductName").Value

        Dim yesOrNo As DialogResult =
        MessageBox.Show(
            $"Do you want to delete: {nameProduct} from the database?",
            "DELETING PRODUCT!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If yesOrNo = DialogResult.Yes Then
            Dim productId = ProductsDataGridView.SelectedRows(0).Cells("ProductId").Value

            DataAccess.DeleteProduct(productId)

            ProductsDataGridView.DataSource = DataAccess.GetAllProducts()
        End If


    End Sub
End Class
