Public Class MenuItemsC
    Private mcategoryId As Integer
    Private menuDesc As String
    Private mprice As Decimal
    Private oqty As Integer

    Public Sub New()
        mcategoryId = 0
        menuDesc = ""
        mprice = 0.0
        oqty = 0
    End Sub

    Public Property ItemID() As Integer
        Get
            Return mcategoryId
        End Get
        Set(value As Integer)
            mcategoryId = value
        End Set
    End Property

    Public Property MenuDescription() As String
        Get
            Return menuDesc
        End Get
        Set(value As String)
            menuDesc = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return mprice
        End Get
        Set(value As Decimal)
            mprice = value
        End Set
    End Property

    Public Property OrderQty() As Integer
        Get
            Return oqty
        End Get
        Set(value As Integer)
            oqty = value
        End Set
    End Property

    'Insert into menu item table
    Public Function SaveMenuItem()
        Dim objDal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        With objParList
            .Add(New csParameterListType("@categoryID", SqlDbType.Int, ItemID))
            .Add(New csParameterListType("@menudesc", SqlDbType.Char, MenuDescription))
            .Add(New csParameterListType("@sellingPrice", SqlDbType.Money, Price))
            objDal.executespreturnnd("CreateMenuItem", objParList)
        End With
        Return objParList
    End Function

    Public Function getMenuItem(ByVal categoryId As Integer)
        Dim objCList As New List(Of MenuItemsC)
        Dim objDal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)

        objParList.Add(New csParameterListType("@categoryId", SqlDbType.Int, categoryId))
        Using dr As IDataReader = objDal.executespreturndr("GetMenuitemsWithGetegory", objParList)
            Try
                While (dr.Read)
                    Dim objc As New MenuItemsC
                    objc.ItemID = dr.GetInt32(0)
                    objc.MenuDescription = dr.GetString(1)
                    objc.Price = Convert.ToDecimal(dr.GetDecimal(2))
                    objCList.Add(objc)
                End While
            Catch ex As Exception
            End Try
            Return objCList
        End Using
    End Function

    Public Function getOrderMenuItem(ByVal orderId As Integer)
        Dim objCList As New List(Of MenuItemsC)
        Dim objDal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)

        objParList.Add(New csParameterListType("@orderId", SqlDbType.Int, orderId))
        Using dr As IDataReader = objDal.executespreturndr("GetMenuItemByID4Kitchen", objParList)
            Try
                While (dr.Read)
                    Dim objc As New MenuItemsC
                    objc.ItemID = dr.GetInt32(0)
                    objc.MenuDescription = dr.GetString(1)
                    objc.OrderQty = dr.GetInt32(2)
                    objCList.Add(objc)
                End While
            Catch ex As Exception
            End Try
            Return objCList
        End Using
    End Function
End Class
