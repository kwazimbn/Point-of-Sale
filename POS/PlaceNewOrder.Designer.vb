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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdCategoryListItem = New System.Windows.Forms.DataGridView()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_to_Cart = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAddtoSalesSet = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.grdSaleSet = New System.Windows.Forms.DataGridView()
        Me.SaleQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdStockDecrement = New System.Windows.Forms.DataGridView()
        Me.grpSaleSet = New System.Windows.Forms.GroupBox()
        Me.btnBurger = New System.Windows.Forms.Button()
        Me.btnChicken = New System.Windows.Forms.Button()
        Me.btnStrips = New System.Windows.Forms.Button()
        Me.toast = New System.Windows.Forms.Button()
        Me.btnWraps = New System.Windows.Forms.Button()
        Me.grpTenders = New System.Windows.Forms.GroupBox()
        Me.testing = New System.Windows.Forms.Button()
        Me.grpCustTender = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCustMobile = New System.Windows.Forms.Label()
        Me.lblCustCurrentBal = New System.Windows.Forms.Label()
        Me.lblCustNames = New System.Windows.Forms.Label()
        Me.lblCustTenderID = New System.Windows.Forms.Label()
        Me.radCustMobile = New System.Windows.Forms.RadioButton()
        Me.radCustID = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCustSearchTender = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.grbTotalSaleSet = New System.Windows.Forms.GroupBox()
        Me.radCombinedPayment = New System.Windows.Forms.RadioButton()
        Me.radTopUpAcc = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.txtTenderAmount = New System.Windows.Forms.TextBox()
        Me.lblTender = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaleTotal = New System.Windows.Forms.TextBox()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblReceiptQty = New System.Windows.Forms.Label()
        Me.btnProcessSale = New System.Windows.Forms.Button()
        Me.btnLineVoid = New System.Windows.Forms.Button()
        Me.btnReceiptVoid = New System.Windows.Forms.Button()
        Me.grpCategoryButtons = New System.Windows.Forms.GroupBox()
        Me.btnSoftDrinks = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.grdCartAddAndItemInfo = New System.Windows.Forms.GroupBox()
        Me.pnlOrderScreen = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.txtReceipt = New System.Windows.Forms.RichTextBox()
        Me.lblCustOrderHeaer = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.grdCategoryListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategory.SuspendLayout()
        CType(Me.grdSaleSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStockDecrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSaleSet.SuspendLayout()
        Me.grpTenders.SuspendLayout()
        Me.grpCustTender.SuspendLayout()
        Me.grbTotalSaleSet.SuspendLayout()
        Me.grpCategoryButtons.SuspendLayout()
        Me.grdCartAddAndItemInfo.SuspendLayout()
        Me.pnlOrderScreen.SuspendLayout()
        Me.grpReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(535, 559)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 1
        '
        'grdCategoryListItem
        '
        Me.grdCategoryListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCategoryListItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Qty, Me.Add_to_Cart})
        Me.grdCategoryListItem.EnableHeadersVisualStyles = False
        Me.grdCategoryListItem.Location = New System.Drawing.Point(7, 19)
        Me.grdCategoryListItem.Name = "grdCategoryListItem"
        Me.grdCategoryListItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCategoryListItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCategoryListItem.Size = New System.Drawing.Size(522, 316)
        Me.grdCategoryListItem.TabIndex = 0
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 60
        '
        'Add_to_Cart
        '
        Me.Add_to_Cart.HeaderText = "Add to Cart"
        Me.Add_to_Cart.Name = "Add_to_Cart"
        Me.Add_to_Cart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Add_to_Cart.Width = 75
        '
        'btnAddtoSalesSet
        '
        Me.btnAddtoSalesSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoSalesSet.Location = New System.Drawing.Point(3, 77)
        Me.btnAddtoSalesSet.Name = "btnAddtoSalesSet"
        Me.btnAddtoSalesSet.Size = New System.Drawing.Size(87, 46)
        Me.btnAddtoSalesSet.TabIndex = 1
        Me.btnAddtoSalesSet.Text = "Add to Cart >>"
        Me.btnAddtoSalesSet.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.BackColor = System.Drawing.Color.YellowGreen
        Me.grpCategory.Controls.Add(Me.grdCategoryListItem)
        Me.grpCategory.Location = New System.Drawing.Point(76, 38)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(535, 344)
        Me.grpCategory.TabIndex = 0
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'grdSaleSet
        '
        Me.grdSaleSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSaleSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleQty, Me.ItemID, Me.Decription, Me.Amount})
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
        Me.SaleQty.Width = 50
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Width = 50
        '
        'Decription
        '
        Me.Decription.HeaderText = "Decription"
        Me.Decription.Name = "Decription"
        Me.Decription.Width = 180
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 80
        '
        'grdStockDecrement
        '
        Me.grdStockDecrement.AllowUserToAddRows = False
        Me.grdStockDecrement.AllowUserToDeleteRows = False
        Me.grdStockDecrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockDecrement.Location = New System.Drawing.Point(78, 105)
        Me.grdStockDecrement.Name = "grdStockDecrement"
        Me.grdStockDecrement.ReadOnly = True
        Me.grdStockDecrement.Size = New System.Drawing.Size(240, 150)
        Me.grdStockDecrement.TabIndex = 2
        '
        'grpSaleSet
        '
        Me.grpSaleSet.BackColor = System.Drawing.Color.YellowGreen
        Me.grpSaleSet.Controls.Add(Me.grdStockDecrement)
        Me.grpSaleSet.Controls.Add(Me.grdSaleSet)
        Me.grpSaleSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSaleSet.Location = New System.Drawing.Point(707, 38)
        Me.grpSaleSet.Name = "grpSaleSet"
        Me.grpSaleSet.Size = New System.Drawing.Size(413, 344)
        Me.grpSaleSet.TabIndex = 0
        Me.grpSaleSet.TabStop = False
        Me.grpSaleSet.Text = "Sale Set"
        '
        'btnBurger
        '
        Me.btnBurger.Location = New System.Drawing.Point(3, 59)
        Me.btnBurger.Name = "btnBurger"
        Me.btnBurger.Size = New System.Drawing.Size(63, 46)
        Me.btnBurger.TabIndex = 2
        Me.btnBurger.Text = "Burger"
        Me.btnBurger.UseVisualStyleBackColor = True
        '
        'btnChicken
        '
        Me.btnChicken.Location = New System.Drawing.Point(3, 107)
        Me.btnChicken.Name = "btnChicken"
        Me.btnChicken.Size = New System.Drawing.Size(63, 46)
        Me.btnChicken.TabIndex = 3
        Me.btnChicken.Text = "Chicken Pieces"
        Me.btnChicken.UseVisualStyleBackColor = True
        '
        'btnStrips
        '
        Me.btnStrips.Location = New System.Drawing.Point(3, 12)
        Me.btnStrips.Name = "btnStrips"
        Me.btnStrips.Size = New System.Drawing.Size(63, 46)
        Me.btnStrips.TabIndex = 4
        Me.btnStrips.Text = "Strips"
        Me.btnStrips.UseVisualStyleBackColor = True
        '
        'toast
        '
        Me.toast.Location = New System.Drawing.Point(3, 153)
        Me.toast.Name = "toast"
        Me.toast.Size = New System.Drawing.Size(63, 46)
        Me.toast.TabIndex = 5
        Me.toast.Text = "Toast"
        Me.toast.UseVisualStyleBackColor = True
        '
        'btnWraps
        '
        Me.btnWraps.Location = New System.Drawing.Point(3, 200)
        Me.btnWraps.Name = "btnWraps"
        Me.btnWraps.Size = New System.Drawing.Size(63, 46)
        Me.btnWraps.TabIndex = 6
        Me.btnWraps.Text = "Wraps"
        Me.btnWraps.UseVisualStyleBackColor = True
        '
        'grpTenders
        '
        Me.grpTenders.BackColor = System.Drawing.Color.YellowGreen
        Me.grpTenders.Controls.Add(Me.testing)
        Me.grpTenders.Controls.Add(Me.grpCustTender)
        Me.grpTenders.Controls.Add(Me.grbTotalSaleSet)
        Me.grpTenders.Controls.Add(Me.btnProcessSale)
        Me.grpTenders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTenders.Location = New System.Drawing.Point(10, 402)
        Me.grpTenders.Name = "grpTenders"
        Me.grpTenders.Size = New System.Drawing.Size(785, 235)
        Me.grpTenders.TabIndex = 10
        Me.grpTenders.TabStop = False
        Me.grpTenders.Text = "Order Payemnt"
        '
        'testing
        '
        Me.testing.Location = New System.Drawing.Point(616, 194)
        Me.testing.Name = "testing"
        Me.testing.Size = New System.Drawing.Size(94, 35)
        Me.testing.TabIndex = 40
        Me.testing.Text = "New Sale"
        Me.testing.UseVisualStyleBackColor = True
        '
        'grpCustTender
        '
        Me.grpCustTender.Controls.Add(Me.Label8)
        Me.grpCustTender.Controls.Add(Me.lblCustMobile)
        Me.grpCustTender.Controls.Add(Me.lblCustCurrentBal)
        Me.grpCustTender.Controls.Add(Me.lblCustNames)
        Me.grpCustTender.Controls.Add(Me.lblCustTenderID)
        Me.grpCustTender.Controls.Add(Me.radCustMobile)
        Me.grpCustTender.Controls.Add(Me.radCustID)
        Me.grpCustTender.Controls.Add(Me.Label7)
        Me.grpCustTender.Controls.Add(Me.Label6)
        Me.grpCustTender.Controls.Add(Me.Label5)
        Me.grpCustTender.Controls.Add(Me.btnCustSearchTender)
        Me.grpCustTender.Controls.Add(Me.Label2)
        Me.grpCustTender.Controls.Add(Me.txtCustomerId)
        Me.grpCustTender.Location = New System.Drawing.Point(6, 16)
        Me.grpCustTender.Name = "grpCustTender"
        Me.grpCustTender.Size = New System.Drawing.Size(362, 174)
        Me.grpCustTender.TabIndex = 18
        Me.grpCustTender.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Customer ID :"
        '
        'lblCustMobile
        '
        Me.lblCustMobile.AutoSize = True
        Me.lblCustMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustMobile.Location = New System.Drawing.Point(143, 152)
        Me.lblCustMobile.Name = "lblCustMobile"
        Me.lblCustMobile.Size = New System.Drawing.Size(2, 15)
        Me.lblCustMobile.TabIndex = 38
        '
        'lblCustCurrentBal
        '
        Me.lblCustCurrentBal.AutoSize = True
        Me.lblCustCurrentBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustCurrentBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustCurrentBal.Location = New System.Drawing.Point(143, 129)
        Me.lblCustCurrentBal.Name = "lblCustCurrentBal"
        Me.lblCustCurrentBal.Size = New System.Drawing.Size(2, 15)
        Me.lblCustCurrentBal.TabIndex = 37
        '
        'lblCustNames
        '
        Me.lblCustNames.AutoSize = True
        Me.lblCustNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNames.Location = New System.Drawing.Point(143, 104)
        Me.lblCustNames.Name = "lblCustNames"
        Me.lblCustNames.Size = New System.Drawing.Size(2, 15)
        Me.lblCustNames.TabIndex = 36
        '
        'lblCustTenderID
        '
        Me.lblCustTenderID.AutoSize = True
        Me.lblCustTenderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustTenderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustTenderID.Location = New System.Drawing.Point(143, 80)
        Me.lblCustTenderID.Name = "lblCustTenderID"
        Me.lblCustTenderID.Size = New System.Drawing.Size(2, 15)
        Me.lblCustTenderID.TabIndex = 35
        '
        'radCustMobile
        '
        Me.radCustMobile.AutoSize = True
        Me.radCustMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustMobile.Location = New System.Drawing.Point(280, 8)
        Me.radCustMobile.Name = "radCustMobile"
        Me.radCustMobile.Size = New System.Drawing.Size(73, 17)
        Me.radCustMobile.TabIndex = 34
        Me.radCustMobile.TabStop = True
        Me.radCustMobile.Text = "Mobile No"
        Me.radCustMobile.UseVisualStyleBackColor = True
        '
        'radCustID
        '
        Me.radCustID.AutoSize = True
        Me.radCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustID.Location = New System.Drawing.Point(280, 26)
        Me.radCustID.Name = "radCustID"
        Me.radCustID.Size = New System.Drawing.Size(83, 17)
        Me.radCustID.TabIndex = 33
        Me.radCustID.TabStop = True
        Me.radCustID.Text = "Customer ID"
        Me.radCustID.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Mobile No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Current Balance : R"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Names :"
        '
        'btnCustSearchTender
        '
        Me.btnCustSearchTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustSearchTender.Location = New System.Drawing.Point(117, 44)
        Me.btnCustSearchTender.Name = "btnCustSearchTender"
        Me.btnCustSearchTender.Size = New System.Drawing.Size(128, 23)
        Me.btnCustSearchTender.TabIndex = 26
        Me.btnCustSearchTender.Text = "Search Customer"
        Me.btnCustSearchTender.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Mobile No/Customer ID :"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(154, 15)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(97, 20)
        Me.txtCustomerId.TabIndex = 24
        '
        'grbTotalSaleSet
        '
        Me.grbTotalSaleSet.Controls.Add(Me.radCombinedPayment)
        Me.grbTotalSaleSet.Controls.Add(Me.radTopUpAcc)
        Me.grbTotalSaleSet.Controls.Add(Me.radCash)
        Me.grbTotalSaleSet.Controls.Add(Me.txtTenderAmount)
        Me.grbTotalSaleSet.Controls.Add(Me.lblTender)
        Me.grbTotalSaleSet.Controls.Add(Me.Label1)
        Me.grbTotalSaleSet.Controls.Add(Me.txtChange)
        Me.grbTotalSaleSet.Controls.Add(Me.Label3)
        Me.grbTotalSaleSet.Controls.Add(Me.txtSaleTotal)
        Me.grbTotalSaleSet.Controls.Add(Me.lblSaleTotal)
        Me.grbTotalSaleSet.Controls.Add(Me.txtQty)
        Me.grbTotalSaleSet.Controls.Add(Me.lblReceiptQty)
        Me.grbTotalSaleSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbTotalSaleSet.Location = New System.Drawing.Point(373, 16)
        Me.grbTotalSaleSet.Name = "grbTotalSaleSet"
        Me.grbTotalSaleSet.Size = New System.Drawing.Size(408, 174)
        Me.grbTotalSaleSet.TabIndex = 12
        Me.grbTotalSaleSet.TabStop = False
        '
        'radCombinedPayment
        '
        Me.radCombinedPayment.AutoSize = True
        Me.radCombinedPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCombinedPayment.Location = New System.Drawing.Point(288, 78)
        Me.radCombinedPayment.Name = "radCombinedPayment"
        Me.radCombinedPayment.Size = New System.Drawing.Size(119, 17)
        Me.radCombinedPayment.TabIndex = 36
        Me.radCombinedPayment.TabStop = True
        Me.radCombinedPayment.Text = "Combined Payment."
        Me.radCombinedPayment.UseVisualStyleBackColor = True
        Me.radCombinedPayment.Visible = False
        '
        'radTopUpAcc
        '
        Me.radTopUpAcc.AutoSize = True
        Me.radTopUpAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTopUpAcc.Location = New System.Drawing.Point(179, 79)
        Me.radTopUpAcc.Name = "radTopUpAcc"
        Me.radTopUpAcc.Size = New System.Drawing.Size(103, 17)
        Me.radTopUpAcc.TabIndex = 35
        Me.radTopUpAcc.TabStop = True
        Me.radTopUpAcc.Text = "Topup Payment."
        Me.radTopUpAcc.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCash.Location = New System.Drawing.Point(122, 79)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(49, 17)
        Me.radCash.TabIndex = 34
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'txtTenderAmount
        '
        Me.txtTenderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenderAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenderAmount.Location = New System.Drawing.Point(122, 46)
        Me.txtTenderAmount.Name = "txtTenderAmount"
        Me.txtTenderAmount.Size = New System.Drawing.Size(122, 22)
        Me.txtTenderAmount.TabIndex = 27
        Me.txtTenderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTender
        '
        Me.lblTender.AutoSize = True
        Me.lblTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTender.Location = New System.Drawing.Point(1, 49)
        Me.lblTender.Name = "lblTender"
        Me.lblTender.Size = New System.Drawing.Size(86, 13)
        Me.lblTender.TabIndex = 26
        Me.lblTender.Text = "Tender Amount :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Payment method :"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(122, 110)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(122, 20)
        Me.txtChange.TabIndex = 12
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Change : R"
        '
        'txtSaleTotal
        '
        Me.txtSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleTotal.Location = New System.Drawing.Point(254, 15)
        Me.txtSaleTotal.Name = "txtSaleTotal"
        Me.txtSaleTotal.ReadOnly = True
        Me.txtSaleTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtSaleTotal.TabIndex = 4
        Me.txtSaleTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.AutoSize = True
        Me.lblSaleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaleTotal.Location = New System.Drawing.Point(165, 19)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(69, 13)
        Me.lblSaleTotal.TabIndex = 2
        Me.lblSaleTotal.Text = "Sale Total R:"
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(122, 15)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(37, 20)
        Me.txtQty.TabIndex = 1
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReceiptQty
        '
        Me.lblReceiptQty.AutoSize = True
        Me.lblReceiptQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptQty.Location = New System.Drawing.Point(6, 22)
        Me.lblReceiptQty.Name = "lblReceiptQty"
        Me.lblReceiptQty.Size = New System.Drawing.Size(69, 13)
        Me.lblReceiptQty.TabIndex = 0
        Me.lblReceiptQty.Text = "Receipt Qty :"
        '
        'btnProcessSale
        '
        Me.btnProcessSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessSale.Location = New System.Drawing.Point(484, 196)
        Me.btnProcessSale.Name = "btnProcessSale"
        Me.btnProcessSale.Size = New System.Drawing.Size(101, 35)
        Me.btnProcessSale.TabIndex = 17
        Me.btnProcessSale.Text = "Process Sale"
        Me.btnProcessSale.UseVisualStyleBackColor = True
        '
        'btnLineVoid
        '
        Me.btnLineVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLineVoid.Location = New System.Drawing.Point(3, 141)
        Me.btnLineVoid.Name = "btnLineVoid"
        Me.btnLineVoid.Size = New System.Drawing.Size(87, 23)
        Me.btnLineVoid.TabIndex = 13
        Me.btnLineVoid.Text = "Item Void"
        Me.btnLineVoid.UseVisualStyleBackColor = True
        '
        'btnReceiptVoid
        '
        Me.btnReceiptVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptVoid.Location = New System.Drawing.Point(3, 167)
        Me.btnReceiptVoid.Name = "btnReceiptVoid"
        Me.btnReceiptVoid.Size = New System.Drawing.Size(87, 23)
        Me.btnReceiptVoid.TabIndex = 16
        Me.btnReceiptVoid.Text = "Order Void"
        Me.btnReceiptVoid.UseVisualStyleBackColor = True
        '
        'grpCategoryButtons
        '
        Me.grpCategoryButtons.BackColor = System.Drawing.Color.YellowGreen
        Me.grpCategoryButtons.Controls.Add(Me.btnSoftDrinks)
        Me.grpCategoryButtons.Controls.Add(Me.btnBurger)
        Me.grpCategoryButtons.Controls.Add(Me.btnChicken)
        Me.grpCategoryButtons.Controls.Add(Me.btnStrips)
        Me.grpCategoryButtons.Controls.Add(Me.lbl2)
        Me.grpCategoryButtons.Controls.Add(Me.lbl1)
        Me.grpCategoryButtons.Controls.Add(Me.toast)
        Me.grpCategoryButtons.Controls.Add(Me.btnWraps)
        Me.grpCategoryButtons.Location = New System.Drawing.Point(3, 38)
        Me.grpCategoryButtons.Name = "grpCategoryButtons"
        Me.grpCategoryButtons.Size = New System.Drawing.Size(69, 344)
        Me.grpCategoryButtons.TabIndex = 1
        Me.grpCategoryButtons.TabStop = False
        '
        'btnSoftDrinks
        '
        Me.btnSoftDrinks.Location = New System.Drawing.Point(2, 246)
        Me.btnSoftDrinks.Name = "btnSoftDrinks"
        Me.btnSoftDrinks.Size = New System.Drawing.Size(63, 46)
        Me.btnSoftDrinks.TabIndex = 10
        Me.btnSoftDrinks.Text = "Soft Drinks"
        Me.btnSoftDrinks.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 325)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(25, 13)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "......"
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 309)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(28, 13)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "......."
        Me.lbl1.Visible = False
        '
        'grdCartAddAndItemInfo
        '
        Me.grdCartAddAndItemInfo.BackColor = System.Drawing.Color.YellowGreen
        Me.grdCartAddAndItemInfo.Controls.Add(Me.btnAddtoSalesSet)
        Me.grdCartAddAndItemInfo.Controls.Add(Me.btnLineVoid)
        Me.grdCartAddAndItemInfo.Controls.Add(Me.btnReceiptVoid)
        Me.grdCartAddAndItemInfo.Location = New System.Drawing.Point(612, 38)
        Me.grdCartAddAndItemInfo.Name = "grdCartAddAndItemInfo"
        Me.grdCartAddAndItemInfo.Size = New System.Drawing.Size(93, 344)
        Me.grdCartAddAndItemInfo.TabIndex = 11
        Me.grdCartAddAndItemInfo.TabStop = False
        '
        'pnlOrderScreen
        '
        Me.pnlOrderScreen.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.pnlOrderScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlOrderScreen.Controls.Add(Me.Button1)
        Me.pnlOrderScreen.Controls.Add(Me.grpReceipt)
        Me.pnlOrderScreen.Controls.Add(Me.lblCustOrderHeaer)
        Me.pnlOrderScreen.Controls.Add(Me.grpSaleSet)
        Me.pnlOrderScreen.Controls.Add(Me.grdCartAddAndItemInfo)
        Me.pnlOrderScreen.Controls.Add(Me.grpTenders)
        Me.pnlOrderScreen.Controls.Add(Me.grpCategoryButtons)
        Me.pnlOrderScreen.Controls.Add(Me.grpCategory)
        Me.pnlOrderScreen.Location = New System.Drawing.Point(12, 1)
        Me.pnlOrderScreen.Name = "pnlOrderScreen"
        Me.pnlOrderScreen.Size = New System.Drawing.Size(1134, 667)
        Me.pnlOrderScreen.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(986, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Complete Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpReceipt
        '
        Me.grpReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpReceipt.Controls.Add(Me.txtReceipt)
        Me.grpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReceipt.Location = New System.Drawing.Point(798, 402)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(322, 235)
        Me.grpReceipt.TabIndex = 13
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Sales Receipt"
        '
        'txtReceipt
        '
        Me.txtReceipt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(3, 16)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtReceipt.Size = New System.Drawing.Size(313, 219)
        Me.txtReceipt.TabIndex = 16
        Me.txtReceipt.Text = ""
        '
        'lblCustOrderHeaer
        '
        Me.lblCustOrderHeaer.AutoSize = True
        Me.lblCustOrderHeaer.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustOrderHeaer.Location = New System.Drawing.Point(461, 3)
        Me.lblCustOrderHeaer.Name = "lblCustOrderHeaer"
        Me.lblCustOrderHeaer.Size = New System.Drawing.Size(291, 32)
        Me.lblCustOrderHeaer.TabIndex = 12
        Me.lblCustOrderHeaer.Text = "Place Customer Order"
        Me.lblCustOrderHeaer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PlaceNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1147, 680)
        Me.Controls.Add(Me.pnlOrderScreen)
        Me.Controls.Add(Me.Label4)
        Me.Name = "PlaceNewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlaceNewOrder"
        CType(Me.grdCategoryListItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategory.ResumeLayout(False)
        CType(Me.grdSaleSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStockDecrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSaleSet.ResumeLayout(False)
        Me.grpTenders.ResumeLayout(False)
        Me.grpCustTender.ResumeLayout(False)
        Me.grpCustTender.PerformLayout()
        Me.grbTotalSaleSet.ResumeLayout(False)
        Me.grbTotalSaleSet.PerformLayout()
        Me.grpCategoryButtons.ResumeLayout(False)
        Me.grpCategoryButtons.PerformLayout()
        Me.grdCartAddAndItemInfo.ResumeLayout(False)
        Me.pnlOrderScreen.ResumeLayout(False)
        Me.pnlOrderScreen.PerformLayout()
        Me.grpReceipt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grdCategoryListItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddtoSalesSet As System.Windows.Forms.Button
    Friend WithEvents grpCategory As System.Windows.Forms.GroupBox
    Friend WithEvents grdSaleSet As System.Windows.Forms.DataGridView
    Friend WithEvents grdStockDecrement As System.Windows.Forms.DataGridView
    Friend WithEvents grpSaleSet As System.Windows.Forms.GroupBox
    Friend WithEvents btnBurger As System.Windows.Forms.Button
    Friend WithEvents btnChicken As System.Windows.Forms.Button
    Friend WithEvents btnStrips As System.Windows.Forms.Button
    Friend WithEvents toast As System.Windows.Forms.Button
    Friend WithEvents btnWraps As System.Windows.Forms.Button
    Friend WithEvents SaleQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Decription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpTenders As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcessSale As System.Windows.Forms.Button
    Friend WithEvents btnReceiptVoid As System.Windows.Forms.Button
    Friend WithEvents btnLineVoid As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents grpCustTender As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCustSearchTender As System.Windows.Forms.Button
    Friend WithEvents grpCategoryButtons As System.Windows.Forms.GroupBox
    Friend WithEvents grdCartAddAndItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents radCustMobile As System.Windows.Forms.RadioButton
    Friend WithEvents radCustID As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCustTenderID As System.Windows.Forms.Label
    Friend WithEvents btnSoftDrinks As System.Windows.Forms.Button
    Friend WithEvents pnlOrderScreen As System.Windows.Forms.Panel
    Friend WithEvents grbTotalSaleSet As System.Windows.Forms.GroupBox
    Friend WithEvents radCombinedPayment As System.Windows.Forms.RadioButton
    Friend WithEvents radTopUpAcc As System.Windows.Forms.RadioButton
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtTenderAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTender As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaleTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptQty As System.Windows.Forms.Label
    Friend WithEvents lblCustMobile As System.Windows.Forms.Label
    Friend WithEvents lblCustCurrentBal As System.Windows.Forms.Label
    Friend WithEvents lblCustNames As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents lblCustOrderHeaer As System.Windows.Forms.Label
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add_to_Cart As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grpReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceipt As System.Windows.Forms.RichTextBox
    Friend WithEvents testing As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
