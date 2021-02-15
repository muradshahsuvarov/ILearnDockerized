var connection = new signalR.HubConnectionBuilder()
    .withUrl('/User/OpenChat')
    .build();

connection.on('receiveMessage', addMessageToChat); // Sends messages in every frame to addMessageToChat
connection.on('receiveMessage', checkNotifications); // Sends messages in every frame to addMessageToChat


connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('SendMessage', message) // SendMessage is a C# HUB Method in ChatHub.cs
}