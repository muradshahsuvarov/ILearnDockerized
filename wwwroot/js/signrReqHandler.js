var connection = new signalR.HubConnectionBuilder()
    .withUrl('/User/OpenChat')
    .build();

connection.on('receiveMessage', addMessageToChat); // Sends empty message to addMessageToChat

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('SendMessage', message)
}