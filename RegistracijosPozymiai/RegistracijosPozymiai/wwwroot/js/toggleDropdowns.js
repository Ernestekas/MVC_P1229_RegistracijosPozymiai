function toggleDropDowns() {
    let allDropDowns = document.getElementsByTagName("select");
    for (let i = 0; i < allDropDowns.length; i++) {
        if (allDropDowns[i].disabled === true) {
            allDropDowns[i].disabled = false;
        }
        else {
            allDropDowns[i].disabled = true;
        }
    }
}