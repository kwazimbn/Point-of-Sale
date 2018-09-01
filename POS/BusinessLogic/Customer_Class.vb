Public Class Customer_Class
    Private _customer_Id As String
    Private _role_Id As Integer
    Private _role_Desc As String
    Private _name As String
    Private _surname As String
    Private _gender As String
    Private _email As String
    Private _contact_No As String
    Private _balance As Double
    Private _password As String
    Private _signupdate As String
    Private _customer_Status As String
    Private _comment As String

    Public Sub New()
        _customer_Id = ""
        _role_Id = 0
        _name = ""
        _surname = ""
        _gender = ""
        _email = ""
        _contact_No = ""
        _balance = 0.0
        _password = ""
        _signupdate = ""
        _customer_Status = ""
        _comment = ""
    End Sub

    Public Property CustomerId() As String
        Get
            Return _customer_Id
        End Get
        Set(value As String)
            _customer_Id = value
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

    Public Property Balance() As Double
        Get
            Return _balance
        End Get
        Set(value As Double)
            _balance = value
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

    Public Property SignupDate() As String
        Get
            Return _signupdate
        End Get
        Set(value As String)
            _signupdate = value
        End Set
    End Property

    Public Property CustomerStatus() As String
        Get
            Return _customer_Status
        End Get
        Set(value As String)
            _customer_Status = value
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


    Public Sub CreateCustomer()
        'Insert customer information into Database
        Dim objdal As New csSQLDALVB
        Dim objlist As New List(Of csParameterListType)
        With objlist
            .Add(New csParameterListType("@roleId", SqlDbType.Int, RoleId))
            .Add(New csParameterListType("@name", SqlDbType.VarChar, FirstName))
            .Add(New csParameterListType("@surname", SqlDbType.VarChar, LastName))
            .Add(New csParameterListType("@gender", SqlDbType.Char, Gender))
            .Add(New csParameterListType("@email", SqlDbType.VarChar, Email))
            .Add(New csParameterListType("@contactNo", SqlDbType.Char, ContactNo))
            .Add(New csParameterListType("@accountBalance", SqlDbType.Decimal, Balance))
            .Add(New csParameterListType("@passwordHash", SqlDbType.VarChar, Password))
            .Add(New csParameterListType("@signUpDate", SqlDbType.DateTime, SignupDate))
            .Add(New csParameterListType("@customerStatus", SqlDbType.VarChar, CustomerStatus))
            .Add(New csParameterListType("@comment", SqlDbType.VarChar, Comment))
            objdal.executespreturnnd("createCustomer", objlist)
            'objdal.executespreturnnd("Insert_Customer", objlist)
        End With
    End Sub

    'Returning List (all) of customers
    Public Function GetAllCustomer() As List(Of Customer_Class)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of Customer_Class)
        Using dr As IDataReader = objDal.executespreturndr("GetAllCustomers")
            While (dr.Read)
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.Gender = dr.GetString(3)
                objc.Email = dr.GetString(4)
                objc.ContactNo = dr.GetString(5)
                objc.CustomerStatus = dr.GetString(6)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Returning emp for status update
    Public Function GetCustbyID4StatusUpdate(ByVal empId As Integer)
        Dim objDal As New csSQLDALVB
        Dim objparList As New List(Of csParameterListType)
        Dim objList As New List(Of Customer_Class)
        objparList.Add(New csParameterListType("@customerId", SqlDbType.Int, empId))
        Using dr As IDataReader = objDal.executespreturndr("GetCust4StatusUpdate", objparList)
            While (dr.Read())
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.CustomerStatus = dr.GetString(3)
                objc.Comment = dr.GetString(4)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    Public Sub topCustomerAccount(ByVal custId As Integer)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of csParameterListType)
        With objList
            .Add(New csParameterListType("@customerId", SqlDbType.Int, Convert.ToInt32(CustomerId)))
            .Add(New csParameterListType("@accountBalance", SqlDbType.Decimal, Convert.ToDecimal(Balance)))
            objDal.executespreturnnd("topCustomerAccount", objList)
        End With
    End Sub

    'Decrement customer balance after tender
    Public Sub decrementBalance(ByVal id As Integer, ByVal bal As Decimal)
        Dim objDal As New csSQLDALVB
        Dim objCsList As New List(Of csParameterListType)
        With objCsList
            .Add(New csParameterListType("@customerId", SqlDbType.Int, CustomerId))
            .Add(New csParameterListType("@accountBalance", SqlDbType.Decimal, Balance))
            objDal.executespreturnnd("DecrementCustomerBalance", objCsList)
        End With
    End Sub

    'Search customer for topup tender by customer ID 
    Public Function GetCustomerByID(ByVal userId As Integer)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        Dim objClist As New List(Of Customer_Class)
        objParList.Add(New csParameterListType("@customerId", SqlDbType.Int, userId))
        Using dr As IDataReader = objdal.executespreturndr("GetCustTenderByID", objParList)
            While (dr.Read)
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.Balance = dr.GetDecimal(2)
                objc.ContactNo = dr.GetString(3)
                objClist.Add(objc)
            End While
            Return objClist
        End Using
    End Function

    'Search customer for topup tender by customer mobile number 
    Public Function GetCustomerByNumber(ByVal mobNo As String)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        Dim objClist As New List(Of Customer_Class)
        objParList.Add(New csParameterListType("@contactNo", SqlDbType.Char, mobNo))
        Using dr As IDataReader = objdal.executespreturndr("GetCustTenderByMobNO", objParList)
            While (dr.Read)
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.Balance = dr.GetDecimal(2)
                objc.ContactNo = dr.GetString(3)
                objClist.Add(objc)
            End While
            Return objClist
        End Using
    End Function

    'Search customer for topup payment account 
    Public Function GetCustomerByNumberForTopUP(ByVal mobNo As String)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        Dim objClist As New List(Of Customer_Class)
        objParList.Add(New csParameterListType("@contactNo", SqlDbType.Char, mobNo))
        Using dr As IDataReader = objdal.executespreturndr("GetCustForTopUp", objParList)
            While (dr.Read)
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.FirstName = dr.GetString(1)
                objc.LastName = dr.GetString(2)
                objc.Balance = dr.GetDecimal(3)
                objClist.Add(objc)
            End While
            Return objClist
        End Using
    End Function

    'Customer Topup and return customer info for SMS.
    Public Sub customerTopup()
        'Insert customer information into Database
        Dim objdal As New csSQLDALVB
        Dim objlist As New List(Of csParameterListType)
        With objlist
            .Add(New csParameterListType("@customerId", SqlDbType.Int, CustomerId))
            .Add(New csParameterListType("@topupAmount", SqlDbType.Decimal, Balance))
            .Add(New csParameterListType("@topupDate", SqlDbType.DateTime, SignupDate))
            objdal.executespreturnnd("Customer_Topup_Customer", objlist)
        End With
    End Sub

    'Search for customer latest balance
    Public Function GetLatestCustomerTop(ByVal custIdbNo As Integer)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        Dim objClist As New List(Of Customer_Class)
        objParList.Add(New csParameterListType("@customerId", SqlDbType.Char, custIdbNo))
        Using dr As IDataReader = objdal.executespreturndr("GetLatestCustomerTop", objParList)
            While (dr.Read)
                Dim objc As New Customer_Class
                objc.CustomerId = dr.GetInt32(0)
                objc.Balance = dr.GetDecimal(1)
                objClist.Add(objc)
            End While
            Return objClist
        End Using
    End Function


    Public Sub UpdateCustomerStatus(ByVal c As Customer_Class)
        'Update customer information into Database
        Dim objdal As New csSQLDALVB
        Dim objlist As New List(Of csParameterListType)
        With objlist
            .Add(New csParameterListType("@customerId", SqlDbType.Int, CustomerId))
            .Add(New csParameterListType("@customerStatus", SqlDbType.VarChar, CustomerStatus))
            .Add(New csParameterListType("@comment", SqlDbType.VarChar, Comment))
            objdal.executespreturnnd("UpdateCustStatus", objlist)
        End With
    End Sub



End Class
