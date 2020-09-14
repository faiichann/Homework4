using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework4.Models
{
    public class User
    {
        [Key]

        [Required(ErrorMessage = "please fill your Email")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "please fill your Name")]
        [MinLength(5,ErrorMessage ="please fill more than 5 letter")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "please fill your Passsword")]
        [MinLength(8, ErrorMessage = "please fill more than 8 letter")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "please Confirm Password ")]
        [Compare("UserPassword", ErrorMessage = "Password not same ")]
        public string UserConfirmPass { get; set; }

        [Required(ErrorMessage = "please select your picture profile")]
        public byte[] UserImage { get; set; }
    }
}
