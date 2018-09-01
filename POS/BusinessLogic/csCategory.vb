Public Class csCategory
    Private _category_ID As Integer
    Private _category_Name As String

    Public Sub New()
        _category_ID = 0
        _category_Name = ""
    End Sub

    Public Property CategoryID() As Integer
        Get
            Return _category_ID
        End Get
        Set(value As Integer)
            _category_ID = value
        End Set
    End Property

    Public Property CategoryName() As String
        Get
            Return _category_Name
        End Get
        Set(value As String)
            _category_Name = value
        End Set
    End Property

    Public Function GetCategoryList() As List(Of csCategory)
        Try
            Dim objDal As New csSQLDALVB
            Dim objCList As New List(Of csCategory)
            Using dr As IDataReader = objDal.executespreturndr("GetCategoryList")
                While (dr.Read())
                    Dim objc As New csCategory
                    objc.CategoryID = dr.GetInt32(0)
                    objc.CategoryName = dr.GetString(1)
                    objCList.Add(objc)
                End While
                Return objCList
            End Using
        Catch ex As Exception

        End Try
    End Function
End Class
