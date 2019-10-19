

new Chart(document.getElementById("ChartLuz"), {
    type: 'line',
    data: chartDataLuminosidad,
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: false,
                    min: 0,
                    max: 650
                }
            }]
        },
        legend: {
            padding: 15
        }
    }
});
