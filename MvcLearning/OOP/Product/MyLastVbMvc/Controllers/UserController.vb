Imports System.Web.Mvc
Imports UserManager



Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            Dim title = "Index"
            ViewBag.Title = title.ToLower()
            Dim manager = New BL.UserManager()
            Dim usersFromDatabase = manager.GetAllUsers()
            Dim users = ConvertUserToUserMV(usersFromDatabase)
            Return View("Index", users)
        End Function
        Function Bb() As ActionResult
            Dim title = "BeBe"
            ViewBag.Title = title.ToLower()
            ViewData("School") = "Academka"
            TempData("TempData") = "PM"

            Return View("Index")
        End Function
        Function Beni() As ActionResult
            Dim title = "Beni"
            ViewBag.Title = title.ToLower()
            ViewData("School") = "Epr AcadeMe"
            TempData("TempData") = "PM"
            ' if we have a Redirect the ViewBag & ViewData won't be available
            Return Redirect("./Index")
            'Return View("Index")
        End Function
        Private Function ConvertUserToUserMV(users As List(Of User)) As List(Of UserVM)
            Dim usersVM = New List(Of UserVM)
            For Each u As User In users
                usersVM.Add(New UserVM(u.ID, u.FirstName, u.LastName))
            Next

            Return usersVM

        End Function
    End Class
End Namespace