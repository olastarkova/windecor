//AJAX TEMPLATE
function sendData(sendUrl, target, value1, value2, value3) {
    $.ajax({
        url: sendUrl,
        type: "POST",
        data: { id: value1, idcol: value2, id2: value3 },
        cache: false,
        async: true,
        success: function (data) {
            $(target).html(data);
        }
    });
}


$("#rolColors").on("click", "input", function () {
    sendData("/Color/ChangeColorName/", "#color", $("#rolColors input:checked").attr("id"));
    var colorCount = $("#rolColors input:checked").attr("data-count");
    $("#mainImage img").attr("src", "/Content/img/RolCollections/" + collectionId + "/" + colorCount + ".png");
});
$("#colors").on("click", "input", function () {
    sendData("/Eaves/ChangePipeList/", "#truby", $("#colors input:checked").attr("id"), collectionId);
    sendData("/Eaves/ChangePipeEavesAllColors/", "#color", $("#colors input:checked").attr("id"));
    sendData("/Eaves/ChangePipeName/", "#truba", $("#truby input:first").attr("value"));
    sendData("/Eaves/ChangeRingList/", "#kolca", $("#colors input:checked").attr("id"), collectionId);
    sendData("/Eaves/ChangeItemTypeList/", "#types", $("#colors input:checked").attr("id"), collectionId);
    sendData("/Eaves/ChangeSizeList/", "#sizes", $("#truby input:first").attr("value"), collectionId);
    sendData("/Eaves/ChangeFasteningName/", "#krepleniye", $("#krepleniya input:first").attr("value"));
    sendData("/Eaves/ChangeFasteningList/", "#krepleniya", $("#types input:first").attr("value"), collectionId, $("#colors input:checked").attr("id"));
    sendData("/Eaves/ChangeRingName/", "#kolco", $("#kolca input:first").attr("value"));
});
$("#truby").on("click", "input", function () {
    sendData("/Eaves/ChangePipeName/", "#truba", $("#truby input:checked").attr("value"));
    sendData("/Eaves/ChangeSizeList/", "#sizes", $("#truby input:checked").attr("value"), collectionId);
});
$("#krepleniya").on("click", "input", function () {
    sendData("/Eaves/ChangeFasteningName/", "#krepleniye", $("#krepleniya input:checked").attr("value"));
});
$("#kolca").on("click", "input", function () {
    sendData("/Eaves/ChangeRingName/", "#kolco", $("#kolca input:checked").attr("value"));
});
$("#types").on("click", "input", function () {
    sendData("/Eaves/ChangeFasteningList/", "#krepleniya", $("#types input:checked").attr("value"), collectionId, $("#colors input:checked").attr("id"));
    sendData("/Eaves/ChangeFasteningName/", "#krepleniye", $("#krepleniya input:first").attr("value"));
});
