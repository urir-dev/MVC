Public Class SessionManager
    Const _USER As String = "Usr"
    Const _USER_ROLE As String = "USER"
    Const _MANAGER_ROLE As String = "MANAGER"

    Private Shared _session As SessionState.HttpSessionState
    Private Shared _products As List(Of Ship)
    Private Shared _users As List(Of UserVM)
    Private Shared ReadOnly Property Session() As SessionState.HttpSessionState
        Get

            If _session Is Nothing Then
                _session = HttpContext.Current.Session

            End If


            Return _session
        End Get

    End Property


    Public Shared ReadOnly Property Products() As List(Of Ship)
        Get

            If _products Is Nothing Then
                _products = New List(Of Ship) From {
        New Ship("123-SPC", "Space Transit", 150000000.99, True, "https://i.insider.com/5e220ea524306a016e4f2012?width=1300&format=jpeg&auto=webp"),
        New Ship("142-SPC", "Moovy", 167000000.99, True, "https://www.teslarati.com/wp-content/uploads/2018/09/BFR-2018-spaceship-and-booster-sep-SpaceX-1c.jpg"),
        New Ship("144-SPC", "Crashalot", 12000000.99, True, "https://cnet3.cbsistatic.com/img/5-gSbQ4FXqXbOwHkUyrun1cu2a0=/2016/11/11/483a4cf3-b6c7-42f9-aaec-aa6f43294fe9/lexus-spaceship-valerian-2.jpg"),
        New Ship("148-SPC", "Hide In The Dark B6", 20000066.99, True, "https://static.turbosquid.com/Preview/2018/07/08__06_51_39/Dagger_1_Black_Perspective_V2.jpgF4DA1E4E-C1B1-45B9-A7ED-D52B4F4F13D2DefaultHQ.jpg"),
        New Ship("150-SPC", "Boringstein II", 1800000.99, True, "https://previews.123rf.com/images/phonlamaiphoto/phonlamaiphoto1809/phonlamaiphoto180900178/108613577-3d-rendering-metal-ufo-or-alien-spaceship-on-black-background.jpg"),
        New Ship("152-SPC", "Affordable UX", 3000000.99, True, "https://previews.123rf.com/images/iimages/iimages1601/iimages160100114/50162345-red-spaceship-with-wings-illustration.jpg"),
        New Ship("153-SPC", "Dream Patch", 2500005000.99, True, "http://farm2.static.flickr.com/1434/1461137007_b5a3163dd5.jpg?v=0"),
        New Ship("156-SPC", "Bug 2000", 200020002000.2, True, "https://img-new.cgtrader.com/items/1026914/e1d3363c59/small-spaceship-01-3d-model.jpg"),
        New Ship("157-SPC", "Ferrari SPC", 9000000000.99, True, "http://doitinpublic.com/awesomeotters/wp-content/uploads/2015/05/ferrari_ufo_spaceship_spacecraft_1.jpg?w=700"),
        New Ship("159-SPC", "Gravity Freind III", 2100, True, "https://ideascdn.lego.com/media/generate/lego_ci/aec6f4fe-28ea-4348-8900-fbaba269913b/resize:800:450"),
        New Ship("160-SPC", "Conspiracy", 5000000000000, True, "https://upload.wikimedia.org/wikipedia/commons/1/14/Spaceship_moon.jpg")
        }

            End If


            Return _products
        End Get

    End Property

    Public Shared ReadOnly Property Users() As List(Of UserVM)
        Get
            Dim userRole = New List(Of String) From {_USER_ROLE}
            Dim managerRole = New List(Of String) From {_USER_ROLE, _MANAGER_ROLE}
            If _users Is Nothing Then
                _users = New List(Of UserVM) From {
          New UserVM(1, "Yonatan", "Yonatan@Epr.co.il", 38, userRole),
          New UserVM(2, "Harel", "Harel@Epr.co.il", 38, userRole),
          New UserVM(1, "Orya", "Orya@Epr.co.il", 38, managerRole)
                }


            End If


            Return _users
        End Get

    End Property

    Public Shared Property User() As UserVM
        Get
            Return Session(_USER)
        End Get
        Set(ByVal usr As UserVM)
            'usr.Age = 40

            Session(_USER) = usr
        End Set
    End Property

    Public Shared ReadOnly Property IsConnect() As Boolean
        Get
            Return User IsNot Nothing
        End Get

    End Property


End Class