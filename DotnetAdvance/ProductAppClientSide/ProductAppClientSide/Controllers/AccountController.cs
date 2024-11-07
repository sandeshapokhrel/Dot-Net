using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductAppClientSide.Models; 
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ProductAppClientSide.Services;

namespace ProductAppClientSide.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthServices _authService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(IAuthServices authService, IHttpContextAccessor httpContextAccessor)
        {
            _authService = authService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public IActionResult Login()
        {  
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin loginModel)
        {
            if (ModelState.IsValid)
            {
                string token = await _authService.AuthenticateAsync(loginModel);

                if (!string.IsNullOrEmpty(token))
                {
                    _httpContextAccessor.HttpContext.Session.SetString("JWToken", token);
                    return RedirectToAction("Dashboard", "Product");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(loginModel);
        }

    }
}