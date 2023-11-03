using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Sklep_Internetowy_MirrorStore.Models
{
    public class Dane
    {
        
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Pole Hasło jest wymagane.")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Prosze powtórz Hasło")]
        [Compare("Password", ErrorMessage ="Hasła nie są takie same")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Podaj swój numer telefonu.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi składać się z 9 cyfr.")]
        public int PhoneNumber { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Podaj swój wiek.")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80 lat.")]
        public int Age { get; set; }

        public string City { get; set; }

        public string Category { get; set; }
        public enum Categories { Warszawa = 1, Kraków = 2, Poznań = 3, Wrocław = 4, Gdańsk = 5  }

    }


}

