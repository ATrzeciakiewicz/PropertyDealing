using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertyDealing.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}