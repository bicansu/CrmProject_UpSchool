using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _FeatureDashboardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
