﻿@ModelType IEnumerable(Of UserVM)
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<body>
    <h2>List</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.FirstName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.LastName)
            </th>

            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.FirstName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.LastName)
                </td>

                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
                </td>
            </tr>
        Next

    </table>

</body>
</html>
