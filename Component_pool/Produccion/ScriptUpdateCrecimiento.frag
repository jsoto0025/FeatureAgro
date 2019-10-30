Fragment Produccion_ScriptUpdateCrecimiento {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: ScriptUpdateCrecimiento
	Destinations: Crecimiento_CrecimientoJS
	SourceCode: [ALTERCODE-FRAG]				
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
	[/ALTERCODE-FRAG]
}
