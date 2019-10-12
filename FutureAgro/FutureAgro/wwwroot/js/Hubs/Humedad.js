"use strict";

connection.on("updateHumedad", function (humedad) {
    $("#divHumedad-" + humedad.modulo).text(humedad.medida + "%");
});