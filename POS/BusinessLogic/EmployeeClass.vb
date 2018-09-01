Public Class EmployeeClass

    Private _employeeId As Integer
    Private _role_Id As Integer
    Private _role_Desc As String
    Private _name As String
    Private _surname As String
    Private _gender As String
    Private _email As String
    Private _contact_No As String
    Private _start_date As String
    Private _password As String
    Private _employeestatus As String
    Private _comment As String

    Public Sub New()
        _employeeId = 0
        _role_Id = 0
        _role_Desc = ""
        _name = ""
        _surname = ""
        _gender = ""
        _email = ""
        _contact_No = ""
        _start_date = ""
        _password = ""
        _employeestatus = ""
        _comment = ""
    End Sub

    Public Property EmployeeId() As Integer
        Get
            Return _employeeId

        End Get
        Set(value As Integer)
            _employeeId = value
        End Set
    End Property

    Public Property RoleId() As Integer
        Get
            Return _role_Id
        End Get
        Set(value As Integer)
            _role_Id = value
        End Set
    End Property

    Public Property RoleDesc() As String
        Get
            Return _role_Desc
        End Get
        Set(value As String)
            _role_Desc = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property ContactNo() As String
        Get
            Return _contact_No
        End Get
        Set(value As String)
            _contact_No = value
        End Set
    End Property

    Public Property StartDate() As String
        Get
            Return _start_date
        End Get
        Set(value As String)
            _start_date = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property EmployeeStatus() As String
        Get
            Return _employeestatus
        End Get
        Set(value As String)
            _employeestatus = value
        End Set
    End Property

    Public Property Comment() As String
        Get
            Return _comment
        End Get
        Set(value As String)
            _comment = value
        End Set
    End Property

    Public Sub CreateEmployee()
        'Insert customer information into Database
        Dim objdal As New csSQLDALVB
        Dim objlist As New List(Of csParameterListType)
        With objlist
            .Add(New csParameterListType("@roleId", SqlDbType.Int, RoleId))
            .Add(New csParameterListType("@name", SqlDbType.VarChar, FirstName))
            .Add(New csParameterListType("@surname", SqlDbType.VarChar, LastName))
            .Add(New csParameterListType("@gender", SqlDbType.VarChar, Gender))
            .Add(New csParameterListType("@email", SqlDbType.VarChar, Email))
            .Add(New csParameterListType("@contactNo", SqlDbType.VarChar, ContactNo))
            .Add(New csParameterListType("@startDate", SqlDbType.DateTime, StartDate))
            .Add(New csParameterListType("@passwordHash", SqlDbType.VarChar, Password))
            .Add(New csParameterListType("@employeeStatus", SqlDbType.VarChar, EmployeeStatus))
            .Add(New csParameterListType("@comment", SqlDbType.VarChar, Comment))
            objdal.executespreturnnd("createEmployee", objlist)
            'objdal.executespreturnnd("Insert_Customer", objlist)
        End With
    End Sub

    Public Function UserLogin(ByVal username As String, ByVal password As String)
        Dim objdal As New csSQLDALVB
        Dim objList As New List(Of EmployeeClass)
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@email", SqlDbType.VarChar, Email))
        objParList.Add(New csParameterListType("@password", SqlDbType.VarChar, password))
        Using dr As IDataReader = objdal.executespreturndr("Userlogin", objParList)
            While (dr.Read)
                Dim objc As New EmployeeClass
                objc.Email = dr.GetString(0)
                objc.Password = dr.GetString(1)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Returning List (all) of employees
    Public Function GetAllEmployee() As List(Of EmployeeClass)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of EmployeeClass)
        Using dr As IDataReader = objDal.executespreturndr("GetAllEmployees")
            While (dr.Read)
                Dim objc As New EmployeeClass
                objc.EmployeeId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.Gender = dr.GetString(3)
                objc.Email = dr.GetString(4)
                objc.ContactNo = dr.GetString(5)
                objc.RoleDesc = dr.GetString(6)
                objc.EmployeeStatus = dr.GetString(7)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Returning emp for personal info to updated
    Public Function GetEmpbyID4Update(ByVal empId As Integer)
        Dim objDal As New csSQLDALVB
        Dim objparList As New List(Of csParameterListType)
        Dim objList As New List(Of EmployeeClass)
        objparList.Add(New csParameterListType("@employeeId", SqlDbType.Int, empId))
        Using dr As IDataReader = objDal.executespreturndr("SearchForEmp4Update", objparList)
            While (dr.Read())
                Dim objc As New EmployeeClass
                objc.EmployeeId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.Gender = dr.GetString(3)
                objc.ContactNo = dr.GetString(4)
                objc.Email = dr.GetString(5)
                objc.RoleDesc = dr.GetString(6)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    Public Sub UpdateEmpPersInfo()
        Dim objDal As New csSQLDALVB
        Dim objparList As New List(Of csParameterListType)
        With objparList
            .Add(New csParameterListType("@employeeId", SqlDbType.Int, EmployeeId))
            .Add(New csParameterListType("@name", SqlDbType.VarChar, FirstName))
            .Add(New csParameterListType("@surname", SqlDbType.VarChar, LastName))
            .Add(New csParameterListType("@gender", SqlDbType.VarChar, Gender))
            .Add(New csParameterListType("@contactNo", SqlDbType.VarChar, ContactNo))
            .Add(New csParameterListType("@email", SqlDbType.VarChar, Email))
            .Add(New csParameterListType("@roleId", SqlDbType.Int, RoleId))
            objDal.executespreturnnd("UpdateSEmpPerInfo", objparList)
        End With
    End Sub

    'Returning emp for status update
    Public Function GetEmpbyID4StatusUpdate(ByVal empId As Integer)
        Dim objDal As New csSQLDALVB
        Dim objparList As New List(Of csParameterListType)
        Dim objList As New List(Of EmployeeClass)
        objparList.Add(New csParameterListType("@employeeId", SqlDbType.Int, empId))
        Using dr As IDataReader = objDal.executespreturndr("GetEmp4StatusUpdate", objparList)
            While (dr.Read())
                Dim objc As New EmployeeClass
                objc.EmployeeId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.RoleId = dr.GetInt32(3)
                objc.EmployeeStatus = dr.GetString(4)
                objc.Comment = dr.GetString(5)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    Public Sub UpdateEmpStatus()
        Dim objDal As New csSQLDALVB
        Dim objparList As New List(Of csParameterListType)
        With objparList
            .Add(New csParameterListType("@employeeId", SqlDbType.Int, EmployeeId))
            .Add(New csParameterListType("@employeeStatus", SqlDbType.VarChar, EmployeeStatus))
            .Add(New csParameterListType("@comment", SqlDbType.VarChar, Comment))
            objDal.executespreturnnd("UpdateEmpStatus", objparList)
        End With
    End Sub
End Class