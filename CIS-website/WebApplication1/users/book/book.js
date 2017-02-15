$(document).ready(function () {
    var defaultvalue = "18:00";
    var minvalue = "18:00";
    var maxvalue = "20:00";
    var step = "1800";
    

    var booktime = document.getElementById("TextboxBookTime");
    booktime.defaultValue = (defaultvalue);
    booktime.min = (minvalue);
    booktime.max = (maxvalue);
    booktime.step = (step);

    var bookdate = document.getElementById("TextboxBookDate");
    bookdate.min = new Date();
    bookdate.max = "2018-01-01";
           
});