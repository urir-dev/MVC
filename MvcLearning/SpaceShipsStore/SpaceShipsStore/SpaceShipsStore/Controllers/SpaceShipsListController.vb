Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult
            Dim manager = New SpaceShipsManager()

            Dim products = manager.GetAll()

            Return View(products)
        End Function
        <HttpGet>
        Function Edit(id As String) As ActionResult
            Dim manager = New SpaceShipsManager()
            Dim product = manager.GetShip(id)

            Return View(product)
        End Function

        '<HttpPost>
        'Function Edit(collection As FormCollection) As ActionResult
        '    Dim manager = New SpaceShipsManager()
        '    Dim id = collection("CatalogID")
        '    Dim Ship = manager.GetShip(id)
        '    Ship.Name = collection("Name")
        '    manager.UpdateShip(Ship)
        '    Return RedirectToAction("Index")
        'End Function


        Function List() As ActionResult
            Dim manager = New SpaceShipsManager
            Dim Ships = manager.GetAll()
            Return View(Ships)


        End Function
    End Class
End Namespace