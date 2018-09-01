Public Class csSupplier

    Private _supplierID As Integer
    Private _sname As String
    Private _scontactNo As String
    Private _smobNo As String
    Private _semail As String

    Public Sub New()
        _supplierID = 0
        _sname = ""
        _scontactNo = ""
        _smobNo = ""
        _semail = ""
    End Sub

    Public Property SupplierID() As Integer
        Get
            Return _supplierID
        End Get
        Set(value As Integer)
            _supplierID = value
        End Set
    End Property

    Public Property SupplierName() As String
        Get
            Return _sname
        End Get
        Set(value As String)
            _sname = value
        End Set
    End Property

    Public Property Landline() As String
        Get
            Return _scontactNo
        End Get
        Set(value As String)
            _scontactNo = value
        End Set
    End Property

    Public Property MobileNo() As String
        Get
            Return _smobNo
        End Get
        Set(value As String)
            _smobNo = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _semail
        End Get
        Set(value As String)
            _semail = value
        End Set
    End Property

    'Get list of Suppliers
    Public Function GetSupplierList() As List(Of csSupplier)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of csSupplier)
        Using dr As IDataReader = objDal.executespreturndr("GetListOfSuppliers")
            While (dr.Read)
                Dim par As New csSupplier
                par.SupplierID = dr.GetInt32(0)
                par.SupplierName = dr.GetString(1)
                objList.Add(par)
            End While
        End Using
        Return objList
    End Function

End Class
