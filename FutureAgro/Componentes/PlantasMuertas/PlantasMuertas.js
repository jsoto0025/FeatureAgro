"use strict";

connection.on("updatePlantaMuerta", function (planta) {
    $("#plantamuerta-" + planta.idPlanta).removeClass("invisible");
    $("#img-" + planta.idPlanta).addClass("disabled");
    $("#progrescrecimiento-" + planta.idPlanta).attr("style", "width:0%;");
    /*B-ScriptUpdatePlantaMuerta*/
});