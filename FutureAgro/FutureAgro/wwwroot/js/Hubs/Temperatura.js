"use strict";

connection.on("updateTemperatura", function (temperatura) {
    var divTemp = $("#divTemp-" + temperatura.modulo);
    divTemp.text(temperatura.medida + "°C");
    if (superiorTemp && inferiorTemp) {
        var color = temperatura.medida <= superiorTemp && temperatura.medida >= inferiorTemp ? "success" : "danger";
        divTemp.removeClass(divTemp.attr("class"));
        divTemp.addClass("badge badge-" + color);
    }
});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var message = document.getElementById("message").value;
//    var groupElement = document.getElementById("group");
//    var groupValue = groupElement.options[groupElement.selectedIndex].value;

//    if (groupValue === "All" || groupValue === "Myself") {
//        var method = groupValue === "All" ? "SendMessageToAll" : "SendMessageToCaller";
//        connection.invoke(method, message).catch(function (err) {
//            return console.error(err.toString());
//        });
//    } else if (groupValue === "PrivateGroup") {
//        connection.invoke("SendMessageToGroup", "PrivateGroup", message).catch(function (err) {
//            return console.error(err.toString());
//        });
//    } else {
//        connection.invoke("SendMessageToUser", groupValue, message).catch(function (err) {
//            return console.error(err.toString());
//        });
//    }

//    event.preventDefault();
//});

//document.getElementById("joinGroup").addEventListener("click", function (event) {
//    connection.invoke("JoinGroup", "PrivateGroup").catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});