using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Models
{
    public class ExternalLoginModel
    {
        public string LoginProvider { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="E-Mail")]
        public string Email { get; set; }
    }
}
