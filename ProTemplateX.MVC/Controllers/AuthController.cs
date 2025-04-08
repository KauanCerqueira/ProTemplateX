using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProTemplateX.Application.DTOs;
using ProTemplateX.Application.Interfaces;
using ProTemplateX.Application.Services;
using ProTemplateX.Data.Entities;
using ProTemplateX.MVC.Models;
using System.Threading.Tasks;

namespace ProTemplateX.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAuthService _authService;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IAuthService authService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dto = new LoginDTO
            {
                Email = model.Email,
                Password = model.Password,
                RememberMe = model.RememberMe
            };

            var result = await _authService.LoginAsync(dto);

            if (result.Succeeded)
                return RedirectToAction("Index", "Home");

            TempData["Error"] = "Email ou senha inválidos!";
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model); // Isso volta para a tela de cadastro com mensagens de erro

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                NomeCompleto = model.NomeCompleto
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                TempData["Success"] = $"Usuário {model.NomeCompleto} cadastrado com sucesso!";
                return RedirectToAction("Login");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);

            return View(model);
        }
    }
}
