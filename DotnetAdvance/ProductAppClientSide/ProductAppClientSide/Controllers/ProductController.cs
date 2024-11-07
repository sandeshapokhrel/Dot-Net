using Microsoft.AspNetCore.Mvc;
using ProductAppClientSide.Services;

namespace ProductAppClientSide.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductController(IProductService productService, IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Dashboard()
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("JWToken");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");
            }

            var products = await _productService.GetProductsAsync(token);
            return View(products);
        }

    }
}
