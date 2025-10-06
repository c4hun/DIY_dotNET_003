using Microsoft.AspNetCore.Mvc;
using AuthApp.Services;

namespace AuthApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly AuthService _authService;

        public LoginController()
        {
            // Pour l’instant, on instancie directement la dépendance
            _authService = new AuthService(new InMemoryUserRepository());
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (_authService.Login(username, password))
            {
                return RedirectToAction("Welcome");
            }

            ViewBag.Error = "Identifiants invalides";
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
