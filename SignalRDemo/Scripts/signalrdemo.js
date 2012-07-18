var hub = $.connection.demoHub;

// Declare methods for the server to call ================
hub.updatePage = function (message) {
    $('#messages').append(message + '<br />');
};

// END : Declarae methods for the server to call =========

$('#send').click(function () {
    var messageToSend = $('#msg').val();
    hub.send(messageToSend);
});

$.connection.hub.start();