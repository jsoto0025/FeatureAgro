"use strict";

connection.on("updateHumedad", function (humedad) {

    if (chartObjHumedad && humedad.modulo === chartObjModulo) {
        if (!chartObjHumedad.data.labels.includes(humedad.fecha)) {
            chartObjHumedad.data.labels.push(humedad.fecha);
            chartObjHumedad.data.datasets[0].data.push(humedad.medida);
            chartObjHumedad.data.labels.shift();
            chartObjHumedad.data.datasets[0].data.shift();
            chartObjHumedad.update();
        }
    }
});
