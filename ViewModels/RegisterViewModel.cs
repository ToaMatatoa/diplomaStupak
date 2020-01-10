using System;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentityApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        [DataType (DataType.Date)]
        public DateTime Date { get; set; }
        //public int Year { get; set; }
        //public int Month { get; set; }
        //public int Day { get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm the password")]
        public string PasswordConfirm { get; set; }
    }
}