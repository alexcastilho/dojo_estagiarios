$(document).ready(function () {
    $("#btnAdd").click(addTask);
});

function addTask() {
    var description = $("#txtDescription").val();
    $.ajax("http://localhost:58294/Home/Add/?description=" + description).done(function (data) {
        $("#grdTask").html(data);
    });
}

function doneTask(button, id){

    $.ajax("http://localhost:58294/Home/Done/?Id=" + id).done(function (data) {
        updateGrid(data);
    });
}

function undoTask(button, id) {
    
    $.ajax("http://localhost:58294/Home/Undo/?Id=" + id);

}

function deleteTask(button, id) {
    $.ajax("http://localhost:58294/Home/Delete/?Id=" + id);
}

function updateGrid(data) {
    $("#grdTask").html(data);
}