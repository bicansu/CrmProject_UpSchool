using CrmUpSchool.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeTaskDetailController : Controller
    {
       
        private readonly IEmployeeTaskDetailService _employeeTaskDetailService;

        public EmployeeTaskDetailController(IEmployeeTaskDetailService employeeTaskDetailService)
        {
            _employeeTaskDetailService = employeeTaskDetailService;
        }

        public IActionResult Index(int id)
        {
            var values = _employeeTaskDetailService.TGetEmployeeTaskDetailsById(id);
            return View(values);
        }
    }
}
