Public Class csCustomerOrderItem
    Private _itemNumber As Integer
    Private _itemQty As Integer
    Private _itemPrice As Decimal

    Public Sub New()
        _itemNumber = 0
        _itemQty = 0
        _itemPrice = 0.0
    End Sub

    Public Property ItemNo() As Integer
        Get
            Return _itemNumber
        End Get
        Set(value As Integer)
            _itemNumber = value
        End Set
    End Property

    Public Property ItemQty() As Integer
        Get
            Return _itemQty
        End Get
        Set(value As Integer)
            _itemQty = value
        End Set
    End Property

    Public Property ItemPrice() As Decimal
        Get
            Return _itemPrice
        End Get
        Set(value As Decimal)
            _itemPrice = value
        End Set
    End Property

    Public Function CreateNewCustomerOrderItem()
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        With objParList
            .Add(New csParameterListType("@menuItemId", SqlDbType.Int, ItemNo))
            .Add(New csParameterListType("@quantity", SqlDbType.Int, ItemQty))
            .Add(New csParameterListType("@orderItemPrice", SqlDbType.Decimal, ItemPrice))
            objdal.executespreturnnd("InsertOrderItem", objParList)
        End With
        Return objParList
    End Function

End Class
