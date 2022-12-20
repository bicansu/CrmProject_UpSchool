using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Drawing.Text;

namespace CrmUpSchool.UILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous] //Sürekli login olmasına gerek olmaz. Kuralları geçersiz kılar.

    public class AdminCustomerController : Controller
    {
       
        private readonly ICustomerService _customerService;

        public AdminCustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult CustomerList()
        {
            var jsonCustomers = JsonConvert.SerializeObject(_customerService.TGetList());
            return Json(jsonCustomers);
        }
        [HttpPost]

        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer); // Veritabanına yansıtmayı sağlar
            var values = JsonConvert.SerializeObject(customer); //Veritabanına Json ile göndermemizi sağlar.
            return Json(values);
        }

        public IActionResult GetById(int CustomerID)
        {
            var values = _customerService.TGetById(CustomerID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var values = _customerService.TGetById(id);
            _customerService.TDelete(values);
            return Json(values);
        }

        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            var values = JsonConvert.SerializeObject(customer);
            return Json(values);
        }
    }
}
