Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult

            Dim manager = New ProductManager()

            Dim products = manager.GetAll()

            Return View(products)
        End Function

        Function Edit(Id As String) As ActionResult
            Dim manager = New ProductManager()

            Dim product = manager.GetProduct(Id)

            Return View(product)

        End Function

        Function Details(Id As String) As ActionResult
            Dim manager = New ProductManager()

            Dim product = manager.GetProduct(Id)

            Return View(product)

        End Function
    End Class
End Namespace