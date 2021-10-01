
let buttons = document.querySelectorAll('button');

let label = document.getElementById("result");

let equalButton = document.getElementById("equal");

let resetButton = document.getElementById("reset")



buttons.forEach(function(btn) {
    btn.addEventListener('click', function (e){
        if(btn.textContent.trim() == 'delete') {
            remove()
        } else {
            if(isNaN(parseInt(label.textContent.toString()[label.textContent.toString().length - 1])) && isNaN(parseInt((btn.textContent.toString().trim())))) {

            } else {
                label.innerText += btn.textContent.trim();
            }
            if (label.textContent === "0") {
                label.innerText = "";
            }
        }

    })
})

equalButton.addEventListener('click', function () {
    equal();
})

resetButton.addEventListener('click', function () {
    label.innerText = "";
})

document.addEventListener('keydown', function(event) {
    console.log(event.key)
    if (checkKey(event.key)) {
        if (event.key == '=' || event.key == 'Enter') {
            equal(event.key);
        } else if(event.key == 'Backspace') {
            remove()
        } else {
            if(isNaN(parseInt(label.textContent.toString()[label.textContent.toString().length - 1]))
                && isNaN(parseInt((event.key.toString().trim())))) {

            } else {
                label.innerText += event.key;
            }

            if (label.textContent === "0") {
                label.innerText = "";
            }
        }
    }
});

function checkKey(key) {
    return (key >= '0' && key <= '9') || key == '+' || key == '-' || key == '/' || key == '%' ||
        key == '*' || key == '=' || key == 'Backspace' || key == 'Enter';
}

function equal(key) {
    if(label.textContent != "" && key == 'Enter') {
        label.innerText = eval(label.textContent.trim());
    } else if (label.textContent != "") {
        if(label.textContent[label.textContent.toString().length - 1] == '=') {
            remove()
        }
        label.innerText = eval(label.textContent.trim());
    }
}

function remove() {
    label.innerText = label.textContent.substring(0, label.textContent.length - 1)
}
