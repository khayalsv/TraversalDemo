 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Adinizi girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadinizi girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Username girin")]
        public string Username { get; set; }
      
        [Required(ErrorMessage = "Email girin")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Password girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password yeniden girin")]
        [Compare("Password",ErrorMessage ="Sifre uyumsuzdur")]
        public string ConfirmPassword { get; set; }
    }
}
