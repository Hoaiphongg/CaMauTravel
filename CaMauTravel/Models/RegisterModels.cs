using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CaMauTravel.Models
{
    public class RegisterModels
    {
        [Key]
        public long ID { set; get; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter Username")]
        public string UserName { set; get; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Erorr")]
        [Required(ErrorMessage = "Enter Password")]
        public string Password { set; get; }

        [Display(Name = "Re-Password")]
        [Compare("Password", ErrorMessage = "Password not match!!!.")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter Name")]
        public string Name { set; get; }

        [Display(Name = "Address")]
        public string Address { set; get; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        public string Email { set; get; }

        [Display(Name = "Phone")]
        public string Phone { set; get; }

        [Display(Name = "Gender")]
        public bool Gender { set; get; }

        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

    }
}