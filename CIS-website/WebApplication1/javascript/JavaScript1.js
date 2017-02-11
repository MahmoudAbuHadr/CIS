$(document).ready(function () {
    /*$('.navlinks').hover(function () {
        $('.navlinks').not(this).each(function () {
            $(this).removeClass('highlighted');
        });
        $(this).addClass('highlighted')
        }, function () {
            $(this).removeClass('highlighted');
    });
    */
    $('.navlinks').click( function(){
    
        $('.navlinks').not(this).each(function () {
            $(this).removeClass('highlighted');
        });
        $(this).addClass('highlighted')
    
    });



});