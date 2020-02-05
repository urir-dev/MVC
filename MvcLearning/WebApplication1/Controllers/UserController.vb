Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            Dim title = "Index"
            ViewBag.Title = title.ToLower
            Dim manager = New BL.UserManager()
            Dim usersFromDataBase = manager.GetAllUsers()
            Dim users = ConvertUserToUserMV(usersFromDataBase)

            Return View("Index", users)
        End Function

        Function Bb() As ActionResult
            Dim title = "BeBe"
            ViewBag.Title = title.ToLower()
            ViewData("School") = "Macademia"
            TempData("School") = "PM"
            Return View("Index")
        End Function

        Function Beni()
            Dim title = "Beni"
            ViewBag.Title = title.ToLower
            ViewData("School") = "Beni Macademia"
            TempData("School") = "PM"
            Return View("Index")
            'if we have a Redirect the Viewbag & Viewdata Won't be avilable
            'Return Redirect("./Index")
        End Function

        Private Function ConvertUserToUserMV(users As List(Of User)) As List(Of UserVM)
            Dim usersVM = New List(Of UserVM)
            For Each u As UserControl In users
                UserVM.Add(New.UserVM(u.ID, u.FirstName, u.LastName))
            Next

            Return (UserVM)

        End Function



    End Class
End Namespace