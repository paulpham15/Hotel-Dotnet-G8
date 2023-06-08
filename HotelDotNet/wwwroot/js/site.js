// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var today = new Date();
var dd = String(today.getDate()).padStart(2, '0');
var mm = String(today.getMonth() + 1).padStart(2, '0');
var yyyy = today.getFullYear();
function show() {
    var p = document.getElementById('pwd');
    p.setAttribute('type', 'text');
}

function hide() {
    var p = document.getElementById('pwd');
    p.setAttribute('type', 'password');
}

var pwShown = 0;

document.getElementById("eye").addEventListener("click", function () {
    if (pwShown == 0) {
        pwShown = 1;
        show();
    } else {
        pwShown = 0;
        hide();
    }
}, false);

today = yyyy + '-' + mm + '-' + dd;

$(".user-menu").click(function () {
    $(this).toggleClass("show");
});
$(".date-picker-icon").click(function () {
    $(".datepicker").datepicker('show');
    $(".datepicker-booking").datepicker('show');
});
$('.datepicker').attr('min', today);
$(function () {
    var shrinkHeader = 60;
    $(window).scroll(function () {
        var scroll = getCurrentScroll();
        if (scroll >= shrinkHeader) {
            $('.header-user-homepage').addClass('shrink');
        }
        else {
            $('.header-user-homepage').removeClass('shrink');
        }
    });
    function getCurrentScroll() {
        return window.pageYOffset;
    }
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
    var dateToday = new Date();
    $(".datepicker").datepicker({
        dateFormat: "yy-mm-dd",
        minDate: dateToday,
    });
    $(".datepicker-booking").datepicker({
        dateFormat: "yy-mm-dd",
        minDate: dateToday,
    });
  

    $(".datepicker").val(new Date().toJSON().slice(0, 10));
    set_($('#input-booking-people'),3);  //return 3 maximum digites
    set_($('#input-booking-stay'),3);    //return 6 maximum digites
    set_($('#nine-max'), 9);  //return 9 maximum digites

    function set_(_this,max) {
        var block = _this.parent();

        block.find(".increase-button").click(function () {
            var currentVal = parseInt(_this.val());
            if (currentVal != NaN && (currentVal + 1) <= max) {
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