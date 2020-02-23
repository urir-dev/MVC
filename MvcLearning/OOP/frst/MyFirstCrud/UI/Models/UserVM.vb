Public Class UserVM

    Public Name As String
    Public email As String
    Public Age As String
    Public _id As Long

    Public Sub New()

    End Sub

    Public Sub New(id As Long, name As String, email As String, age As String)

        Me._id = id
        Me.Name = name
        Me.email = email
        Me.Age = age

    End Sub

End Class
