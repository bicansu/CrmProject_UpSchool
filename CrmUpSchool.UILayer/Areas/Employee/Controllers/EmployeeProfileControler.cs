using CrmUpSchool.EntityLayer.Concrete;
using CrmUpSchool.UILayer.Areas.Employee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeProfileControler : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private object directory;

        public EmployeeProfileControler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditProfile userEditProfile = new UserEditProfile();
            userEditProfile.Name = values.Name;
            userEditProfile.Surname = values.Surname;
            userEditProfile.PhoneNumber = values.PhoneNumber;
            userEditProfile.Email = values.Email;
            return View(userEditProfile);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfile p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var ImageName = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImages/" + ImageName;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = ImageName;
            }

            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.PhoneNumber;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();

        }
    }
}
