function getColor() {
    var red = ((255 * ($("#temperature").val() - 10)) / 40);
    var blue = 255 - red;

    return "rgb (" + red + ", 0, " + blue + " )";
}


$(document).ready(function () {

    drawSun();

})



function drawSun() {
    var node = document.getElementById("canvas");
    var context = node.getContext("2d");

    context.fillStyle = "yellow";
    context.strokeStyle = "yellow";
    context.beginPath();
    context.arc(node.width / 2, node.height / 2, 18, 0, 2 * Math.PI);
    context.fill();
    context.stroke();
}

/*
function drawCloud() {
    var node = document.getElementById("canvas");
    var context = node.getContext("2d");

    context.fillStyle = "yellow";
    context.strokeStyle = "yellow";
    context.beginPath();
    context.arc(node.width / 2, node.height / 2, 18, 0, 2 * Math.PI);
    context.fill();
    context.stroke();

}*/