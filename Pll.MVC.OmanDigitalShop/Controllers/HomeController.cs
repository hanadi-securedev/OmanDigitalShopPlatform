using Microsoft.AspNetCore.Mvc;
using Pll.MVC.OmanDigitalShop.Models;
using SLL.OmanDigitalLyer.Interface;
using System.Diagnostics;

namespace Pll.MVC.OmanDigitalShop.Controllers
{
    /// <summary>
    /// ?????????? ??????? ??????
    /// </summary>
    public class HomeController : Controller
    {
        // ============================================
        // ????????? ??????
        // ============================================

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        // ============================================
        // Constructor
        // ============================================

        public HomeController(
            IProductService productService,
            ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        // ============================================
        // ?????? ????????
        // ============================================

        /// <summary>
        /// ??? ?????? ???????? ?? ????????
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetActiveProductsAsync();
            var categories = await _categoryService.GetActiveCategoriesAsync();

            ViewBag.Categories = categories;
            return View(products);
        }

        // ============================================
        // ???? ????????
        // ============================================

        public IActionResult Privacy()
        {
            return View();
        }

        // ============================================
        // ???? ?????
        // ============================================

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
