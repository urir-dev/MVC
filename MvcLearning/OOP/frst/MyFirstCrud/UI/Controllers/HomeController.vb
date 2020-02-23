Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function bootstrap() As ActionResult
            Return View()
        End Function
    End Class
End Namespace