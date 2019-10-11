﻿var colors = ['#007bff', '#28a745', '#333333', '#c3e6cb', '#dc3545', '#6c757d', 'lightblue'];

var chLine = document.getElementById("ChartTemperatura");
var chartData = {
    labels: ["L", "M", "W", "J", "V", "S", "D"],
    datasets: [{
        label: "Ideal",
        data: [19.5, 19.5, 19.5, 19.5, 19.5, 19.5, 19.5],
        backgroundColor: 'transparent',
        borderColor: "Gray",
        borderWidth: 1,
        pointBackgroundColor: "Gray"
    },
        {
            label: "Promedio",
            data: [20.5, 20.5, 20.5, 20.5, 20.5, 20.5, 20.5],
            backgroundColor: "transparent",
            borderColor: colors[1],
            borderWidth: 1, 
            pointBackgroundColor: colors[1]
        },
    {
        label: "Medida",
        data: [19.5, 23, 19, 19.5, 19.5, 20, 23],
        backgroundColor: "antiquewhite",
        borderColor: "INDIANRED",
        borderWidth: 1,
        pointBackgroundColor: "INDIANRED"
        }]
};

if (chLine) {
    new Chart(chLine, {
        type: 'line',
        data: chartData,
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: false,
                        min: 15,
                        max: 25
                    }
                }]
            },
            legend: {
                padding: 15
            }
        }
    });
}





var chLine = document.getElementById("ChartHumedad");
var chartData = {
    labels: ["L", "M", "W", "J", "V", "S", "D"],
    datasets: [{
        label: "Ideal",
        data: [70, 70, 70, 70, 70, 70, 70],
        backgroundColor: 'transparent',
        borderColor: "Gray",
        borderWidth: 1,
        pointBackgroundColor: "Gray"
    },
    {
        label: "Promedio",
        data: [69, 69, 69, 69, 69, 69, 69],
        backgroundColor: "transparent",
        borderColor: colors[1],
        borderWidth: 1,
        pointBackgroundColor: colors[1]
    },
    {
        label: "Medida",
        data: [73, 72, 60, 70, 80, 65, 70],
        backgroundColor: colors[6],
        borderColor: colors[0],
        borderWidth: 1,
        pointBackgroundColor: colors[0]
    }]
};

if (chLine) {
    new Chart(chLine, {
        type: 'line',
        data: chartData,
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: false,
                        min: 50,
                        max: 100
                    }
                }]
            },
            legend: {
                padding: 15
            }
        }
    });
}





var chLine = document.getElementById("ChartLuz");
var chartData = {
    labels: ["L", "M", "W", "J", "V", "S", "D"],
    datasets: [{
        label: "Ideal",
        data: [490, 490, 490, 490, 490, 490, 490],
        backgroundColor: 'transparent',
        borderColor: "Gray",
        borderWidth: 1,
        pointBackgroundColor: "Gray"
    },
    {
        label: "Promedio",
        data: [450, 450, 450, 450, 450, 450, 450],
        backgroundColor: "transparent",
        borderColor: colors[1],
        borderWidth: 1,
        pointBackgroundColor: colors[1]
    },
    {
        label: "Medida",
        data: [450, 500, 600, 450, 400, 400, 450],
        backgroundColor: "LightYellow",
        borderColor: "Yellow",
        borderWidth: 1,
        pointBackgroundColor: "Yellow"
    }]
};

if (chLine) {
    new Chart(chLine, {
        type: 'line',
        data: chartData,
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: false,
                        min: 400,
                        max: 650
                    }
                }]
            },
            legend: {
                padding: 15
            }
        }
    });
}