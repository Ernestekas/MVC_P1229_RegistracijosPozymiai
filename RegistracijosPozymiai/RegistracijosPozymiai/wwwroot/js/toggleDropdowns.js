﻿function toggleDropDowns() {
    let allDropDowns = document.getElementsByTagName("select");
    let submitButton = document.getElementById("withToggle");
    let redoButton = document.getElementById("redo");

    if (submitButton.disabled === true) {
        submitButton.disabled = false;
        redoButton.disabled = false;
    }
    else {
        submitButton.disabled = true;
        redoButton.disabled = true;
    }

    for (let i = 0; i < allDropDowns.length; i++) {
        if (allDropDowns[i].disabled === true) {
            allDropDowns[i].disabled = false;
        }
        else {
            allDropDowns[i].disabled = true;
        }
    }
}