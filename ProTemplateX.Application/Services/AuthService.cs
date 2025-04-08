using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProTemplateX.Application.DTOs;
using ProTemplateX.Application.Interfaces;
using ProTemplateX.Data.Entities;

namespace ProTemplateX.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthService(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<SignInResult> LoginAsync(LoginDTO dto)
        {
            var user = await _signInManager.UserManager.FindByEmailAsync(dto.Email);

            if (user == null)
                return SignInResult.Failed;

            return await _signInManager.PasswordSignInAsync(
                user.UserName,
                dto.Password,
                dto.RememberMe,
                lockoutOnFailure: false);
        }

    }
}
