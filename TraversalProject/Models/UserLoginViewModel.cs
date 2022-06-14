using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Username Girin")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Sifre Girin")]
        public string Password { get; set; }


    }
}
