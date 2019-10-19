"use strict";

connection.on("updateLuminosidad", function (luminosidad) {

    if (chartObjLuminosidad && luminosidad.modulo === chartObjModulo) {
        if (!chartObjLuminosidad.data.labels.includes(luminosidad.fecha)) {
            chartObjLuminosidad.data.labels.push(luminosidad.fecha);
            chartObjLuminosidad.data.datasets[0].data.push(luminosidad.medida);
            chartObjLuminosidad.data.labels.shift();
            chartObjLuminosidad.data.datasets[0].data.shift();
            chartObjLuminosidad.update();
        }
    }
});
