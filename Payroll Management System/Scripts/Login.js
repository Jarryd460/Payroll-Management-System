$(document).ready(function () {
    var animating = false;

    $(document).on("click", "#btnSubmit", function (e) {
        if (animating) return;
        animating = true;
        var that = this;
        $(that).addClass("processing");
    });
});