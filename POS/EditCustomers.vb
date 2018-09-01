Public Class EditCustomers
    Dim objC As New Customer_Class
    Dim objCList As New List(Of Customer_Class)
    Dim DS As New group26DataSet


    Private Sub EditCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        CenterButton()
        pageNavCMB.SelectedIndex = 1
        cmdTitle.SelectedIndex = 0 'customer title
        cmdGender.SelectedIndex = 0 'customer gender
        CustomerGridview() 'Customer Load gridview
        lblCoutCustomer.Text = grdCustomer.RowCount - 1
    End Sub
    Private Sub CenterButton()
        TabControl1.Top = (Me.ClientSize.Height / 2) - (TabControl1.Height / 2)
        TabControl1.Left = (Me.ClientSize.Width / 2) - (TabControl1.Width / 2)
    End Sub

    'Creating Gridview for Menu Items
    Private Sub CustomerGridview()
        Dim cat As Integer = 0
        grdCustomer.ColumnCount = 7 'Defining gridview columns size (number of columns)
        grdCustomer.Columns(0).Name = "Cust_ID"
        grdCustomer.Columns(1).Name = "Name"
        grdCustomer.Columns(2).Name = "Surname"
        grdCustomer.Columns(3).Name = "Gender"
        grdCustomer.Columns(4).Name = "Email"
        grdCustomer.Columns(5).Name = "Contact"
        grdCustomer.Columns(6).Name = "Status"

        grdCustomer.Columns(0).Width = 55
        grdCustomer.Columns(3).Width = 55
        'grdCategoryListItem.Columns(3).Width = 180
        'grdCategoryListItem.Columns(4).Width = 80

        objCList = objC.GetAllCustomer  'Selected combobox search criterea   
        grdCustomer.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        For Each x As Customer_Class In objCList
            grdCustomer.Rows.Add(x.CustomerId, x.FirstName, x.LastName, x.Gender, x.Email, x.ContactNo, x.CustomerStatus) 'Gridview load
        Next
    End Sub

    Private Sub btnSaveCust_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCust.Click
        If txtname.Text = "" Or txtsurname.Text = "" Then
            MessageBox.Show("Fill-in all customer information.")
        Else
            objC.FirstName = txtname.Text
            objC.LastName = txtsurname.Text
            If cmdGender.SelectedIndex = 1 Then
                objC.Gender = "M"
            ElseIf cmdGender.SelectedIndex = 2 Then
                objC.Gender = "F"
            Else
                MessageBox.Show("Please select Gender!")
            End If
            objC.ContactNo = txtNumber.Text
            objC.Email = txtEmail.Text
            objC.RoleId = 1
            objC.SignupDate = CDate(System.DateTime.Now.ToString())
            objC.Password = "12345"
            objC.CustomerStatus = "Active"
            objC.Comment = "None"
            objC.CreateCustomer()
            MessageBox.Show("Succesfully Saved")

            CustomerGridview() 'Reload gridview

            txtname.Clear()
            txtsurname.Clear()
            cmdGender.SelectedIndex = 0
            cmdTitle.SelectedIndex = 0
            txtNumber.Clear()
            txtEmail.Clear()
        End If

    End Sub


    Private Sub btnSearchCustStatusU_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustStatusU.Click
        'searching for customer to Update status 
        Dim objClist As New List(Of Customer_Class)
            If txtSearchEmpSU.Text = "" Then
                MessageBox.Show("The search criteria is empty")
        Else
            Try
                txtSearchEmpSU.Text = CInt(txtSearchEmpSU.Text)
            Catch ex As Exception
                MsgBox("The input is invalid. Make sure the entered customer ID is numeric")
                Exit Sub
            End Try
            objClist = objC.GetCustbyID4StatusUpdate(CInt(txtSearchEmpSU.Text))
            For Each x As Customer_Class In objClist
                lblEmpIDStatus.Text = x.CustomerId
                txtCustFNSU.Text = x.FirstName
                txtCustLNSU.Text = x.LastName
                txtCustSP.Text = x.CustomerStatus
                txtCustComm.Text = x.Comment
            Next
            End If
    End Sub


    Private Sub cmdEmpLSU_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmdCustLSU.SelectedIndexChanged
        If cmdCustLSU.SelectedIndex = 1 Then
            txtCustSP.Text = "Active"
        Else
            txtCustSP.Text = "Blocked"
        End If
    End Sub

    Private Sub btnCustSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnCustSearch.Click
        Dim objClist2 As New List(Of Customer_Class)
        objClist2 = objC.GetCustomerByNumberForTopUP(Trim(txtSearchByMobNo.Text))
        For Each x As Customer_Class In objClist2
            txtCustID.Text = x.CustomerId
            txtCustName.Text = x.FirstName
            txtCustSurname.Text = x.LastName
            txtCurrentBal.Text = x.Balance
        Next

    End Sub

    Private Sub btnSaveTopUp_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveTopUp.Click
        Dim n As String = ""

        objC.CustomerId = CInt(txtCustID.Text)
        objC.SignupDate = CDate(System.DateTime.Now.ToString())
        objC.Balance = CInt(txtTopUpBal.Text)
        objC.customerTopup()

        objC.CustomerId = CInt(txtCustID.Text)
        Label14.Text = objC.Balance
        Label15.Text = objC.ContactNo
        MessageBox.Show("Topup amount of R: " + objC.Balance.ToString() + " has been added")

    End Sub

    Private Sub btnSearchEmpUpdate_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnUpdateStatusEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateStatusEmp.Click
        Dim objDSTA As New group26DataSetTableAdapters.UpdateCustStatusTableAdapter
        objDSTA.Fill(DS.UpdateCustStatus, CInt(lblEmpIDStatus.Text), txtCustSP.Text, txtCustComm.Text)
        objDSTA.Update(DS)

        'objC.CustomerId = CInt(lblEmpIDStatus.Text)
        'objC.CustomerStatus = txtCustSP.Text
        'objC.Comment = txtCustComm.Text
        'objC.UpdateCustomerStatus(objC)

        MessageBox.Show("Updated Succesfully")

        txtCustID.Clear()
        lblCoutCustomer.Text = ""
        cmdCustLSU.SelectedIndex = 0
        txtCustComm.Clear()
        txtCustFNSU.Clear()
        txtCustLNSU.Clear()
        txtCustSP.Clear()
        txtCustComm.Clear()
    End Sub

    Private Sub grpUpEmpStatus_Enter(sender As System.Object, e As System.EventArgs) Handles grpUpEmpStatus.Enter

    End Sub


    Private Sub grpUpdEmpPersInfo_Enter(sender As System.Object, e As System.EventArgs) Handles grpUpdEmpPersInfo.Enter
        CustomerGridview()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If pageNavCMB.SelectedIndex = 0 Then
            AddEmployee.Show()
            Me.Hide()

        ElseIf pageNavCMB.SelectedIndex = 1 Then
            InvetoryDetails.Show()
            Me.Hide()
        ElseIf pageNavCMB.SelectedIndex = 2 Then
            AddNewMenuItem.Show()
            Me.Hide()
        Else
            LoginVcity.Show()
            Me.Hide()
        End If
    End Sub
End Class