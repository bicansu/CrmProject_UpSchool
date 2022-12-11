using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _HeadDashboardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
