
class Message {
    constructor(text, UserId) {  /*, when*//*, UserId*/
        this.UserId = UserId;
        this.text = text;
        
    }
}
const username = userName;
const textInput = document.getElementById('messageText');
const chat = document.getElementById('chat');
const chatting = document.getElementById('chatting');

const messagesQueue = [];


function clearInputField() {
    const textInput = document.getElementById('messageText');

    messagesQueue.push(textInput.value);
    textInput.value = "";
}

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() == "") return;
    debugger;
    let message = new Message(text, UserId);
    sendMessageToHub(message);
}

function addMessageToChat(message) {
    let isCurrentUserMessage = message.userId === UserId;
    let container = document.createElement('div');
    container.className = isCurrentUserMessage ? "sender" : "receiver";

    let sender = document.createElement('p');
   
    sender.innerHTML = userName;
    let text = document.createElement('p');
    text.innerHTML = message.text;
    debugger;
    let when = document.createElement('span');
    
    var currentdate = new Date();
    when.innerHTML =
         currentdate.toLocaleString('en-US'), { hour: 'numeric', minute: 'numeric' }
    
    debugger;
    
    if (isCurrentUserMessage == false) {
       
        container.style.marginLeft = "auto";
    container.style.marginRight = "1.5em";

    }
    else {
        container.style.marginLeft = "1.5em";

    }
    container.classList.add("chat");
    container.style.padding = "10px";
    container.appendChild(text);
    container.appendChild(when);    
    chat.appendChild(container);
    container.focus();

}