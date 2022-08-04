function checkFilled() {
    var inputVal = document.getElementById("subEmail");
    if (inputVal.value == "") {
        inputVal.style.backgroundColor = "yellow";
    }
    else{
        inputVal.style.backgroundColor = "";
    }
}

checkFilled();