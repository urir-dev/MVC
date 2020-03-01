Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class UserController
        Inherits ApiController

        ' GET: api/User
        Public Function GetValues() As IEnumerable(Of String)

            Dim arr As List(Of String) = New List(Of String)() From {
                "Yonatan",
                "Maayan",
                "Harry",
                "Orya",
                "Uri"
            }
            Dim name2 = arr(2).ToString()
            'Dim name = arr(7).ToString()

            Return arr
        End Function

        ' GET: api/User/5
        Public Function GetValue(ByVal id As Integer) As String
            Dim name As String
            Dim arr As List(Of String) = New List(Of String)() From {
                "Yonatan",
                "Maayan",
                "Harry",
                "Orya",
                "Uri"
            }

            Try

                name = arr(id)

            Catch ex As Exception

                name = "המשתמש הוא דרעק"

            End Try

            Return name

        End Function

        ' POST: api/User
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace