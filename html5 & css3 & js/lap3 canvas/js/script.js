window.addEventListener('load', doitfirst);
function doitfirst(){
    //canvas 
    mycanvas = document.getElementById("mycanvas");
    mycontext = mycanvas.getContext('2d');
    mycanvas.width = window.innerWidth;
    mycanvas.height = window.innerHeight;
    // registeration for canvas events
    //mycanvas.addEventListener('mousedown', drawcircle)
    isdrawable = false;
    mycanvas.addEventListener('mousemove', drawcircle)
    mycanvas.addEventListener('mousedown', enabledrawing);
    mycanvas.addEventListener('mouseup', disabledrawing);
    let downloadImg=document.querySelector(".download");

    downloadImg.addEventListener("click",(e)=>{
        e.target.href=mycanvas.toDataURL()
        e.target.download = "download-this-canvas"
    })

    

    //radius
    radius = 10;
    incre = document.getElementById('incre');
    decre = document.getElementById('decre');
    radiusvalue = document.getElementById('radiusvalue');
    incre.addEventListener('click' , increaseradius);
    decre.addEventListener('click' , decreaseradius);


    //save
    //colors
//     allcolors = document.querySelectorAll('.colors');
//     for( var i = 0; i < allcolors.length; i ++){
//         allcolors[i].addEventListener('click', changecolor);
//         if(allcolors[i].style.backgroundColor == localStorage.getItem('selectedcolor')){
//             allcolors[i].className += ' active ';
//             mycontext.fillStyle = allcolors[i].style.backgroundColor;
//         }
//     }
// }// end load
   colorsbar = document.getElementById('colorsbar');
   allcolors = ['red' , 'green' , 'blue' , 'pink' , 'orange' , 'cyan' , 'magenta' , 'purple' , 'lightgoldenrodyellow' , 'hotpink'] ;
   for (var i = 0; i < allcolors.length; i++ ){
    createddiv = document.createElement('div');
    createddiv.style.backgroundColor = allcolors[i];
    createddiv.addEventListener('click' , changecolor);
    createddiv.className = 'colors';
    if(allcolors[i] == localStorage.getItem('selectedcolor')){
                createddiv.className += ' active ';
               mycontext.fillStyle = allcolors[i];
         }
         colorsbar.appendChild(createddiv);
   }

function changecolor(e){
    oldselectedcolor = document.getElementsByClassName('active')[0];
    if(oldselectedcolor != null)
    oldselectedcolor.className = 'colors';
    newclickedone = e.target;
    newclickedone.className += ' active ';
    mycontext.fillStyle = newclickedone.style.backgroundColor;
    localStorage.setItem('selectedcolor', newclickedone.style.backgroundColor);

}
function increaseradius(){
    radius++;
    checkradius(radius);
}
function decreaseradius(){
    radius--;
    checkradius(radius);
}
function checkradius(newradius){
    if(newradius > 50)
    newradius = 50;
    else if(newradius < 10)
    newradius = 10;
    radius = newradius;
    radiusvalue.innerText = radius;
}
function enabledrawing(){
    isdrawable = true;

}
function disabledrawing(){
    isdrawable = false;

}

function drawcircle(e){
    if(isdrawable){
    mycontext.beginPath();
    console.log('goooo')
    mycontext.arc(e.clientX, e.clientY, radius , 0 , Math.PI * 2);
    mycontext.fill();
    mycontext.closePath();
    }

}


}