var imagearr = ["1.jpg", "2.jpg" , "3.jpg" , "4.jpg" , "5.jpg" , "6.jpg"] ;
var pos = 0;
function startshow() {
    t=setInterval("nextimg()", 1000);
}
function nextimg() {
    pos++;
    if (pos >= imagearr.length) pos = 0;
    myimg.src= imagearr[pos];
}
function previmg() {
    pos--;
    if (pos < 0) pos = imagearr.length-1;
    myimg.src = imagearr[pos];
}
function stopshow() {
    clearInterval(t);
}
function removefocus(){
    document.activeElement.blur();
}
function stop(){
    

}