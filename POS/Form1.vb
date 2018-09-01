
Public Class Form1
    Public Sub FormSetUp(ByVal ChildForm As Form)
        Try
            If Not (ChildForm.Equals(Me.ActiveMdiChild)) Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SalesReport.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        SalesReport.WindowState = FormWindowState.Maximized
        Me.TopMost = True


        LoginVcity.TopMost = True

        FormSetUp(LoginVcity)
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tlsAddnewemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormSetUp(AddEmployee)
    End Sub

    Private Sub tlsEditemployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As System.Object, e As System.EventArgs)
        FormSetUp(PlaceNewOrder)
    End Sub

    Private Sub tlsLogout_Click(sender As System.Object, e As System.EventArgs) Handles tlsLogout.Click
        FormSetUp(LoginVcity)
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        FormSetUp(AddEmployee)
    End Sub

    Private Sub IngredientsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PlaceOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlaceOrderToolStripMenuItem.Click
        FormSetUp(PlaceNewOrder)
    End Sub

    Private Sub CompleteOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompleteOrderToolStripMenuItem.Click
        FormSetUp(CompleteOrder)
    End Sub

    Private Sub tlsEditMenus_Click(sender As System.Object, e As System.EventArgs) Handles tlsEditMenus.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        FormSetUp(EditCustomers)
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem8.Click
        
    End Sub
End Class
