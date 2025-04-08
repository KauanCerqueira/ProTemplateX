using Microsoft.AspNetCore.Mvc;
using ProTemplateX.MVC.Models;

namespace ProTemplateX.Presentation.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@admin.com" && password == "123456")
                return RedirectToAction("Index", "Home");

            TempData["Error"] = "Credenciais inválidas!";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Simulação de cadastro
            TempData["Success"] = $"Usuário {model.Name} cadastrado com sucesso!";
            return RedirectToAction("Login");
        }
    }
}
