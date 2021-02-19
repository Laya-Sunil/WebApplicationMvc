$(document).ready(function () {
    alert("Hello");
});

function validate() {
    alert('java script');
    var mail = document.forms["register-form"]["EmailId"].value;
    var name = document.getElementById("uname").value;
    var nameRegex = /(^[A-Z][a-z]{3,9}$)/;
    // Name Validating
    if (!name.match(mailRegex)) {
        alert("Invalid name");
        return false;
    }
    var mailRegex = /[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]+/;
    if (mail.match(mailRegex)) {
        alert("Mail Id accepted");
    }
    else
        {
            alert("Invalid mail id");
            return false;
        }
};