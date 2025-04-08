using System.Threading.Tasks;
using ProTemplateX.Application.DTOs;
using Microsoft.AspNetCore.Identity;

namespace ProTemplateX.Application.Interfaces
{
    public interface IAuthService
    {
        Task<SignInResult> LoginAsync(LoginDTO dto);
    }
}
