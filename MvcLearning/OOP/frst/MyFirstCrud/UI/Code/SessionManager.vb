Public Class SessionManager

    Const _USER As String = "usr"

    Const _users

    Private Shared _session As SessionState.HttpSessionState
    Public Shared ReadOnly Property session() As SessionState.HttpSessionState
        Get
            If _session Is Nothing Then
                _session = HttpContext.Current.Session

            End If

            Return _session
        End Get

    End Property

    Public Shared Property user() As uservm
        Get
            Return session(_USER)
        End Get

        Set(ByVal usr As USERVM)

            session(_USER) = usr

        End Set

    End Property

    Public Shared ReadOnly Property isconnect() As Boolean
        Get
            Return user IsNot Nothing
        End Get

    End Property

    Private Shared ReadOnly Property users() As List(Of UserVM)
        Get
            Dim userrole = New List(Of String) From {_User_Role}
            Dim managerrole = New List(Of String) From {_User_Role, _manager_role}
            If _users Is Nothing Then
                _users = New List(Of UserVM) From {
                New UserVM(1, "kuku", "laptop@gmail.con", 56,),
                New UserVM(2, "koolop", "laptop@gmail.con", 43,),
                New UserVM(3, "kuku", "laptop@gmail.con", 56,)
                    }
            End If

        End Get
    End Property


End Class
