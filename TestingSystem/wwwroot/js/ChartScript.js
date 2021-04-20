
var cats = document.getElementsByClassName('cat');
var catArr = [];

fLen = cats.length;
for (i = 0; i < fLen; i++) {
    catArr.push(cats[i].innerText);
}

var overall = document.getElementsByClassName('overall');
var arr = []; 

oLen = overall.length;
for (i = 0; i < oLen; i++) {
    arr.push(parseInt(overall[i].innerText));
}

var ctx = document.getElementById('myChart').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'radar',
    data: {
        labels: catArr,
        datasets: [{
            label: 'Overall',
            data: arr,
            borderColor: 'rgb(255, 99, 132)',
            backgroundColor: 'rgba(255, 99, 132, 0.2)',
            order: 2,
            borderWidth: 3
        },
        {
            label: 'Goal',
            data: [70, 85, 75, 95, 85],
            borderColor: 'rgb(54, 162, 235)',
            backgroundColor: 'rgba(54, 162, 235, 0.2)',
            order: 1,
            borderWidth: 3
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


var ctx = document.getElementById('myChart2').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: catArr,
        datasets: [{
            label: 'Overall',
            data: arr,
            backgroundColor: 'rgba(255, 99, 132, 0.2)',
            borderColor: 'rgb(255, 99, 132)',
            order: 2,
            borderWidth: 2
        },
        {
            label: 'Goal',
            data: [70, 85, 75, 95, 85],
            type: 'line',
            borderColor: 'rgb(54, 162, 235)',
            backgroundColor: 'rgba(54, 162, 235, 0.2)',
            order: 1,
            borderWidth: 2
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});