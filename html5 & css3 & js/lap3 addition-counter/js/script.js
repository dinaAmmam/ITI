
function calculateAddition() {
    var addend1 = parseInt(document.getElementById("addend1").value);
    var addend2 = parseInt(document.getElementById("addend2").value);
    var result = addend1 + addend2;
    document.getElementById("additionResult").innerHTML = result;
}

function calculateMultiplication() {
    var factor1 = parseInt(document.getElementById("factor1").value);
    var factor2 = parseInt(document.getElementById("factor2").value);
    var result = factor1 * factor2;
    document.getElementById("multiplicationResult").innerHTML = result;
}

document.getElementById("addend1").addEventListener("input", calculateAddition);
document.getElementById("addend2").addEventListener("input", calculateAddition);
document.getElementById("factor1").addEventListener("input", calculateMultiplication);
document.getElementById("factor2").addEventListener("input", calculateMultiplication);

calculateAddition();
calculateMultiplication();