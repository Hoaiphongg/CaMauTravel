using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaMauTravel.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Username cannot be empty")]
        public string Password { get; set; }

        public bool Remember { get; set; }

    }
}