using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Models
{
    public class LoginModel
    {
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        public string Message { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
