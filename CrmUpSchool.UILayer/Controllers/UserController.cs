using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CrmUpSchool.UILayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
