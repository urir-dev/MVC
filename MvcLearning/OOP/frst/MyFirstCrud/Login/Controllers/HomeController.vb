Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Dim IsUserLogin = Session("User") IsNot Nothing


            If IsUserLogin Then
                Return View()
            End If

            Return RedirectToAction("Index", "Login")


            Return View()
        End Function


    End Class
End Namespace