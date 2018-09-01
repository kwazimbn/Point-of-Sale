<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsEditMenus = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LgnStatus = New System.Windows.Forms.Label()
        Me.userCatlbl = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(1177, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 467)
        Me.VScrollBar1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 437)
        Me.Panel1.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.tlsLogout})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(20, 20, 10, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(148, 270)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 20, 20, 10)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 19)
        Me.ToolStripMenuItem1.Text = "User Management"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaceOrderToolStripMenuItem, Me.CompleteOrderToolStripMenuItem})
        Me.ToolStripMenuItem3.Margin = New System.Windows.Forms.Padding(0, 20, 20, 10)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(121, 19)
        Me.ToolStripMenuItem3.Text = "Sales"
        '
        'PlaceOrderToolStripMenuItem
        '
        Me.PlaceOrderToolStripMenuItem.Name = "PlaceOrderToolStripMenuItem"
        Me.PlaceOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PlaceOrderToolStripMenuItem.Text = "Place Order"
        '
        'CompleteOrderToolStripMenuItem
        '
        Me.CompleteOrderToolStripMenuItem.Name = "CompleteOrderToolStripMenuItem"
        Me.CompleteOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompleteOrderToolStripMenuItem.Text = "Complete Order"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsEditMenus, Me.CreateRecipeToolStripMenuItem})
        Me.ToolStripMenuItem5.Margin = New System.Windows.Forms.Padding(0, 20, 20, 10)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(121, 19)
        Me.ToolStripMenuItem5.Text = "Inventory"
        '
        'tlsEditMenus
        '
        Me.tlsEditMenus.Name = "tlsEditMenus"
        Me.tlsEditMenus.Size = New System.Drawing.Size(146, 22)
        Me.tlsEditMenus.Text = "Receive stock"
        '
        'CreateRecipeToolStripMenuItem
        '
        Me.CreateRecipeToolStripMenuItem.Name = "CreateRecipeToolStripMenuItem"
        Me.CreateRecipeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CreateRecipeToolStripMenuItem.Text = "Create Recipe"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.ToolStripMenuItem6.Margin = New System.Windows.Forms.Padding(0, 20, 20, 10)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(121, 19)
        Me.ToolStripMenuItem6.Text = "Reports"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem8.Text = "Sales Report"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem9.Text = "Stock On Hand"
        '
        'tlsLogout
        '
        Me.tlsLogout.Margin = New System.Windows.Forms.Padding(0, 20, 20, 10)
        Me.tlsLogout.Name = "tlsLogout"
        Me.tlsLogout.Size = New System.Drawing.Size(121, 19)
        Me.tlsLogout.Text = "LogOut"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PointOfSale.My.Resources.Resources.userlogin
        Me.PictureBox1.Location = New System.Drawing.Point(1098, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LgnStatus
        '
        Me.LgnStatus.AutoSize = True
        Me.LgnStatus.Location = New System.Drawing.Point(1009, 0)
        Me.LgnStatus.Name = "LgnStatus"
        Me.LgnStatus.Size = New System.Drawing.Size(58, 13)
        Me.LgnStatus.TabIndex = 16
        Me.LgnStatus.Text = "Logged off"
        '
        'userCatlbl
        '
        Me.userCatlbl.AutoSize = True
        Me.userCatlbl.Location = New System.Drawing.Point(1024, 23)
        Me.userCatlbl.Name = "userCatlbl"
        Me.userCatlbl.Size = New System.Drawing.Size(29, 13)
        Me.userCatlbl.TabIndex = 17
        Me.userCatlbl.Text = "User"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1177, 30)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 467)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.userCatlbl)
        Me.Controls.Add(Me.LgnStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.VScrollBar1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "V'City Chicks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsEditMenus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LgnStatus As System.Windows.Forms.Label
    Friend WithEvents userCatlbl As System.Windows.Forms.Label
    Friend WithEvents CreateRecipeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
