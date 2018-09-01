Public Class SaleSet
    Dim desc As String
    Dim sPrice As Decimal
    Dim ingrId As Integer
    Dim ingrDesc As String
    Dim mproportion As Decimal

    Public Sub New()
        desc = ""
        sPrice = 0.0
        ingrId = 0
        ingrDesc = ""
        mproportion = 0.0
    End Sub

    Public Property MenuDescription As String
        Get
            Return desc
        End Get
        Set(value As String)
            desc = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return sPrice
        End Get
        Set(value As Decimal)
            sPrice = value
        End Set
    End Property

    Public Property _ingrId() As Integer
        Get
            Return ingrId
        End Get
        Set(value As Integer)
            ingrId = value
        End Set
    End Property

    Public Property _ingrDesc As String
        Get
            Return ingrDesc
        End Get
        Set(value As String)
            ingrDesc = value
        End Set
    End Property

    Public Property Proportion As Decimal
        Get
            Return mproportion
        End Get
        Set(value As Decimal)
            mproportion = value
        End Set
    End Property

    Public Sub decrement_Inventory(ByVal id As Integer, ByVal prop As Decimal)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of csParameterListType)
        With objList
            .Add(New csParameterListType("@ingredientId", SqlDbType.Int, Convert.ToInt32(_ingrId)))
            .Add(New csParameterListType("@proportion", SqlDbType.Decimal, Convert.ToDecimal(Proportion)))
            objDal.executespreturnnd("decrement_Inventory", objList)
        End With
    End Sub

    Public Function getAnOrder() As List(Of SaleSet)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of SaleSet)
        Using dr As IDataReader = objDal.executespreturndr("GetBurger")
            While (dr.Read)
                Dim objc As New SaleSet
                populate_Data(dr, objc)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    Public Sub populate_Data(ByVal dr As IDataReader, ByVal objc As SaleSet)
        objc.MenuDescription = dr.GetString(0)
        objc.Price = dr.GetDecimal(1)
        objc._ingrId = dr.GetInt32(2)
        objc._ingrDesc = dr.GetString(3)
        objc.Proportion = dr.GetDecimal(4)
    End Sub

    Public Function GetIngredientsDecrementDriver(ByVal desc As String, ByVal pric As Decimal)
        Dim objdal As New csSQLDALVB
        Dim objList As New List(Of MenuItemsC)
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@menuItemDescription", SqlDbType.VarChar, desc))
        objParList.Add(New csParameterListType("@sellingPrice", SqlDbType.Decimal, pric))
        Using dr As IDataReader = objdal.executespreturndr("GetIngredientsDecrementDriver", objParList)
            While (dr.Read)
                Dim objc As New MenuItemsC
                'populate_data_GetIngredientsDecrementDriver(dr, objc)
                objc.MenuDescription = dr.GetInt32(0)
                objc.Price = dr.GetDecimal(1)
                objList.Add(objc)
            End While
            Return objList
        End Using
    End Function

    'Public Sub populate_data_GetIngredientsDecrementDriver(ByVal dr As IDataReader, ByVal objc As MenuItemsC)
    '    objc.MenuDescription = dr.GetInt32(0)
    '    objc.Price = dr.GetDecimal(1)
    'End Sub
End Class
