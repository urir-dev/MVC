@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width-device-width" />
    <title>Index</title>
</head>
<body>
    <h1>
        @ViewBag.Title
    </h1>
    <h2>
        @ViewData("school")
    </h2>
    <div>

        @Model.Count
        <ViewBag>dd</ViewBag>

    </div><input type="text" />

</body>


</html>