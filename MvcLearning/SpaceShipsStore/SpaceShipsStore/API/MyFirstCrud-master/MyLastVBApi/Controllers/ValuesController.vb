﻿Imports System.Net
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function
    Public Function GetList(ByVal FromPrice As Integer, ByVal ToPrice As Integer) As String

        Dim pets = GetPets().findall()
        Dim message = String.Format("{0} - {1}", FromPrice, ToPrice)
        Return message


    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
