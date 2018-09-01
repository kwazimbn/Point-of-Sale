Public Class AddNewMenuItem

    Dim objC As New csCategory
    Dim objS As New StockItems
    Dim objCat As New csCategory
    Dim objCList As List(Of csCategory)
    Dim objSList As List(Of StockItems)
    Dim objCatList As New List(Of csCategory)


    Private Sub AddNewMenuItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Default select for ComboBox
        cmbItmCategory.SelectedIndex = 0

        'Populating the categories into a combobox
        objCList = objC.GetCategoryList() 'Feeding class list with category items
        For Each x As csCategory In objCList
            cmbItmCategory.Items.Add(x.CategoryName) 'Adding list of items into combobox
        Next

        'Populating a the gridview with ingredients
        objSList = objS.GetIngredients4Recipe()
        grdIngridientsRecipeLoader.DataSource = objSList

        'Populating the Category list object
        objCatList = objCat.GetCategoryList()

        'Hiding uneeded columns
        grdIngridientsRecipeLoader.Columns(1).Visible = False 'supplier id
        grdIngridientsRecipeLoader.Columns(4).Visible = False 'item qty
        grdIngridientsRecipeLoader.Columns(6).Visible = False 'item price
        grdIngridientsRecipeLoader.Columns(7).Visible = False 'item treshold

    End Sub

    Private Sub txtItemDescSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtItemDescSearch.TextChanged
        'Textbox search while user is typing.
        Dim itemDesc As String = txtItemDescSearch.Text

        'grdIngridientsRecipeLoader.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        'IngridientsGridview(itemDesc)

        objSList = objS.GetIngredientsByDesc4Recipe(itemDesc)
        'For Each x As StockItems In objSList
        '    grdIngridientsRecipeLoader.Rows.Add(0, x.Item_ID, x.Item_Desc, x.Item_Unit)
        'Next

        grdIngridientsRecipeLoader.DataSource = objSList
        lbltescount.Text = grdIngridientsRecipeLoader.Rows.Count

    End Sub

    'Creating Gridview for Menu Items
    Private Sub IngridientsGridview(ByVal itemDes As String)
        Dim cat As Integer = 0
        'grdIngridientsRecipeLoader.ColumnCount = 4 'Defining gridview columns size (number of columns)
        grdIngridientsRecipeLoader.Columns(1).Name = "Menu ID"
        grdIngridientsRecipeLoader.Columns(2).Name = "Menu Description"
        grdIngridientsRecipeLoader.Columns(3).Name = "Item Unit"
        'grdIngridientsRecipeLoader.Columns(2).Width = 55
        'grdIngridientsRecipeLoader.Columns(3).Width = 180
        'grdIngridientsRecipeLoader.Columns(4).Width = 80

        objSList = objS.GetIngredientsByDesc4Recipe(itemDes) 'Selected combobox search criterea   
        grdIngridientsRecipeLoader.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        For Each x As StockItems In objSList
            grdIngridientsRecipeLoader.Rows.Add(0, x.Item_ID, x.Item_Desc, x.Item_Unit) 'Gridview load
        Next

    End Sub

    Private Sub btnAddToRecipeGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnAddToRecipeGrid.Click
        Dim grdRecipeCount As Integer = grdIngridientReceipe.Rows.Count - 1 'Attaining the row count of a gridview
        lbltescount.Text = grdRecipeCount

        ' Try
        For x As Integer = 0 To grdIngridientsRecipeLoader.Rows.Count - 1
            'Quantity per line item in a sale-set - Setting the default quantity value

            'Adding item(s) into a sale set

            If grdIngridientsRecipeLoader.Rows(x).Cells(0).Value = True Then 'Checking the checkbox if its checked.
                If grdRecipeCount <= 0 Then 'Just add into a grid if its still empty
                    grdIngridientReceipe.Rows.Add(grdIngridientsRecipeLoader.Rows(x).Cells(2).Value, grdIngridientsRecipeLoader.Rows(x).Cells(3).Value, 0, grdIngridientsRecipeLoader.Rows(x).Cells(5).Value)
                Else
                    For y As Integer = 0 To grdIngridientReceipe.Rows.Count - 1 'Recipe gridview
                        If grdIngridientsRecipeLoader.Rows(x).Cells(2).Value = grdIngridientReceipe.Rows(y).Cells(0).Value Then 'Checking if the ingredients has been already added into a recipe.
                            MessageBox.Show("Already exist") 'Show this message
                            Exit For
                        Else 'Just the item into receipt grid since its not yet in the recipe gridview.
                            grdIngridientReceipe.Rows.Add(grdIngridientsRecipeLoader.Rows(x).Cells(2).Value, grdIngridientsRecipeLoader.Rows(x).Cells(3).Value, 0, grdIngridientsRecipeLoader.Rows(x).Cells(5).Value)
                            Exit For
                        End If
                    Next
                End If
            End If
        Next

        ' Catch ex As Exception

        ' End Try
    End Sub

    Private Sub btnRemoveFromRecipeGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveFromRecipeGrid.Click
        'The line delete of a recipe on Recipe Grid (grdIngridientReceipe)
        For i As Integer = 0 To grdIngridientReceipe.Rows.Count - 1
            Try
                If grdIngridientReceipe.Rows(i).Selected = True Then
                    Dim row As Integer
                    Dim selRow As New DataGridViewRow
                    Dim index As Integer
                    index = grdIngridientReceipe.SelectedRows.Item(0).Index
                    selRow = grdIngridientReceipe.Rows.Item(index)
                    grdIngridientReceipe.Rows.Remove(selRow)
                    row = row - 1
                End If
            Catch

            End Try
        Next
    End Sub

    Private Sub btnSaveRecipe_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveMenuItemAndRecipe.Click
        Dim objMI As New MenuItemsC
        Dim objRC As New csReceipe

        If cmbItmCategory.SelectedIndex = 0 Then
            MessageBox.Show("Select menu category")
        Else
            'Saving item menu information
            objMI.ItemID = CInt(lblCatID.Text)
            objMI.MenuDescription = txtMenuItemDesc.Text
            objMI.Price = CDbl(txtMenuItemPrice.Text)
            objMI.SaveMenuItem()

            'Saving into recipe table using Recipe Grid loop
            For x As Integer = 0 To grdIngridientReceipe.Rows.Count - 1 'Looping on the Recipe gridview to save all recipe info
                objRC.IngrID = grdIngridientReceipe.Rows(x).Cells(0).Value
                objRC.Proportion = CDec(grdIngridientReceipe.Rows(x).Cells(2).Value)
                objRC.Unit = grdIngridientReceipe.Rows(x).Cells(3).Value
                objRC.CreateDate = CDate(System.DateTime.Now)
                objRC.SaveRecipe()
            Next
            MessageBox.Show("Succesfully saved")
        End If

    End Sub

    Private Sub cmbItmCategory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbItmCategory.SelectedIndexChanged
        For Each x As csCategory In objCatList
            If cmbItmCategory.SelectedItem = x.CategoryName Then
                lblCatID.Text = x.CategoryID
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If pageNavCMB.SelectedIndex = 0 Then
            EditCustomers.Show()
            Me.Hide()
        ElseIf pageNavCMB.SelectedIndex = 1 Then
            AddEmployee.Show()
            Me.Hide()
        ElseIf pageNavCMB.SelectedIndex = 2 Then
            InvetoryDetails.Show()
            Me.Hide()
        Else
            LoginVcity.Show()
            Me.Hide()


        End If
    End Sub
End Class