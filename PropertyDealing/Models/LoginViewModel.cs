using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertyDealing.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Podaj swój email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wpisz swoje hasło.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}