// Autopopulate years on sign-up page
function generateUserBirthYears() {
    var birthYearSelect = document.getElementById("birthYear");
    var year = new Date().getFullYear();

    while (year > 1925) {
        var option = document.createElement("option");
        option.text = year;
        option.value = year;
        birthYearSelect.appendChild(option);
        year--;
    }
}