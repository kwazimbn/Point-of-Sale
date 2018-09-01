<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompleteOrder
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
        Me.btnCompleteOrder = New System.Windows.Forms.Button()
        Me.gridviewKitchen = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OrderItems1 = New System.Windows.Forms.TabPage()
        Me.grdOrderLeft = New System.Windows.Forms.DataGridView()
        Me.Recipe1 = New System.Windows.Forms.TabPage()
        Me.gridRecipe = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbloid1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOrderStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrderCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOrderStatus = New System.Windows.Forms.ComboBox()
        Me.pnlKitchenCompleteOrder = New System.Windows.Forms.Panel()
        Me.lblCustOrderHeaer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.gridviewKitchen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.OrderItems1.SuspendLayout()
        CType(Me.grdOrderLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Recipe1.SuspendLayout()
        CType(Me.gridRecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlKitchenCompleteOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompleteOrder
        '
        Me.btnCompleteOrder.Location = New System.Drawing.Point(300, 513)
        Me.btnCompleteOrder.Name = "btnCompleteOrder"
        Me.btnCompleteOrder.Size = New System.Drawing.Size(101, 35)
        Me.btnCompleteOrder.TabIndex = 0
        Me.btnCompleteOrder.Text = "Complete Order"
        Me.btnCompleteOrder.UseVisualStyleBackColor = True
        '
        'gridviewKitchen
        '
        Me.gridviewKitchen.AllowUserToResizeColumns = False
        Me.gridviewKitchen.AllowUserToResizeRows = False
        Me.gridviewKitchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewKitchen.Location = New System.Drawing.Point(6, 74)
        Me.gridviewKitchen.Name = "gridviewKitchen"
        Me.gridviewKitchen.ReadOnly = True
        Me.gridviewKitchen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridviewKitchen.Size = New System.Drawing.Size(226, 345)
        Me.gridviewKitchen.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.OrderItems1)
        Me.TabControl1.Controls.Add(Me.Recipe1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 389)
        Me.TabControl1.TabIndex = 2
        '
        'OrderItems1
        '
        Me.OrderItems1.Controls.Add(Me.grdOrderLeft)
        Me.OrderItems1.Location = New System.Drawing.Point(4, 22)
        Me.OrderItems1.Name = "OrderItems1"
        Me.OrderItems1.Padding = New System.Windows.Forms.Padding(3)
        Me.OrderItems1.Size = New System.Drawing.Size(441, 363)
        Me.OrderItems1.TabIndex = 0
        Me.OrderItems1.Text = "Order Items"
        Me.OrderItems1.UseVisualStyleBackColor = True
        '
        'grdOrderLeft
        '
        Me.grdOrderLeft.AllowUserToResizeColumns = False
        Me.grdOrderLeft.AllowUserToResizeRows = False
        Me.grdOrderLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrderLeft.Location = New System.Drawing.Point(3, 3)
        Me.grdOrderLeft.Name = "grdOrderLeft"
        Me.grdOrderLeft.ReadOnly = True
        Me.grdOrderLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrderLeft.Size = New System.Drawing.Size(436, 357)
        Me.grdOrderLeft.TabIndex = 2
        '
        'Recipe1
        '
        Me.Recipe1.Controls.Add(Me.gridRecipe)
        Me.Recipe1.Location = New System.Drawing.Point(4, 22)
        Me.Recipe1.Name = "Recipe1"
        Me.Recipe1.Padding = New System.Windows.Forms.Padding(3)
        Me.Recipe1.Size = New System.Drawing.Size(441, 363)
        Me.Recipe1.TabIndex = 1
        Me.Recipe1.Text = "Recipe"
        Me.Recipe1.UseVisualStyleBackColor = True
        '
        'gridRecipe
        '
        Me.gridRecipe.AllowUserToResizeColumns = False
        Me.gridRecipe.AllowUserToResizeRows = False
        Me.gridRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRecipe.Location = New System.Drawing.Point(3, 3)
        Me.gridRecipe.Name = "gridRecipe"
        Me.gridRecipe.ReadOnly = True
        Me.gridRecipe.Size = New System.Drawing.Size(419, 207)
        Me.gridRecipe.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbloid1)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 443)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Order ID :"
        '
        'lbloid1
        '
        Me.lbloid1.AutoSize = True
        Me.lbloid1.Location = New System.Drawing.Point(212, 32)
        Me.lbloid1.Name = "lbloid1"
        Me.lbloid1.Size = New System.Drawing.Size(31, 13)
        Me.lbloid1.TabIndex = 3
        Me.lbloid1.Text = "........"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOrderStatus)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblOrderCount)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbOrderStatus)
        Me.GroupBox2.Controls.Add(Me.gridviewKitchen)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 443)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Queue"
        '
        'lblOrderStatus
        '
        Me.lblOrderStatus.AutoSize = True
        Me.lblOrderStatus.Location = New System.Drawing.Point(155, 421)
        Me.lblOrderStatus.Name = "lblOrderStatus"
        Me.lblOrderStatus.Size = New System.Drawing.Size(19, 13)
        Me.lblOrderStatus.TabIndex = 6
        Me.lblOrderStatus.Text = "...."
        Me.lblOrderStatus.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No of Orders : "
        '
        'lblOrderCount
        '
        Me.lblOrderCount.AutoSize = True
        Me.lblOrderCount.Location = New System.Drawing.Point(92, 422)
        Me.lblOrderCount.Name = "lblOrderCount"
        Me.lblOrderCount.Size = New System.Drawing.Size(25, 13)
        Me.lblOrderCount.TabIndex = 7
        Me.lblOrderCount.Text = "......"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Orders Status :"
        '
        'cmbOrderStatus
        '
        Me.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrderStatus.FormattingEnabled = True
        Me.cmbOrderStatus.Items.AddRange(New Object() {"Open", "Closed"})
        Me.cmbOrderStatus.Location = New System.Drawing.Point(111, 34)
        Me.cmbOrderStatus.Name = "cmbOrderStatus"
        Me.cmbOrderStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrderStatus.TabIndex = 5
        '
        'pnlKitchenCompleteOrder
        '
        Me.pnlKitchenCompleteOrder.BackColor = System.Drawing.Color.YellowGreen
        Me.pnlKitchenCompleteOrder.Controls.Add(Me.lblCustOrderHeaer)
        Me.pnlKitchenCompleteOrder.Controls.Add(Me.GroupBox2)
        Me.pnlKitchenCompleteOrder.Controls.Add(Me.btnCompleteOrder)
        Me.pnlKitchenCompleteOrder.Controls.Add(Me.GroupBox1)
        Me.pnlKitchenCompleteOrder.Location = New System.Drawing.Point(221, 3)
        Me.pnlKitchenCompleteOrder.Name = "pnlKitchenCompleteOrder"
        Me.pnlKitchenCompleteOrder.Size = New System.Drawing.Size(748, 566)
        Me.pnlKitchenCompleteOrder.TabIndex = 6
        '
        'lblCustOrderHeaer
        '
        Me.lblCustOrderHeaer.AutoSize = True
        Me.lblCustOrderHeaer.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustOrderHeaer.Location = New System.Drawing.Point(185, 6)
        Me.lblCustOrderHeaer.Name = "lblCustOrderHeaer"
        Me.lblCustOrderHeaer.Size = New System.Drawing.Size(217, 32)
        Me.lblCustOrderHeaer.TabIndex = 27
        Me.lblCustOrderHeaer.Text = "Complete Order"
        Me.lblCustOrderHeaer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(976, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Place Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(976, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CompleteOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1098, 590)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlKitchenCompleteOrder)
        Me.Name = "CompleteOrder"
        Me.Text = "CompleteOrder"
        CType(Me.gridviewKitchen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.OrderItems1.ResumeLayout(False)
        CType(Me.grdOrderLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Recipe1.ResumeLayout(False)
        CType(Me.gridRecipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlKitchenCompleteOrder.ResumeLayout(False)
        Me.pnlKitchenCompleteOrder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompleteOrder As System.Windows.Forms.Button
    Friend WithEvents gridviewKitchen As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents OrderItems1 As System.Windows.Forms.TabPage
    Friend WithEvents Recipe1 As System.Windows.Forms.TabPage
    Friend WithEvents gridRecipe As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbloid1 As System.Windows.Forms.Label
    Friend WithEvents grdOrderLeft As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOrderStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOrderStatus As System.Windows.Forms.Label
    Friend WithEvents pnlKitchenCompleteOrder As System.Windows.Forms.Panel
    Friend WithEvents lblCustOrderHeaer As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
