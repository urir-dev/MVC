Imports BL
Module Module1

    Sub Main()
        Console.WriteLine("hellooooo")
        Dim manager = New ProductManager()

        Dim products = manager.GetAll

        For Each product In products


        Next

    End Sub

End Module
