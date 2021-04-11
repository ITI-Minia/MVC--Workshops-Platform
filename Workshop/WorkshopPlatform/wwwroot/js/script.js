
////////from here
var name = localStorage.getItem('firstName') + " " + localStorage.getItem('lastName');
var done;
post = () => {
    var review = document.getElementById("txtArea").value;
    var thanking = document.getElementById("Thanks")

    if (review && starValue) {
        document.getElementById("txtArea").value = "";

        thanking.innerHTML = "Thanks " + name + " For Your Review";
        var LInode = document.createElement("li");
        LInode.dataset.target = "#demo2";
        LInode.className = "Warshacircle";
        LInode.setAttribute('data-slide-to', 3);
        document.getElementById("commentsList").appendChild(LInode);

        var inp = document.getElementById("inp");

        var carousalITem = document.createElement("div");
        carousalITem.classList.add('WarshaCurosal', 'carousel-item');


        var cardeck = document.createElement("div");
        cardeck.className = "card-deck";
        carousalITem.appendChild(cardeck);

        var clientFeedbackCard = document.createElement("div");
        clientFeedbackCard.classList.add('card', 'border', 'p-3', 'clientFeedbackCard')

        cardeck.appendChild(clientFeedbackCard);


        //awl div
        var commentIconBackground = document.createElement("div");
        commentIconBackground.className = "commentIconBackground";
        //span in awl div
        var Warshaspan = document.createElement("span");
        Warshaspan.classList.add('fa', 'fa-quote-left', 'commentIcon');
        commentIconBackground.appendChild(Warshaspan);
        clientFeedbackCard.appendChild(commentIconBackground);



        //
        var flexdiv = document.createElement('div');
        flexdiv.style.display = "flex";
        flexdiv.className = "row";

        var warshImage = document.createElement('img');
        warshImage.src = 'assets/images/img_avatar3.png';
        warshImage.classList.add('mt-3', 'rounded-circle', 'clientImage', 'ml-3');
        //
        var mediaBody = document.createElement("div");
        mediaBody.classList.add('media-body', 'pl-3', 'mt-3', 'userInfo');
        //
        var WarshaH5 = document.createElement('h5');
        var nameNode = document.createTextNode(name);
        WarshaH5.className = "userName";
        WarshaH5.appendChild(nameNode);
        //
        var warshaParagraph = document.createElement('p');
        var d = new Date();
        var todayDate = d.getDate() + "/" + parseInt(d.getMonth() + 1) + "/" + d.getFullYear();
        console.log(todayDate);

        var dateNode = document.createTextNode(todayDate);

        warshaParagraph.className = "date";
        warshaParagraph.appendChild(dateNode);
        //
        mediaBody.appendChild(WarshaH5);
        mediaBody.appendChild(warshaParagraph);
        flexdiv.appendChild(warshImage);

        flexdiv.appendChild(mediaBody);

        var userComment = document.createElement('p');
        var commentNode = document.createTextNode(review);
        userComment.classList.add('pl-2', 'pt-4', 'userComment');
        userComment.appendChild(commentNode);

        clientFeedbackCard.appendChild(flexdiv);
        clientFeedbackCard.appendChild(userComment);

        inp.appendChild(carousalITem);
        done = 0;
        document.getElementById("txtArea").readOnly = true;



    }
    else if (done == 0) {

        thanking.innerHTML = "Your Review have been already Recorded";

    }
    else if (review) {
        thanking.innerHTML = "Please Rate our Services";

    }
    else if (starValue) {
        thanking.innerHTML = "Please Write your Review";

    }
    else {
        thanking.innerHTML = "Please Write your Review and Rate our Services";

    }

}
AddServices = () => {

    var service = document.getElementById("warshaService").value;
    var price = document.getElementById("servicePrice").value;
    var thanking = document.getElementById("Thanks")

if(service&&price&&price>0)
{
    var LInode = document.createElement("li");
    LInode.dataset.target = "#demo";
    LInode.className = "Warshacircle";
    LInode.setAttribute('data-slide-to', 3);
    document.getElementById("serviceList").appendChild(LInode);
    var service_price = document.getElementById("service_price");
    var carousalITem = document.createElement("div");
    carousalITem.classList.add('WarshaCurosal', 'carousel-item');


    var cardeck = document.createElement("div");
    cardeck.className = "card-deck";
    carousalITem.appendChild(cardeck);

    var cardService = document.createElement("div");
    cardService.classList.add('card', 'cardService')

    cardeck.appendChild(cardService);


    var cardBody = document.createElement("div");
    cardBody.classList.add('card-body', 'text-center');
    //span in awl div
    var serviceNameSpan = document.createElement("span");
    var srvNameNode = document.createTextNode(service);

    serviceNameSpan.classList.add('serviceName');
    serviceNameSpan.appendChild(srvNameNode);


    var priceSpan = document.createElement('span');
    var priceNode = document.createTextNode(price);
    priceSpan.className = "price";
    var br = document.createElement('br');
    var br2 = document.createElement('br');
    var br3 = document.createElement('br');
    var br4 = document.createElement('br');

    var sup = document.createElement('sup');
    var supvalue = document.createTextNode("$");
    sup.appendChild(supvalue);
    sup.style.color = "#064acb";
    priceSpan.appendChild(priceNode);

    var serviceImage = document.createElement('img');
    serviceImage.src = 'assets/images/pexels-photo-2244746.jpeg';
    serviceImage.classList.add('img-thumbnail', 'priceImage');

    var servicebutton = document.createElement('button');
    
    servicebutton.classList.add('btn','btn-secondary','AddToCard','row');
    servicebutton.innerHTML = "Edit Service"; 
    cardBody.appendChild(serviceNameSpan);
    cardBody.appendChild(br);
     cardBody.appendChild(sup)
     cardBody.appendChild(priceSpan);
      cardBody.appendChild(br2);
     cardBody.appendChild(serviceImage);
     cardBody.appendChild(br3);
     cardBody.appendChild(br4);
     cardBody.appendChild(servicebutton);

    cardService.appendChild(cardBody);

    service_price.appendChild(carousalITem);
 thanking.innerHTML="Service added successfully"   ;
 document.getElementById("warshaService").readOnly = true;
 document.getElementById("servicePrice").readOnly = true;



}
else
{
 thanking.innerHTML="Please add service and price"   ;

}
}



let star = document.querySelectorAll('.star');
let showValue = document.querySelector('#rating-value');
console.log(star.length);
var starValue;
for (let i = 0; i < star.length; i++) {
    star[i].addEventListener('click', function () {
        // i = this.value;
        starValue = this.value;
    });


}
//addtocard counter
var warshaCount = 0;

function warshaCounte() {

    warshaCount += 1;

    document.getElementById("warshaBadge").innerHTML = warshaCount;
}
