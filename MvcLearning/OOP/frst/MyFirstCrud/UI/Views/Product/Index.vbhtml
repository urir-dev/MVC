@ModelType IEnumerable(Of UI.Freind)

<h2>Index</h2>

<style>

    img {

        height:100px
    }

</style>



}

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CatalogID)
        </th>

        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>

        <th>
            @Html.DisplayNameFor(Function(model) model.Price)
        </th>

        <th>
            @Html.DisplayNameFor(Function(model) model.Image)
        </th>


    </tr>

@For Each product In Model
    @<tr>
    <td>
        @product.CatalogID
    </td>

    <td>
        @product.Name
    </td>

    <td>
        @product.Price
    </td>

    <td>
       <img src="@product.Image" alt="@product.Name" />
    </td>

    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = product.CatalogID}) |
        @Html.ActionLink("Details", "Details", New With {.id = product.Name}) |
    </td>
</tr>
Next

</table>
