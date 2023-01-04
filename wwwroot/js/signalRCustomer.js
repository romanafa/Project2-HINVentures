"use strict";
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.start().then(function() {

    console.log("connected");
});


function updateClients()
{
    connection.invoke("SendAssignment").catch(function (err) {
        return console.error(err.toString());
    });

    //todo get user... get title, description and message...
    //var title = document.getElementById("title").value;
    //var description = document.getElementById("description").value;
    //var customer = document.getElementById("customer").value;


   

    // "customer", "title", "description"
};
