"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/humedadhub", {
        accessTokenFactory: () => "testing"
    })
    .build();

connection.on("updateHumedad", function (humedad) {
    $("#divHumedad-" + humedad.modulo).text(humedad.medida + "%");
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});