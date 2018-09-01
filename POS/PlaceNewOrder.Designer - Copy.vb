<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceNewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceNewOrder))
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.btnAddtoSalesSet = New System.Windows.Forms.Button()
        Me.grdCategoryListItem = New System.Windows.Forms.DataGridView()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_to_Cart = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grpSaleSet = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdStockDecrement = New System.Windows.Forms.DataGridView()
        Me.btnProcessSale = New System.Windows.Forms.Button()
        Me.grbTotalSaleSet = New System.Windows.Forms.GroupBox()
        Me.btnReceiptVoid = New System.Windows.Forms.Button()
        Me.btnLineVoid = New System.Windows.Forms.Button()
        Me.txtSaleTotal = New System.Windows.Forms.TextBox()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblReceiptQty = New System.Windows.Forms.Label()
        Me.grdSaleSet = New System.Windows.Forms.DataGridView()
        Me.SaleQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCategoryList = New System.Windows.Forms.GroupBox()
        Me.tspCategory = New System.Windows.Forms.ToolStrip()
        Me.btnBurgers = New System.Windows.Forms.ToolStripButton()
        Me.btnToast = New System.Windows.Forms.ToolStripButton()
        Me.btnChknPc = New System.Windows.Forms.ToolStripButton()
        Me.btnChknStrps = New System.Windows.Forms.ToolStripButton()
        Me.btnWrap = New System.Windows.Forms.ToolStripButton()
        Me.lblTender = New System.Windows.Forms.Label()
        Me.txtTenderAmount = New System.Windows.Forms.TextBox()
        Me.grpCategory.SuspendLayout()
        CType(Me.grdCategoryListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSaleSet.SuspendLayout()
        CType(Me.grdStockDecrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTotalSaleSet.SuspendLayout()
        CType(Me.grdSaleSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategoryList.SuspendLayout()
        Me.tspCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.btnAddtoSalesSet)
        Me.grpCategory.Controls.Add(Me.grdCategoryListItem)
        Me.grpCategory.Location = New System.Drawing.Point(500, 47)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(546, 584)
        Me.grpCategory.TabIndex = 0
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'btnAddtoSalesSet
        '
        Me.btnAddtoSalesSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoSalesSet.Location = New System.Drawing.Point(222, 533)
        Me.btnAddtoSalesSet.Name = "btnAddtoSalesSet"
        Me.btnAddtoSalesSet.Size = New System.Drawing.Size(101, 35)
        Me.btnAddtoSalesSet.TabIndex = 1
        Me.btnAddtoSalesSet.Text = "Add to Cart"
        Me.btnAddtoSalesSet.UseVisualStyleBackColor = True
        '
        'grdCategoryListItem
        '
        Me.grdCategoryListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCategoryListItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Qty, Me.Add_to_Cart})
        Me.grdCategoryListItem.Location = New System.Drawing.Point(6, 31)
        Me.grdCategoryListItem.Name = "grdCategoryListItem"
        Me.grdCategoryListItem.Size = New System.Drawing.Size(521, 484)
        Me.grdCategoryListItem.TabIndex = 0
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Add_to_Cart
        '
        Me.Add_to_Cart.HeaderText = "Add to Cart"
        Me.Add_to_Cart.Name = "Add_to_Cart"
        Me.Add_to_Cart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'grpSaleSet
        '
        Me.grpSaleSet.Controls.Add(Me.txtTenderAmount)
        Me.grpSaleSet.Controls.Add(Me.lblTender)
        Me.grpSaleSet.Controls.Add(Me.Label2)
        Me.grpSaleSet.Controls.Add(Me.txtCustomerId)
        Me.grpSaleSet.Controls.Add(Me.cmbPaymentMethod)
        Me.grpSaleSet.Controls.Add(Me.Label1)
        Me.grpSaleSet.Controls.Add(Me.grdStockDecrement)
        Me.grpSaleSet.Controls.Add(Me.btnProcessSale)
        Me.grpSaleSet.Controls.Add(Me.grbTotalSaleSet)
        Me.grpSaleSet.Controls.Add(Me.grdSaleSet)
        Me.grpSaleSet.Location = New System.Drawing.Point(12, 50)
        Me.grpSaleSet.Name = "grpSaleSet"
        Me.grpSaleSet.Size = New System.Drawing.Size(413, 581)
        Me.grpSaleSet.TabIndex = 0
        Me.grpSaleSet.TabStop = False
        Me.grpSaleSet.Text = "Sale Set"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Customer Id :"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(90, 468)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerId.TabIndex = 8
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Select Payment Type", "Cash", "Topup"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(90, 436)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(132, 21)
        Me.cmbPaymentMethod.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Method of Pay :"
        '
        'grdStockDecrement
        '
        Me.grdStockDecrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockDecrement.Location = New System.Drawing.Point(55, 114)
        Me.grdStockDecrement.Name = "grdStockDecrement"
        Me.grdStockDecrement.Size = New System.Drawing.Size(240, 150)
        Me.grdStockDecrement.TabIndex = 2
        '
        'btnProcessSale
        '
        Me.btnProcessSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessSale.Location = New System.Drawing.Point(131, 534)
        Me.btnProcessSale.Name = "btnProcessSale"
        Me.btnProcessSale.Size = New System.Drawing.Size(101, 31)
        Me.btnProcessSale.TabIndex = 5
        Me.btnProcessSale.Text = "Proccess Sale"
        Me.btnProcessSale.UseVisualStyleBackColor = True
        '
        'grbTotalSaleSet
        '
        Me.grbTotalSaleSet.Controls.Add(Me.btnReceiptVoid)
        Me.grbTotalSaleSet.Controls.Add(Me.btnLineVoid)
        Me.grbTotalSaleSet.Controls.Add(Me.txtSaleTotal)
        Me.grbTotalSaleSet.Controls.Add(Me.lblSaleTotal)
        Me.grbTotalSaleSet.Controls.Add(Me.txtQty)
        Me.grbTotalSaleSet.Controls.Add(Me.lblReceiptQty)
        Me.grbTotalSaleSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbTotalSaleSet.Location = New System.Drawing.Point(12, 349)
        Me.grbTotalSaleSet.Name = "grbTotalSaleSet"
        Me.grbTotalSaleSet.Size = New System.Drawing.Size(395, 83)
        Me.grbTotalSaleSet.TabIndex = 1
        Me.grbTotalSaleSet.TabStop = False
        '
        'btnReceiptVoid
        '
        Me.btnReceiptVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptVoid.Location = New System.Drawing.Point(182, 51)
        Me.btnReceiptVoid.Name = "btnReceiptVoid"
        Me.btnReceiptVoid.Size = New System.Drawing.Size(112, 23)
        Me.btnReceiptVoid.TabIndex = 6
        Me.btnReceiptVoid.Text = "Receipt Void"
        Me.btnReceiptVoid.UseVisualStyleBackColor = True
        '
        'btnLineVoid
        '
        Me.btnLineVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLineVoid.Location = New System.Drawing.Point(32, 52)
        Me.btnLineVoid.Name = "btnLineVoid"
        Me.btnLineVoid.Size = New System.Drawing.Size(92, 23)
        Me.btnLineVoid.TabIndex = 5
        Me.btnLineVoid.Text = "Line Void"
        Me.btnLineVoid.UseVisualStyleBackColor = True
        '
        'txtSaleTotal
        '
        Me.txtSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleTotal.Location = New System.Drawing.Point(191, 21)
        Me.txtSaleTotal.Name = "txtSaleTotal"
        Me.txtSaleTotal.ReadOnly = True
        Me.txtSaleTotal.Size = New System.Drawing.Size(130, 22)
        Me.txtSaleTotal.TabIndex = 4
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.AutoSize = True
        Me.lblSaleTotal.Location = New System.Drawing.Point(116, 25)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(69, 13)
        Me.lblSaleTotal.TabIndex = 2
        Me.lblSaleTotal.Text = "Sale Total R:"
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(78, 20)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(29, 22)
        Me.txtQty.TabIndex = 1
        '
        'lblReceiptQty
        '
        Me.lblReceiptQty.AutoSize = True
        Me.lblReceiptQty.Location = New System.Drawing.Point(3, 23)
        Me.lblReceiptQty.Name = "lblReceiptQty"
        Me.lblReceiptQty.Size = New System.Drawing.Size(69, 13)
        Me.lblReceiptQty.TabIndex = 0
        Me.lblReceiptQty.Text = "Receipt Qty :"
        '
        'grdSaleSet
        '
        Me.grdSaleSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSaleSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleQty, Me.Decription, Me.Amount})
        Me.grdSaleSet.Location = New System.Drawing.Point(6, 16)
        Me.grdSaleSet.Name = "grdSaleSet"
        Me.grdSaleSet.Size = New System.Drawing.Size(401, 316)
        Me.grdSaleSet.TabIndex = 0
        '
        'SaleQty
        '
        Me.SaleQty.HeaderText = "Qty"
        Me.SaleQty.Name = "SaleQty"
        Me.SaleQty.ReadOnly = True
        '
        'Decription
        '
        Me.Decription.HeaderText = "Decription"
        Me.Decription.Name = "Decription"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'grpCategoryList
        '
        Me.grpCategoryList.Controls.Add(Me.tspCategory)
        Me.grpCategoryList.Location = New System.Drawing.Point(431, 49)
        Me.grpCategoryList.Name = "grpCategoryList"
        Me.grpCategoryList.Size = New System.Drawing.Size(63, 502)
        Me.grpCategoryList.TabIndex = 0
        Me.grpCategoryList.TabStop = False
        Me.grpCategoryList.Text = "Category List"
        '
        'tspCategory
        '
        Me.tspCategory.Dock = System.Windows.Forms.DockStyle.Right
        Me.tspCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBurgers, Me.btnToast, Me.btnChknPc, Me.btnChknStrps, Me.btnWrap})
        Me.tspCategory.Location = New System.Drawing.Point(36, 16)
        Me.tspCategory.Name = "tspCategory"
        Me.tspCategory.Size = New System.Drawing.Size(24, 483)
        Me.tspCategory.TabIndex = 0
        Me.tspCategory.Text = "ToolStrip1"
        '
        'btnBurgers
        '
        Me.btnBurgers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBurgers.Image = CType(resources.GetObject("btnBurgers.Image"), System.Drawing.Image)
        Me.btnBurgers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(21, 20)
        Me.btnBurgers.Text = "ToolStripButton1"
        '
        'btnToast
        '
        Me.btnToast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToast.Image = CType(resources.GetObject("btnToast.Image"), System.Drawing.Image)
        Me.btnToast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToast.Name = "btnToast"
        Me.btnToast.Size = New System.Drawing.Size(21, 20)
        Me.btnToast.Text = "ToolStripButton2"
        '
        'btnChknPc
        '
        Me.btnChknPc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChknPc.Image = CType(resources.GetObject("btnChknPc.Image"), System.Drawing.Image)
        Me.btnChknPc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChknPc.Name = "btnChknPc"
        Me.btnChknPc.Size = New System.Drawing.Size(21, 20)
        Me.btnChknPc.Text = "ToolStripButton3"
        '
        'btnChknStrps
        '
        Me.btnChknStrps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChknStrps.Image = CType(resources.GetObject("btnChknStrps.Image"), System.Drawing.Image)
        Me.btnChknStrps.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChknStrps.Name = "btnChknStrps"
        Me.btnChknStrps.Size = New System.Drawing.Size(21, 20)
        Me.btnChknStrps.Text = "ToolStripButton4"
        '
        'btnWrap
        '
        Me.btnWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnWrap.Image = CType(resources.GetObject("btnWrap.Image"), System.Drawing.Image)
        Me.btnWrap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnWrap.Name = "btnWrap"
        Me.btnWrap.Size = New System.Drawing.Size(21, 20)
        Me.btnWrap.Text = "ToolStripButton5"
        '
        'lblTender
        '
        Me.lblTender.AutoSize = True
        Me.lblTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTender.Location = New System.Drawing.Point(1, 501)
        Me.lblTender.Name = "lblTender"
        Me.lblTender.Size = New System.Drawing.Size(101, 13)
        Me.lblTender.TabIndex = 10
        Me.lblTender.Text = "Tender Amount :"
        '
        'txtTenderAmount
        '
        Me.txtTenderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenderAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenderAmount.Location = New System.Drawing.Point(105, 494)
        Me.txtTenderAmount.Name = "txtTenderAmount"
        Me.txtTenderAmount.Size = New System.Drawing.Size(161, 22)
        Me.txtTenderAmount.TabIndex = 11
        '
        'PlaceNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 680)
        Me.Controls.Add(Me.grpCategoryList)
        Me.Controls.Add(Me.grpSaleSet)
        Me.Controls.Add(Me.grpCategory)
        Me.Name = "PlaceNewOrder"
        Me.Text = "PlaceNewOrder"
        Me.grpCategory.ResumeLayout(False)
        CType(Me.grdCategoryListItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSaleSet.ResumeLayout(False)
        Me.grpSaleSet.PerformLayout()
        CType(Me.grdStockDecrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTotalSaleSet.ResumeLayout(False)
        Me.grbTotalSaleSet.PerformLayout()
        CType(Me.grdSaleSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategoryList.ResumeLayout(False)
        Me.grpCategoryList.PerformLayout()
        Me.tspCategory.ResumeLayout(False)
        Me.tspCategory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCategory As System.Windows.Forms.GroupBox
    Friend WithEvents grdCategoryListItem As System.Windows.Forms.DataGridView
    Friend WithEvents grpSaleSet As System.Windows.Forms.GroupBox
    Friend WithEvents grdSaleSet As System.Windows.Forms.DataGridView
    Friend WithEvents SaleQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpCategoryList As System.Windows.Forms.GroupBox
    Friend WithEvents tspCategory As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBurgers As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnToast As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChknPc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChknStrps As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnWrap As System.Windows.Forms.ToolStripButton
    Friend WithEvents grbTotalSaleSet As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaleTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptQty As System.Windows.Forms.Label
    Friend WithEvents btnProcessSale As System.Windows.Forms.Button
    Friend WithEvents btnAddtoSalesSet As System.Windows.Forms.Button
    Friend WithEvents grdStockDecrement As System.Windows.Forms.DataGridView
    Friend WithEvents btnReceiptVoid As System.Windows.Forms.Button
    Friend WithEvents btnLineVoid As System.Windows.Forms.Button
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add_to_Cart As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenderAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTender As System.Windows.Forms.Label
End Class
