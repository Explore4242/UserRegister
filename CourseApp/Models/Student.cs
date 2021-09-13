using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsminizi giriniz.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir email giriniz.")]
        [Required(ErrorMessage = "Email giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefononuzu giriniz.")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Kursa katılıp katılmayacağınızı bilmemiz gerekir.")]
        public bool? WillAtend { get; set; }
    }
}
   