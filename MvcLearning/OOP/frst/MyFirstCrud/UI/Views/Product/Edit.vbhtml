﻿@ModelType UI.Freind

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Product</h4>
        <div class="form-control">
            <div>
                @Html.LabelFor(Function(model) model.Name)
                @Html.TextBoxFor(Function(model) model.Name)
            </div>

            <div>
                @Html.LabelFor(Function(model) model.Name)
            </div>
        </div>





        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
