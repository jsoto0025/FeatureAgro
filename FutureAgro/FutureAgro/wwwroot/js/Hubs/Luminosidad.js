"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/luminosidadhub", {
        accessTokenFactory: () => "testing"
    })
    .build();

connection.on("updateLuminosidad", function (luminosidad) {
    $("#divLumens-" + luminosidad.modulo).text(luminosidad.medida + " Lumens");
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});