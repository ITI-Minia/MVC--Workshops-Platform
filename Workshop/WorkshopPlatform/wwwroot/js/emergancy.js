var data;
var rate = "",
    j = 0,
    i = 0;
localStorage.setItem('location2', 'giza')

var firebaseConfig = {
    apiKey: "AIzaSyAC0G0nvAK7KbKx2qgkyGJ16jORzlzyE-Y",
    authDomain: "carworkshop-7ec37.firebaseapp.com",
    databaseURL: "https://carworkshop-7ec37-default-rtdb.firebaseio.com",
    projectId: "carworkshop-7ec37",
    storageBucket: "carworkshop-7ec37.appspot.com",
    messagingSenderId: "640153744311",
    appId: "1:640153744311:web:27c8a4e0fe189c40136e32",
    measurementId: "G-641RNWK139"
};

// Initialize Firebase;
firebase.initializeApp(firebaseConfig);
var db = firebase.firestore();
var anlaytics = firebase.analytics();


function loadData() {
    rate = "";
    i = 0;
    j = 0;
    var cnt = 0;
    document.getElementById("workShops").innerHTML = "";
    var loc = location.href.split('=');
    loc = loc[1];

    db.collection("workshop").where("location", "==", loc).get().then((querySnapshot) => {
        querySnapshot.forEach((doc) => {
            var data = doc.data();
            rate = "";
            j = 0;
            tr = document.createElement('div');
            tr.className = "row";
            var td = document.createElement('div');
            td.className = "col-md-12 WshopTd";

            for (j = 0; j < parseInt(data.rate); j++)
                rate += "<i class='fa fa-star rate'></i>"
            if (data.rate % 1 != 0) {
                rate += "<i class='fa fa-star-half-empty rate'></i>"
                j++;
            }
            for (j; j < 5; j++)
                rate += "<i class='fa fa-star-o rate'></i>"

            td.innerHTML = "  <div class='card' style = ' max-width: 90% !important;'>   <div class='logo' style='background-image:" + data.icon + "'>  </div>   <div class='card-text'>   <div  class='portada' style='background-image:" + data.image + "'>   </div>  <div class='title-total'>  <div class='title'>" + rate + " </div><div class='row'> <div class='col-sm-6 pleft'>  <h2>" + data.name + " </h2>   <div class='address' ><i class='fas fa-building icolor'> </i> &nbsp; " + data.address + "</div> <div class='phone' > <i class='fas  fa-mobile-alt	 icolor'> </i> &nbsp;" + data.phonenumber + "</div> </div> <div class='col-sm-6 rcorner'> <br>  <div> <i class='fas  fa-snowplow	 icolor'> </i> &nbsp; Winch service   </div>  <div> <i class='fas  fa-mobile-alt	 icolor'> </i> &nbsp;  &nbsp; Urgent <span> immediate </span>maintenance  service  </div>  </div>     </div>  </div>     </div>    ";

            tr.appendChild(td);

            document.getElementById("workShops").appendChild(tr);
            cnt++;
            i++;
        });
    });

}

loadData();

console.log(localStorage);