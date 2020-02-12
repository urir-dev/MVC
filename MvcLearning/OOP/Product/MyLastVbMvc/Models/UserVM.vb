Public Class UserVM
    Private _id As Integer
    Private _firstName As String
    Private _lastName As String


    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstName

        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _lastName

        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property
    Public ReadOnly Property FullName() As String
        Get
            Return _lastName + " " + _firstName


        End Get

    End Property

    Public Sub New(ByVal id As Integer, ByVal firstName As String, ByVal lastName As String)
        ' Initialize with a specific course in mind
        Me.ID = id
        Me.FirstName = firstName
        Me.LastName = lastName



    End Sub
    Public Sub New()
        ' Initialize without a course
    End Sub
End Class
