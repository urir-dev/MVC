Imports System.Web.Mvc

Namespace Controllers
    Public Class Login
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Dim IsUserLogin = Session("User") IsNot Nothing


            If IsUserLogin Then
                Return RedirectToAction("Index", "Home")
            End If

            Return View()

        End Function

        <HttpPost()>
        Function Login(ByVal collection As FormCollection) As ActionResult
            Dim IsUserLogin = Session("User") IsNot Nothing
            Try

                If IsUserLogin Then
                Return RedirectToAction("Index", "Home")
            End If

            Return View()

        End Function

    End Class
End Namespace