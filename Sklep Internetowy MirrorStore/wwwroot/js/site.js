$(document).ready(function () {
    $("#clearButton").click(function () {
        $("input[type='text']").val('');
    });
$(document).ready(function () {
    $("form").submit(function () {
        if (!validateForm()) {
            return false;
        }
    });

    let btnClear = document.querySelector('button');
    let inputs = document.querySelector('input')
    btnClear.addEventListener('click', () => {

        inputs.forEach(input => input.value = '');
    });

    function validateForm() {
        var isValid = true;

        
        var firstName = $("#Name").val();
        var lastName = $("#Surname").val();
        if (firstName.length < 2 || lastName.length < 2) {
            alert("Imię i nazwisko muszą mieć co najmniej 2 znaki.");
            isValid = false;
        }

        
        var email = $("#Email").val();
        if (!isValidEmail(email)) {
            alert("Podaj poprawny adres e-mail.");
            isValid = false;
        }

        
        var phoneNumber = $("#PhoneNumber").val();
        if (!isValidPhoneNumber(phoneNumber)) {
            alert("Podaj poprawny numer telefonu.");
            isValid = false;
        }

        
        var age = parseInt($("#Age").val());
        if (isNaN(age) || age < 11 || age > 80) {
            alert("Wiek musi być między 11 a 80 lat.");
            isValid = false;
        }

        
        var password = $("#Password").val();
        var confirmPassword = $("#ConfirmPassword").val();
        if (password.length < 8 || !isValidPassword(password) || password !== confirmPassword) {
            alert("Hasło musi mieć co najmniej 8 znaków, zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę oraz być takie same jak potwierdzenie hasła.");
            isValid = false;
        }

        return isValid;
    }

    function isValidEmail(email) {
        
        var emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
        return emailPattern.test(email);
    }

    function isValidPhoneNumber(phoneNumber) {
        
        var phonePattern = /^\d{9}$/;
        return phonePattern.test(phoneNumber);
    }

    function isValidPassword(password) {
        
        var passwordPattern = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
        return passwordPattern.test(password);
    }
});