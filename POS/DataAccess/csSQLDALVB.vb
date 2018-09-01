Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient
Imports System.Configuration
Public Class csSQLDALVB
    Protected _strconn As String = ConfigurationManager.ConnectionStrings("group26").ConnectionString.ToString()
    Private conn As SqlConnection
    Private errorstr As String = String.Empty

    Public Sub New()
        conn = New SqlConnection()
    End Sub

    Public Property ConnectionString() As String
        Get
            Return _strconn
        End Get
        Set(ByVal value As String)
            _strconn = value
        End Set
    End Property

    Private Function Open_Connection() As Boolean
        If conn Is Nothing Then
            conn = New SqlConnection()
        End If
        If conn.State = System.Data.ConnectionState.Closed Then
            Try
                conn.ConnectionString = ConnectionString
                conn.Open()
                Return True
            Catch a As Exception
                errorstr += " " & a.Message
                Return False
            End Try
        Else
            Return True
        End If
    End Function

    Private Function add_parameters(ByVal objpar As csParameterListType) As SqlParameter
        Dim sqlpar As New SqlParameter()

        sqlpar.ParameterName = objpar.Name
        sqlpar.SqlDbType = objpar.SqlType
        sqlpar.SqlValue = objpar.Value

        Return sqlpar
    End Function


    Public Function executespreturnds(ByVal spname As String, ByVal objlist As List(Of csParameterListType)) As System.Data.DataSet

        Dim cmd As New SqlCommand()
        Dim sda As New SqlDataAdapter()
        Dim ds As New DataSet()

        If Open_Connection() Then
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = spname

            For Each par As csParameterListType In objlist
                cmd.Parameters.Add(add_parameters(par))
            Next

            sda.SelectCommand = cmd

            sda.Fill(ds)
        End If

        close_conn()

        Return ds
    End Function

    Public Function executespreturnds(ByVal spname As String) As System.Data.DataSet

        Dim cmd As New SqlCommand()
        Dim sda As New SqlDataAdapter()
        Dim ds As New DataSet()

        If Open_Connection() Then
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = spname

            sda.SelectCommand = cmd


            sda.Fill(ds)
        End If

        close_conn()

        Return ds
    End Function

    Public Function executespreturndr(ByVal spname As String, ByVal objlist As List(Of csParameterListType)) As IDataReader
        Dim cmd As New SqlCommand()
        Dim dr As IDataReader = Nothing
        Try
            If Open_Connection() Then
                cmd.Connection = conn
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cmd.CommandText = spname

                For Each par As csParameterListType In objlist
                    cmd.Parameters.Add(add_parameters(par))
                Next

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            End If
            Return dr
        Catch e As Exception
            errorstr += " " & e.Message
            Return Nothing
        End Try
    End Function

    Public Function executespreturndr(ByVal spname As String) As IDataReader
        Dim cmd As New SqlCommand()
        Dim dr As IDataReader = Nothing

        Try
            If Open_Connection() Then
                cmd.Connection = conn
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cmd.CommandText = spname
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            End If
            Return dr
        Catch e As Exception
            errorstr += " " & e.Message
            Return Nothing
        End Try
    End Function

    Public Sub executespreturnnd(ByVal spname As String)
        Dim cmd As New SqlCommand()

        Try
            If Open_Connection() Then
                cmd.Connection = conn
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cmd.CommandText = spname
                cmd.ExecuteNonQuery()
            End If

            close_conn()
        Catch e As Exception
            errorstr += " " & e.Message
        End Try
    End Sub

    Public Sub executespreturnnd(ByVal spname As String, ByVal objlist As List(Of csParameterListType))
        Dim cmd As New SqlCommand()
        Try
            If Open_Connection() Then
                cmd.Connection = conn
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cmd.CommandText = spname

                For Each par As csParameterListType In objlist
                    cmd.Parameters.Add(add_parameters(par))
                Next

                cmd.ExecuteNonQuery()
            End If
            close_conn()
        Catch e As Exception
            errorstr += " " & e.Message
        End Try
    End Sub

    Private Sub close_conn()
        If conn.State = System.Data.ConnectionState.Open Then
            conn.Close()
        End If

        conn = Nothing
    End Sub
End Class
