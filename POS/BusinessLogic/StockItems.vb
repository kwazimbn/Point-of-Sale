Public Class StockItems
    Private _supID As Integer
    Private _ingredientID As Integer
    Private _igredientDesc As String
    Private _quantityIngr As Decimal
    Private _itemUnit As String
    Private _costPrice As Decimal
    Private _reorderThreshold As Integer

    Public Sub New()
        _supID = 0
        _ingredientID = 0
        _igredientDesc = ""
        _quantityIngr = 0
        _itemUnit = ""
        _costPrice = 0
        _reorderThreshold = 0
    End Sub

    Public Property Supplier_ID As Integer
        Get
            Return _supID
        End Get
        Set(value As Integer)
            _supID = value
        End Set
    End Property

    Public Property Item_ID As Integer
        Get
            Return _ingredientID
        End Get
        Set(value As Integer)
            _ingredientID = value
        End Set
    End Property

    Public Property Item_Desc As String
        Get
            Return _igredientDesc
        End Get
        Set(value As String)
            _igredientDesc = value
        End Set
    End Property

    Public Property Item_Qty As Decimal
        Get
            Return _quantityIngr
        End Get
        Set(value As Decimal)
            _quantityIngr = value
        End Set
    End Property

    Public Property Item_Unit As String
        Get
            Return _itemUnit
        End Get
        Set(value As String)
            _itemUnit = value
        End Set
    End Property

    Public Property Item_Price As Decimal
        Get
            Return _costPrice
        End Get
        Set(value As Decimal)
            _costPrice = value
        End Set
    End Property

    Public Property Reorder_Threshold As Integer
        Get
            Return _reorderThreshold
        End Get
        Set(value As Integer)
            _reorderThreshold = value
        End Set
    End Property

    'Saving ingredients into Database
    Public Sub SaveReceivedStock()
        Dim objDal As New csSQLDALVB
        Dim objparlist As New List(Of csParameterListType)
        With objparlist
            .Add(New csParameterListType("@ingredientDescription", SqlDbType.VarChar, Item_Desc))
            .Add(New csParameterListType("@quantity", SqlDbType.Decimal, Item_Qty))
            .Add(New csParameterListType("@unit", SqlDbType.VarChar, Item_Unit))
            .Add(New csParameterListType("@costPrice", SqlDbType.Decimal, Item_Price))
            .Add(New csParameterListType("@reorderThreshHold", SqlDbType.Int, Reorder_Threshold))
            objDal.executespreturnnd("StockReceiving", objparlist)
        End With
    End Sub

    'Searching by Supplier ID for ingredients associated with a Supplier 
    Public Function GetIngredientsBySupplier(ByVal supID As Integer) As List(Of StockItems)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of StockItems)
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@supplierID", SqlDbType.Int, supID))
        Using dr As IDataReader = objDal.executespreturndr("GetIngredientsBySupplier", objParList)
            While (dr.Read)
                Dim objc As New StockItems
                objc.Item_ID = dr.GetInt32(0)
                objc.Item_Desc = dr.GetString(1)
                objc.Item_Unit = dr.GetString(2)
                objc.Item_Price = dr.GetDecimal(3)
                objc.Item_Qty = dr.GetDecimal(4)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Loading list of ingredients inorder to prep for receipe
    Public Function GetIngredients4Recipe() As List(Of StockItems)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of StockItems)
        Using dr As IDataReader = objDal.executespreturndr("GetIngredients4Recipe")
            While (dr.Read)
                Dim objc As New StockItems
                objc.Item_ID = dr.GetInt32(0)
                objc.Item_Desc = dr.GetString(1)
                objc.Item_Unit = dr.GetString(2)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Searching for an ingridient by ingridient Desc.
    Public Function GetIngredientsByDesc4Recipe(ByVal ingDesc As String) As List(Of StockItems)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of StockItems)
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@ingredientDescription", SqlDbType.VarChar, ingDesc))
        Using dr As IDataReader = objDal.executespreturndr("GetIngredientsByDesc4Recipe", objParList)
            While (dr.Read)
                Dim objc As New StockItems
                objc.Item_ID = dr.GetInt32(0)
                objc.Item_Desc = dr.GetString(1)
                objc.Item_Unit = dr.GetString(2)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

End Class
