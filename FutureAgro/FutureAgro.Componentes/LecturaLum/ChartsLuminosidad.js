
var chLine = document.getElementById("ChartLuminosidad");

if (chLine) {
    var chartObjLuminosidad = new Chart(chLine, {
        type: 'line',
        data: chartDataLuminosidad,
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