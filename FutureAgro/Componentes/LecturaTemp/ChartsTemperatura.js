
var chLine = document.getElementById("ChartTemperatura");

if (chLine) {
    var chartObjTemperatura = new Chart(chLine, {
        type: 'line',
        data: chartDataTemperatura,
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