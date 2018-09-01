<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomers
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
        Me.ListingEmployeeTab = New System.Windows.Forms.TabPage()
        Me.grpUpEmpStatus = New System.Windows.Forms.GroupBox()
        Me.btnUpdateStatusEmp = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCustComm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCustSP = New System.Windows.Forms.TextBox()
        Me.cmdCustLSU = New System.Windows.Forms.ComboBox()
        Me.lblEmpIDStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCustFNSU = New System.Windows.Forms.TextBox()
        Me.txtCustLNSU = New System.Windows.Forms.TextBox()
        Me.btnSearchCustStatusU = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSearchEmpSU = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpUEI = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSaveTopUp = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pageNavCMB = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCustOrderHeaer = New System.Windows.Forms.Label()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpUpdEmpPersInfo = New System.Windows.Forms.GroupBox()
        Me.lblCoutCustomer = New System.Windows.Forms.Label()
        Me.grdCustomer = New System.Windows.Forms.DataGridView()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveCust = New System.Windows.Forms.Button()
        Me.grpEmpReg = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmdTitle = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ListingEmployeeTab.SuspendLayout()
        Me.grpUpEmpStatus.SuspendLayout()
        Me.grpUEI.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpUpdEmpPersInfo.SuspendLayout()
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmpReg.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListingEmployeeTab
        '
        Me.ListingEmployeeTab.BackColor = System.Drawing.Color.YellowGreen
        Me.ListingEmployeeTab.Controls.Add(Me.grpUpEmpStatus)
        Me.ListingEmployeeTab.Controls.Add(Me.Button1)
        Me.ListingEmployeeTab.Controls.Add(Me.grpUEI)
        Me.ListingEmployeeTab.Location = New System.Drawing.Point(4, 22)
        Me.ListingEmployeeTab.Name = "ListingEmployeeTab"
        Me.ListingEmployeeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ListingEmployeeTab.Size = New System.Drawing.Size(1256, 507)
        Me.ListingEmployeeTab.TabIndex = 1
        Me.ListingEmployeeTab.Text = "Customer Update Info"
        '
        'grpUpEmpStatus
        '
        Me.grpUpEmpStatus.Controls.Add(Me.btnUpdateStatusEmp)
        Me.grpUpEmpStatus.Controls.Add(Me.Label21)
        Me.grpUpEmpStatus.Controls.Add(Me.txtCustComm)
        Me.grpUpEmpStatus.Controls.Add(Me.Label19)
        Me.grpUpEmpStatus.Controls.Add(Me.txtCustSP)
        Me.grpUpEmpStatus.Controls.Add(Me.cmdCustLSU)
        Me.grpUpEmpStatus.Controls.Add(Me.lblEmpIDStatus)
        Me.grpUpEmpStatus.Controls.Add(Me.Label16)
        Me.grpUpEmpStatus.Controls.Add(Me.Label17)
        Me.grpUpEmpStatus.Controls.Add(Me.txtCustFNSU)
        Me.grpUpEmpStatus.Controls.Add(Me.txtCustLNSU)
        Me.grpUpEmpStatus.Controls.Add(Me.btnSearchCustStatusU)
        Me.grpUpEmpStatus.Controls.Add(Me.Label18)
        Me.grpUpEmpStatus.Controls.Add(Me.txtSearchEmpSU)
        Me.grpUpEmpStatus.Location = New System.Drawing.Point(594, 39)
        Me.grpUpEmpStatus.Name = "grpUpEmpStatus"
        Me.grpUpEmpStatus.Size = New System.Drawing.Size(368, 305)
        Me.grpUpEmpStatus.TabIndex = 2
        Me.grpUpEmpStatus.TabStop = False
        Me.grpUpEmpStatus.Text = "Update Customer Status"
        '
        'btnUpdateStatusEmp
        '
        Me.btnUpdateStatusEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatusEmp.Location = New System.Drawing.Point(162, 258)
        Me.btnUpdateStatusEmp.Name = "btnUpdateStatusEmp"
        Me.btnUpdateStatusEmp.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateStatusEmp.TabIndex = 61
        Me.btnUpdateStatusEmp.Text = "Update Status"
        Me.btnUpdateStatusEmp.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Comment :"
        '
        'txtCustComm
        '
        Me.txtCustComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustComm.Location = New System.Drawing.Point(140, 184)
        Me.txtCustComm.Multiline = True
        Me.txtCustComm.Name = "txtCustComm"
        Me.txtCustComm.Size = New System.Drawing.Size(197, 42)
        Me.txtCustComm.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Status :"
        '
        'txtCustSP
        '
        Me.txtCustSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSP.Location = New System.Drawing.Point(140, 153)
        Me.txtCustSP.Name = "txtCustSP"
        Me.txtCustSP.ReadOnly = True
        Me.txtCustSP.Size = New System.Drawing.Size(82, 20)
        Me.txtCustSP.TabIndex = 55
        '
        'cmdCustLSU
        '
        Me.cmdCustLSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdCustLSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustLSU.FormattingEnabled = True
        Me.cmdCustLSU.Items.AddRange(New Object() {"Select status", "Active", "Blocked"})
        Me.cmdCustLSU.Location = New System.Drawing.Point(228, 152)
        Me.cmdCustLSU.Name = "cmdCustLSU"
        Me.cmdCustLSU.Size = New System.Drawing.Size(109, 21)
        Me.cmdCustLSU.TabIndex = 54
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
        'txtCustFNSU
        '
        Me.txtCustFNSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFNSU.Location = New System.Drawing.Point(140, 96)
        Me.txtCustFNSU.Name = "txtCustFNSU"
        Me.txtCustFNSU.ReadOnly = True
        Me.txtCustFNSU.Size = New System.Drawing.Size(197, 20)
        Me.txtCustFNSU.TabIndex = 49
        '
        'txtCustLNSU
        '
        Me.txtCustLNSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLNSU.Location = New System.Drawing.Point(140, 126)
        Me.txtCustLNSU.Name = "txtCustLNSU"
        Me.txtCustLNSU.ReadOnly = True
        Me.txtCustLNSU.Size = New System.Drawing.Size(197, 20)
        Me.txtCustLNSU.TabIndex = 50
        '
        'btnSearchCustStatusU
        '
        Me.btnSearchCustStatusU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustStatusU.Location = New System.Drawing.Point(162, 61)
        Me.btnSearchCustStatusU.Name = "btnSearchCustStatusU"
        Me.btnSearchCustStatusU.Size = New System.Drawing.Size(83, 29)
        Me.btnSearchCustStatusU.TabIndex = 48
        Me.btnSearchCustStatusU.Text = "Search"
        Me.btnSearchCustStatusU.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Test button"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpUEI
        '
        Me.grpUEI.BackColor = System.Drawing.Color.YellowGreen
        Me.grpUEI.Controls.Add(Me.Label15)
        Me.grpUEI.Controls.Add(Me.Label14)
        Me.grpUEI.Controls.Add(Me.txtCustID)
        Me.grpUEI.Controls.Add(Me.Label13)
        Me.grpUEI.Controls.Add(Me.txtTopUpBal)
        Me.grpUEI.Controls.Add(Me.btnCustSearch)
        Me.grpUEI.Controls.Add(Me.txtCurrentBal)
        Me.grpUEI.Controls.Add(Me.Label12)
        Me.grpUEI.Controls.Add(Me.txtCustSurname)
        Me.grpUEI.Controls.Add(Me.txtCustName)
        Me.grpUEI.Controls.Add(Me.txtSearchByMobNo)
        Me.grpUEI.Controls.Add(Me.Label11)
        Me.grpUEI.Controls.Add(Me.Label10)
        Me.grpUEI.Controls.Add(Me.Label6)
        Me.grpUEI.Controls.Add(Me.Label4)
        Me.grpUEI.Controls.Add(Me.btnSaveTopUp)
        Me.grpUEI.Location = New System.Drawing.Point(232, 39)
        Me.grpUEI.Name = "grpUEI"
        Me.grpUEI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpUEI.Size = New System.Drawing.Size(356, 505)
        Me.grpUEI.TabIndex = 0
        Me.grpUEI.TabStop = False
        Me.grpUEI.Text = "Customer Topup"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(119, 396)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "__"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 356)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "__"
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
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Customer Id :"
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
        Me.btnCustSearch.Location = New System.Drawing.Point(107, 74)
        Me.btnCustSearch.Name = "btnCustSearch"
        Me.btnCustSearch.Size = New System.Drawing.Size(106, 25)
        Me.btnCustSearch.TabIndex = 10
        Me.btnCustSearch.Text = "Search Customer"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Current Balance :"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer Mob No : "
        '
        'btnSaveTopUp
        '
        Me.btnSaveTopUp.Location = New System.Drawing.Point(122, 285)
        Me.btnSaveTopUp.Name = "btnSaveTopUp"
        Me.btnSaveTopUp.Size = New System.Drawing.Size(83, 29)
        Me.btnSaveTopUp.TabIndex = 0
        Me.btnSaveTopUp.Text = "Save"
        Me.btnSaveTopUp.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1256, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reg Customer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.pageNavCMB)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lblCustOrderHeaer)
        Me.GroupBox1.Controls.Add(Me.btnUpdateEmp)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.grpUpdEmpPersInfo)
        Me.GroupBox1.Controls.Add(Me.btnSaveCust)
        Me.GroupBox1.Controls.Add(Me.grpEmpReg)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1250, 501)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "........"
        '
        'pageNavCMB
        '
        Me.pageNavCMB.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageNavCMB.FormattingEnabled = True
        Me.pageNavCMB.Items.AddRange(New Object() {"Employees", "Inventory", "Menu Items", "Logout"})
        Me.pageNavCMB.Location = New System.Drawing.Point(1028, 23)
        Me.pageNavCMB.Name = "pageNavCMB"
        Me.pageNavCMB.Size = New System.Drawing.Size(103, 25)
        Me.pageNavCMB.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1137, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCustOrderHeaer
        '
        Me.lblCustOrderHeaer.AutoSize = True
        Me.lblCustOrderHeaer.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustOrderHeaer.Location = New System.Drawing.Point(474, 22)
        Me.lblCustOrderHeaer.Name = "lblCustOrderHeaer"
        Me.lblCustOrderHeaer.Size = New System.Drawing.Size(360, 32)
        Me.lblCustOrderHeaer.TabIndex = 26
        Me.lblCustOrderHeaer.Text = "Manage Customer Accounts"
        Me.lblCustOrderHeaer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmp.Location = New System.Drawing.Point(518, 500)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(83, 37)
        Me.btnUpdateEmp.TabIndex = 25
        Me.btnUpdateEmp.Text = "Update"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(638, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 37)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grpUpdEmpPersInfo
        '
        Me.grpUpdEmpPersInfo.BackColor = System.Drawing.Color.YellowGreen
        Me.grpUpdEmpPersInfo.Controls.Add(Me.lblCoutCustomer)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.grdCustomer)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.TextBox7)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.ComboBox4)
        Me.grpUpdEmpPersInfo.Controls.Add(Me.Label5)
        Me.grpUpdEmpPersInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUpdEmpPersInfo.Location = New System.Drawing.Point(338, 71)
        Me.grpUpdEmpPersInfo.Name = "grpUpdEmpPersInfo"
        Me.grpUpdEmpPersInfo.Size = New System.Drawing.Size(779, 423)
        Me.grpUpdEmpPersInfo.TabIndex = 23
        Me.grpUpdEmpPersInfo.TabStop = False
        '
        'lblCoutCustomer
        '
        Me.lblCoutCustomer.AutoSize = True
        Me.lblCoutCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoutCustomer.Location = New System.Drawing.Point(151, 17)
        Me.lblCoutCustomer.Name = "lblCoutCustomer"
        Me.lblCoutCustomer.Size = New System.Drawing.Size(31, 15)
        Me.lblCoutCustomer.TabIndex = 31
        Me.lblCoutCustomer.Text = "........"
        '
        'grdCustomer
        '
        Me.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomer.Location = New System.Drawing.Point(5, 40)
        Me.grdCustomer.Name = "grdCustomer"
        Me.grdCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdCustomer.Size = New System.Drawing.Size(732, 355)
        Me.grdCustomer.TabIndex = 30
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "No of Customers :"
        '
        'btnSaveCust
        '
        Me.btnSaveCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCust.Location = New System.Drawing.Point(109, 393)
        Me.btnSaveCust.Name = "btnSaveCust"
        Me.btnSaveCust.Size = New System.Drawing.Size(83, 37)
        Me.btnSaveCust.TabIndex = 22
        Me.btnSaveCust.Text = "Save"
        Me.btnSaveCust.UseVisualStyleBackColor = True
        '
        'grpEmpReg
        '
        Me.grpEmpReg.BackColor = System.Drawing.Color.YellowGreen
        Me.grpEmpReg.Controls.Add(Me.Label3)
        Me.grpEmpReg.Controls.Add(Me.txtNumber)
        Me.grpEmpReg.Controls.Add(Me.Label8)
        Me.grpEmpReg.Controls.Add(Me.cmdGender)
        Me.grpEmpReg.Controls.Add(Me.Label7)
        Me.grpEmpReg.Controls.Add(Me.Label2)
        Me.grpEmpReg.Controls.Add(Me.Label9)
        Me.grpEmpReg.Controls.Add(Me.Label1)
        Me.grpEmpReg.Controls.Add(Me.txtEmail)
        Me.grpEmpReg.Controls.Add(Me.cmdTitle)
        Me.grpEmpReg.Controls.Add(Me.txtname)
        Me.grpEmpReg.Controls.Add(Me.txtsurname)
        Me.grpEmpReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmpReg.Location = New System.Drawing.Point(17, 71)
        Me.grpEmpReg.Name = "grpEmpReg"
        Me.grpEmpReg.Size = New System.Drawing.Size(306, 289)
        Me.grpEmpReg.TabIndex = 20
        Me.grpEmpReg.TabStop = False
        Me.grpEmpReg.Text = "Customer Registration"
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
        Me.cmdGender.Size = New System.Drawing.Size(197, 21)
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
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(104, 194)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 20)
        Me.txtEmail.TabIndex = 12
        '
        'cmdTitle
        '
        Me.cmdTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTitle.FormattingEnabled = True
        Me.cmdTitle.Items.AddRange(New Object() {"Select Title", "Mr", "Miss", "Mrs"})
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.ListingEmployeeTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1264, 533)
        Me.TabControl1.TabIndex = 1
        '
        'EditCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PointOfSale.My.Resources.Resources.Vcitylogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 533)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EditCustomers"
        Me.Text = "EditCustomers"
        Me.ListingEmployeeTab.ResumeLayout(False)
        Me.grpUpEmpStatus.ResumeLayout(False)
        Me.grpUpEmpStatus.PerformLayout()
        Me.grpUEI.ResumeLayout(False)
        Me.grpUEI.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpUpdEmpPersInfo.ResumeLayout(False)
        Me.grpUpdEmpPersInfo.PerformLayout()
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmpReg.ResumeLayout(False)
        Me.grpEmpReg.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListingEmployeeTab As System.Windows.Forms.TabPage
    Friend WithEvents grpUpEmpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateStatusEmp As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCustComm As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCustSP As System.Windows.Forms.TextBox
    Friend WithEvents cmdCustLSU As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpIDStatus As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCustFNSU As System.Windows.Forms.TextBox
    Friend WithEvents txtCustLNSU As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchCustStatusU As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSearchEmpSU As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpUEI As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSaveTopUp As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateEmp As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents grpUpdEmpPersInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblCoutCustomer As System.Windows.Forms.Label
    Friend WithEvents grdCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSaveCust As System.Windows.Forms.Button
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
    Friend WithEvents cmdTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblCustOrderHeaer As System.Windows.Forms.Label
    Friend WithEvents pageNavCMB As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
