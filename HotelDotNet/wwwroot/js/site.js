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
    $(".vertical-center-3 ").slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 4,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });
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