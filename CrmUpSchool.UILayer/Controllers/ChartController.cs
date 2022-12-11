using CrmUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrmUpSchool.UILayer.Controllers
{
    [Area("Employee")]
    public class ChartController : Controller
    {
        List<DepartmantSalary> departmantSalaries = new List<DepartmantSalary>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartmantChart()
        {
            departmantSalaries.Add(new DepartmantSalary
            {
                DepartmantName = "Muhasebe",
                SalaryAvg = 10000
            });
          

            departmantSalaries.Add(new DepartmantSalary
            {
                DepartmantName = "IT",
                SalaryAvg = 20000
            });

            departmantSalaries.Add(new DepartmantSalary
            {
                DepartmantName = "Satıs",
                SalaryAvg = 20000
            });
            return Json(new { jsonList = departmantSalaries});
        }


    }
}
