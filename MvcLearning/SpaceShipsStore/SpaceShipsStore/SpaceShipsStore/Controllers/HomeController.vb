Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller


        ' GET: Home
        Function Index() As ActionResult

            '    If isUserLogin Then
            If SessionManager.IsConnect Then
                Return View()

            End If
            Return RedirectToAction("Index", "Login")

        End Function

    End Class
End Namespace