var child;
function openchildfun(){
    child= open("childwindow.html", "", "width=300,height=400")
}
scroller =0;

function scrollbyfun() {
     
    child.scrollBy(0, 50);
    scroller +=1;
}
document.write(scroller);
function closechildfun() {
    if(child.x == 0){
        child.close();
    }
  }
  function starttimer() {
    t=setInterval("scrollbyfun()", 1000);
    child.t
}