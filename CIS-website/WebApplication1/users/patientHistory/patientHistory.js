$(document).ready(function () {
    $("legend").click(function () {
        $(this).siblings().slideToggle();
    });

    $(".choiceRadio").click(function () {
        if ($(this).parent().children().filter("#yes").is(":checked")) {
            $(this).parent().siblings().children().not(".choiceRadio").removeAttr("disabled");
        } else {
            $(this).parent().siblings().children().not(".choiceRadio").attr("disabled", true);
        }
    });

    $(".other").click(function () {
        if ($(this).is(":checked")) {
            $(this).next().removeAttr("disabled");
        } else {
            $(this).next().attr("disabled", true);
        }
    });

});

