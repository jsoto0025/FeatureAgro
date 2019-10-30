"use strict";

connection.on("updateTemperatura", function (temperatura) {

    if (chartObjTemperatura && temperatura.modulo === chartObjModulo) {
        if (!chartObjTemperatura.data.labels.includes(temperatura.fecha)) {
            chartObjTemperatura.data.labels.push(temperatura.fecha);
            chartObjTemperatura.data.datasets[0].data.push(temperatura.medida);
            chartObjTemperatura.data.labels.shift();
            chartObjTemperatura.data.datasets[0].data.shift();
            chartObjTemperatura.update();
        }
    }
});
