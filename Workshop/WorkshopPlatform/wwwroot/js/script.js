////var done;
////var url = window.location.href;
////post = () => {
////    var review = $("#txtArea").val();
////    var rate = starValue;
////    var id = url.substring(url.lastIndexOf('/') + 1);
////    var obj = {
////        Review: review,
////        Rate: rate,
////        WorkShopId: id
////    };
////    $.ajax({
////        url: "/WorkShops/userrate",
////        type: "POST",
////        //dataType: "json",
////        data: obj,
////        success: function (data) {
////            //data = JSON.parse(data)
////            //alert(data);
////        },
////        error: function (err) {
////            console.log(err);
////        }
////    })

////    console.log(starValue);
////}
////AddServices = () => {
////    var service = document.getElementById("warshaService").value;
////    var price = document.getElementById("servicePrice").value;
////    var thanking = document.getElementById("Thanks")

////    if (service && price && price > 0) {
////        var LInode = document.createElement("li");
////        LInode.dataset.target = "#demo";
////        LInode.className = "Warshacircle";
////        LInode.setAttribute('data-slide-to', 3);
////        document.getElementById("serviceList").appendChild(LInode);
////        var service_price = document.getElementById("service_price");
////        var carousalITem = document.createElement("div");
////        carousalITem.classList.add('WarshaCurosal', 'carousel-item');

////        var cardeck = document.createElement("div");
////        cardeck.className = "card-deck";
////        carousalITem.appendChild(cardeck);

////        var cardService = document.createElement("div");
////        cardService.classList.add('card', 'cardService')

////        cardeck.appendChild(cardService);

////        var cardBody = document.createElement("div");
////        cardBody.classList.add('card-body', 'text-center');
////        //span in awl div
////        var serviceNameSpan = document.createElement("span");
////        var srvNameNode = document.createTextNode(service);

////        serviceNameSpan.classList.add('serviceName');
////        serviceNameSpan.appendChild(srvNameNode);

////        var priceSpan = document.createElement('span');
////        var priceNode = document.createTextNode(price);
////        priceSpan.className = "price";
////        var br = document.createElement('br');
////        var br2 = document.createElement('br');
////        var br3 = document.createElement('br');
////        var br4 = document.createElement('br');

////        var sup = document.createElement('sup');
////        var supvalue = document.createTextNode("$");
////        sup.appendChild(supvalue);
////        sup.style.color = "#064acb";
////        priceSpan.appendChild(priceNode);

////        var serviceImage = document.createElement('img');
////        serviceImage.src = 'assets/images/pexels-photo-2244746.jpeg';
////        serviceImage.classList.add('img-thumbnail', 'priceImage');

////        var servicebutton = document.createElement('button');

////        servicebutton.classList.add('btn', 'btn-secondary', 'AddToCard', 'row');
////        servicebutton.innerHTML = "Edit Service";
////        cardBody.appendChild(serviceNameSpan);
////        cardBody.appendChild(br);
////        cardBody.appendChild(sup)
////        cardBody.appendChild(priceSpan);
////        cardBody.appendChild(br2);
////        cardBody.appendChild(serviceImage);
////        cardBody.appendChild(br3);
////        cardBody.appendChild(br4);
////        cardBody.appendChild(servicebutton);

////        cardService.appendChild(cardBody);

////        service_price.appendChild(carousalITem);
////        thanking.innerHTML = "Service added successfully";
////        document.getElementById("warshaService").readOnly = true;
////        document.getElementById("servicePrice").readOnly = true;
////    }
////    else {
////        thanking.innerHTML = "Please add service and price";
////    }
////}

////let star = document.querySelectorAll('.star');
////let showValue = document.querySelector('#rating-value');
////console.log(star.length);
////var starValue;
////for (let i = 0; i < star.length; i++) {
////    star[i].addEventListener('click', function () {
////        // i = this.value;
////        starValue = this.value;
////        console.log(starValue);
////    });
////}
//////addtocard counter
////var warshaCount = 0;

////function warshaCounte() {
////    warshaCount += 1;

////    document.getElementById("warshaBadge").innerHTML = warshaCount;
////}

////function SubmitForm() {
////    var obj = {
////        Review: $("#txtArea").val(),
////        rate: $(starValue)
////    };
////    $.ajax({
////        url: "/WorkShops/UserRate",
////        type: "POST",
////        //dataType: "json",
////        data: obj,
////        success: function (data) {
////            alert(data);
////        },
////        error: function (err) {
////            console.log(err);
////        }
////    })
////}