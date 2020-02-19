Public Class UserVM

    Public Name As String
    Public email As String
    Public Age As String

    Public Sub New()

    End Sub

    Public Sub New(name As String, email As String, age As String)

        Me.Name = name
        Me.email = email
        Me.Age = age

    End Sub

End Class
