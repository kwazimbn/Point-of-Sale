Public Class AddEmployee
    Dim objC As New EmployeeClass
    Dim objCList As New List(Of EmployeeClass)
    Dim DS As New group26DataSet
    Dim sms As New SMSNotification

    Private Sub AddEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        CenterButton()
        pageNavCMB.SelectedIndex = 0

        cmdTitle.SelectedIndex = 0
        cmdGender.SelectedIndex = 0
        cmdRole.SelectedIndex = 0
        cmdEmpLSU.SelectedIndex = 0

        EmployeesGridview() 'Load employee list

    End Sub
    Private Sub CenterButton()
        TbIngredients.Top = (Me.ClientSize.Height / 2) - (TbIngredients.Height / 2)
        TbIngredients.Left = (Me.ClientSize.Width / 2) - (TbIngredients.Width / 2)
    End Sub

    'Creating Gridview for Menu Items
    Private Sub EmployeesGridview()
        Dim cat As Integer = 0
        grdEmployee.ColumnCount = 8 'Defining gridview columns size (number of columns)
        grdEmployee.Columns(0).Name = "Emp_ID"
        grdEmployee.Columns(1).Name = "Name"
        grdEmployee.Columns(2).Name = "Surname"
        grdEmployee.Columns(3).Name = "Gender"
        grdEmployee.Columns(4).Name = "Email"
        grdEmployee.Columns(5).Name = "Contact"
        grdEmployee.Columns(6).Name = "Role"
        grdEmployee.Columns(7).Name = "Status"

        grdEmployee.Columns(0).Width = 55
        grdEmployee.Columns(3).Width = 55
        'grdCategoryListItem.Columns(3).Width = 180
        'grdCategoryListItem.Columns(4).Width = 80

        objCList = objC.GetAllEmployee() 'Selected combobox search criterea   
        grdEmployee.Rows.Clear() 'Clearing gridview before loading new data, to avoid appending the information
        For Each x As EmployeeClass In objCList
            grdEmployee.Rows.Add(x.EmployeeId, x.FirstName, x.LastName, x.Gender, x.Email, x.ContactNo, x.RoleDesc, x.EmployeeStatus) 'Gridview load
        Next
    End Sub

    Private Sub btnSearchEmpUpdate_Click(sender As System.Object, e As System.EventArgs)

        'Dim objClist As New List(Of EmployeeClass)
        'If txtSearchEmpUpdate.Text = "" Then
        '    MessageBox.Show("The search criteria is empty")
        'Else
        '    objClist = objC.GetEmpbyID4Update(CInt(txtSearchEmpUpdate.Text))
        '    For Each x As EmployeeClass In objClist

        '        'lblEmpId.Text = x.EmployeeId
        '        'txtFNEmpUp.Text = x.FirstName
        '        'txtLNEmpUp.Text = x.LastName
        '        'txtGenEmUp.Text = x.Gender
        '        'txtMobEmpUp.Text = x.ContactNo
        '        'txtEmailEmpUp.Text = x.Email
        '        'txtRoleEmpUp.Text = x.EmployeeStatus
        '    Next
        'End If

    End Sub

    Private Sub btnUpdateEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateEmp.Click

        'objC.EmployeeId = CInt(lblEmpId.Text)
        'objC.FirstName = txtFNEmpUp.Text
        'objC.LastName = txtLNEmpUp.Text
        'objC.Gender = txtGenEmUp.Text
        'objC.Email = txtEmailEmpUp.Text
        'objC.ContactNo = txtMobEmpUp.Text
        'objC.RoleId = CInt(txtRoleEmpUp.Text)
        'objC.UpdateEmpPersInfo()
        'lblmsgupdate.Text = "Emp info updated succesfully"
        ''Clear the input fields
        'lblEmpId.Text = ""
        'txtFNEmpUp.Clear()
        'txtLNEmpUp.Clear()
        'txtGenEmUp.Clear()
        'txtEmailEmpUp.Clear()
        'txtMobEmpUp.Clear()
        'txtRoleEmpUp.Clear()
        'cmdGenEmUp.SelectedIndex = 0
        'cmdRoleEmpUp.SelectedIndex = 0

    End Sub

    Private Sub cmdGenEmUp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

        'If cmdGenEmUp.SelectedIndex = 1 Then
        '    txtGenEmUp.Text = "M"
        'ElseIf cmdGenEmUp.SelectedIndex = 2 Then
        '    txtGenEmUp.Text = "F"
        'End If

    End Sub

    Private Sub cmdRoleEmpUp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'If cmdRoleEmpUp.SelectedIndex = 1 Then
        '    txtRoleEmpUp.Text = 1
        'ElseIf cmdRoleEmpUp.SelectedIndex = 2 Then
        '    txtRoleEmpUp.Text = 2
        'ElseIf cmdRoleEmpUp.SelectedIndex = 3 Then
        '    txtRoleEmpUp.Text = 3
        'ElseIf cmdRoleEmpUp.SelectedIndex = 4 Then
        '    txtRoleEmpUp.Text = 4
        'ElseIf cmdRoleEmpUp.SelectedIndex = 5 Then
        '    txtRoleEmpUp.Text = 5
        'End If
    End Sub

    Private Sub btnSearchEmpStatusU_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchEmpStatusU.Click
        Dim objClist As New List(Of EmployeeClass)
        If txtSearchEmpSU.Text = "" Then
            MessageBox.Show("The search criteria is empty")
        Else
            Try
                txtSearchEmpSU.Text = CInt(txtSearchEmpSU.Text)
            Catch ex As Exception
                MsgBox("The input is invalid. Make sure the entered employee ID is numeric")
                Exit Sub
            End Try
            objClist = objC.GetEmpbyID4StatusUpdate(CInt(txtSearchEmpSU.Text))
            For Each x As EmployeeClass In objClist

                lblEmpIDStatus.Text = x.EmployeeId
                txtEmpFNSU.Text = x.FirstName
                lblEmpRoleIDStatus.Text = x.RoleId
                If x.RoleId = 2 Then
                    txtEmpRSU.Text = "Kitchen Staff"
                ElseIf x.RoleId = 3 Then
                    txtEmpRSU.Text = "Cashier"
                ElseIf x.RoleId = 4 Then
                    txtEmpRSU.Text = "Supervisor"
                ElseIf x.RoleId = 5 Then
                    txtEmpRSU.Text = "StoreManager"
                End If
                txtEmpLNSU.Text = x.LastName
                txtEmpSP.Text = x.EmployeeStatus
                txtEmpSComm.Text = x.Comment
            Next
        End If
    End Sub

    Private Sub cmdEmpLSU_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmdEmpLSU.SelectedIndexChanged
        If cmdEmpLSU.SelectedIndex = 1 Then
            txtEmpSP.Text = "Active"
        Else
            txtEmpSP.Text = "Blocked"
        End If
    End Sub

    Private Sub btnSaveEmp_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSaveEmp.Click
        objC.FirstName = txtname.Text
        objC.LastName = txtsurname.Text
        If cmdGender.SelectedIndex = 1 Then
            objC.Gender = "M"
        ElseIf cmdGender.SelectedIndex = 2 Then
            objC.Gender = "F"
        Else
            MessageBox.Show("Please select Gender! ")
        End If
        objC.ContactNo = txtNumber.Text
        objC.Email = txtEmail.Text
        objC.RoleId = cmdRole.SelectedIndex
        objC.StartDate = CDate(System.DateTime.Now.ToString())
        objC.Password = "12345"
        objC.EmployeeStatus = "Active"
        objC.Comment = "None"
        objC.CreateEmployee()
        MessageBox.Show("Succesfully Saved")
        EmployeesGridview() 'Reload gridview
        txtname.Clear()
        txtsurname.Clear()
        cmdGender.SelectedIndex = 0
        cmdRole.SelectedIndex = 0
        cmdTitle.SelectedIndex = 0
        txtNumber.Clear()
        txtEmail.Clear()

    End Sub

    Private Sub btnUpdateStatusEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateStatusEmp.Click

        objC.EmployeeId = CInt(lblEmpIDStatus.Text)
        objC.EmployeeStatus = txtEmpSP.Text
        objC.Comment = txtEmpSComm.Text
        objC.UpdateEmpStatus()
        MessageBox.Show("Updated Succesfully")
        txtSearchEmpSU.Clear()
        lblEmpIDStatus.Text = ""
        cmdEmpLSU.SelectedIndex = 0
        txtEmpFNSU.Clear()
        txtEmpLNSU.Clear()
        txtEmpRSU.Clear()
        txtEmpSP.Clear()
        txtEmpSComm.Clear()

    End Sub

    Private Sub radUpdateEmpPerInfo_CheckedChanged(sender As System.Object, e As System.EventArgs)
        grpEmpReg.Enabled = False
        grpUpdEmpPersInfo.Enabled = True
    End Sub

    Private Sub radEmpreg_CheckedChanged(sender As System.Object, e As System.EventArgs)
        grpEmpReg.Enabled = True
        grpUpdEmpPersInfo.Enabled = False
    End Sub

    Private Sub radUpdEmpStatus_CheckedChanged(sender As System.Object, e As System.EventArgs)
        'grpEmpPassRest.Enabled = False
        'grpEmpPassRest.Enabled = True
    End Sub

    Private Sub radResetEmpPass_CheckedChanged(sender As System.Object, e As System.EventArgs)
        'grpEmpPassRest.Enabled = True
        'grpEmpPassRest.Enabled = False
    End Sub

  
    
    Private Sub grpUpdEmpPersInfo_Enter(sender As System.Object, e As System.EventArgs) Handles grpUpdEmpPersInfo.Enter
        EmployeesGridview()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If pageNavCMB.SelectedIndex = 0 Then
            EditCustomers.Show()
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

    Private Sub pageNavCMB_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles pageNavCMB.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim objDSTA As New group26DataSetTableAdapters.W_GetEmpForPassResetTableAdapter()
        objDSTA.Fill(DS.W_GetEmpForPassReset, CInt(txtsearchID.Text))
        objDSTA.Update(DS)

        lblID.Text = DS.W_GetEmpForPassReset.Rows(0).Item("employeeId")
        txtEname.Text = DS.W_GetEmpForPassReset.Rows(0).Item("name")
        txtcontact.Text = DS.W_GetEmpForPassReset.Rows(0).Item("contactNo")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim MyString As String = Nothing
        Dim message As String = Nothing
        Dim number As String = Nothing
        Dim TxUsername As String = Nothing
        Dim TxPassword As String = Nothing

        Dim objDSTA As New group26DataSetTableAdapters.W_UpdateEmpPassTableAdapter
        Dim newPass As String = ((txtEname.Text.Substring(0, 4)) + "" + (txtcontact.Text.Substring(3, 5)))
        objDSTA.Fill(DS.W_UpdateEmpPass, CInt(lblID.Text), newPass)
        objDSTA.Update(DS)

        message = ("Dear user, your new password is " + newPass)
        TxUsername = "lndignity074@gmail.com"
        TxPassword = "fqjstisq"
        number = txtcontact.Text
        MyString = "http://www.winsms.net/api/batchmessage.asp?User="
        MyString = (MyString _
                    + (TxUsername + ("&Password=" _
                    + (TxPassword + "&Delivery=No"))))
        MyString = (MyString + ("&Message=" _
                    + (message + ("&Numbers=" _
                    + (number + ";")))))
        sms.sendNotification(MyString) 'Sennding sms notification

        MessageBox.Show("Password reset was succesful and Its sent to " + txtEname.Text + " on " + (txtcontact.Text))

        lblID.Text = ""
        txtEname.Clear()
        txtcontact.Clear()


    End Sub
End Class
