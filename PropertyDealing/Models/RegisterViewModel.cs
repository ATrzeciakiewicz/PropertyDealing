using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertyDealing.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Podaj swój email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj swój numer telefonu.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Wpisz hasło.")]
        [StringLength(30,
            ErrorMessage = "{0} musi mieć przynajmniej {2} znaków",
            MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Powtórz hasło.")]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Hasła nie są takie same.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}