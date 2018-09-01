Public Class UserRole_Class
    Dim role_Id As Integer
    Dim role_Desc As String

    Public Sub New()
        role_Id = 0
        role_Desc = ""
    End Sub

    Public Property _role_Id() As Integer
        Get
            Return role_Id
        End Get
        Set(value As Integer)
            role_Id = value
        End Set
    End Property

    Public Property _role_Desc() As String
        Get
            Return role_Desc
        End Get
        Set(value As String)
            role_Desc = value
        End Set
    End Property

    Public Sub addUserRole(ByVal desc As String)
        Dim objdal As New csSQLDALVB
        Dim objlist As New List(Of csParameterListType)
        With objlist
            .Add(New csParameterListType("@UserRole", SqlDbType.VarChar, _role_Desc.ToString()))
            objdal.executespreturnnd("insertUserRole", objlist)
        End With
    End Sub

    Public Function getAllRoles() As List(Of UserRole_Class)
        Dim objDal As New csSQLDALVB
        Dim objList As New List(Of UserRole_Class)
        Using dr As IDataReader = objDal.executespreturndr("getAllRoles")
            While (dr.Read)
                Dim par As New UserRole_Class
                'populate_data(dr, par)
                par._role_Id = dr.GetInt32(0)
                par._role_Desc = dr.GetString(1)
                objList.Add(par)
            End While
        End Using
        Return objList
    End Function

    'Public Sub populate_data(ByVal dr As IDataReader, ByVal par As UserRole_Class)
    '    par._role_Id = dr.GetInt32(0)
    '    par._role_Desc = dr.GetString(1)
    'End Sub
End Class
