using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen telefonunuzu giriniz")]
        public string Phonenumber { get; set; }


        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor lütfen terar deneyin")]

        public string ConfirmPassword { get; set; }
    }
}
