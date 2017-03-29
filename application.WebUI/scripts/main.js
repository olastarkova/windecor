
   //$(document).ready(function() {
   //    sendData(changePipeList, "#truby", $("#colors input:checked").attr("id"), collectionId);
   //    sendData(changeSizeListUrl, "#sizes", 1, collectionId);
   // });

//AJAX TEMPLATE
function sendData(sendUrl, target, value1, value2) {
    $.ajax({
        url: sendUrl,
        type: "POST",
        data: { id: value1, idcol: value2 },
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
    $("#mainImage img").attr("src", "/Content/img/RolCollections/" + collectionId + "/" + colorCount + ".png");
});
$("#colors").on("click", "input", function () {
    sendData(changePipeList, "#truby", $("#colors input:checked").attr("id"), collectionId);
    sendData(changeEavesColorNameUrl, "#color", $("#colors input:checked").attr("id"));
    sendData(changePipeNameUrl, "#truba", $("#truby input:first").attr("value"));
});
$("#truby").on("click", "input", function () {
    sendData(changePipeNameUrl, "#truba", $("#truby input:checked").attr("value"));
});
$("#krepleniya").on("click", "input", function () {
    sendData(changeFasteningName, "#krepleniye", $("#krepleniya input:checked").attr("value"));
});


