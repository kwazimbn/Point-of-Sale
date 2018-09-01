<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pageNavCMB = New System.Windows.Forms.ComboBox()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpUpdEmpPersInfo = New System.Windows.Forms.GroupBox()
        Me.grdEmployee = New System.Windows.Forms.DataGridView()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpEmpReg = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoleEmpUp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmdRole = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdTitle = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.TbIngredients = New System.Windows.Forms.TabControl()
        Me.ListingEmployeeTab = New System.Windows.Forms.TabPage()
        Me.lblCustOrderHeaer = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTopUpBal = New System.Windows.Forms.TextBox()
        Me.btnCustSearch = New System.Windows.Forms.Button()
        Me.txtCurrentBal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCustSurname = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtSearchByMobNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnSaveTopUp = New System.Windows.Forms.Button()
        Me.grpEmpPassRest = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtsearchID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.grpUpEmpStatus = New System.Windows.Forms.GroupBox()
        Me.lblEmpRoleIDStatus = New System.Windows.Forms.Label()
        Me.btnUpdateStatusEmp = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEmpRSU = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEmpSComm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmpSP = New System.Windows.Forms.TextBox()
        Me.cmdEmpLSU = New System.Windows.Forms.ComboBox()
        Me.lblEmpIDStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmpFNSU = New System.Windows.Forms.TextBox()
        Me.txtEmpLNSU = New System.Windows.Forms.TextBox()
        Me.btnSearchEmpStatusU = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSearchEmpSU = New System.Windows.Forms.TextBox()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpUpdEmpPersInfo.SuspendLayout()
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmpReg.SuspendLayout()
        Me.TbIngredients.SuspendLayout()
        Me.ListingEmployeeTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpEmpPassRest.SuspendLayout()
        Me.grpUpEmpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1175, 566)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reg Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.pageNavCMB)
        Me.GroupBox1.Controls.Add(Me.btnUpdateEmp)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.grpUpdEmpPersInfo)
        Me.GroupBox1.Controls.Add(Me.btnSaveEmp)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.grpEmpReg)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1169, 560)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(426, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(243, 32)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Manage Employee"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(961, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Next Page"
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pageNavCMB
        '
        Me.pageNavCMB.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageNavCMB.FormattingEnabled = True
        Me.pageNavCMB.Items.AddRange(New Object() {"Customers", "Inventory", "Menu Items", "Logout"})
        Me.pageNavCMB.Location = New System.Drawing.Point(1042, 25)
        Me.pageNavCMB.Name = "pageNavCMB"
        Me.pageNavCMB.Size = New System.Drawing.Size(121, 25)
        Me.pageNavCMB.TabIndex = 9
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmp.Location = New System.Drawing.Point(518, 499)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(83, 37)
        Me.btnUpdateEmp.TabIndex = 25
        Me.btnUpdateEmp.Text = "Update"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(638, 499)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 37)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grpUpdEmpPersInfo
        '
        Me.grpUpdEmpPersInfo.Controls.Add(Me.grdEmployee)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.TextBox7)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.ComboBox4)
        Me.grpUpdEmpPersInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUpdEmpPersInfo.Location = New System.Drawing.Point(338, 69)
        Me.grpUpdEmpPersInfo.Name = "grpUpdEmpPersInfo"
        Me.grpUpdEmpPersInfo.Size = New System.Drawing.Size(779, 423)
        Me.grpUpdEmpPersInfo.TabIndex = 23
        Me.grpUpdEmpPersInfo.TabStop = False
        Me.grpUpdEmpPersInfo.Text = "Employee Info"
        '
        'grdEmployee
        '
        Me.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmployee.Location = New System.Drawing.Point(5, 20)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdEmployee.Size = New System.Drawing.Size(768, 397)
        Me.grdEmployee.TabIndex = 30
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(115, 465)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(197, 20)
        Me.TextBox7.TabIndex = 23
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Select user role", "Customer", "Kitchen Staff", "Cashier ", "Supervisor", "Store Manager", "Admin"})
        Me.ComboBox4.Location = New System.Drawing.Point(115, 498)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox4.TabIndex = 25
        '
        'btnSaveEmp
        '
        Me.btnSaveEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEmp.Location = New System.Drawing.Point(52, 371)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(83, 37)
        Me.btnSaveEmp.TabIndex = 22
        Me.btnSaveEmp.Text = "Save"
        Me.btnSaveEmp.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(172, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 37)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpEmpReg
        '
        Me.grpEmpReg.Controls.Add(Me.Label3)
        Me.grpEmpReg.Controls.Add(Me.txtNumber)
        Me.grpEmpReg.Controls.Add(Me.Label8)
        Me.grpEmpReg.Controls.Add(Me.cmdGender)
        Me.grpEmpReg.Controls.Add(Me.Label7)
        Me.grpEmpReg.Controls.Add(Me.Label2)
        Me.grpEmpReg.Controls.Add(Me.Label9)
        Me.grpEmpReg.Controls.Add(Me.Label1)
        Me.grpEmpReg.Controls.Add(Me.txtRoleEmpUp)
        Me.grpEmpReg.Controls.Add(Me.txtEmail)
        Me.grpEmpReg.Controls.Add(Me.cmdRole)
        Me.grpEmpReg.Controls.Add(Me.Label11)
        Me.grpEmpReg.Controls.Add(Me.cmdTitle)
        Me.grpEmpReg.Controls.Add(Me.txtname)
        Me.grpEmpReg.Controls.Add(Me.txtsurname)
        Me.grpEmpReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmpReg.Location = New System.Drawing.Point(17, 69)
        Me.grpEmpReg.Name = "grpEmpReg"
        Me.grpEmpReg.Size = New System.Drawing.Size(306, 289)
        Me.grpEmpReg.TabIndex = 20
        Me.grpEmpReg.TabStop = False
        Me.grpEmpReg.Text = "Emp Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Phone Number :"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(104, 162)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtNumber.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Title :"
        '
        'cmdGender
        '
        Me.cmdGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGender.FormattingEnabled = True
        Me.cmdGender.Items.AddRange(New Object() {"Select Gender", "Male", "Female"})
        Me.cmdGender.Location = New System.Drawing.Point(104, 128)
        Me.cmdGender.Name = "cmdGender"
        Me.cmdGender.Size = New System.Drawing.Size(83, 21)
        Me.cmdGender.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gender :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email-Address :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'txtRoleEmpUp
        '
        Me.txtRoleEmpUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoleEmpUp.Location = New System.Drawing.Point(210, 227)
        Me.txtRoleEmpUp.Name = "txtRoleEmpUp"
        Me.txtRoleEmpUp.ReadOnly = True
        Me.txtRoleEmpUp.Size = New System.Drawing.Size(91, 20)
        Me.txtRoleEmpUp.TabIndex = 38
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(104, 194)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 20)
        Me.txtEmail.TabIndex = 12
        '
        'cmdRole
        '
        Me.cmdRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRole.FormattingEnabled = True
        Me.cmdRole.Items.AddRange(New Object() {"Select user role", "Kitchen Staff", "Cashier ", "Supervisor", "Store Manager", "Admin"})
        Me.cmdRole.Location = New System.Drawing.Point(104, 227)
        Me.cmdRole.Name = "cmdRole"
        Me.cmdRole.Size = New System.Drawing.Size(100, 21)
        Me.cmdRole.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Role :"
        '
        'cmdTitle
        '
        Me.cmdTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTitle.FormattingEnabled = True
        Me.cmdTitle.Items.AddRange(New Object() {"Select Title", "Mr", "Ms"})
        Me.cmdTitle.Location = New System.Drawing.Point(104, 32)
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(83, 21)
        Me.cmdTitle.TabIndex = 9
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(104, 65)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(197, 20)
        Me.txtname.TabIndex = 10
        '
        'txtsurname
        '
        Me.txtsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsurname.Location = New System.Drawing.Point(104, 95)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(197, 20)
        Me.txtsurname.TabIndex = 11
        '
        'TbIngredients
        '
        Me.TbIngredients.Controls.Add(Me.ListingEmployeeTab)
        Me.TbIngredients.Controls.Add(Me.TabPage1)
        Me.TbIngredients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbIngredients.Location = New System.Drawing.Point(0, 0)
        Me.TbIngredients.Name = "TbIngredients"
        Me.TbIngredients.SelectedIndex = 0
        Me.TbIngredients.Size = New System.Drawing.Size(1183, 592)
        Me.TbIngredients.TabIndex = 0
        '
        'ListingEmployeeTab
        '
        Me.ListingEmployeeTab.BackColor = System.Drawing.Color.YellowGreen
        Me.ListingEmployeeTab.Controls.Add(Me.lblCustOrderHeaer)
        Me.ListingEmployeeTab.Controls.Add(Me.GroupBox2)
        Me.ListingEmployeeTab.Controls.Add(Me.grpEmpPassRest)
        Me.ListingEmployeeTab.Controls.Add(Me.grpUpEmpStatus)
        Me.ListingEmployeeTab.Location = New System.Drawing.Point(4, 22)
        Me.ListingEmployeeTab.Name = "ListingEmployeeTab"
        Me.ListingEmployeeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ListingEmployeeTab.Size = New System.Drawing.Size(1175, 566)
        Me.ListingEmployeeTab.TabIndex = 1
        Me.ListingEmployeeTab.Text = "List of Employees"
        '
        'lblCustOrderHeaer
        '
        Me.lblCustOrderHeaer.AutoSize = True
        Me.lblCustOrderHeaer.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustOrderHeaer.Location = New System.Drawing.Point(457, 12)
        Me.lblCustOrderHeaer.Name = "lblCustOrderHeaer"
        Me.lblCustOrderHeaer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCustOrderHeaer.Size = New System.Drawing.Size(306, 32)
        Me.lblCustOrderHeaer.TabIndex = 63
        Me.lblCustOrderHeaer.Text = "Employee Management"
        Me.lblCustOrderHeaer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCustID)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTopUpBal)
        Me.GroupBox2.Controls.Add(Me.btnCustSearch)
        Me.GroupBox2.Controls.Add(Me.txtCurrentBal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCustSurname)
        Me.GroupBox2.Controls.Add(Me.txtCustName)
        Me.GroupBox2.Controls.Add(Me.txtSearchByMobNo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btnSaveTopUp)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(427, 420)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employees Update"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 356)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "...."
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(113, 117)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(137, 20)
        Me.txtCustID.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Employee ID :"
        '
        'txtTopUpBal
        '
        Me.txtTopUpBal.Location = New System.Drawing.Point(113, 242)
        Me.txtTopUpBal.Name = "txtTopUpBal"
        Me.txtTopUpBal.Size = New System.Drawing.Size(137, 20)
        Me.txtTopUpBal.TabIndex = 11
        '
        'btnCustSearch
        '
        Me.btnCustSearch.Location = New System.Drawing.Point(113, 74)
        Me.btnCustSearch.Name = "btnCustSearch"
        Me.btnCustSearch.Size = New System.Drawing.Size(106, 25)
        Me.btnCustSearch.TabIndex = 10
        Me.btnCustSearch.Text = "Search Employee"
        Me.btnCustSearch.UseVisualStyleBackColor = True
        '
        'txtCurrentBal
        '
        Me.txtCurrentBal.Location = New System.Drawing.Point(113, 212)
        Me.txtCurrentBal.Name = "txtCurrentBal"
        Me.txtCurrentBal.ReadOnly = True
        Me.txtCurrentBal.Size = New System.Drawing.Size(137, 20)
        Me.txtCurrentBal.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "TopUp Amount :"
        '
        'txtCustSurname
        '
        Me.txtCustSurname.Location = New System.Drawing.Point(113, 179)
        Me.txtCustSurname.Name = "txtCustSurname"
        Me.txtCustSurname.ReadOnly = True
        Me.txtCustSurname.Size = New System.Drawing.Size(137, 20)
        Me.txtCustSurname.TabIndex = 7
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(113, 148)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(137, 20)
        Me.txtCustName.TabIndex = 6
        '
        'txtSearchByMobNo
        '
        Me.txtSearchByMobNo.Location = New System.Drawing.Point(122, 37)
        Me.txtSearchByMobNo.Name = "txtSearchByMobNo"
        Me.txtSearchByMobNo.Size = New System.Drawing.Size(128, 20)
        Me.txtSearchByMobNo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Balance :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Surname :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Name :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(103, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Employee Mob No : "
        '
        'btnSaveTopUp
        '
        Me.btnSaveTopUp.Location = New System.Drawing.Point(122, 285)
        Me.btnSaveTopUp.Name = "btnSaveTopUp"
        Me.btnSaveTopUp.Size = New System.Drawing.Size(83, 33)
        Me.btnSaveTopUp.TabIndex = 0
        Me.btnSaveTopUp.Text = "Update"
        Me.btnSaveTopUp.UseVisualStyleBackColor = True
        '
        'grpEmpPassRest
        '
        Me.grpEmpPassRest.Controls.Add(Me.lblID)
        Me.grpEmpPassRest.Controls.Add(Me.btnSearch)
        Me.grpEmpPassRest.Controls.Add(Me.Label26)
        Me.grpEmpPassRest.Controls.Add(Me.txtsearchID)
        Me.grpEmpPassRest.Controls.Add(Me.Label23)
        Me.grpEmpPassRest.Controls.Add(Me.Label25)
        Me.grpEmpPassRest.Controls.Add(Me.txtEname)
        Me.grpEmpPassRest.Controls.Add(Me.txtcontact)
        Me.grpEmpPassRest.Controls.Add(Me.Button4)
        Me.grpEmpPassRest.Location = New System.Drawing.Point(813, 66)
        Me.grpEmpPassRest.Name = "grpEmpPassRest"
        Me.grpEmpPassRest.Size = New System.Drawing.Size(345, 305)
        Me.grpEmpPassRest.TabIndex = 3
        Me.grpEmpPassRest.TabStop = False
        Me.grpEmpPassRest.Text = "Reset Emp Password"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(113, 128)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(19, 15)
        Me.lblID.TabIndex = 52
        Me.lblID.Text = ".. :"
        Me.lblID.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(137, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 29)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(40, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 15)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Emp ID :"
        '
        'txtsearchID
        '
        Me.txtsearchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchID.Location = New System.Drawing.Point(137, 28)
        Me.txtsearchID.Name = "txtsearchID"
        Me.txtsearchID.Size = New System.Drawing.Size(88, 20)
        Me.txtsearchID.TabIndex = 49
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(21, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Employee Name :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 159)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 13)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Contact No :"
        '
        'txtEname
        '
        Me.txtEname.Location = New System.Drawing.Point(138, 124)
        Me.txtEname.Name = "txtEname"
        Me.txtEname.ReadOnly = True
        Me.txtEname.Size = New System.Drawing.Size(137, 20)
        Me.txtEname.TabIndex = 16
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(138, 155)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.ReadOnly = True
        Me.txtcontact.Size = New System.Drawing.Size(137, 20)
        Me.txtcontact.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(137, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 34)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Change Password"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'grpUpEmpStatus
        '
        Me.grpUpEmpStatus.Controls.Add(Me.lblEmpRoleIDStatus)
        Me.grpUpEmpStatus.Controls.Add(Me.btnUpdateStatusEmp)
        Me.grpUpEmpStatus.Controls.Add(Me.Label15)
        Me.grpUpEmpStatus.Controls.Add(Me.txtEmpRSU)
        Me.grpUpEmpStatus.Controls.Add(Me.Label21)
        Me.grpUpEmpStatus.Controls.Add(Me.txtEmpSComm)
        Me.grpUpEmpStatus.Controls.Add(Me.Label19)
        Me.grpUpEmpStatus.Controls.Add(Me.txtEmpSP)
        Me.grpUpEmpStatus.Controls.Add(Me.cmdEmpLSU)
        Me.grpUpEmpStatus.Controls.Add(Me.lblEmpIDStatus)
        Me.grpUpEmpStatus.Controls.Add(Me.Label16)
        Me.grpUpEmpStatus.Controls.Add(Me.Label17)
        Me.grpUpEmpStatus.Controls.Add(Me.txtEmpFNSU)
        Me.grpUpEmpStatus.Controls.Add(Me.txtEmpLNSU)
        Me.grpUpEmpStatus.Controls.Add(Me.btnSearchEmpStatusU)
        Me.grpUpEmpStatus.Controls.Add(Me.Label18)
        Me.grpUpEmpStatus.Controls.Add(Me.txtSearchEmpSU)
        Me.grpUpEmpStatus.Location = New System.Drawing.Point(439, 65)
        Me.grpUpEmpStatus.Name = "grpUpEmpStatus"
        Me.grpUpEmpStatus.Size = New System.Drawing.Size(368, 305)
        Me.grpUpEmpStatus.TabIndex = 2
        Me.grpUpEmpStatus.TabStop = False
        Me.grpUpEmpStatus.Text = "Update Emp Status"
        '
        'lblEmpRoleIDStatus
        '
        Me.lblEmpRoleIDStatus.AutoSize = True
        Me.lblEmpRoleIDStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpRoleIDStatus.Location = New System.Drawing.Point(107, 158)
        Me.lblEmpRoleIDStatus.Name = "lblEmpRoleIDStatus"
        Me.lblEmpRoleIDStatus.Size = New System.Drawing.Size(19, 15)
        Me.lblEmpRoleIDStatus.TabIndex = 62
        Me.lblEmpRoleIDStatus.Text = "...."
        Me.lblEmpRoleIDStatus.Visible = False
        '
        'btnUpdateStatusEmp
        '
        Me.btnUpdateStatusEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatusEmp.Location = New System.Drawing.Point(157, 260)
        Me.btnUpdateStatusEmp.Name = "btnUpdateStatusEmp"
        Me.btnUpdateStatusEmp.Size = New System.Drawing.Size(83, 34)
        Me.btnUpdateStatusEmp.TabIndex = 61
        Me.btnUpdateStatusEmp.Text = "Update Status"
        Me.btnUpdateStatusEmp.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Role :"
        '
        'txtEmpRSU
        '
        Me.txtEmpRSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpRSU.Location = New System.Drawing.Point(140, 153)
        Me.txtEmpRSU.Name = "txtEmpRSU"
        Me.txtEmpRSU.ReadOnly = True
        Me.txtEmpRSU.Size = New System.Drawing.Size(197, 20)
        Me.txtEmpRSU.TabIndex = 59
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Comment :"
        '
        'txtEmpSComm
        '
        Me.txtEmpSComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSComm.Location = New System.Drawing.Point(140, 212)
        Me.txtEmpSComm.Multiline = True
        Me.txtEmpSComm.Name = "txtEmpSComm"
        Me.txtEmpSComm.Size = New System.Drawing.Size(197, 42)
        Me.txtEmpSComm.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Status :"
        '
        'txtEmpSP
        '
        Me.txtEmpSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSP.Location = New System.Drawing.Point(140, 181)
        Me.txtEmpSP.Name = "txtEmpSP"
        Me.txtEmpSP.ReadOnly = True
        Me.txtEmpSP.Size = New System.Drawing.Size(82, 20)
        Me.txtEmpSP.TabIndex = 55
        '
        'cmdEmpLSU
        '
        Me.cmdEmpLSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmpLSU.FormattingEnabled = True
        Me.cmdEmpLSU.Items.AddRange(New Object() {"Select status", "Active", "Blocked"})
        Me.cmdEmpLSU.Location = New System.Drawing.Point(228, 180)
        Me.cmdEmpLSU.Name = "cmdEmpLSU"
        Me.cmdEmpLSU.Size = New System.Drawing.Size(109, 21)
        Me.cmdEmpLSU.TabIndex = 54
        '
        'lblEmpIDStatus
        '
        Me.lblEmpIDStatus.AutoSize = True
        Me.lblEmpIDStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpIDStatus.Location = New System.Drawing.Point(107, 98)
        Me.lblEmpIDStatus.Name = "lblEmpIDStatus"
        Me.lblEmpIDStatus.Size = New System.Drawing.Size(19, 15)
        Me.lblEmpIDStatus.TabIndex = 53
        Me.lblEmpIDStatus.Text = "...."
        Me.lblEmpIDStatus.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 15)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Last Name :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 15)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "First Name :"
        '
        'txtEmpFNSU
        '
        Me.txtEmpFNSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpFNSU.Location = New System.Drawing.Point(140, 96)
        Me.txtEmpFNSU.Name = "txtEmpFNSU"
        Me.txtEmpFNSU.ReadOnly = True
        Me.txtEmpFNSU.Size = New System.Drawing.Size(197, 20)
        Me.txtEmpFNSU.TabIndex = 49
        '
        'txtEmpLNSU
        '
        Me.txtEmpLNSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpLNSU.Location = New System.Drawing.Point(140, 126)
        Me.txtEmpLNSU.Name = "txtEmpLNSU"
        Me.txtEmpLNSU.ReadOnly = True
        Me.txtEmpLNSU.Size = New System.Drawing.Size(197, 20)
        Me.txtEmpLNSU.TabIndex = 50
        '
        'btnSearchEmpStatusU
        '
        Me.btnSearchEmpStatusU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEmpStatusU.Location = New System.Drawing.Point(162, 61)
        Me.btnSearchEmpStatusU.Name = "btnSearchEmpStatusU"
        Me.btnSearchEmpStatusU.Size = New System.Drawing.Size(83, 29)
        Me.btnSearchEmpStatusU.TabIndex = 48
        Me.btnSearchEmpStatusU.Text = "Search"
        Me.btnSearchEmpStatusU.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(65, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 15)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Emp ID :"
        '
        'txtSearchEmpSU
        '
        Me.txtSearchEmpSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmpSU.Location = New System.Drawing.Point(162, 20)
        Me.txtSearchEmpSU.Name = "txtSearchEmpSU"
        Me.txtSearchEmpSU.Size = New System.Drawing.Size(88, 20)
        Me.txtSearchEmpSU.TabIndex = 46
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 592)
        Me.Controls.Add(Me.TbIngredients)
        Me.Name = "AddEmployee"
        Me.Text = "Employee"
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpUpdEmpPersInfo.ResumeLayout(False)
        Me.grpUpdEmpPersInfo.PerformLayout()
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmpReg.ResumeLayout(False)
        Me.grpEmpReg.PerformLayout()
        Me.TbIngredients.ResumeLayout(False)
        Me.ListingEmployeeTab.ResumeLayout(False)
        Me.ListingEmployeeTab.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpEmpPassRest.ResumeLayout(False)
        Me.grpEmpPassRest.PerformLayout()
        Me.grpUpEmpStatus.ResumeLayout(False)
        Me.grpUpEmpStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TbIngredients As System.Windows.Forms.TabControl
    Friend WithEvents ListingEmployeeTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveEmp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpEmpReg As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmdRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateEmp As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents grpUpdEmpPersInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtRoleEmpUp As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents grdEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents grpEmpPassRest As System.Windows.Forms.GroupBox
    Friend WithEvents grpUpEmpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmpRoleIDStatus As System.Windows.Forms.Label
    Friend WithEvents btnUpdateStatusEmp As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmpRSU As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSComm As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSP As System.Windows.Forms.TextBox
    Friend WithEvents cmdEmpLSU As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpIDStatus As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEmpFNSU As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpLNSU As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchEmpStatusU As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSearchEmpSU As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTopUpBal As System.Windows.Forms.TextBox
    Friend WithEvents btnCustSearch As System.Windows.Forms.Button
    Friend WithEvents txtCurrentBal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCustSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchByMobNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnSaveTopUp As System.Windows.Forms.Button
    Friend WithEvents lblCustOrderHeaer As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pageNavCMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtsearchID As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtEname As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label

End Class
