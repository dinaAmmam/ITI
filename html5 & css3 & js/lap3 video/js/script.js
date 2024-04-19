window.addEventListener('load', function(){
    myvideo = this.document.getElementById('myvideo');
    myvideo.addEventListener('click' , playpausefun);
    myvideo.addEventListener('dblclick' , fullscreenfun)
    let buttons = document.querySelectorAll('#controls input[type="button"]');
    let videoList= ['videos/2.mp4','videos/3.mp4','videos/5.mp4','videos/6.mp4']
    for (let i = 0; i < buttons.length; i++) {
        buttons[i].addEventListener('click', function () {
            playVideo(videoList[i]);
        });
    }
    
}); //end load function

function playpausefun(){
    /* myvideo.play();*/
    if (myvideo.paused) {
        myvideo.play();
    } else {
        myvideo.pause();
    }
}

function fullscreenfun(){
    myvideo.requestFullscreen();
}


function playVideo(videoSrc) {
myvideo.src =  videoSrc;
myvideo.load();
myvideo.play();
}