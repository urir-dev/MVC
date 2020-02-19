Imports System.Web.Mvc

Namespace Views.Freinds
    Public Class FreindController
        Inherits Controller

        ' GET: Freind
        Function Index() As ActionResult
            Return View()
        End Function

        <HttpGet()>
        Function Create() As ActionResult
            TempData("message") = "Edit!"
            Return View()
        End Function

        <HttpPost()>
        Function Create(ByVal Collection As FormCollection) As ActionResult
            Try
                TempData("message") = Collection("name")
                Return RedirectToAction("index")
            Catch
                TempData("message") = "Error!"
                Return View()
            End Try
        End Function

        Function ConvertCollectionToFreind(Collection As FormCollection)

            Dim _Freind = New FreindVM(Collection("Name"), Collection("Email"), Collection("Age"))

        End Function




    End Class
End Namespace