using FinanceTaskOne.Models;
using FinanceTaskOne.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinanceTaskOne.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult GetAllProducts()
        {
            List<Products> productList = _productService.GetAllProducts();
            return View(productList);
        }
        [HttpGet]
        public IActionResult AddProductItem()
        {
            var category = _productService.GetCategoryName();
            ViewBag.Category = new SelectList(category, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult AddProductItem(Products product) {
            int productCount = _productService.AddProductItem(product);
            if(productCount > 0)
            {
                    return RedirectToAction("GetAllProducts");
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var category = _productService.GetCategoryName();
            ViewBag.Category = new SelectList(category, "CategoryId", "CategoryName");
            Products productItem = _productService.EditProduct(id);
            return View(productItem);
        }
        [HttpPost]
        public IActionResult EditProduct(Products product)
        {
            int productCount =_productService.UpdateProduct(product);
            if(productCount > 0)
            {
                return RedirectToAction("GetAllProducts");
            }
            return View(product);
        }
        public IActionResult ProductDetails(int id)
        {
            Products productItem = _productService.GetProductById(id);
            return View(productItem);
        }
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            Products productItem = _productService.GetProductById(id);
            return View(productItem);
        }
        [HttpPost]
        public IActionResult DeleteProduct(Products products)
        {
            int isDeleted = _productService.DeleteProductItem(products);
            if(isDeleted > 0)
            {
                return RedirectToAction("GetAllProducts");
            }
            return View(products);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
