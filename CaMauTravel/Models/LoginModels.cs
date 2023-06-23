using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaMauTravel.Models
{
    public class LoginModels
    {
        [Key]
        [Display(Name = "Username:")]
        [Required(ErrorMessage = "Enter your username")]
        public string Username { set; get; }

        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Enter your password")]
        public string Passwords { set; get; }

        public bool RememberMe { set; get; }
    }
}