Imports System.Web.Mvc
Imports System.Configuration
Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult


            Dim appName As String = ConfigurationManager.AppSettings("appName")

            Dim time = Session.Timeout

            ViewBag.AppName = appName

            Dim isUserLogin = SessionManager.User IsNot Nothing

            If isUserLogin Then
                Return RedirectToAction("Index", "Home")

            End If
            Return View()
        End Function

        ' POST: Login/Create
        <HttpPost()>
        Function Index(ByVal collection As FormCollection) As ActionResult
            Try
                Dim user = New UserVM(collection)

                Dim tempUser = SessionManager.Users.Find(Function(u) u.Email = user.Email)
                SessionManager.User = tempUser

                If SessionManager.IsConnect Then
                    Return RedirectToAction("Index", "Home")

                End If
                ViewBag.Error = "Email or Password is Incorrect!!!!!!! Are you an alien who tries to breach the system ?"
                Return View("Index")
            Catch
                Return View("Index")
            End Try
        End Function


    End Class
End Namespace
