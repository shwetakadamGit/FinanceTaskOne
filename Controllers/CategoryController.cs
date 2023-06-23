using Microsoft.AspNetCore.Mvc;
using FinanceTaskOne.Models;
using FinanceTaskOne.Service;

namespace FinanceTaskOne.Controllers
{
    public class CategoryController : Controller
    {
        readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            //List<Category> categoryList = _categoryService.GetAllCategories();
            var categoryList = _categoryService.GetAllCategories();
            return View(categoryList);
        }
        public IActionResult AddCategoryItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategoryItem(Category category) {
            int categoryCount = _categoryService.AddCategoryItem(category);
            if(categoryCount > 0)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult EditCategoryItem(int id)
        {
            Category categoryItem = _categoryService.EditCategory(id);
            return View(categoryItem);
        }
        [HttpPost]
        public IActionResult EditCategoryItem(Category category)
        {
            int categoryCount = _categoryService.UpdateCategory(category);
            if(categoryCount > 0)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
        //[HttpGet]
        public IActionResult GetCategoryById(int id)
        {
            Category categoryItem = _categoryService.GetCategoryById(id);
            return View(categoryItem);
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            Category categoryItem = _categoryService.GetCategoryById(id);
            return View(categoryItem);
        }
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            int isDeleted = _categoryService.DeleteCategoryItem(category);
            if(isDeleted > 0)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
