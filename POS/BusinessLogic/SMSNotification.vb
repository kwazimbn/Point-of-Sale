Imports System
Imports System.Data
Imports System.Configuration
Imports System.Linq
Imports System.Web
Imports System.Xml.Linq
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Diagnostics.PerformanceData
Imports System.Net.Mail
Imports System.Threading
Public Class SMSNotification
    Dim id As Integer
    Dim cellNo As String
    Dim bal As Decimal
    Dim errorMsg As String

    Public Sub New()
        id = 0
        cellNo = 0.0
        bal = 0.0
        errorMsg = ""
    End Sub


    Public Property _ID() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _cellNo() As String
        Get
            Return cellNo
        End Get
        Set(value As String)
            cellNo = value
        End Set
    End Property

    Public Property _Bal() As Decimal
        Get
            Return id
        End Get
        Set(value As Decimal)
            id = value
        End Set
    End Property

    Public Property _errorMsg() As String
        Get
            Return errorMsg
        End Get
        Set(value As String)
            errorMsg = value
        End Set
    End Property

    'Send SMS function
    Public Function sendNotification(ByVal url As String)
        'Initialization is still missing in these two objects
        'Dim objResponse As WebResponse = DefaultSection(WebResponse)
        'Dim objRequest As WebRequest = DefaultSection(WebRequest)
        Dim objResponse As WebResponse
        Dim objRequest As WebRequest
        Dim outCome As String = Nothing
        Try
            objRequest = HttpWebRequest.Create(url)
            objResponse = objRequest.GetResponse()
            Dim stream As StreamReader = New StreamReader(objResponse.GetResponseStream())
            outCome = stream.ReadToEnd()
            stream.Close()
        Catch ex As Exception
            errorMsg += (ex.Message)
        End Try
        Return outCome
    End Function

    Public Function GetUserContact(ByVal userId As Integer)
        Dim objdal As New csSQLDALVB
        Dim objParList As New List(Of csParameterListType)
        Dim objClist As New List(Of SMSNotification)
        objParList.Add(New csParameterListType("@customerId", SqlDbType.Int, _ID))
        Using dr As IDataReader = objdal.executespreturndr("GetUseBal_Contact", objParList)
            While (dr.Read)
                Dim objc As New SMSNotification
                'populate_dataCell(dr, objc)
                objc._cellNo = dr.GetString(0)
                objc._Bal = dr.GetDecimal(1)
                objClist.Add(objc)
            End While
            Return objClist
        End Using
    End Function

    'Public Sub populate_dataCell(ByVal dr As IDataReader, ByVal objc As SMSNotification)
    '    objc._cellNo = dr.GetString(0)
    '    objc._Bal = dr.GetDecimal(1)
    'End Sub
End Class
