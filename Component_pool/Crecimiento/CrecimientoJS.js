"use strict";

connection.on("updateCrecimiento", function (planta) {

    var crecimiento = planta.porcentajeCrecimiento;

    $("#divCrecimiento-" + planta.idPlanta).text(crecimiento + "%");
    $("#progrescrecimiento-" + planta.idPlanta).attr("style", "width:" + crecimiento + "%;");

    /*B-ScriptUpdateCrecimiento*/
});