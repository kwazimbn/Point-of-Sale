Public Class CompleteOrder
    Dim objC As New CustomerOrders
    Dim objCList As List(Of CustomerOrders)
    Dim objCM As New MenuItemsC
    Dim objCMList As List(Of MenuItemsC)
    Dim objCR As New csReceipe
    Dim objCRList As List(Of csReceipe)

    Private Sub CompleteOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        CenterButton()


        cmbOrderStatus.SelectedIndex = 0 'Default selected value in combobox
        gridviewKitchen.ColumnCount = 2 'Defining gridview columns size (number of columns)
        gridviewKitchen.Columns(0).Name = "Order ID"
        gridviewKitchen.Columns(1).Name = "Order Time"
        gridviewKitchen.Columns(0).Width = 55
        gridviewKitchen.Columns(1).Width = 110

        objCList = objC.GetKitchenByOrderStatus(cmbOrderStatus.SelectedValue) 'Selected combobox search criterea
        For Each x As CustomerOrders In objCList
            gridviewKitchen.Rows.Add(x.OrderId, x.OrderDate) 'Populate gridview controlled by combobox filter
        Next
        lblOrderCount.Text = gridviewKitchen.Rows.Count - 1
        TabControl1.SelectedIndex = 1 'Redirecting to recipe tab
    End Sub
    'Center align panel which contains all objects on the screen
    Private Sub CenterButton()
        pnlKitchenCompleteOrder.Top = (Me.ClientSize.Height / 2) - (pnlKitchenCompleteOrder.Height / 2)
        pnlKitchenCompleteOrder.Left = (Me.ClientSize.Width / 2) - (pnlKitchenCompleteOrder.Width / 2)
    End Sub
    'Center align panel which contains all objects on the screen
    Private Sub CompleteOrder_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CenterButton()
    End Sub

    Private Sub gridviewKitchen_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles gridviewKitchen.MouseClick
        Dim n = ""
        For x As Integer = 0 To gridviewKitchen.Rows.Count - 1
            If gridviewKitchen.Rows(x).Selected Then
                lbloid1.Text = gridviewKitchen.Rows(x).Cells(0).Value
            End If
        Next


        Try
            'Displaying the detailed order from Order Item table
            objCMList = objCM.getOrderMenuItem(CInt(lbloid1.Text)) '(CInt(lbloid1.Text))
            grdOrderLeft.DataSource = objCMList
            TabControl1.SelectedIndex = 0 'Redirecting to recipe tab
            grdOrderLeft.Columns(2).Visible = False 'Hide column two

        Catch ex As Exception


        End Try


    End Sub

    Private Sub grdOrderLeft_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdOrderLeft.CellMouseClick

        Dim itemNo As Integer = 0

        'Gridview with customization of required columns
        gridRecipe.ColumnCount = 3 'Defining gridview columns size (number of columns)
        gridRecipe.Columns(0).Name = "Item Name"
        gridRecipe.Columns(1).Name = "Proportion"
        gridRecipe.Columns(2).Name = "Unit"

        For x As Integer = 0 To grdOrderLeft.Rows.Count - 1
            If grdOrderLeft.Rows(x).Selected Then
                itemNo = CInt(grdOrderLeft.Rows(x).Cells(0).Value)
            End If
            'lbloid2.Text = itemNo
            objCRList = objCR.getRecipe4MenuItem(itemNo)
        Next

        gridRecipe.Rows.Clear() 'Clearing gridview before loading it.
        For Each n As csReceipe In objCRList
            gridRecipe.Rows.Add(CStr(n.Desc), n.Proportion, n.Unit) 'Populatting a gridview
        Next
        TabControl1.SelectedIndex = 1 'Redirecting to recipe tab
    End Sub


    Private Sub cmbOrderStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbOrderStatus.SelectedIndexChanged

        objCList = objC.GetKitchenByOrderStatus(cmbOrderStatus.SelectedItem)
        gridviewKitchen.ColumnCount = 2 'Defining gridview columns size (number of columns)
        gridviewKitchen.Columns(0).Name = "Order ID"
        gridviewKitchen.Columns(1).Name = "Order Time"
        gridviewKitchen.Rows.Clear()
        For Each x As CustomerOrders In objCList
            gridviewKitchen.Rows.Add(x.OrderId, x.OrderDate)
        Next
        lblOrderCount.Text = gridviewKitchen.Rows.Count - 1
    End Sub


    Private Sub btnCompleteOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCompleteOrder.Click

        If lbloid1.Text = "........" Then
            MessageBox.Show("No order been selected")
        Else
            Try
                objC.OrderId = CInt(lbloid1.Text) 'Manipulating order ID
                Dim msg As MsgBoxResult = MsgBox("Are you sure to Close Order No : " + CInt(lbloid1.Text).ToString, MsgBoxStyle.OkCancel)
                If (msg = MsgBoxResult.Ok) Then
                    objC.CloseCompleteCustomerOrder(objC.OrderId) 'Passing parameter order ID to close order

                    'cmbOrderStatus.SelectedIndex = 0 'Default selected value in combobox
                    gridviewKitchen.ColumnCount = 2 'Defining gridview columns size (number of columns)
                    gridviewKitchen.Columns(0).Name = "Order ID"
                    gridviewKitchen.Columns(1).Name = "Order Time"
                    gridviewKitchen.Columns(0).Width = 55
                    gridviewKitchen.Columns(1).Width = 110

                    cmbOrderStatus.SelectedIndex = 0
                    lblOrderStatus.Text = cmbOrderStatus.SelectedItem.ToString()
                    objCList = objC.GetKitchenByOrderStatus(lblOrderStatus.Text) 'Selected combobox search criterea

                    gridviewKitchen.Rows.Clear()
                    For Each x As CustomerOrders In objCList
                        gridviewKitchen.Rows.Add(x.OrderId, x.OrderDate) 'Populate gridview controlled by combobox filter
                    Next

                    'Reseting the order item table once order completed
                    Dim orderID As Integer
                    orderID = gridviewKitchen.Rows(0).Cells(0).Value
                    objCMList = objCM.getOrderMenuItem(CInt(orderID)) '(CInt(lbloid1.Text))
                    grdOrderLeft.DataSource = objCMList
                    lbloid1.Text = orderID
                    TabControl1.SelectedIndex = 0 'Redirecting to recipe tab


                    lblOrderCount.Text = gridviewKitchen.Rows.Count - 1
                End If
            Catch ex As Exception

            End Try

            'Clearing the saleset with receipt void button
            'grdOrderLeft.Rows.Clear()

            gridRecipe.Rows.Clear()
            'grdOrderLeft.Rows.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PlaceNewOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoginVcity.Show()
        Me.Hide()
    End Sub
End Class

