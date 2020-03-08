$(document).ready(function () {
    $("#btn-submit").click(function (e) {
        e.preventDefault();
        console.log(e);
        alert("Handler for .click() called.");
    });
    $("#form").on("submit", function (event) {
        event.preventDefault();
        const params = $(this).serialize();
        console.log('params:', $(this).serialize());
        const url = '/api/pet/getlist?' +
            $.get(url, function (res) {

                console.log(res);

            });

    });


});