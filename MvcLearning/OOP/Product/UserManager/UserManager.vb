Namespace BL
    Public Class UserManager

        Public Function GetAllUsers() As List(Of User)
            Dim users As New List(Of User) From {
                New User(111, "Yonatan", "Altman", New DateTime(2019, 1, 2)),
                New User(111, "Harel", "Rabinovich", New DateTime(2019, 1, 2)),
                New User(111, "Shirit", "Mauda", New DateTime(2010, 1, 2)),
                New User(111, "Maayan", "Lichtensteinfjd", New DateTime(2013, 1, 2)),
                New User(111, "Uri", "Redler", New DateTime(2014, 1, 2))
            }

            Return users
        End Function

    End Class
End Namespace

