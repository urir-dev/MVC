Public Class Class1
    Sub main(args As String)

    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class

Public Class Employee

    Public ID As Integer
    Public FirstName As String
    Public LsatName As String
    Public address As Integer
    Public salary As String

    Public Sub New(id As Integer, fname As String, lname As String, address As String)

        Me.ID = id
        Me.FirstName = fname
        Me.LsatName = lname

    End Sub

    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double)

        Me.ID = id
        Me.FirstName = fname
        Me.LsatName = lname
        Me.Address = address
        Me.Salary = salary
    End Sub

End Class

Public Class Manager

    Inherits Employee
    Public car As Car
    Public Bonus As Double

    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double, car As Car, Bonus As Long)
        MyBase.New(id, fname, lname, address, salary)
        Me.car = car
        Me.Bonus = Bonus
    End Sub

End Class

Public Class Car

    Public Type As String

    Sub New(Type As Type)

    End Sub

End Class

Public Class Cofounder

    Inherits Manager

    Public stocks As Integer

    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double, car As Car, bonus As Long, stocks As Integer)
        MyBase.New(id, fname, lname, address, salary, car, bonus)
        Me.stocks = stocks
    End Sub

End Class

'Abstract אין לו מקום בזיכרון
Public MustInherit Class Animal

    Public Name As String

    Public Eyes As Integer

    MustOverride Sub Move()

    Overridable Sub Eat()
        Console.WriteLine("Must Eat!")
    End Sub

End Class
Interface IFly
    'אין מימוש אבל כל יורש חייב ליישם את הפונקציות שבתוך האינטרפייס
    Sub Fly()

End Interface

'MUST OVERRIDE אין לו מקום בזיכרון
Public Class Fish
    Inherits Animal

    Sub New()
        Me.Eyes = 2
        Me.Name = "clownFish"
    End Sub

    Public Overrides Sub Move()

    End Sub


End Class


Public Class Person
    Inherits Animal

    Public Overrides Sub Move()

    End Sub


    Public Overrides Sub Eat()

    End Sub


End Class

Public Class Bird
    Inherits Animal

    Public Overrides Sub Move()

    End Sub

End Class

Public Class Superman
    Inherits Person
    Implements IFly

    Public Sub fly() Implements IFly.Fly

    End Sub

    Public Overrides Sub Move()

    End Sub


End Class

Public Class Airplain
    Implements IFly

    Public Sub fly() Implements IFly.Fly
        Console.WriteLine("Engine")
    End Sub

End Class

Public Sub Part1()

End Sub

Public Sub Part2()

    Dim animals = New List(Of Animal)
    Dim flys = New List(Of IFly)
    Dim fish = New Fish()
    Dim person = New Person()
    Dim bird = New Bird()

    animals.Add(fish)
    animals.Add(person)
    animals.Add(bird)

    flys.Add(bird)
    flys.Add(New Superman())
    flys.Add(New Airplain())

End Sub