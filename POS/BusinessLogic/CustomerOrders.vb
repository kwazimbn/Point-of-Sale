Imports System.Data

Public Class CustomerOrders

    Private _orderId As Integer
    Private _CustomerId As Integer
    Private _EmployeeId As Integer
    Private _OrderTotal As Decimal
    Private _OrderTender As Decimal
    Private _PaymentMethod As String
    Private _PaymentStatus As String
    Private _OrderStatus As String
    Private _OrderDate As String

    Public Sub New()
        _orderId = 0
        _CustomerId = 0
        _EmployeeId = 0
        _OrderTotal = 0.0
        _OrderTender = 0.0
        _PaymentMethod = ""
        _PaymentStatus = ""
        _OrderStatus = ""
        _OrderDate = ""
    End Sub

    Public Property OrderId() As Integer
        Get
            Return _orderId
        End Get
        Set(value As Integer)
            _orderId = value
        End Set
    End Property

    Public Property CustomerId() As Integer
        Get
            Return _CustomerId
        End Get
        Set(value As Integer)
            _CustomerId = value
        End Set
    End Property

    Public Property EmployeeId() As Integer
        Get
            Return _EmployeeId
        End Get
        Set(value As Integer)
            _EmployeeId = value
        End Set
    End Property

    Public Property OrderTotal() As Decimal
        Get
            Return _OrderTotal
        End Get
        Set(value As Decimal)
            _OrderTotal = value
        End Set
    End Property

    Public Property OrderTender() As Decimal
        Get
            Return _OrderTender
        End Get
        Set(value As Decimal)
            _OrderTender = value
        End Set
    End Property

    Public Property PaymentMethod() As String
        Get
            Return _PaymentMethod
        End Get
        Set(value As String)
            _PaymentMethod = value
        End Set
    End Property

    Public Property PaymentStatus() As String
        Get
            Return _PaymentStatus
        End Get
        Set(value As String)
            _PaymentStatus = value
        End Set
    End Property

    Public Property OrderStatus() As String
        Get
            Return _OrderStatus
        End Get
        Set(value As String)
            _OrderStatus = value
        End Set
    End Property

    Public Property OrderDate() As String
        Get
            Return _OrderDate
        End Get
        Set(value As String)
            _OrderDate = value
        End Set
    End Property

    Public Function CreateNewCustomerOrder(ByVal objc As CustomerOrders)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        With objParList
            .Add(New csParameterListType("@customerid", SqlDbType.Int, objc.CustomerId))
            .Add(New csParameterListType("@employeeId", SqlDbType.Int, objc.EmployeeId))
            .Add(New csParameterListType("@orderTotal", SqlDbType.Decimal, objc.OrderTotal))
            .Add(New csParameterListType("@orderTenderAmount", SqlDbType.Decimal, objc.OrderTender))
            .Add(New csParameterListType("@paymentMethod", SqlDbType.Char, objc.PaymentMethod))
            .Add(New csParameterListType("@paymentStatus", SqlDbType.Char, objc.PaymentStatus))
            .Add(New csParameterListType("@orderstatus", SqlDbType.Char, objc.OrderStatus))
            .Add(New csParameterListType("@orderDateTime", SqlDbType.DateTime, objc.OrderDate))
            .Add(New csParameterListType("@orderType", SqlDbType.Int, 0))
            objdal.executespreturnnd("createCustomerOrder", objParList)
        End With
        Return objParList
    End Function

    'Getting orders by order status
    Public Function GetKitchenByOrderStatus(ByVal status As String) As List(Of CustomerOrders)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of CustomerOrders)
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@orderstatus", SqlDbType.VarChar, status))
        Using dr As IDataReader = objDal.executespreturndr("GetKitchenByOrderStatus", objParList)
            Try
                While (dr.Read)
                    Dim objc As New CustomerOrders
                    Dim ordertime = ""
                    Dim time = ""
                    objc.OrderId = dr.GetInt32(0)
                    ordertime = dr.GetDateTime(1) 'substring time for order
                    time = dr.GetDateTime(1)
                    objc.OrderDate = (ordertime.Substring(0, 16)).ToString  'assigning sunstringed value
                    objList.Add(objc)
                End While
            Catch ex As Exception

            End Try
            Return objList
        End Using
    End Function

    Public Function getAllOrders() As List(Of CustomerOrders)

        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of CustomerOrders)
        Using dr As IDataReader = objDal.executespreturndr("GetAllMenuItems")
            While (dr.Read)
                Dim objc As New CustomerOrders
                ''  populate_Data(dr, par)

                '    par.a = dr.GetInt32(0)
                '    par.b = dr.GetInt32(1)
                '    par.c = dr.GetString(2)
                '    par.d = dr.GetDecimal(3)
                objList.Add(objc)
            End While
        End Using
        Return objList
    End Function

    'Get Last order id for receipt
    Public Function getOrderID()
        Dim objDal As New csSQLDALVB
        Dim ID As Integer = 0
        Using dr As IDataReader = objDal.executespreturndr("W_P_MaxOrderID")
            While (dr.Read)
                Dim objc As New CustomerOrders
                objc.OrderId = dr.GetInt32(0)
                ID = objc.OrderId
            End While
        End Using
        Return ID
    End Function

    Public Function CloseCompleteCustomerOrder(ByVal id As Integer)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        With objParList
            .Add(New csParameterListType("@orderId", SqlDbType.Int, id))
            objdal.executespreturnnd("CloseCustomerOrder", objParList)
        End With
        Return objParList
    End Function
End Class
