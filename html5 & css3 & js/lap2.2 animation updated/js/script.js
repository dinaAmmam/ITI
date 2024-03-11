/*document.addEventListener('DOMContentLoaded', function () {
    const square = document.querySelector('.square');
    const startBtn = document.getElementById('btn1');
    const stopBtn = document.getElementById('btn2');
    
    
    let animationPaused = true;

    function startanimation() {
        if(animationPaused == true){
            square.style.animationPlayState = 'running';
            animationPaused = false;
        }   
    }
    function stopanimation(){
        if(animationPaused == false){
            square.style.animationPlayState = 'paused';
            animationPaused=true;
        }
    }

    startBtn.addEventListener('click', startanimation);

    stopBtn.addEventListener('click', stopanimation);
});*/
document.addEventListener('DOMContentLoaded', function () {
    const square = document.querySelector('.square');
    const startBtn = document.getElementById('btn1');
    const stopBtn = document.getElementById('btn2');

    let animationPaused = true;

    function toggleAnimation(e) {
        if (animationPaused && e.target == startBtn) {
            square.style.animationPlayState = 'running';
            animationPaused = false;
        } else if (!animationPaused && e.target == stopBtn) {
            square.style.animationPlayState = 'paused';
            animationPaused = true;
        }
    }


    startBtn.addEventListener('click', toggleAnimation);
    stopBtn.addEventListener('click', toggleAnimation);


});