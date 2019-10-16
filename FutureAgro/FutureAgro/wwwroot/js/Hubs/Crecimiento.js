"use strict";

connection.on("updateCrecimiento", function (planta) {
    $("#divCrecimiento-" + planta.idPlanta).text(planta.crecimiento + "%");
    $("#progrescrecimiento-" + planta.idPlanta).attr("style", "width:" + planta.crecimiento + "%;");

    var color = planta.crecimiento <= 20 ? "light" : planta.crecimiento <= 40 ? "info" : planta.crecimiento <= 60 ? "success" : planta.crecimiento <= 80 ? "warning" : "danger";
    var spanProduccion = $("#spanTiempoProduccion-" + planta.idPlanta);
    spanProduccion.removeClass(spanProduccion.attr("class"));
    spanProduccion.addClass("badge badge-" + color);

    var semanas = (planta.crecimiento * 0.05);
    if (semanas >= 5) {
        spanProduccion.text("Cosechar");
        semanas = 5;
    } else {
        spanProduccion.text(Math.round((5 - semanas) * 10) / 10 + " Semanas");
    }
});