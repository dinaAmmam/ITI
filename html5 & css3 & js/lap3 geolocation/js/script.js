window.addEventListener('load', function(){
    //select globally map
    mymap = this.document.getElementById("map");
    details = document.getElementById("details-map");

}); //end of load

function getloactionfun() {
    // 1- check exience
    if (navigator.geolocation) {
        // exist
        // 2- get permission  : using method getCurrentPosition(successCallback,errorcallback);
        navigator.geolocation.getCurrentPosition(getposition, errorhandler);

    } else {
        //not exist
        mymap.innerText = "Update Your Browser And Try Again !";
    }
}

function getposition(position) {

    details.style.display = "none";
    mymap.style.display = "block";
    lat = position.coords.latitude;
    lon = position.coords.longitude;

    var location = new google.maps.LatLng(lat, lon);
    //2- specify specs of map : zoom : , center
    var specs = { zoom: 17, center: location };
    // 3 retrive map and display map
    new google.maps.Map(mymap, specs);

    var myLatlng = new google.maps.LatLng(lat,lon);
    var mapOptions = {
    zoom: 17,
    center: myLatlng
    }
    var map = new google.maps.Map(document.getElementById("map"), mapOptions);

    var marker = new google.maps.Marker({
        position: myLatlng,
        title:"Hello World!"
    });

// To add the marker to the map, call setMap();
marker.setMap(map)

}


function getDetails() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(getData, errorhandler);

    } else {

        map.innerText = "Update Your Browser And Try Again !!!!!";
    }
}
function getData(e) {
    mymap.style.display = "none";
    details.style.display = "flex";

    let lat = e.coords.latitude;
    let lon = e.coords.longitude;
    let accuracy = e.coords.accuracy;
    let timestamp = new Date(e.timestamp).toLocaleString();

    details.querySelector('input:nth-of-type(1)').value = lat;
    details.querySelector('input:nth-of-type(2)').value = lon;
    details.querySelector('input:nth-of-type(3)').value = accuracy;
    details.querySelector('input:nth-of-type(4)').value = timestamp;
}
function errorhandler() {
    alert("Error");
}
