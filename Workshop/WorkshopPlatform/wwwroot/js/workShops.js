////var data;
////var rate = "",
////    j = 0;
////var i = 0;



////function loadData() {
////    i = 0;
////    document.getElementById("workShops").innerHTML = "";

////    db.collection("workshop").orderBy("id").get().then((querySnapshot) => {
////        querySnapshot.forEach((doc) => {
////            var data = doc.data();
////            rate = "";
////            j = 0;

////            if (i % 2 == 0) {
////                tr = document.createElement('div');
////                tr.className = "row";
////            }

////            var td = document.createElement('div');
////            td.className = "col-md-6 WshopTd";

////            for (j = 0; j < parseInt(data.rate); j++)
////                rate += "<i class='fa fa-star rate'></i>"
////            if (data.rate % 1 != 0) {
////                rate += "<i class='fa fa-star-half-empty rate'></i>"
////                j++;
////            }
////            for (j; j < 5; j++)
////                rate += "<i class='fa fa-star-o rate'></i>"

////            td.innerHTML = "<div class='card '>  <div class='logo' style='background-image:" + data.icon + "'>    </div>   <div class='card-text'>   <div class='portada' style='background-image:" + data.image + "'>   </div>  <div class='title-total'>            <div class='title'>" + rate + "                             </div>  <h2>" + data.name + " </h2>    <div class='address'> " + data.address + "</div>   <div class='actions mt-auto btn'> <button onclick='load(this);' class='wsbtn' id=' " + data.id + "'> <div>Show more</div>  </button>     </div>     </div>  </div>     </div>";
////            tr.appendChild(td);
////            if (i % 2 == 1) {
////                document.getElementById("workShops").appendChild(tr);
////            }
////            i++;
////        });

////    });


////}

////loadData();

////function filterCity() {
////    i = 0;
////    rate = "";
////    j = 0;
////    var cnt = 0;
////    document.getElementById("workShops").innerHTML = "";
////    city = document.getElementById("select-box1").value;

////    db.collection("workshop").where("city", "==", city).get().then((querySnapshot) => {
////        querySnapshot.forEach((doc) => {


////            var data = doc.data();
////            rate = "";
////            j = 0;


////            if (cnt % 2 == 0) {
////                tr = document.createElement('div');
////                tr.className = "row";
////            }

////            var td = document.createElement('div');
////            td.className = "col-md-6 WshopTd";

//////            for (j = 0; j < parseInt(data.rate); j++)
//////                rate += "<i class='fa fa-star rate'></i>"
//////            if (data.rate % 1 != 0) {
//////                rate += "<i class='fa fa-star-half-empty rate'></i>"
//////                j++;
////            }
////            for (j; j < 5; j++)
////                rate += "<i class='fa fa-star-o rate'></i>"

////            td.innerHTML = "  <div class='card'>   <div class='logo' style='background-image:" + data.icon + "'>    </div>   <div class='card-text'>   <div  class='portada' style='background-image:" + data.image + "'>   </div>  <div class='title-total'>  <div class='title'>" + rate + " </div>  <h2>" + data.name + " </h2>    <div class='address'> " + data.address + "</div>  <div class='actions mt-auto btn'>    <button class='wsbtn' onclick='load(this);' id='" + data.id + " .btn'><div  >Show more</div></button>     </div>     </div>  </div>     </div>    ";

////            tr.appendChild(td);
////            if (cnt % 2 == 1) {
////                document.getElementById("workShops").appendChild(tr);
////            }

////            cnt++;

////            i++;
////        });
////    });

////}



////function filterLoction() {
////    rate = "";
////    i = 0;
////    j = 0;
////    var cnt = 0;
////    document.getElementById("workShops").innerHTML = "";
////    loc = document.getElementById("select-box2").value;

////    db.collection("workshop").where("location", "==", loc).get().then((querySnapshot) => {
////        querySnapshot.forEach((doc) => {

////            var data = doc.data();
////            rate = "";
////            j = 0;

////            if (cnt % 2 == 0) {
////                tr = document.createElement('div');
////                tr.className = "row";
////            }

////            var td = document.createElement('div');
////            td.className = "col-md-6 WshopTd";

////            for (j = 0; j < parseInt(data.rate); j++)
////                rate += "<i class='fa fa-star rate'></i>"
////            if (data.rate % 1 != 0) {
////                rate += "<i class='fa fa-star-half-empty rate'></i>"
////                j++;
////            }
////            for (j; j < 5; j++)
////                rate += "<i class='fa fa-star-o rate'></i>"

////            td.innerHTML = "  <div class='card'>   <div class='logo' style='background-image:" + data.icon + "'>    </div>   <div class='card-text'>   <div  class='portada' style='background-image:" + data.image + "'>   </div>  <div class='title-total'>  <div class='title'>" + rate + " </div>  <h2>" + data.name + " </h2>    <div class='address'> " + data.address + "</div>  <div class='actions mt-auto btn'>    <button class='wsbtn' onclick='load(this);' id='" + data.id + "'><div  >Show more</div></button>     </div>     </div>  </div>     </div>    ";
////            tr.appendChild(td);

////            document.getElementById("workShops").appendChild(tr);

////            cnt++;
////        });
////    });

    // readTextFile("Data.json", function (text) {
    // });
}


// db.collection("workshop").get().then((querySnapshot) => {
//   querySnapshot.forEach((doc) => {
//     console.log(`${doc.id} => ${JSON.stringify(doc.data())}`);
//   });
// });