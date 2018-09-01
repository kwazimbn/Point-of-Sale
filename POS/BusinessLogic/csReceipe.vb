Public Class csReceipe
    Private _itemId As Integer
    Private _ingrId As Integer
    Private _desc As String
    Private _proportion As Decimal
    Private _unit As String
    Private _recipeCreationDate As String

    Public Sub New()
        _itemId = 0
        _ingrId = 0
        _desc = ""
        _proportion = 0.0
        _unit = ""
        _recipeCreationDate = ""
    End Sub

    Public Property ItemID As Integer
        Get
            Return _itemId
        End Get
        Set(value As Integer)
            _itemId = value
        End Set
    End Property

    Public Property IngrID As Integer
        Get
            Return _ingrId
        End Get
        Set(value As Integer)
            _ingrId = value
        End Set
    End Property

    Public Property Desc As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property

    Public Property Proportion As Decimal
        Get
            Return _proportion
        End Get
        Set(value As Decimal)
            _proportion = value
        End Set
    End Property

    Public Property Unit As String
        Get
            Return _unit
        End Get
        Set(value As String)
            _unit = value
        End Set
    End Property

    Public Property CreateDate As String
        Get
            Return _recipeCreationDate
        End Get
        Set(value As String)
            _recipeCreationDate = value
        End Set
    End Property

    Public Function SaveRecipe()
        Dim objDal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        With objParList
            '.Add(New csParameterListType("@menuItemId", SqlDbType.Int, ItemID))
            .Add(New csParameterListType("@ingredieniId", SqlDbType.Int, IngrID))
            .Add(New csParameterListType("@proportion", SqlDbType.Decimal, Proportion))
            .Add(New csParameterListType("@unit", SqlDbType.Char, Unit))
            .Add(New csParameterListType("@creationTime", SqlDbType.DateTime, CreateDate))
            objDal.executespreturnnd("CreateRecipe", objParList)
        End With
        Return objParList
    End Function

    Public Function getRecipe4MenuItem(ByVal itemId As Integer)
        Dim objCList As New List(Of csReceipe)
        Dim objDal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        objParList.Add(New csParameterListType("@menuItemId", SqlDbType.Int, itemId))
        Using dr As IDataReader = objDal.executespreturndr("GetMenuRecipe4Item", objParList)
            Try
                While (dr.Read)
                    Dim objc As New csReceipe
                    objc.Desc = dr.GetString(0)
                    objc.Proportion = dr.GetDecimal(1)
                    objc.Unit = dr.GetString(2)
                    objCList.Add(objc)
                End While
            Catch ex As Exception
            End Try
            Return objCList
        End Using
    End Function
End Class
