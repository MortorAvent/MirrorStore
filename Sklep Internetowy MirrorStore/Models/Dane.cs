using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Sklep_Internetowy_MirrorStore.Models
{
    public class Dane
    {
        [MinLength(2)]
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Name { get; set; }

        [MinLength(2)]
        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Prosze podaj Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Prosze powtórz Hasło")]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public string Category { get; set; }
        public enum Categories { Warszawa = 1, Kraków = 2, Poznań = 3, Wrocław = 4, Gdańsk = 5  }

    }


}

