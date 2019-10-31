var colors = ['#007bff', '#28a745', '#333333', '#c3e6cb', '#dc3545', '#6c757d', 'lightblue'];

var chartData = {
    labels: ["L", "M", "W", "J", "V", "S", "D"],
    datasets: [
        {
            label: "Cosecha",
            data: [50, 30, 60, 10, 80, 90, 5, 5, 5, 5, 5, 5, 5],
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