(function () {
    //var ele = $("#username");
    //ele.text("Hello Rasika");

    //var main = $("#main");
    //main.on("mouseenter", function () {
       
    //    main.style = "background-color : #888;";
    //});
    //main.on("mouseleave", function () {
    //    main.style = "";
    //});


    var $getSideBarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");
    $("#sidebarToggle").on("click", function () {
        $getSideBarAndWrapper.toggleClass("hide-sidebar");
        if($getSideBarAndWrapper.hasClass("hide-sidebar")){
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });
    


})();