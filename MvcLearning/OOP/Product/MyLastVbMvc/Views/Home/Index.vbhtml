
@Code
    Layout = Nothing
    Dim myDate As New DateTime()

End Code




<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        This is my first View!
    </div>
    <div>
        @myDate
    </div>
    <div>
        @myDate.ToString("dd/MM/yy")

    </div>
    <div>
        @ViewBag.Message
    </div>
    <div>
      The best school is:  @ViewData("school")
    </div>


</body>
</html>
