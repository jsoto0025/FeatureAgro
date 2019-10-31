
var chLine = document.getElementById("ChartHumedad");

if (chLine) {
    var chartObjHumedad = new Chart(chLine, {
        type: 'line',
        data: chartDataHumedad,
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: false
                    }
                }]
            },
            legend: {
                padding: 15
            }
        }
    });
}