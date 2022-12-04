using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CrmUpSchool.UILayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PassordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır"
             };
             
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane küçük harf giriniz"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf giriniz"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 tane sayı girişi yapın"
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"İlgili mail adresi : {email} zaten sistemde mevcut, lütfen farklı bir mail adresi ile kayıt olun"
            };
                
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DublicateUserName",
                Description = $"İlgili kullanıcı adı : {userName} zaten sistemde mevcut, lütfen farklı bir kullanıcı adı ile kayıt olun"
            };
            
        }
    }
}
    

