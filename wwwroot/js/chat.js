class Message {
    constructor(username, text, when) {
        this.userName = username;
        this.text = text;
        this.when = when;
    }
}

// userName is declared in razor page.
const username = userName;
const textInput = document.getElementById('messageText');
const whenInput = document.getElementById('when');
const chat = document.getElementById('chat');
const notiContainer = document.getElementById('noti_Container');
const messagesQueue = [];

document.getElementById('submitButton').addEventListener('click', () => {
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
});

function clearInputField() { // clears input field in OpenChat.cshtml
    messagesQueue.push(textInput.value);
    textInput.value = "";
}

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() === "") return;


    let when = new Date();
    let message = new Message(username, text, when);
    sendMessageToHub(message);
}


// This part is SignalR
function addMessageToChat(message) {

    let isCurrentUserMessage = message.userName === username;

    let container = document.createElement('div');
    container.className = isCurrentUserMessage ? "container darker" : "container";

    let sender = document.createElement('p');
    sender.className = "sender";
    sender.innerHTML = message.userName;
    let text = document.createElement('p');
    text.innerHTML = message.text;

    let when = document.createElement('span');
    when.className = isCurrentUserMessage ? "time-left" : "time-right";
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    container.appendChild(sender);
    container.appendChild(text);
    container.appendChild(when);

    checkNotifications();


    chat.appendChild(container);
}


function sendSubsNotif() {
    sendNotifToHub();
    window.location.href = '/User/ListOfEvents';
}

// This part is SignalR
function checkNotifications() {


    $.post('/User/GetTotalNumOfNotifsAction', function (data) {
        if (data.notifsCount > 0) {
            let container_notif = document.createElement('span');
            container_notif.className = "button__badge";

            // create text of the container_notif
            let container_notif_text = document.createTextNode("" + data.notifsCount);
            container_notif.appendChild(container_notif_text);

            notiContainer.appendChild(container_notif);
        }
    });

}