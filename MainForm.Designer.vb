<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonShowAllProducts = New System.Windows.Forms.Button()
        Me.ButtonAddNewProductForm = New System.Windows.Forms.Button()
        Me.ButtonToggleDiscontinuesStatus = New System.Windows.Forms.Button()
        Me.ButtonDeleteProduct = New System.Windows.Forms.Button()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Location = New System.Drawing.Point(13, 13)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(775, 303)
        Me.ProductsDataGridView.TabIndex = 0
        '
        'ButtonShowAllProducts
        '
        Me.ButtonShowAllProducts.Location = New System.Drawing.Point(13, 323)
        Me.ButtonShowAllProducts.Name = "ButtonShowAllProducts"
        Me.ButtonShowAllProducts.Size = New System.Drawing.Size(162, 23)
        Me.ButtonShowAllProducts.TabIndex = 1
        Me.ButtonShowAllProducts.Text = "Show all products"
        Me.ButtonShowAllProducts.UseVisualStyleBackColor = True
        '
        'ButtonAddNewProductForm
        '
        Me.ButtonAddNewProductForm.Location = New System.Drawing.Point(13, 352)
        Me.ButtonAddNewProductForm.Name = "ButtonAddNewProductForm"
        Me.ButtonAddNewProductForm.Size = New System.Drawing.Size(162, 23)
        Me.ButtonAddNewProductForm.TabIndex = 2
        Me.ButtonAddNewProductForm.Text = "Add new product"
        Me.ButtonAddNewProductForm.UseVisualStyleBackColor = True
        '
        'ButtonToggleDiscontinuesStatus
        '
        Me.ButtonToggleDiscontinuesStatus.Enabled = False
        Me.ButtonToggleDiscontinuesStatus.Location = New System.Drawing.Point(13, 381)
        Me.ButtonToggleDiscontinuesStatus.Name = "ButtonToggleDiscontinuesStatus"
        Me.ButtonToggleDiscontinuesStatus.Size = New System.Drawing.Size(162, 23)
        Me.ButtonToggleDiscontinuesStatus.TabIndex = 3
        Me.ButtonToggleDiscontinuesStatus.Text = "Toggle ""IsDiscontinued"" status"
        Me.ButtonToggleDiscontinuesStatus.UseVisualStyleBackColor = True
        '
        'ButtonDeleteProduct
        '
        Me.ButtonDeleteProduct.Enabled = False
        Me.ButtonDeleteProduct.Location = New System.Drawing.Point(13, 410)
        Me.ButtonDeleteProduct.Name = "ButtonDeleteProduct"
        Me.ButtonDeleteProduct.Size = New System.Drawing.Size(162, 23)
        Me.ButtonDeleteProduct.TabIndex = 4
        Me.ButtonDeleteProduct.Text = "Delete product"
        Me.ButtonDeleteProduct.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDeleteProduct)
        Me.Controls.Add(Me.ButtonToggleDiscontinuesStatus)
        Me.Controls.Add(Me.ButtonAddNewProductForm)
        Me.Controls.Add(Me.ButtonShowAllProducts)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Name = "MainForm"
        Me.Text = "ProductInventoryApp"
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents ButtonShowAllProducts As Button
    Friend WithEvents ButtonAddNewProductForm As Button
    Friend WithEvents ButtonToggleDiscontinuesStatus As Button
    Friend WithEvents ButtonDeleteProduct As Button
End Class
