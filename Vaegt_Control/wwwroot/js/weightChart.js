window.weightChartInterop = {
    chartInstances: {},

    renderChart: function (canvasId, labels, actualData, expectedData) {
        const canvas = document.getElementById(canvasId);
        if (!canvas) return;

        const ctx = canvas.getContext("2d");

        if (this.chartInstances[canvasId]) {
            this.chartInstances[canvasId].destroy();
        }

        const datasets = [
            {
                label: "Faktisk vægt",
                data: actualData,
                borderColor: "#2563eb",
                backgroundColor: "#2563eb",
                tension: 0.25,
                borderWidth: 3,
                pointRadius: 4,
                pointHoverRadius: 6
            }
        ];

        if (expectedData && expectedData.length > 0) {
            datasets.push({
                label: "Forventet kurve",
                data: expectedData,
                borderColor: "#f59e0b",
                backgroundColor: "#f59e0b",
                tension: 0.25,
                borderWidth: 3,
                borderDash: [8, 6],
                pointRadius: 3,
                pointHoverRadius: 5
            });
        }

        this.chartInstances[canvasId] = new Chart(ctx, {
            type: "line",
            data: {
                labels: labels,
                datasets: datasets
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                interaction: {
                    mode: "index",
                    intersect: false
                },
                plugins: {
                    legend: {
                        position: "top"
                    },
                    tooltip: {
                        callbacks: {
                            label: function (context) {
                                return `${context.dataset.label}: ${context.parsed.y} kg`;
                            }
                        }
                    }
                },
                scales: {
                    y: {
                        title: {
                            display: true,
                            text: "Kg"
                        }
                    },
                    x: {
                        title: {
                            display: true,
                            text: "Dato"
                        }
                    }
                }
            }
        });
    }
};