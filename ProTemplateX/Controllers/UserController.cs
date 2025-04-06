using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ProTemplateX.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Protege todas as rotas do controller
    public class UserController : ControllerBase
    {
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            return Ok(new
            {
                Message = "Usuário autenticado com sucesso!",
                UserId = userId,
                Email = userEmail
            });
        }
    }
}
