
   $(document).ready(function() {
        $(".sideBar .glyphicon").click(function () {
            if ($(this).attr("aria-expanded") == "true") {
                $(this).removeClass("glyphicon-minus").addClass("glyphicon-plus");
            } else {
                $(this).removeClass("glyphicon-plus").addClass("glyphicon-minus");
            }

           
        });
    });
