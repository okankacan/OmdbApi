/*layout page start */


var url = window.location.protocol + '//' + window.location.host;
var apiUrl = "https://localhost:44390/api/";
function LayoutPageDocument() {
    $("#owl-demo").owlCarousel({
        navigation: true,
        slideSpeed: 300,
        paginationSpeed: 400,
        singleItem: true,
        autoPlay: true

    });
};

$(function () {
    $('select.styled').customSelect();
});

function flagGet(flagURL) {
    $("#languageImg").attr('src', flagURL);
};
/* layout page end */

$("#SearchFilm").click(function () {

    filmName = $("#filmname").val();
    if (filmName === "")
        alert("Lütfen film ismini giriniz");
    else {
        $(".loading").show();
        var filmData = JSON.stringify({
            "filmName": filmName
        });

        var _url = apiUrl + "Film/FilmSearch?filmData=" + filmName;
        $('#output').html('');
        $.ajax({
            type: "Get",
            url: _url,
            success: function (response) {
               
                $(".loading").hide();
                var result = response.data.search;
                result.forEach(appendFunc);

            },
            error: function (msg1) {
                $(".loading").hide();

                alert(msg1.d);
            }
        });

    }
 
});

function appendFunc(item) {
    $('#output').append('<div class="col-md-12"><h2> ' + item.title + '</h2></div>' +
        '<div class="col-md-6"><img src="' + item.poster + '"/></div>'
        + '<div class="col-md-6">' + item.type + ' - ' + item.year+ '</div>');
}