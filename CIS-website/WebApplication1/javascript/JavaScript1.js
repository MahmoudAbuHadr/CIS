$(document).ready(function () {
    $('.navlinks').hover(function () {
        $('.navlinks').not(this).each(function () {
            $(this).removeClass('highlighted');
        });
        $(this).addClass('highlighted');
    });
});