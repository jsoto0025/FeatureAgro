"use strict";

connection.on("updateHumedad", function (humedad) {
    var divHum = $("#divHumedad-" + humedad.modulo);
    divHum.text(humedad.medida + "%");
    if (superiorHum && inferiorHum) {
        var color = humedad.medida <= superiorHum && humedad.medida >= inferiorHum ? "success" : "danger";
        divHum.removeClass(divHum.attr("class"));
        divHum.addClass("badge badge-" + color);
    }
});