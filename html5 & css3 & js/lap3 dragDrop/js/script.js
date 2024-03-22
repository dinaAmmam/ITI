window.addEventListener('load', function(){
    top = document.getElementById("top");
    bottom = document.getElementById("bottom");
    allimgs = document.querySelectorAll("img");
    emptyspan = document.getElementById("sp");
    counter = allimgs.length;

    bottom.addEventListener('drop', dropped);
    bottom.addEventListener('dragenter', enterdrag);
    bottom.addEventListener('dragover', overdrag);
    top.addEventListener('dragleave', leavedrag);
    

    for (var i = 0; i < allimgs.length; i++) {
        allimgs[i].addEventListener('dragstart', startdrag);
        allimgs[i].addEventListener('dragend', enddrag);
        
    } //end for loop

    
}); // end of load

function startdrag(e) {
    /*console.log(e.dataTransfer.setData());*/
    //console.log(e.target.outerHTML);
    /*e.preventDefault();*/
    e.dataTransfer.setData("myimg", e.target.outerHTML);
}
function enddrag(e) {
    e.preventDefault();
    e.target.style.display = "none";
}
function dropped(e) {
    e.preventDefault();
   bottom.innerHTML+= e.dataTransfer.getData("myimg");
   counter -=1;
   if(counter ==0){
    console.log('dodoooo');
    emptyspan.innerHTML = "EMPTYYY"
    /*
    top.removeAttribute('top');
    top.setAttribute('bottom');
    bottom.removeAttribute('bottom');
    bottom.setAttribute('top');*/

    
   }



}
function overdrag(e) {
    e.preventDefault();
}
function leavedrag(e) {
    e.preventDefault();

}
function enterdrag(e) {
    e.preventDefault();
    bottom.style.backgroundColor = 'rgb(244, 213, 217)';
}