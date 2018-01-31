using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertyDealing.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your phone number.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter your password.")]
        [StringLength(30,
            ErrorMessage = "{0} must have at least {2} characters",
            MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter your password.")]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Passwords are not the same.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}