/*window.addEventListener('load', function(){
    email_to_show = document.getElementById('email');
    pass_to_show = document.getElementById('pass');
    entered_email = document.getElementById('exampleInputEmail1').value;
    entered_pass = this.document.getElementById('exampleInputPassword1').value




}); //end of load
function show(){
    email_to_show.innertext = entered_email;
    pass_to_show.innertext= entered_pass;
}*/



function show() {
    let email_to_show = document.getElementById('email');
    let pass_to_show = document.getElementById('pass');
    
    let entered_email = document.getElementById('exampleInputEmail1').value;
    let entered_pass = document.getElementById('exampleInputPassword1').value;

    email_to_show.innerHTML = entered_email;
    pass_to_show.innerHTML = entered_pass;
    return false;
}