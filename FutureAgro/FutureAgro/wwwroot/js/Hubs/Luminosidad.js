"use strict";

connection.on("updateLuminosidad", function (luminosidad) {
    $("#divLumens-" + luminosidad.modulo).text(luminosidad.medida + " Lumens");
});
