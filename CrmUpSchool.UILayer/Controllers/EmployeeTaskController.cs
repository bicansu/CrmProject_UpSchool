using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CrmUpSchool.UILayer.Controllers
{
    public class EmployeeTaskController : Controller
    {
        private readonly IEmployeeTaskService _employeeTaskService;
        private readonly UserManager<AppUser> _userManager;

        public EmployeeTaskController(IEmployeeTaskService employeeTaskService, UserManager<AppUser> userManager)
        {
            _employeeTaskService = employeeTaskService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _employeeTaskService.TGetEmployeeTasksByEmployee();
            return View(values);
            
        }
        [HttpGet]

        public IActionResult AddTask()
        {
            List<SelectListItem> userValues = (from x in _userManager.Users.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name + " " + x.Surname,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.v = userValues;
            return View();
          
        }

        [HttpPost]

        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            employeeTask.Status = "Görev Atandı";
            employeeTask.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
           _employeeTaskService.TInsert(employeeTask);
            return RedirectToAction("Index");
        }

    }
}
