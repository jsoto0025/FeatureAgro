var colors = ['#007bff', '#28a745', '#333333', '#c3e6cb', '#dc3545', '#6c757d', 'lightblue'];

//var chLine = document.getElementById("ChartTemperatura");
//var chartData = {
//    labels: ["L", "M", "W", "J", "V", "S", "D"],
//    datasets: [
//    {
//        label: "Temperatura",
//        data: [19.5, 23, 19, 19.5, 19.5, 20, 23],
//        backgroundColor: "antiquewhite",
//        borderColor: "INDIANRED",
//        borderWidth: 1,
//        pointBackgroundColor: "INDIANRED"
//    }]
//};


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

var chartData = {
    labels: ["L", "M", "W", "J", "V", "S", "D"],
    datasets: [
    {
        label: "Cosecha",
        data: [50, 30, 60, 10, 80, 90, 5,5,5,5,5,5,5],
        backgroundColor: "Lightgreen",
        borderColor: colors[1],
        borderWidth: 1,
        pointBackgroundColor: colors[1]
    }]
};

new Chart(document.getElementById("ChartCosecha"), {
    type: 'line',
    data: chartData,
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: false,
                    min: 100,
                    max: 0
                }
            }]
        },
        legend: {
            padding: 15
        }
    }
});