
new Chart(document.getElementById("ChartHumedad"), {
    type: 'line',
    data: chartDataHumedad,
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: false,
                    min: 0,
                    max: 80
                }
            }]
        },
        legend: {
            padding: 15
        }
    }
});