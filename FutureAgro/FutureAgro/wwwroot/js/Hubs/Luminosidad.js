"use strict";

connection.on("updateLuminosidad", function (luminosidad) {
    var divLuz = $("#divLumens-" + luminosidad.modulo);
    divLuz.text(luminosidad.medida + " Lumens");
    if (superiorLuz && inferiorLuz) {
        var color = luminosidad.medida <= superiorLuz && luminosidad.medida >= inferiorLuz ? "success" : "danger";
        divLuz.removeClass(divLuz.attr("class"));
        divLuz.addClass("badge badge-" + color);
    }
});
