$("input[type='text']").focus(function () {
    $("li").removeClass("background");
    $(this).closest("li").addClass("background");
});