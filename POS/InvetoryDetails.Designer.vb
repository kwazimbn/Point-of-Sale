<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvetoryDetails
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.grbTotalSaleSet = New System.Windows.Forms.GroupBox()
        Me.btnOrderVoid = New System.Windows.Forms.Button()
        Me.btnLineVoid = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblOrderCostPrice = New System.Windows.Forms.Label()
        Me.lblOrderQty = New System.Windows.Forms.Label()
        Me.btnProcessSale = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblReceiptQty = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdSupplierOrder = New System.Windows.Forms.DataGridView()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSOAdd = New System.Windows.Forms.Button()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdSupplierStock = New System.Windows.Forms.DataGridView()
        Me.grdCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSupID = New System.Windows.Forms.Label()
        Me.cmbSupplierList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pageNavCMB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTotalSaleSet.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdSupplierOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSupplierStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'grbTotalSaleSet
        '
        Me.grbTotalSaleSet.Controls.Add(Me.btnOrderVoid)
        Me.grbTotalSaleSet.Controls.Add(Me.btnLineVoid)
        Me.grbTotalSaleSet.Controls.Add(Me.lbl2)
        Me.grbTotalSaleSet.Controls.Add(Me.lblOrderCostPrice)
        Me.grbTotalSaleSet.Controls.Add(Me.lblOrderQty)
        Me.grbTotalSaleSet.Controls.Add(Me.btnProcessSale)
        Me.grbTotalSaleSet.Controls.Add(Me.lbl)
        Me.grbTotalSaleSet.Controls.Add(Me.lblReceiptQty)
        Me.grbTotalSaleSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbTotalSaleSet.Location = New System.Drawing.Point(22, 341)
        Me.grbTotalSaleSet.Name = "grbTotalSaleSet"
        Me.grbTotalSaleSet.Size = New System.Drawing.Size(429, 142)
        Me.grbTotalSaleSet.TabIndex = 13
        Me.grbTotalSaleSet.TabStop = False
        '
        'btnOrderVoid
        '
        Me.btnOrderVoid.Location = New System.Drawing.Point(280, 55)
        Me.btnOrderVoid.Name = "btnOrderVoid"
        Me.btnOrderVoid.Size = New System.Drawing.Size(101, 35)
        Me.btnOrderVoid.TabIndex = 32
        Me.btnOrderVoid.Text = "Order Void"
        Me.btnOrderVoid.UseVisualStyleBackColor = True
        '
        'btnLineVoid
        '
        Me.btnLineVoid.Location = New System.Drawing.Point(173, 55)
        Me.btnLineVoid.Name = "btnLineVoid"
        Me.btnLineVoid.Size = New System.Drawing.Size(101, 35)
        Me.btnLineVoid.TabIndex = 4
        Me.btnLineVoid.Text = "Item Void"
        Me.btnLineVoid.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(59, 103)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 13)
        Me.lbl2.TabIndex = 31
        Me.lbl2.Text = "Label2"
        Me.lbl2.Visible = False
        '
        'lblOrderCostPrice
        '
        Me.lblOrderCostPrice.AutoSize = True
        Me.lblOrderCostPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCostPrice.Location = New System.Drawing.Point(277, 25)
        Me.lblOrderCostPrice.Name = "lblOrderCostPrice"
        Me.lblOrderCostPrice.Size = New System.Drawing.Size(51, 13)
        Me.lblOrderCostPrice.TabIndex = 30
        Me.lblOrderCostPrice.Text = "..........."
        '
        'lblOrderQty
        '
        Me.lblOrderQty.AutoSize = True
        Me.lblOrderQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderQty.Location = New System.Drawing.Point(69, 25)
        Me.lblOrderQty.Name = "lblOrderQty"
        Me.lblOrderQty.Size = New System.Drawing.Size(51, 13)
        Me.lblOrderQty.TabIndex = 29
        Me.lblOrderQty.Text = "..........."
        '
        'btnProcessSale
        '
        Me.btnProcessSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessSale.Location = New System.Drawing.Point(6, 54)
        Me.btnProcessSale.Name = "btnProcessSale"
        Me.btnProcessSale.Size = New System.Drawing.Size(101, 35)
        Me.btnProcessSale.TabIndex = 28
        Me.btnProcessSale.Text = "Record Order"
        Me.btnProcessSale.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(157, 25)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(121, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Order Cost Price : R"
        '
        'lblReceiptQty
        '
        Me.lblReceiptQty.AutoSize = True
        Me.lblReceiptQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptQty.Location = New System.Drawing.Point(3, 23)
        Me.lblReceiptQty.Name = "lblReceiptQty"
        Me.lblReceiptQty.Size = New System.Drawing.Size(62, 13)
        Me.lblReceiptQty.TabIndex = 0
        Me.lblReceiptQty.Text = "Item Qty :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox3.Controls.Add(Me.grbTotalSaleSet)
        Me.GroupBox3.Controls.Add(Me.grdSupplierOrder)
        Me.GroupBox3.Location = New System.Drawing.Point(617, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 529)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invetory Details"
        '
        'grdSupplierOrder
        '
        Me.grdSupplierOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSupplierOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.ItemDesc, Me.Qty, Me.CostPrice, Me.Unit})
        Me.grdSupplierOrder.Location = New System.Drawing.Point(8, 19)
        Me.grdSupplierOrder.Name = "grdSupplierOrder"
        Me.grdSupplierOrder.Size = New System.Drawing.Size(443, 314)
        Me.grdSupplierOrder.TabIndex = 1
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Width = 60
        '
        'ItemDesc
        '
        Me.ItemDesc.HeaderText = "ItemDesc"
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.Width = 120
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 50
        '
        'CostPrice
        '
        Me.CostPrice.HeaderText = "Cost Price"
        Me.CostPrice.Name = "CostPrice"
        Me.CostPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CostPrice.Width = 65
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'btnSOAdd
        '
        Me.btnSOAdd.Location = New System.Drawing.Point(252, 599)
        Me.btnSOAdd.Name = "btnSOAdd"
        Me.btnSOAdd.Size = New System.Drawing.Size(101, 35)
        Me.btnSOAdd.TabIndex = 3
        Me.btnSOAdd.Text = "Add to Cart"
        Me.btnSOAdd.UseVisualStyleBackColor = True
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "SupplierID"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.Width = 60
        '
        'grdSupplierStock
        '
        Me.grdSupplierStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSupplierStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdCheck})
        Me.grdSupplierStock.Location = New System.Drawing.Point(9, 96)
        Me.grdSupplierStock.Name = "grdSupplierStock"
        Me.grdSupplierStock.Size = New System.Drawing.Size(537, 387)
        Me.grdSupplierStock.TabIndex = 1
        '
        'grdCheck
        '
        Me.grdCheck.HeaderText = "Check"
        Me.grdCheck.Name = "grdCheck"
        Me.grdCheck.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSupID)
        Me.GroupBox2.Controls.Add(Me.cmbSupplierList)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(531, 64)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search for Item"
        '
        'lblSupID
        '
        Me.lblSupID.AutoSize = True
        Me.lblSupID.Location = New System.Drawing.Point(203, 32)
        Me.lblSupID.Name = "lblSupID"
        Me.lblSupID.Size = New System.Drawing.Size(31, 13)
        Me.lblSupID.TabIndex = 10
        Me.lblSupID.Text = "........"
        Me.lblSupID.Visible = False
        '
        'cmbSupplierList
        '
        Me.cmbSupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplierList.FormattingEnabled = True
        Me.cmbSupplierList.Location = New System.Drawing.Point(61, 30)
        Me.cmbSupplierList.Name = "cmbSupplierList"
        Me.cmbSupplierList.Size = New System.Drawing.Size(121, 21)
        Me.cmbSupplierList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suppier :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grdSupplierStock)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 499)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invetory Details"
        '
        'pageNavCMB
        '
        Me.pageNavCMB.FormattingEnabled = True
        Me.pageNavCMB.Items.AddRange(New Object() {"Customers", "Employees", "Logout"})
        Me.pageNavCMB.Location = New System.Drawing.Point(1101, 21)
        Me.pageNavCMB.Name = "pageNavCMB"
        Me.pageNavCMB.Size = New System.Drawing.Size(121, 21)
        Me.pageNavCMB.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1020, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InvetoryDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 680)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pageNavCMB)
        Me.Controls.Add(Me.btnSOAdd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InvetoryDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTotalSaleSet.ResumeLayout(False)
        Me.grbTotalSaleSet.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdSupplierOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSupplierStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents btnSOAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grbTotalSaleSet As System.Windows.Forms.GroupBox
    Friend WithEvents btnOrderVoid As System.Windows.Forms.Button
    Friend WithEvents btnLineVoid As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblOrderCostPrice As System.Windows.Forms.Label
    Friend WithEvents lblOrderQty As System.Windows.Forms.Label
    Friend WithEvents btnProcessSale As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents lblReceiptQty As System.Windows.Forms.Label
    Friend WithEvents grdSupplierOrder As System.Windows.Forms.DataGridView
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSupID As System.Windows.Forms.Label
    Friend WithEvents cmbSupplierList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdSupplierStock As System.Windows.Forms.DataGridView
    Friend WithEvents grdCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SupplierID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pageNavCMB As System.Windows.Forms.ComboBox
End Class
