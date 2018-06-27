using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RCingenierosApuControl.ViewModels
{
    public class LoginViewModel { 
        [Required]
        public string UsuarioLogin { get; set; }

        [Required]
        public string Password { get; set; }
    }
}