
new Chart(document.getElementById("ChartTemperatura"), {
    type: 'line',
    data: chartDataTemperatura,
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: false,
                    min: 0,
                    max: 30
                }
            }]
        },
        legend: {
            padding: 15
        }
    }
});