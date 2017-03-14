
   //$(document).ready(function() {
   //     $(".sideBar .glyphicon").click(function () {
   //         if ($(this).attr("aria-expanded") == "true") {
   //             $(this).removeClass("glyphicon-minus").addClass("glyphicon-plus");
   //         } else {
   //             $(this).removeClass("glyphicon-plus").addClass("glyphicon-minus");
   //         }

           
   //     });
   // });

//AJAX TEMPLATE
function sendData(sendUrl, target, value1) {
    $.ajax({
        url: sendUrl,
        type: "POST",
        data: { id: value1 },
        cache: false,
        async: true,
        success: function (data) {
            $(target).html(data);
        }
    });
}

$("#rolColors").on("click", "input", function () {
    sendData(changeColorNameUrl, "#color", $("#rolColors input:checked").attr("id"));
    var colorCount = $("#rolColors input:checked").attr("data-count");
    $("#mainImage img").attr("src", "/Content/img/RolCollections/" + collectionId + "/" + colorCount + ".png")
});

