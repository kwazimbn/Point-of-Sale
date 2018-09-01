Public Class EditEmployees
    Dim objc As New EmployeeClass
    Private Sub EditEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        gdrViewEmp.DataSource = objc.GetAllEmployee
        gdrViewEmp.Columns(0).Visible = False
        gdrViewEmp.Columns(1).Visible = False
        gdrViewEmp.Columns(4).Visible = False
        gdrViewEmp.Columns(7).Visible = False
        gdrViewEmp.Columns(8).Visible = False
    End Sub
End Class