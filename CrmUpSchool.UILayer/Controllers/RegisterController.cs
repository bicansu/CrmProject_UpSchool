using CrmUpSchool.EntityLayer.Concrete;
using CrmUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result =await _userManager.CreateAsync(appUser, appUser.PasswordHash);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "UserList");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index2(UserSignUpModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = p.Username,
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Email,
                    PhoneNumber = p.Phonenumber
                };
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Şifreler uyuşmuyor");
                }
            }
            
            
            return View();
        }
    }
}
