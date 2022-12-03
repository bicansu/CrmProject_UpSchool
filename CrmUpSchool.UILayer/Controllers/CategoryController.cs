using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }
        [HttpGet]

        public IActionResult AddCetgory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
