// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".user-menu").click(function () {
    $(this).toggleClass("show");
});
$(".date-picker-icon").click(function () {
    $(".datepicker").datepicker('show');
});
$(function () {
    $(".datepicker").datepicker({
        dateFormat: "yy-mm-dd"
    });
    $(".datepicker").val(new Date().toJSON().slice(0, 10));
    set_($('#input-booking-people'));  //return 3 maximum digites
    set_($('#input-booking-stay'));    //return 6 maximum digites
    set_($('#nine-max'), 9);  //return 9 maximum digites

    function set_(_this) {
        var block = _this.parent();

        block.find(".increase-button").click(function () {
            var currentVal = parseInt(_this.val());
            if (currentVal != NaN && (currentVal + 1)) {
                _this.val(currentVal + 1);
            }
        });

        block.find(".decrease-button").click(function () {
            var currentVal = parseInt(_this.val());
            if (currentVal != NaN && currentVal != 0) {
                _this.val(currentVal - 1);
            }
        });
    }
});