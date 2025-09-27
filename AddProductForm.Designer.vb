<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxProductName = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBoxProductPrice = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBoxProductStock = New System.Windows.Forms.TextBox()
        Me.ButtonAddProduct = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ComboBoxProductCategory = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Enter product name:"
        '
        'TextBoxProductName
        '
        Me.TextBoxProductName.Location = New System.Drawing.Point(151, 12)
        Me.TextBoxProductName.Name = "TextBoxProductName"
        Me.TextBoxProductName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProductName.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(12, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Enter category of product:"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(12, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 20)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Enter price:"
        '
        'TextBoxProductPrice
        '
        Me.TextBoxProductPrice.Location = New System.Drawing.Point(151, 64)
        Me.TextBoxProductPrice.Name = "TextBoxProductPrice"
        Me.TextBoxProductPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProductPrice.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(12, 90)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(133, 20)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Text = "Enter stock:"
        '
        'TextBoxProductStock
        '
        Me.TextBoxProductStock.Location = New System.Drawing.Point(151, 90)
        Me.TextBoxProductStock.Name = "TextBoxProductStock"
        Me.TextBoxProductStock.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProductStock.TabIndex = 7
        '
        'ButtonAddProduct
        '
        Me.ButtonAddProduct.Location = New System.Drawing.Point(12, 117)
        Me.ButtonAddProduct.Name = "ButtonAddProduct"
        Me.ButtonAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddProduct.TabIndex = 8
        Me.ButtonAddProduct.Text = "Add product"
        Me.ButtonAddProduct.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(176, 117)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 9
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ComboBoxProductCategory
        '
        Me.ComboBoxProductCategory.FormattingEnabled = True
        Me.ComboBoxProductCategory.Location = New System.Drawing.Point(151, 39)
        Me.ComboBoxProductCategory.Name = "ComboBoxProductCategory"
        Me.ComboBoxProductCategory.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxProductCategory.TabIndex = 10
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 152)
        Me.Controls.Add(Me.ComboBoxProductCategory)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAddProduct)
        Me.Controls.Add(Me.TextBoxProductStock)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBoxProductPrice)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBoxProductName)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AddProductForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxProductName As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBoxProductPrice As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBoxProductStock As TextBox
    Friend WithEvents ButtonAddProduct As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ComboBoxProductCategory As ComboBox
End Class
