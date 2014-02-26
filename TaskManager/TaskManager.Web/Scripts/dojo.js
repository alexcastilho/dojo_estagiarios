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

    $(button).parent().parent().css("background-color", "lightgreen");
    $.ajax("http://localhost:58294/Home/Done/?Id=" + id);
}

function undoTask(button, id) {
    
    $(button).parent().parent().css("background-color", "silver");
    $.ajax("http://localhost:58294/Home/Undo/?Id=" + id);

}

function deleteTask(button, id) {
    $(button).parent().parent().remove();
    $.ajax("http://localhost:58294/Home/Delete/?Id=" + id);
}