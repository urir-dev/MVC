Public Class FreindVM

    Public Name As String
    Public email As String
    Public Age As String

    Public Sub New()

    End Sub

    Public Sub New(name As String, email As String, age As String)

        Me.Name = name
        Me.Age = age

    End Sub

    Private _email As String
    Public Property Email() As String
        Get

        End Get
        Set(value As String)

        End Set

    End Property


End Class
