
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.start().then(function() {

    console.log("connected");
});


connection.on("ReceiveAssignments", function () {

    var url = window.location.href.toString();
    var arr = url.split("/");
    var _string = arr[arr.length - 1];
    
    swal("Nytt oppdrag registrert!", "En kunde har registrert et nytt oppdrag. Du finner oppdraget under menypunkt: Velg oppdrag", "info");

    if (_string === "Assignments") {
        $(document.location.reload());
    }


});


