Public Class InvetoryDetails
    Dim objStock As New StockItems
    Dim objSupplier As New csSupplier
    Dim objSList As New List(Of csSupplier)
    Dim objSTList As New List(Of StockItems)

    Dim totOrder As Decimal = 0.0

    Private Sub cmbSupplierList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSupplierList.SelectedIndexChanged
        'Looping into a suppliers list object
        For Each x As csSupplier In objSList '
            'Mapping in supplier ID into supplier name
            If cmbSupplierList.SelectedItem = x.SupplierName Then
                lblSupID.Text = x.SupplierID

                StockGridview(CInt(lblSupID.Text))
                'objSTList = objStock.GetIngredientsBySupplier(x.SupplierID)

                'grdSupplierStock.DataSource = objStock.GetIngredientsBySupplier(x.SupplierID)
                'grdSupplierStock.Columns(1).Visible = False 'Hiding the column which is not reqiured.
                'grdSupplierStock.Columns(7).Visible = False 'Hiding the column which is not reqiured.

                'Dim grdchck As DataGridViewColumn = grdSupplierStock.Columns(0)
                'Dim grdItmId As DataGridViewColumn = grdSupplierStock.Columns(2)
                'grdchck.Width = 45
                'grdItmId.Width = 50
                Dim grdStockUnit As DataGridViewColumn = grdSupplierStock.Columns(4)
                grdStockUnit.Width = 45
            End If
        Next
    End Sub

    'Creating Gridview for Menu Items
    Private Sub StockGridview(ByVal SuppID As Integer)

        Dim cat As Integer = 0
        grdSupplierStock.ColumnCount = 7 'Defining gridview columns size (number of columns)
        grdSupplierStock.Columns(1).Name = "ID"
        grdSupplierStock.Columns(2).Name = "Description"
        grdSupplierStock.Columns(3).Name = "Qty"
        grdSupplierStock.Columns(4).Name = "Unit"
        grdSupplierStock.Columns(5).Name = "Price"
        grdSupplierStock.Columns(6).Name = "Grp Qty"
        grdSupplierStock.Columns(1).Width = 40
        grdSupplierStock.Columns(2).Width = 170
        grdSupplierStock.Columns(3).Width = 60
        grdSupplierStock.Columns(4).Width = 40
        grdSupplierStock.Columns(5).Width = 70
        grdSupplierStock.Columns(6).Width = 50

        objSTList = objStock.GetIngredientsBySupplier(SuppID) 'Selected combobox search criterea   
        grdSupplierStock.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        For Each x As StockItems In objSTList
            grdSupplierStock.Rows.Add(0, x.Item_ID, x.Item_Desc, x.Item_Qty, x.Item_Unit, x.Item_Price) 'Gridview load
        Next
    End Sub


    Private Sub InvetoryDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        '   CenterButton()
        pageNavCMB.SelectedIndex = 0

        lbl2.Text = grdSupplierOrder.Rows.Count
        objSList = objSupplier.GetSupplierList() 'Assigning an array list returned by a method in Class Objec List
        'Looping into a suppliers list object
        For Each x As csSupplier In objSList
            cmbSupplierList.Items.Add(x.SupplierName) 'Populating supplier name in combobox
        Next

        Dim grdsId As DataGridViewColumn = grdSupplierOrder.Columns(0)
        Dim grdItmId As DataGridViewColumn = grdSupplierOrder.Columns(1)
        Dim grdUnit As DataGridViewColumn = grdSupplierOrder.Columns(4)

       
        'grdsId.Width = 40
        'grdItmId.Width = 40
        'grdUnit.Width = 40


        cmbSupplierList.SelectedIndex = 0

    End Sub

    Private Sub btnSOAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnSOAdd.Click
        'The add to Sale Set Button
        Dim itemDec As String = ""
        Dim costPr As Decimal = 0.0
        Dim compareQty As Integer = 0

        ' Try
        'Dim saleSetCount As Integer = grdSupplierOrder.Rows.Count
        Dim desc As String = ""
        Dim sellp As Decimal = 0.0

        'Copy qty and from menu to saleset gridview
        Dim totQty As Integer = 0

        Dim qty As Decimal = 0.0

        'Item qty
        Dim val As Integer = 0
        Dim defaultQty = 0



        'Checking if grdSupplierOrder has any item, if not add the initial sale set.

        'If grdSupplierOrder.Rows.Count = 1 Then
        ' Try
        'For x As Integer = 0 To grdSupplierStock.Rows.Count - 1
        'Quantity per line item in a sale-set - Setting the default quantity value
        'If grdSupplierStock.Rows(x).Cells(0).Value = "" Then
        '    compareQty = 1
        'Else
        '    compareQty = CInt(grdSupplierStock.Rows(x).Cells(0).Value)
        'End If
        'Adding item(s) into a sale set
        'If grdSupplierStock.Rows(x).Cells(0).Value = True Then
        '    grdSupplierOrder.Rows.Add(lbltest.Text, grdSupplierStock.Rows(x).Cells(2).Value, grdSupplierStock.Rows(x).Cells(3).Value, "", grdSupplierStock.Rows(x).Cells(6).Value)
        'End If
        ' Next
        '    Catch ex As Exception

        '    End Try

        '' Else 'If the gridsaleSet already has item(a), add these item(s) with a bit of validation 

        For xy As Integer = 0 To grdSupplierStock.Rows.Count - 1
            If grdSupplierStock.Rows(xy).Cells(0).Value = True Then
                For y As Integer = 0 To grdSupplierOrder.Rows.Count - 1
                    If grdSupplierStock.Rows(xy).Cells(1).Value = grdSupplierOrder.Rows(y).Cells(0).Value Then
                        MessageBox.Show("Item already added into cart")
                        Exit For 'Terminate the loop after iteration
                    ElseIf (y = grdSupplierOrder.Rows.Count - 1) Then 'Check if the looping is equal to the size of the grdSupplierOrder
                        'Add into saleset the item(s) which doesn't exist
                        grdSupplierOrder.Rows.Add(grdSupplierStock.Rows(xy).Cells(1).Value, grdSupplierStock.Rows(xy).Cells(2).Value, 1, grdSupplierStock.Rows(xy).Cells(5).Value, CStr(grdSupplierStock.Rows(xy).Cells(4).Value))

                        qty = CDec(grdSupplierOrder.Rows(y).Cells(2).Value)

                        If grdSupplierOrder.Rows(y).Cells(2).Value = 1 Then
                            qty = 1
                            totOrder += CInt(grdSupplierOrder.Rows(y).Cells(3).Value)
                        Else
                            totOrder += (qty * CInt(grdSupplierOrder.Rows(y).Cells(3).Value))
                        End If
                        totQty += qty
                        Exit For 'Terminate the loop after iteration
                    End If
                Next
            End If
        Next
        ''  End If
        lblOrderCostPrice.Text = totOrder

        For x As Integer = 0 To grdSupplierOrder.Rows.Count - 1
            If grdSupplierOrder.Rows(x).Cells(2).Value = 1 Then
                val += 1

            Else
                val += grdSupplierOrder.Rows(x).Cells(2).Value

            End If
        Next
        lblOrderQty.Text = val

        StockGridview(CInt(lblSupID.Text))
        'grdSupplierStock.DataSource = objStock.GetIngredientsBySupplier(CInt(lblSupID.Text))

        'totQty -= 1
        'txtQty.Text = totQty
        'txtSaleTotal.Text = totSale

        'grdCategoryListItem.DataSource = objCM.getMenuItem(clrearCheck)

    End Sub

    Private Sub grdSupplierOrder_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewTextBoxColumn AndAlso e.RowIndex >= 0 Then
            lbl2.Text = grdSupplierOrder.Rows(0).Cells(3).Value
        End If

        'For x As Integer = 0 To grdSupplierOrder.Rows.Count - 1
        '    If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewTextBoxColumn AndAlso e.RowIndex >= 0 Then
        '        lblOrderQty.Text = grdSupplierOrder.Rows(x).Cells(3).Value
        '    End If
        '    ' Dim itmQ As 

        '    If grdSupplierOrder.Rows(x).Cells(3).Value Then

        '    End If
        'Next


        'grdSupplierOrder.Rows
    End Sub

    Private Sub grdSupplierOrder_CellStateChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles grdSupplierOrder.CellStateChanged
        Dim val As Integer = 0
        Dim defaultQty = 0

        Try
            For x As Integer = 0 To grdSupplierOrder.Rows.Count - 1
                If grdSupplierOrder.Rows(x).Cells(2).Value = "" Then
                    val += 1
                Else
                    val += grdSupplierOrder.Rows(x).Cells(3).Value
                End If
                val += grdSupplierOrder.Rows(x).Cells(3).Value
                lblOrderQty.Text = val
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnProcessSale_Click(sender As System.Object, e As System.EventArgs) Handles btnProcessSale.Click
        Dim ds As New group26DataSet
        Dim ta As New group26DataSetTableAdapters.receiveInventoryTableAdapter
        Dim dt As New group26DataSet.receiveInventoryDataTable()

        For i As Integer = 0 To grdSupplierOrder.Rows.Count - 1
            ta.Fill(dt, CInt(grdSupplierOrder.Rows(i).Cells(0).Value), CInt(grdSupplierOrder.Rows(i).Cells(2).Value))
        Next
        
        MsgBox("Inventory stock updated")
        grdSupplierOrder.Rows.Clear()
        lblOrderQty.Text = "0"
        lblOrderCostPrice.Text = "0.0"
    End Sub

    Private Sub btnLineVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnLineVoid.Click
        'The live void button on saleset
        Dim totQty As Integer = 0
        Dim totorder As Decimal = 0

        For i As Integer = 0 To grdSupplierOrder.Rows.Count - 1
            Try
                If grdSupplierOrder.Rows(i).Selected = True Then
                    Dim row As Integer
                    Dim selRow As New DataGridViewRow
                    Dim index As Integer
                    index = grdSupplierOrder.SelectedRows.Item(0).Index
                    selRow = grdSupplierOrder.Rows.Item(index)
                    grdSupplierOrder.Rows.Remove(selRow)
                    row = row - 1
                End If
            Catch

            End Try
        Next
        For x As Integer = 0 To grdSupplierOrder.Rows.Count - 1
            Dim qty As Integer = grdSupplierOrder.Rows(x).Cells(2).Value
            If grdSupplierOrder.Rows(x).Cells(2).Value = 0 Then
                qty = 1
                totorder += grdSupplierOrder.Rows(x).Cells(3).Value
            Else
                totorder += (qty * grdSupplierOrder.Rows(x).Cells(3).Value)
            End If
            totQty += qty
        Next
        totQty -= 1
        lblOrderQty.Text = totQty
        lblOrderCostPrice.Text = totorder

    End Sub

    Private Sub btnOrderVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnOrderVoid.Click
        'Clearing the saleset with receipt void button
        grdSupplierOrder.Rows.Clear()
        lblOrderQty.Text = "0"
        lblOrderCostPrice.Text = "0.0"
        totOrder = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If pageNavCMB.SelectedIndex = 0 Then
            EditCustomers.Show()
            Me.Close()

        ElseIf pageNavCMB.SelectedIndex = 1 Then
            AddEmployee.Show()
            Me.Close()
        Else
            LoginVcity.Show()
            Me.Close()
        End If
    End Sub
End Class