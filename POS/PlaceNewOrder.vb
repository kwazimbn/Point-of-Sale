Public Class PlaceNewOrder
    Dim cat1 As Integer = 1
    Dim cat2 As Integer = 2
    Dim cat3 As Integer = 3
    Dim cat4 As Integer = 4
    Dim cat5 As Integer = 5
    Dim cat6 As Integer = 6

    Dim clrearCheck As Integer = 0
    Dim id As Integer = 0 'customer Id variable used in searching customer info, and updated customer balance.
    Dim changeAmount As Double = 0.0 'Customer change amount

    Dim objCM As New MenuItemsC
    Dim objCMList As New List(Of MenuItemsC)
    Dim objc As New SaleSet
    Dim objSMS As New SMSNotification
    Dim objCustInfo As New Customer_Class 'Object class customer used for Searching for customer info
    Dim objCustList As New List(Of Customer_Class) 'List object customer used for Searching for customer info
    Dim objOrder As New CustomerOrders


    Public Sub PlaceNewOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        CenterButton()

        'Page Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        lbl1.Text = grdSaleSet.Rows.Count 'Gridview row count

        radCash.Checked = True
        radCustMobile.Checked = True

        grdStockDecrement.Visible = False 'Hiding the stock decrement driver gridview
        'grdCategoryListItem.Columns(3).Visible = True
        MenuItemsGridview(2)
        Label4.Text = Date.Now
        txtQty.Text = CInt("0")
        txtSaleTotal.Text = "0.0"
        Dim totSale As Decimal = 0


    End Sub

    'Center align panel which contains all objects on the screen
    Private Sub CenterButton()
        pnlOrderScreen.Top = (Me.ClientSize.Height / 2) - (pnlOrderScreen.Height / 2)
        pnlOrderScreen.Left = (Me.ClientSize.Width / 2) - (pnlOrderScreen.Width / 2)
    End Sub
    'Center align panel which contains all objects on the screen
    Private Sub PlaceNewOrder_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CenterButton()
    End Sub

    Public Function CreateDataTable() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("MenuItemID")
        tb.Columns.Add("IngridientID")
        tb.Columns.Add("Proportion")
        tb.AcceptChanges()
        Return tb
    End Function

    Private Function AddRow(ByVal grdRow As DataGridViewRow, ByVal dt As DataTable) As DataTable
        Dim dr As DataRow() = dt.Select("MenuItemID = '" & grdRow.Cells(1).Value.ToString())
        If dr.Length <= 0 Then
            dt.Rows.Add()
            dt.Rows(dt.Rows.Count - 1)("MenuItemID") = grdRow.Cells(1).Value.ToString
            dt.Rows(dt.Rows.Count - 1)("IngridientID") = grdRow.Cells(2).Value.ToString
            dt.Rows(dt.Rows.Count - 1)("Proportion") = grdRow.Cells(3).Value.ToString
        End If
        Return dt
    End Function

    Private Function RemoveRow(ByVal grdRow As DataGridViewRow, ByVal dt As DataTable)
        Dim dr As DataRow() = dt.Select("MenuItemID = '" & grdRow.Cells(1).Value)
        If dr.Length > 0 Then
            dt.Rows.Remove(dr(0))
            dt.AcceptChanges()
        End If
        Return dt
    End Function

    'Checkbox to add into cart
    Private Sub GetData()
        Dim dt As New DataTable
        'dt = DirectCast(""), DataTable)
        Dim addToCart As CheckBox = DirectCast(grdCategoryListItem.Rows(0).Cells(0).Value, CheckBox)
        For i As Integer = 0 To grdCategoryListItem.Rows.Count - 1
            If addToCart.Checked Then
                dt = AddRow(grdCategoryListItem.Rows(i), dt)
            Else
                dt = RemoveRow(grdCategoryListItem.Rows(i), dt)
            End If
        Next

    End Sub
 
    Private Sub btnAddtoSalesSet_Click(sender As System.Object, e As System.EventArgs) Handles btnAddtoSalesSet.Click

        'The add to Sale Set Button
        Dim itemDec As String = ""
        Dim sellingPr As Decimal = 0.0
        Dim compareQty As Integer = 0
        ' Try
        Dim saleSetCount As Integer = grdSaleSet.Rows.Count
        Dim desc As String = ""
        Dim sellp As Decimal = 0.0


        'Checking if grdSaleSet has any item, if not add the initial sale set.
        If grdSaleSet.Rows.Count = 1 Then
            Try
                For x As Integer = 0 To grdCategoryListItem.Rows.Count - 1
                    'Quantity per line item in a sale-set - Setting the default quantity value
                    If grdCategoryListItem.Rows(x).Cells(0).Value = "" Then
                        compareQty = 1
                    Else
                        compareQty = CInt(grdCategoryListItem.Rows(x).Cells(0).Value)
                    End If
                    'Adding item(s) into a sale set
                    If grdCategoryListItem.Rows(x).Cells(1).Value = True Then
                        grdSaleSet.Rows.Add(compareQty, grdCategoryListItem.Rows(x).Cells(2).Value, grdCategoryListItem.Rows(x).Cells(3).Value, grdCategoryListItem.Rows(x).Cells(4).Value)
                    End If
                Next
            Catch ex As Exception

            End Try

        Else 'If the gridsaleSet already has item(s), add these item(s) with a bit of validation 
            For xy As Integer = 0 To grdCategoryListItem.Rows.Count - 1
                If grdCategoryListItem.Rows(xy).Cells(1).Value = True Then
                    'Quantity per line item in a sale-set - Setting the default quantity value
                    If grdCategoryListItem.Rows(xy).Cells(0).Value = "" Then
                        compareQty = 1
                    Else
                        compareQty = CInt(grdCategoryListItem.Rows(xy).Cells(0).Value)
                    End If

                    For y As Integer = 0 To grdSaleSet.Rows.Count - 1
                        If grdSaleSet.Rows(y).Cells(1).Value = grdCategoryListItem.Rows(xy).Cells(2).Value Then
                            grdSaleSet.Item(0, y).Value = grdSaleSet.Item(0, y).Value + compareQty 'Update only qty if the item already exist in the saleset
                            Exit For 'Terminate the loop after iteration
                        ElseIf (y = grdSaleSet.Rows.Count - 1) Then 'Check if the looping is equal to the size of the grdsaleset
                            'Add into saleset the item(s) which doesn't exist
                            grdSaleSet.Rows.Add(compareQty, grdCategoryListItem.Rows(xy).Cells(2).Value, grdCategoryListItem.Rows(xy).Cells(3).Value, grdCategoryListItem.Rows(xy).Cells(4).Value)
                            Exit For 'Terminate the loop after iteration
                        End If
                    Next
                End If
            Next
        End If



        'If grdSaleSet.Rows(y).Cells(1).Value = grdCategoryListItem.Rows(x).Cells(2).Value Then
        '    grdSaleSet.Rows.Add(grdSaleSet.Rows(y).Cells(0).Value = grdSaleSet.Rows(y).Cells(0).Value + compareQty)
        'Else
        '    grdSaleSet.Rows.Add(grdCategoryListItem.Rows(x).Cells(0).Value, grdCategoryListItem.Rows(x).Cells(2).Value, grdCategoryListItem.Rows(x).Cells(3).Value, grdCategoryListItem.Rows(x).Cells(4).Value)
        'End If
        '  Next
        'lbl1.Text = CInt(saleSetCount)

        'For i As Integer = 0 To grdCategoryListItem.Rows.Count - 1
        '    If grdCategoryListItem.Rows(i).Cells(1).Value = True Then
        '        grdSaleSet.Rows.Add(grdCategoryListItem.Rows(i).Cells(0).Value, grdCategoryListItem.Rows(i).Cells(2).Value, grdCategoryListItem.Rows(i).Cells(3).Value, grdCategoryListItem.Rows(i).Cells(4).Value)
        '    End If
        'Next

        '----------------------------------------------------------------------------------------------
        ' Adding the selected items into a saleset.
        'For i As Integer = 0 To grdCategoryListItem.Rows.Count - 1
        '    If grdCategoryListItem.Rows(i).Cells(1).Value = True Then
        '        grdSaleSet.Rows.Add(grdCategoryListItem.Rows(i).Cells(0).Value, grdCategoryListItem.Rows(i).Cells(2).Value, grdCategoryListItem.Rows(i).Cells(3).Value, grdCategoryListItem.Rows(i).Cells(4).Value)
        '    End If
        'Next
        '-----------------------------------------------------------------------------------------------
        ''search controller to decrement stock driver grid
        'For x As Integer = 0 To grdSaleSet.Rows.Count - 1
        '    objCM.MenuDescription = grdSaleSet.Rows(x).Cells(1).Value 'extract item description
        '    objCM.Price = Convert.ToDecimal(grdSaleSet.Rows(x).Cells(2).Value) 'extract item price
        '    grdStockDecrement.DataSource = objc.GetIngredientsDecrementDriver(objCM.MenuDescription, objCM.Price) 'search using item desc and price
        'Next
        'Catch ex As Exception

        'End Try

        'Copy qty and from menu to saleset gridview
        Dim totQty As Integer = 0
        Dim totSale As Decimal = 0
        For x As Integer = 0 To grdSaleSet.Rows.Count - 1
            Dim qty As Integer = grdSaleSet.Rows(x).Cells(0).Value
            If grdSaleSet.Rows(x).Cells(0).Value = 0 Then
                qty = 1
                totSale += grdSaleSet.Rows(x).Cells(3).Value
            Else
                totSale += (qty * grdSaleSet.Rows(x).Cells(3).Value)
            End If
            totQty += qty
        Next
        totQty -= 1
        txtQty.Text = totQty
        txtSaleTotal.Text = totSale
        MenuItemsGridview(clrearCheck)
    End Sub

    Private Sub btnProcessSale_Click_1(sender As System.Object, e As System.EventArgs) Handles btnProcessSale.Click 'btnProcessSale_Click(sender As System.Object, e As System.EventArgs)

        ''Customer order object
        Dim objSMS As New SMSNotification
        Dim objCust As New CustomerOrders
        Dim objCusCl As New Customer_Class
        Dim objCustOrd As New csCustomerOrderItem

        objc.MenuDescription = grdSaleSet.Rows(0).Cells(1).Value
        objc.Price = grdSaleSet.Rows(0).Cells(3).Value

        Dim totQty As Integer = 0
        Dim totSale As Decimal = 0
        Dim itemQty As Integer = 1

        '------------------------------------------------------------------------
        ''Controller driver  gridview to decrement stock
        'For ss As Integer = 0 To grdSaleSet.Rows.Count - 2
        '    Dim itemQty As Integer = 1

        '    itemQty = CInt(grdSaleSet.Rows(ss).Cells(0).Value) 'Quantity per line item in a sale-set
        '    objCM.MenuDescription = grdSaleSet.Rows(ss).Cells(1).Value 'extract item description
        '    objCM.Price = Convert.ToDecimal(grdSaleSet.Rows(ss).Cells(2).Value) 'extract item price

        '    'Checking the line item qty, if its zero set it one  
        '    If itemQty = 0 Then
        '        itemQty = 1  'set line item qty to a default value of one
        '    End If

        '    grdStockDecrement.DataSource = objc.GetIngredientsDecrementDriver(objCM.MenuDescription, objCM.Price) 'search using item desc and price and display on decrement gridview
        '    grdStockDecrement.Columns(0).Visible = False 'Hiding the column which is not reqiured.
        '    'Proportion to decrease stock
        '    For dd As Integer = 0 To grdStockDecrement.Rows.Count - 1 'loop using decreament gridview
        '        objc._ingrId = grdStockDecrement.Rows(dd).Cells(1).Value 'extract ingredient id
        '        objc.Proportion = Convert.ToDecimal(grdStockDecrement.Rows(dd).Cells(2).Value) * itemQty  'extract ingredient recipe proportion
        '        objc.decrement_Inventory(objc._ingrId, objc.Proportion)
        '    Next

        'Next
        '-------------------------------------------------------------------

        ''search controller to decrement stock driver grid
        'For x As Integer = 0 To grdSaleSet.Rows.Count - 1
        '    objCM.MenuDescription = grdSaleSet.Rows(x).Cells(1).Value 'extract item description
        '    objCM.Price = Convert.ToDecimal(grdSaleSet.Rows(x).Cells(2).Value) 'extract item price
        '    grdStockDecrement.DataSource = objc.GetIngredientsDecrementDriver(objCM.MenuDescription, objCM.Price) 'search using item desc and price
        'Next
        'grdStockDecrement.Columns(0).Visible = False 'Hiding the column which is not reqiured.


        'For i As Integer = 0 To grdSaleSet.Rows.Count - 1
        'grdStockDecrement.DataSource = objc.GetIngredientsDecrementDriver(objc.Proportion, objc.Price)   'Still to look at this
        'Next

        'grdStockDecrement.Columns(0).Visible = False

        'SMS Notification parameters
        Dim MyString As String = Nothing
        Dim message As String = Nothing
        Dim number As String = Nothing
        Dim TxUsername As String = Nothing
        Dim TxPassword As String = Nothing
        Dim amount As Integer = 0

        'Saving order into order table
        Try
            If txtQty.Text = "0" Then
                MessageBox.Show("Nothing on sale set!")
            Else
                'If cmbPaymentMethod.SelectedIndex = 0 Then
                '    MessageBox.Show("Please select method of payment!")
                'End If


                'The CASH payment only
                If grdSaleSet.Rows.Count - 1 = 0 Then
                    MessageBox.Show("Nothing in a sale set")
                ElseIf radCash.Checked = True Then
                    If txtTenderAmount.Text = "" Then
                        MessageBox.Show("Please enter cash amount")
                    Else
                        'saving into order table
                        objCust.CustomerId = Convert.ToInt32(1)
                        objCust.EmployeeId = 3
                        objCust.OrderTotal = Convert.ToDecimal(txtSaleTotal.Text)
                        objCust.OrderTender = Convert.ToDecimal(txtTenderAmount.Text)
                        objCust.PaymentMethod = "Cash"
                        objCust.PaymentStatus = "Paid"
                        objCust.OrderStatus = "Open"
                        objCust.OrderDate = CDate(System.DateTime.Now)
                        objCust.CreateNewCustomerOrder(objCust)

                        'Save order info into bridge entity OrderItem table
                        For x As Integer = 0 To grdSaleSet.Rows.Count - 1

                            itemQty = CInt(grdSaleSet.Rows(x).Cells(0).Value) 'extract item qty in sale set
                            If itemQty = 0 Then
                                lbl1.Text = itemQty
                                objCustOrd.ItemQty = 1
                            Else
                                objCustOrd.ItemQty = itemQty 'extract item qty in sale set
                            End If
                            'objCustOrd.ItemQty = grdSaleSet.Rows(x).Cells(0).Value 'extract item qty in sale set
                            objCustOrd.ItemNo = CInt(grdSaleSet.Rows(x).Cells(1).Value) 'extract item No
                            objCustOrd.ItemPrice = grdSaleSet.Rows(x).Cells(3).Value 'extract item price
                            objCustOrd.CreateNewCustomerOrderItem() 'calling save function into order item
                        Next

                        'Controller driver  gridview to decrement stock
                        For ss As Integer = 0 To grdSaleSet.Rows.Count - 2  'This gridview -2 because of the default header which and last row in the grid which is empty.
                            itemQty = CInt(grdSaleSet.Rows(ss).Cells(0).Value) 'Quantity per line item in a sale-set
                            objCM.MenuDescription = grdSaleSet.Rows(ss).Cells(2).Value 'extract item description
                            objCM.Price = Convert.ToDecimal(grdSaleSet.Rows(ss).Cells(3).Value) 'extract item price

                            'Checking the line item qty, if its zero set it one  
                            If itemQty = 0 Then
                                itemQty = 1  'set line item qty to a default value of one
                            End If

                            grdStockDecrement.DataSource = objc.GetIngredientsDecrementDriver(objCM.MenuDescription, objCM.Price) 'search using item desc and price and display on decrement gridview
                            grdStockDecrement.Columns(0).Visible = False 'Hiding the column which is not reqiured.
                            'Proportion to decrease stock
                            For dd As Integer = 0 To grdStockDecrement.Rows.Count - 1 'loop using decreament gridview
                                objc._ingrId = grdStockDecrement.Rows(dd).Cells(1).Value 'extract ingredient id
                                objc.Proportion = Convert.ToDecimal(grdStockDecrement.Rows(dd).Cells(2).Value) * itemQty  'extract ingredient recipe proportion
                                objc.decrement_Inventory(objc._ingrId, objc.Proportion)
                            Next
                        Next
                        MessageBox.Show("Order succesfully saved") 'Show succes completion of order
                    End If
                End If
            End If


            'The topup account payment only
            Dim custId As Integer = CInt(lblCustTenderID.Text)
            If radTopUpAcc.Checked = True Then
                If lblCustCurrentBal.Text = "" Then
                    MessageBox.Show("Please Search for customer")
                ElseIf CInt(txtSaleTotal.Text) > CInt(lblCustCurrentBal.Text) Then
                    MessageBox.Show("You've insufficient funds to complete this order!")
                Else
                    'Save Order infomration
                    txtTenderAmount.Enabled = False

                    txtTenderAmount.Text = 0
                    objCust.CustomerId = (CInt(lblCustTenderID.Text)) 'Still to change this value once customer
                    objCust.EmployeeId = 3 'Still to take session ID once employee can login
                    objCust.OrderTotal = Convert.ToDecimal(txtSaleTotal.Text)
                    objCust.OrderTender = Convert.ToDecimal(txtTenderAmount.Text) + 0
                    objCust.PaymentMethod = "Topup" 'cmbPaymentMethod.SelectedItem.ToString()
                    objCust.PaymentStatus = "Paid"
                    objCust.OrderStatus = "Open"
                    objCust.OrderDate = CDate(System.DateTime.Now)
                    objCust.CreateNewCustomerOrder(objCust)
                    objCusCl.Balance = Convert.ToDecimal(txtSaleTotal.Text)
                    objCusCl.CustomerId = CInt(lblCustTenderID.Text)

                    objCusCl.decrementBalance(CInt(lblCustTenderID.Text), objCusCl.Balance)
                    Dim diff = amount - Convert.ToDecimal(txtSaleTotal.Text)

                    'Search by customer ID, for customer updated balance
                    id = CInt(lblCustTenderID.Text)
                    objCustList = objCustInfo.GetCustomerByID(id)
                    For Each x As Customer_Class In objCustList
                        lblCustTenderID.Text = x.CustomerId
                        lblCustNames.Text = x.FirstName
                        lblCustCurrentBal.Text = x.Balance
                        lblCustMobile.Text = x.ContactNo
                    Next

                    'Try
                    '    'Validating zero tender amount
                    '    changeAmount = CDbl(txtTenderAmount.Text) - CDbl(txtSaleTotal.Text)
                    '    txtChange.Text = changeAmount
                    '    If (changeAmount < 0) Then
                    '        MessageBox.Show("Tendered amount is short: ")
                    '    End If
                    'Catch ex As Exception

                    'End Try
                    message = ("Dear user, an amount of R: " & (Convert.ToDecimal(txtSaleTotal.Text)) & " has been deducted from your topup account and the current balance is R: " & lblCustCurrentBal.Text.ToString())
                    MessageBox.Show("Order succesfully saved") 'Show succes completion of order
                End If
            End If

            'The combined payment
            If radCombinedPayment.Checked = True Then
                If lblCustCurrentBal.Text = "" Then
                    MessageBox.Show("Please Search for customer")
                ElseIf CInt(txtSaleTotal.Text) > CInt(lblCustCurrentBal.Text) Then
                    MessageBox.Show("The customer account has insufficient funds to complete this order!")
                Else
                    'Save Order infomration
                    'txtTenderAmount.Text = 0
                    'objCust.CustomerId = Convert.ToInt32(1)
                    'objCust.EmployeeId = 3
                    'objCust.OrderTotal = Convert.ToDecimal(txtSaleTotal.Text)
                    'objCust.OrderTender = Convert.ToDecimal(txtTenderAmount.Text) + 0
                    'objCust.PaymentMethod = cmbPaymentMethod.SelectedItem.ToString()
                    'objCust.PaymentStatus = "Paid"
                    'objCust.OrderStatus = "Open"
                    'objCust.OrderDate = CDate(System.DateTime.Now)
                    'objCust.CreateNewCustomerOrder(objCust)
                    'objCusCl.Balance = Convert.ToDecimal(txtSaleTotal.Text)
                    'objCusCl.CustomerId = CInt(txtCustomerId.Text)
                    'objCusCl.decrementBalance(objCusCl.CustomerId, objCusCl.Balance)
                    'Dim diff = amount - Convert.ToDecimal(txtSaleTotal.Text)

                    'message = ("Dear user, an amount of R: " & (Convert.ToDecimal(txtSaleTotal.Text)) & " has been deducted from your topup account and the current balance is R: " & diff)
                    'MessageBox.Show("Your number is :" & number)
                End If
            End If
        Catch ex As Exception

        End Try

        'Printing of receipt
        Try
            Dim dir As String = ""
            txtReceipt.Paste()
            Dim Header As String = "V'City Chicks"
            Dim dateAndTime As DateTime = System.DateTime.Now.ToString()
            Dim orderID As String = CStr(objOrder.getOrderID())


            txtReceipt.AppendText(vbNewLine)

            txtReceipt.AppendText("+++++++++++++++++++++++++++++++++++++++++++++++" + vbNewLine)
            txtReceipt.AppendText(vbTab + vbTab + Header + vbNewLine)
            txtReceipt.AppendText(vbTab + "Shop no. 1 Student Development Centre " + vbNewLine + vbTab + "University of Kwazulu Natal Westville Campus" + vbNewLine + vbTab + "Block D, University Road, Westville." + vbNewLine)
            txtReceipt.AppendText(vbTab + "Date Time: " + dateAndTime.ToString() + vbNewLine)
            txtReceipt.AppendText(vbTab + vbTab + "Tax Invoice " + vbNewLine)
            txtReceipt.AppendText(vbNewLine)
            txtReceipt.AppendText(vbTab + vbTab + "Order NO :" + orderID + vbNewLine)
            txtReceipt.AppendText("===============================================" + vbNewLine)
            txtReceipt.AppendText(vbNewLine)
            Try
                txtReceipt.AppendText("Item" + vbTab + vbTab + vbTab + "Qty" + vbTab + " Price R " + vbTab + " Total R " + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
                'txtReceipt.AppendText(String.Format("{0,-13}{1,33}{2,18}{3,18}", "Item", "Qty", "Price", "Total") + vbNewLine)
                'txtReceipt.AppendText("")

                Dim name As String = ""

                For i As Integer = 0 To grdSaleSet.Rows.Count - 1
                    txtReceipt.AppendText(String.Format("{0,-34} {1,-11} {2,10}{3,14}", grdSaleSet.Rows(i).Cells(2).Value.ToString(), grdSaleSet.Rows(i).Cells(0).Value.ToString() + " x", grdSaleSet.Rows(i).Cells(3).Value.ToString(), (CDbl(grdSaleSet.Rows(i).Cells(0).Value) * CDbl(grdSaleSet.Rows(i).Cells(3).Value)).ToString()) + vbNewLine)
                    'txtReceipt.AppendText(String.Format("{0,-13}{1,22}{2,12}{3,18}", grdSaleSet.Rows(i).Cells(2).Value.ToString(), grdSaleSet.Rows(i).Cells(0).Value.ToString(), grdSaleSet.Rows(i).Cells(3).Value.ToString(), (CDbl(grdSaleSet.Rows(i).Cells(1).Value) * CDbl(grdSaleSet.Rows(i).Cells(3).Value)).ToString()) + vbNewLine)
                Next

            Catch ex As Exception

            End Try
            txtReceipt.AppendText(vbNewLine)
            txtReceipt.AppendText("----------------------------------------------------------------------------------------------" + vbNewLine)
            txtReceipt.AppendText(vbNewLine)

            If (radCash.Checked = True) Then
                txtReceipt.AppendText("Total:" + vbTab + vbTab + vbTab + vbTab + vbTab + "R" + (txtSaleTotal.Text.ToString()) + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
                txtReceipt.AppendText("Tender:" + vbTab + vbTab + vbTab + vbTab + vbTab + "R" + (txtTenderAmount.Text.ToString()) + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
                txtReceipt.AppendText("Change:" + vbTab + vbTab + vbTab + vbTab + vbTab + "R" + (txtChange.Text.ToString()) + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
            ElseIf (radTopUpAcc.Checked = True) Then
                txtReceipt.AppendText("Total:" + vbTab + vbTab + vbTab + vbTab + vbTab + "R" + (txtSaleTotal.Text.ToString()) + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
                txtReceipt.AppendText("Tender:" + vbTab + vbTab + vbTab + vbTab + vbTab + "Topup Account" + vbNewLine)
                txtReceipt.AppendText(vbNewLine)
                txtReceipt.AppendText("Customer Name:" + vbTab + vbTab + vbTab + vbTab + vbTab + lblCustNames.Text)
                txtReceipt.AppendText(vbNewLine)


            End If

            txtReceipt.AppendText("===============================================" + vbNewLine)
            txtReceipt.AppendText(vbTab + vbTab + "Thank you for shopping" + vbNewLine + vbTab + vbTab + " VCity chicks, Please call again!" + vbNewLine)
            txtReceipt.AppendText("+++++++++++++++++++++++++++++++++++++++++++++++" + vbNewLine)
        Catch ex As Exception

        End Try


        TxUsername = "lndignity074@gmail.com"
        TxPassword = "fqjstisq"
        number = lblCustMobile.Text
        MyString = "http://www.winsms.net/api/batchmessage.asp?User="
        MyString = (MyString _
                    + (TxUsername + ("&Password=" _
                    + (TxPassword + "&Delivery=No"))))
        MyString = (MyString + ("&Message=" _
                    + (message + ("&Numbers=" _
                    + (number + ";")))))
        objSMS.sendNotification(MyString) 'Sennding sms notification

        ''  Catch ex As Exception

        ''  End Try
        txtTenderAmount.Enabled = True
    End Sub


    'Controlling the input controls at payment
    'Private Sub cmbPaymentMethod_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs)
    '    If cmbPaymentMethod.SelectedIndex = 2 Then
    '        txtCustomerId.Enabled = True
    '    Else
    '        txtCustomerId.Enabled = False
    '        txtCustomerId.Text = ""
    '    End If
    '    If cmbPaymentMethod.SelectedIndex = 0 Then
    '        txtTenderAmount.Enabled = False
    '    Else
    '        txtTenderAmount.Enabled = True
    '    End If
    'End Sub


    Private Sub btnBurger_Click(sender As System.Object, e As System.EventArgs) Handles btnBurger.Click

        'Display the Burger category menu items
        MenuItemsGridview(cat1)
        'grdCategoryListItem.DataSource = objCM.getMenuItem(cat1)
        clrearCheck = 1

        'Changing the grid colour
        ' grdCategoryListItem.RowHeadersVisible = True

        For snb As Integer = 0 To grdCategoryListItem.Rows.Count - 1
            ' If grdCategoryListItem.Rows(snb).Cells(2).Value > 3 Then

            'grdCategoryListItem.Rows (snb).HeaderCell .ValueType
            grdCategoryListItem.Rows(snb).HeaderCell.Value = "*" 'Working fine for adding count values
            'grdCategoryListItem.Rows(snb).DefaultCellStyle.BackColor = Color.Coral
            '   End If
        Next
    End Sub

    Private Sub toast_Click(sender As System.Object, e As System.EventArgs) Handles toast.Click
        MenuItemsGridview(cat2)
        clrearCheck = 2 'Clearing checkbox value
    End Sub

    Private Sub btnStrips_Click(sender As System.Object, e As System.EventArgs) Handles btnStrips.Click
        MenuItemsGridview(cat4)
        clrearCheck = 4 'Clearing checkbox value
    End Sub

    Private Sub btnChicken_Click(sender As System.Object, e As System.EventArgs) Handles btnChicken.Click
        MenuItemsGridview(cat3)
        clrearCheck = 3 'Clearing checkbox value
    End Sub

    Private Sub btnWraps_Click(sender As System.Object, e As System.EventArgs) Handles btnWraps.Click
        MenuItemsGridview(cat5)
        clrearCheck = 5 'Clearing checkbox value
    End Sub

    Private Sub btnSoftDrinks_Click(sender As System.Object, e As System.EventArgs) Handles btnSoftDrinks.Click
        MenuItemsGridview(cat6)
        clrearCheck = 6 'Clearing checkbox value
    End Sub

    Private Sub txtTenderAmount_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    'Validating the amount textbox to take only numeric values
    Private Sub txtTenderAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not [Char].IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Enter digits only")
        End If
    End Sub

    'validating the amount textbox when cashier enter the cash amount.
    'Private Sub txtTenderAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenderAmount.KeyPress
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
    '        e.Handled = True
    '        MessageBox.Show("Enter only numeric values")
    '    End If
    'End Sub

    Private Sub btnCustSearchTender_Click(sender As System.Object, e As System.EventArgs) Handles btnCustSearchTender.Click
        If txtCustomerId.Text = "" Then
            MessageBox.Show("Nothing on search criteria!")
        Else
            'Search by customer ID
            If radCustID.Checked = True Then
                Try
                    id = CInt(txtCustomerId.Text)
                    objCustList = objCustInfo.GetCustomerByID(id)
                    For Each x As Customer_Class In objCustList
                        lblCustTenderID.Text = x.CustomerId
                        lblCustNames.Text = x.FirstName
                        lblCustCurrentBal.Text = x.Balance
                        lblCustMobile.Text = x.ContactNo
                    Next
                Catch
                End Try
            End If

            'Search by mobile NO
            If radCustMobile.Checked = True Then
                Try
                    Dim contactNo As String = txtCustomerId.Text
                    objCustList = objCustInfo.GetCustomerByNumber(contactNo)
                    For Each x As Customer_Class In objCustList
                        lblCustTenderID.Text = x.CustomerId
                        lblCustNames.Text = x.FirstName
                        lblCustCurrentBal.Text = x.Balance
                        lblCustMobile.Text = x.ContactNo
                    Next
                Catch
                End Try
            End If
        End If
    End Sub

    Private Sub btnReceiptVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnReceiptVoid.Click
        'Clearing the saleset with receipt void button
        grdSaleSet.Rows.Clear()
        txtQty.Text = "0"
        txtSaleTotal.Text = "0.0"
        txtChange.Text = ""
        txtTenderAmount.Text = ""
    End Sub

    Private Sub btnLineVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnLineVoid.Click
        'The live void button on saleset
        For i As Integer = 0 To grdSaleSet.Rows.Count - 1
            Try
                If grdSaleSet.Rows(i).Selected = True Then
                    Dim row As Integer
                    Dim selRow As New DataGridViewRow
                    Dim index As Integer
                    index = grdSaleSet.SelectedRows.Item(0).Index
                    selRow = grdSaleSet.Rows.Item(index)
                    grdSaleSet.Rows.Remove(selRow)
                    row = row - 1
                End If
            Catch

            End Try


            Dim totQty As Integer = 0
            Dim totSale As Decimal = 0
            For x As Integer = 0 To grdSaleSet.Rows.Count - 1
                Dim qty As Integer = grdSaleSet.Rows(x).Cells(0).Value
                If grdSaleSet.Rows(x).Cells(0).Value = 0 Then
                    qty = 1
                    totSale += grdSaleSet.Rows(x).Cells(3).Value
                Else
                    totSale += (qty * grdSaleSet.Rows(x).Cells(3).Value)
                End If
                totQty += qty
            Next
            totQty -= 1
            txtQty.Text = totQty
            txtSaleTotal.Text = totSale
        Next
    End Sub

    Private Sub radTopUpAcc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radTopUpAcc.CheckedChanged
        If radTopUpAcc.Checked = True Then
            If lblCustCurrentBal.Text = "" Then
                MessageBox.Show("Please Search for customer")
            ElseIf CInt(txtSaleTotal.Text) > CInt(lblCustCurrentBal.Text) Then
                MessageBox.Show("The customer account has insufficient funds to complete this order!")
            End If
        End If
    End Sub

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs)
        'Dim dir As String = ""
        'txtReceipt.Paste()
        'Dim Header As String = "V'City Chicks"
        'Dim dateAndTime As DateTime = System.DateTime.Now.ToString()
        'Dim orderID As String = CStr(objOrder.getOrderID())


        'txtReceipt.AppendText(vbNewLine)

        'txtReceipt.AppendText("+++++++++++++++++++++++++++++++++++++++++++++++" + vbNewLine)
        'txtReceipt.AppendText(vbTab + vbTab + Header + vbNewLine)
        'txtReceipt.AppendText("Shop no. 1 Student Development Centre " + vbNewLine + "University of Kwazulu Natal Westville Campus" + vbNewLine + "Block D, University Road, Westville." + vbNewLine)
        'txtReceipt.AppendText("Date Time: " + dateAndTime.ToString() + vbNewLine)
        'txtReceipt.AppendText(vbTab + vbTab + "Tax Invoice " + vbNewLine)
        'txtReceipt.AppendText(vbTab + vbTab + "Order NO :" + orderID + vbNewLine)
        'txtReceipt.AppendText("===============================================" + vbNewLine)
        'txtReceipt.AppendText(vbNewLine)
        'Try
        '    txtReceipt.AppendText("Item" + vbTab + vbTab + vbTab + "Qty" + vbTab + " Price R " + vbTab + " Total R " + vbNewLine)
        '    txtReceipt.AppendText(vbNewLine)
        '    'txtReceipt.AppendText(String.Format("{0,-13}{1,33}{2,18}{3,18}", "Item", "Qty", "Price", "Total") + vbNewLine)
        '    'txtReceipt.AppendText("")

        '    Dim totSale As Double = 0
        '    Dim name As String = ""

        '    For i As Integer = 0 To grdSaleSet.Rows.Count - 1
        '        txtReceipt.AppendText(String.Format("{0,-34} {1,-11} {2,10}{3,14}", grdSaleSet.Rows(i).Cells(2).Value.ToString(), grdSaleSet.Rows(i).Cells(0).Value.ToString() + " x", grdSaleSet.Rows(i).Cells(3).Value.ToString(), (CDbl(grdSaleSet.Rows(i).Cells(1).Value) * CDbl(grdSaleSet.Rows(i).Cells(3).Value)).ToString()) + vbNewLine)
        '        'txtReceipt.AppendText(String.Format("{0,-13}{1,22}{2,12}{3,18}", grdSaleSet.Rows(i).Cells(2).Value.ToString(), grdSaleSet.Rows(i).Cells(0).Value.ToString(), grdSaleSet.Rows(i).Cells(3).Value.ToString(), (CDbl(grdSaleSet.Rows(i).Cells(1).Value) * CDbl(grdSaleSet.Rows(i).Cells(3).Value)).ToString()) + vbNewLine)
        '    Next

        'Catch ex As Exception

        'End Try
        'txtReceipt.AppendText(vbNewLine)
        'txtReceipt.AppendText("===============================================" + vbNewLine)
        'txtReceipt.AppendText("Receipt Total: R " + (txtSaleTotal.Text.ToString()) + vbNewLine)
        'txtReceipt.AppendText(vbTab + vbTab + "Thank you for shopping" + vbNewLine + vbTab + vbTab + " VCity chicks, Please call again!" + vbNewLine)

    End Sub

    'Creating Gridview for Menu Items
    Private Sub MenuItemsGridview(ByVal catID As Integer)
        Dim cat As Integer = 0
        grdCategoryListItem.ColumnCount = 5 'Defining gridview columns size (number of columns)
        grdCategoryListItem.Columns(2).Name = "Menu ID"
        grdCategoryListItem.Columns(3).Name = "Menu Description"
        grdCategoryListItem.Columns(4).Name = "Price"
        grdCategoryListItem.Columns(2).Width = 55
        grdCategoryListItem.Columns(3).Width = 180
        grdCategoryListItem.Columns(4).Width = 80

        grdCategoryListItem.Columns(2).ReadOnly = True
        grdCategoryListItem.Columns(3).ReadOnly = True
        grdCategoryListItem.Columns(4).ReadOnly = True

        objCMList = objCM.getMenuItem(catID) 'Selected combobox search criterea   
        grdCategoryListItem.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        For Each x As MenuItemsC In objCMList
            grdCategoryListItem.Rows.Add("", 0, x.ItemID, x.MenuDescription, x.Price) 'Gridview load
        Next
    End Sub

    Private Sub grdCategoryListItem_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCategoryListItem.CellContentClick
        Try
            Dim addToCart As CheckBox = DirectCast(grdCategoryListItem.Rows(0).Cells(0).Value, CheckBox)
            Dim lastRow = grdCategoryListItem.Rows.Count - 1


            If (addToCart.CheckState = CheckState.Checked) And (grdCategoryListItem.Rows(lastRow).Cells(2).Value = "") Then
                ' grdCategoryListItem.Rows.Add = False
                MessageBox.Show("Test")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtTenderAmount_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtTenderAmount.TextChanged
        'Change calculation
        Try
            txtChange.Text = -CDbl(txtSaleTotal.Text) + CDbl(txtTenderAmount.Text)
            If txtTenderAmount.Text = "" Then
                txtChange.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub grdSaleSet_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSaleSet.CellContentClick


    End Sub

    Private Sub grdSaleSet_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdSaleSet.RowsAdded

    End Sub

    Private Sub testing_Click(sender As System.Object, e As System.EventArgs) Handles testing.Click
        txtReceipt.Clear()
        grdSaleSet.Rows.Clear()
        txtQty.Clear()
        txtTenderAmount.Clear()
        txtSaleTotal.Clear()
        txtChange.Clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CompleteOrder.Show()
        Me.Hide()
    End Sub

    Private Sub grpCustTender_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCustTender.Enter

    End Sub
End Class