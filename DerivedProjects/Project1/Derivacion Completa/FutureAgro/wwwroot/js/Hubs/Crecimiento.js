"use strict";

connection.on("updateCrecimiento", function (planta) {

    var crecimiento = planta.porcentajeCrecimiento;

    $("#divCrecimiento-" + planta.idPlanta).text(crecimiento + "%");
    $("#progrescrecimiento-" + planta.idPlanta).attr("style", "width:" + crecimiento + "%;");

    /*B-ScriptUpdateCrecimiento*/

/*Code injected by: Produccion_ScriptUpdateCrecimiento*/
var color = crecimiento <= 20 ? "light" : crecimiento <= 40 ? "info" : crecimiento <= 60 ? "success" : crecimiento < 100 ? "warning" : "danger";
		var spanProduccion = $("#spanTiempoProduccion-" + planta.idPlanta);
		spanProduccion.removeClass(spanProduccion.attr("class"));
		spanProduccion.addClass("badge badge-" + color);

		var dias = (crecimiento * 0.35);
		if (dias >= 35) {
			spanProduccion.text("Cosechar");
			dias = 35;
		} else {
			spanProduccion.text(Math.round(35 - dias) + " Días");
		}
/*Code injected by: Produccion_ScriptUpdateCrecimiento*/

});