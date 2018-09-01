<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewMenuItem
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCatID = New System.Windows.Forms.Label()
        Me.MenuCategory = New System.Windows.Forms.Label()
        Me.MenuPrice = New System.Windows.Forms.Label()
        Me.MenuName = New System.Windows.Forms.Label()
        Me.cmbItmCategory = New System.Windows.Forms.ComboBox()
        Me.txtMenuItemDesc = New System.Windows.Forms.TextBox()
        Me.txtMenuItemPrice = New System.Windows.Forms.TextBox()
        Me.RecipeCombox = New System.Windows.Forms.GroupBox()
        Me.lbltescount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemDescSearch = New System.Windows.Forms.TextBox()
        Me.grdIngridientsRecipeLoader = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnRemoveFromRecipeGrid = New System.Windows.Forms.Button()
        Me.btnAddToRecipeGrid = New System.Windows.Forms.Button()
        Me.grdIngridientReceipe = New System.Windows.Forms.DataGridView()
        Me.IngredientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientProportion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientUnits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveMenuItemAndRecipe = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCustOrderHeaer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pageNavCMB = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.RecipeCombox.SuspendLayout()
        CType(Me.grdIngridientsRecipeLoader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdIngridientReceipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.Controls.Add(Me.lblCatID)
        Me.GroupBox1.Controls.Add(Me.MenuCategory)
        Me.GroupBox1.Controls.Add(Me.MenuPrice)
        Me.GroupBox1.Controls.Add(Me.MenuName)
        Me.GroupBox1.Controls.Add(Me.cmbItmCategory)
        Me.GroupBox1.Controls.Add(Me.txtMenuItemDesc)
        Me.GroupBox1.Controls.Add(Me.txtMenuItemPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'lblCatID
        '
        Me.lblCatID.AutoSize = True
        Me.lblCatID.Location = New System.Drawing.Point(268, 35)
        Me.lblCatID.Name = "lblCatID"
        Me.lblCatID.Size = New System.Drawing.Size(34, 13)
        Me.lblCatID.TabIndex = 8
        Me.lblCatID.Text = "........."
        '
        'MenuCategory
        '
        Me.MenuCategory.AutoSize = True
        Me.MenuCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCategory.Location = New System.Drawing.Point(29, 31)
        Me.MenuCategory.Name = "MenuCategory"
        Me.MenuCategory.Size = New System.Drawing.Size(55, 13)
        Me.MenuCategory.TabIndex = 7
        Me.MenuCategory.Text = "Category :"
        '
        'MenuPrice
        '
        Me.MenuPrice.AutoSize = True
        Me.MenuPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPrice.Location = New System.Drawing.Point(29, 84)
        Me.MenuPrice.Name = "MenuPrice"
        Me.MenuPrice.Size = New System.Drawing.Size(48, 13)
        Me.MenuPrice.TabIndex = 6
        Me.MenuPrice.Text = "Price : R"
        '
        'MenuName
        '
        Me.MenuName.AutoSize = True
        Me.MenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuName.Location = New System.Drawing.Point(29, 58)
        Me.MenuName.Name = "MenuName"
        Me.MenuName.Size = New System.Drawing.Size(71, 13)
        Me.MenuName.TabIndex = 5
        Me.MenuName.Text = "Menu Name :"
        '
        'cmbItmCategory
        '
        Me.cmbItmCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItmCategory.FormattingEnabled = True
        Me.cmbItmCategory.Items.AddRange(New Object() {"Select Category ...."})
        Me.cmbItmCategory.Location = New System.Drawing.Point(112, 28)
        Me.cmbItmCategory.Name = "cmbItmCategory"
        Me.cmbItmCategory.Size = New System.Drawing.Size(151, 21)
        Me.cmbItmCategory.TabIndex = 4
        '
        'txtMenuItemDesc
        '
        Me.txtMenuItemDesc.Location = New System.Drawing.Point(112, 55)
        Me.txtMenuItemDesc.Name = "txtMenuItemDesc"
        Me.txtMenuItemDesc.Size = New System.Drawing.Size(254, 20)
        Me.txtMenuItemDesc.TabIndex = 2
        '
        'txtMenuItemPrice
        '
        Me.txtMenuItemPrice.Location = New System.Drawing.Point(112, 81)
        Me.txtMenuItemPrice.Name = "txtMenuItemPrice"
        Me.txtMenuItemPrice.Size = New System.Drawing.Size(151, 20)
        Me.txtMenuItemPrice.TabIndex = 3
        '
        'RecipeCombox
        '
        Me.RecipeCombox.BackColor = System.Drawing.Color.YellowGreen
        Me.RecipeCombox.Controls.Add(Me.lbltescount)
        Me.RecipeCombox.Controls.Add(Me.Label1)
        Me.RecipeCombox.Controls.Add(Me.txtItemDescSearch)
        Me.RecipeCombox.Controls.Add(Me.grdIngridientsRecipeLoader)
        Me.RecipeCombox.Controls.Add(Me.btnRemoveFromRecipeGrid)
        Me.RecipeCombox.Controls.Add(Me.btnAddToRecipeGrid)
        Me.RecipeCombox.Controls.Add(Me.grdIngridientReceipe)
        Me.RecipeCombox.Location = New System.Drawing.Point(73, 149)
        Me.RecipeCombox.Name = "RecipeCombox"
        Me.RecipeCombox.Size = New System.Drawing.Size(806, 326)
        Me.RecipeCombox.TabIndex = 1
        Me.RecipeCombox.TabStop = False
        Me.RecipeCombox.Text = "Item Recipe Selection"
        '
        'lbltescount
        '
        Me.lbltescount.AutoSize = True
        Me.lbltescount.Location = New System.Drawing.Point(409, 31)
        Me.lbltescount.Name = "lbltescount"
        Me.lbltescount.Size = New System.Drawing.Size(28, 13)
        Me.lbltescount.TabIndex = 9
        Me.lbltescount.Text = "Test"
        Me.lbltescount.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Item Desciption Search :"
        '
        'txtItemDescSearch
        '
        Me.txtItemDescSearch.Location = New System.Drawing.Point(140, 24)
        Me.txtItemDescSearch.Name = "txtItemDescSearch"
        Me.txtItemDescSearch.Size = New System.Drawing.Size(226, 20)
        Me.txtItemDescSearch.TabIndex = 6
        '
        'grdIngridientsRecipeLoader
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIngridientsRecipeLoader.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdIngridientsRecipeLoader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdIngridientsRecipeLoader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdIngridientsRecipeLoader.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdIngridientsRecipeLoader.Location = New System.Drawing.Point(6, 67)
        Me.grdIngridientsRecipeLoader.Name = "grdIngridientsRecipeLoader"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIngridientsRecipeLoader.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdIngridientsRecipeLoader.Size = New System.Drawing.Size(403, 255)
        Me.grdIngridientsRecipeLoader.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tick"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'btnRemoveFromRecipeGrid
        '
        Me.btnRemoveFromRecipeGrid.Location = New System.Drawing.Point(412, 153)
        Me.btnRemoveFromRecipeGrid.Name = "btnRemoveFromRecipeGrid"
        Me.btnRemoveFromRecipeGrid.Size = New System.Drawing.Size(71, 33)
        Me.btnRemoveFromRecipeGrid.TabIndex = 4
        Me.btnRemoveFromRecipeGrid.Text = "Remove <<"
        Me.btnRemoveFromRecipeGrid.UseVisualStyleBackColor = True
        '
        'btnAddToRecipeGrid
        '
        Me.btnAddToRecipeGrid.Location = New System.Drawing.Point(412, 112)
        Me.btnAddToRecipeGrid.Name = "btnAddToRecipeGrid"
        Me.btnAddToRecipeGrid.Size = New System.Drawing.Size(71, 35)
        Me.btnAddToRecipeGrid.TabIndex = 3
        Me.btnAddToRecipeGrid.Text = "Add >>"
        Me.btnAddToRecipeGrid.UseVisualStyleBackColor = True
        '
        'grdIngridientReceipe
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIngridientReceipe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdIngridientReceipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdIngridientReceipe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IngredientId, Me.IngredientName, Me.IngredientProportion, Me.IngredientUnits})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdIngridientReceipe.DefaultCellStyle = DataGridViewCellStyle10
        Me.grdIngridientReceipe.Location = New System.Drawing.Point(487, 67)
        Me.grdIngridientReceipe.Name = "grdIngridientReceipe"
        Me.grdIngridientReceipe.Size = New System.Drawing.Size(311, 255)
        Me.grdIngridientReceipe.TabIndex = 0
        '
        'IngredientId
        '
        Me.IngredientId.HeaderText = "ItemID"
        Me.IngredientId.Name = "IngredientId"
        Me.IngredientId.Width = 55
        '
        'IngredientName
        '
        Me.IngredientName.HeaderText = "IngDesc"
        Me.IngredientName.Name = "IngredientName"
        '
        'IngredientProportion
        '
        Me.IngredientProportion.HeaderText = "Proportion"
        Me.IngredientProportion.Name = "IngredientProportion"
        Me.IngredientProportion.Width = 60
        '
        'IngredientUnits
        '
        Me.IngredientUnits.HeaderText = "Units"
        Me.IngredientUnits.Name = "IngredientUnits"
        Me.IngredientUnits.Width = 50
        '
        'btnSaveMenuItemAndRecipe
        '
        Me.btnSaveMenuItemAndRecipe.Location = New System.Drawing.Point(545, 19)
        Me.btnSaveMenuItemAndRecipe.Name = "btnSaveMenuItemAndRecipe"
        Me.btnSaveMenuItemAndRecipe.Size = New System.Drawing.Size(75, 43)
        Me.btnSaveMenuItemAndRecipe.TabIndex = 1
        Me.btnSaveMenuItemAndRecipe.Text = "Save Recipe"
        Me.btnSaveMenuItemAndRecipe.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(656, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 43)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnSaveMenuItemAndRecipe)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 500)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(787, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lblCustOrderHeaer
        '
        Me.lblCustOrderHeaer.AutoSize = True
        Me.lblCustOrderHeaer.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustOrderHeaer.Location = New System.Drawing.Point(527, 22)
        Me.lblCustOrderHeaer.Name = "lblCustOrderHeaer"
        Me.lblCustOrderHeaer.Size = New System.Drawing.Size(270, 32)
        Me.lblCustOrderHeaer.TabIndex = 27
        Me.lblCustOrderHeaer.Text = "Manage Menu Items"
        Me.lblCustOrderHeaer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1135, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pageNavCMB
        '
        Me.pageNavCMB.FormattingEnabled = True
        Me.pageNavCMB.Items.AddRange(New Object() {"Customers", "Employees", "Inventory", "Logout"})
        Me.pageNavCMB.Location = New System.Drawing.Point(1008, 14)
        Me.pageNavCMB.Name = "pageNavCMB"
        Me.pageNavCMB.Size = New System.Drawing.Size(121, 21)
        Me.pageNavCMB.TabIndex = 29
        '
        'AddNewMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 680)
        Me.Controls.Add(Me.pageNavCMB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCustOrderHeaer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RecipeCombox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddNewMenuItem"
        Me.Text = "AddNewMenuItem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RecipeCombox.ResumeLayout(False)
        Me.RecipeCombox.PerformLayout()
        CType(Me.grdIngridientsRecipeLoader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdIngridientReceipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuCategory As System.Windows.Forms.Label
    Friend WithEvents MenuPrice As System.Windows.Forms.Label
    Friend WithEvents MenuName As System.Windows.Forms.Label
    Friend WithEvents cmbItmCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtMenuItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtMenuItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents RecipeCombox As System.Windows.Forms.GroupBox
    Friend WithEvents grdIngridientReceipe As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveFromRecipeGrid As System.Windows.Forms.Button
    Friend WithEvents btnAddToRecipeGrid As System.Windows.Forms.Button
    Friend WithEvents btnSaveMenuItemAndRecipe As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemDescSearch As System.Windows.Forms.TextBox
    Friend WithEvents grdIngridientsRecipeLoader As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lbltescount As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCatID As System.Windows.Forms.Label
    Friend WithEvents IngredientId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientProportion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientUnits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCustOrderHeaer As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pageNavCMB As System.Windows.Forms.ComboBox
End Class
