using Microsoft.AspNetCore.Http;

namespace CrmUpSchool.UILayer.Areas.Employee.Models
{
    public class UserEditProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }
        public IFormFile Image { get; set; }
    }
}
