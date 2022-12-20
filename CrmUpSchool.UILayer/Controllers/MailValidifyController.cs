using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Controllers
{
    [AllowAnonymous]
    public class MailValidifyController : Controller
    {
  
        public IActionResult Index()
        {
            return View();
        }
    }
}
