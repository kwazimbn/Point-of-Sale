Public Class LoginVcity

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet.Employee' table. You can move, or remove it, as needed.
        ' Me.EmployeeTableAdapter.Fill(Me.Group26DataSet.Employee)
        'Controlling the size of the screen
        Me.WindowState = FormWindowState.Maximized
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        CenterButton()

    End Sub
    Private Sub CenterButton()
        loginPnl.Top = (Me.ClientSize.Height / 2) - (loginPnl.Height / 2)
        loginPnl.Left = (Me.ClientSize.Width / 2) - (loginPnl.Width / 2)
    End Sub
    
    Public Sub CreateMyPasswordTextBox()
        ' Create an instance of the TextBox control.
        Dim textBox1 As New TextBox()
        ' Set the maximum length of text in the control to eight.
        textBox1.MaxLength = 8
        ' Assign the asterisk to be the password character.
        textBox1.PasswordChar = "*"c
        ' Change all text entered to be lowercase.
        textBox1.CharacterCasing = CharacterCasing.Lower
        ' Align the text in the center of the TextBox control.
        textBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpassword.TextChanged
        CreateMyPasswordTextBox()

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Btn5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Login.Click
        'Dim objc As New EmployeeClass
        'Dim username As String
        'Dim password As String
        'username = txtUserName.Text
        'password = txtpassword.Text

        'Dim session As Integer = objc.UserLogin(username, password)
        'If (session > 2) Then
        '    lbl.Text = session
        'End If

        Try

            EmployeeTableAdapter.FillBy(Group26DataSet.Employee, txtUserName.Text, txtpassword.Text)
            If Group26DataSet.Employee.Rows.Count > 0 Then
                'MsgBox("you are logged is as " & Group26DataSet.Employee.Rows(0).Item(2))
                If (Group26DataSet.Employee.Rows(0).Item(1) = 2) Or (Group26DataSet.Employee.Rows(0).Item(1) = 3) Then
                    PlaceNewOrder.Show()
                    MsgBox("General Employee logged in as:" + vbNewLine + Group26DataSet.Employee.Rows(0).Item(2).ToString + " " + Group26DataSet.Employee.Rows(0).Item(3).ToString)
                    txtpassword.Clear()
                    txtUserName.Clear()
                    Me.Hide()
                ElseIf Group26DataSet.Employee.Rows(0).Item(1) = 5 Or (Group26DataSet.Employee.Rows(0).Item(1) = 4) Then
                    AddEmployee.Show()
                    MsgBox("Admin logged in as:" + vbNewLine + Group26DataSet.Employee.Rows(0).Item(2).ToString + " " + Group26DataSet.Employee.Rows(0).Item(3).ToString)
                    txtpassword.Clear()
                    txtUserName.Clear()
                    Me.Hide()
                End If
            Else
                MsgBox("Check your credentials and try again")

            End If
        Catch ex As Exception

        End Try

        
    End Sub
End Class
