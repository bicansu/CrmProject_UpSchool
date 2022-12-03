using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}
