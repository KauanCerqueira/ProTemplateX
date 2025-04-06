using Microsoft.AspNetCore.Identity;

namespace ProTemplateX.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? NomeCompleto { get; set; }
        // Aqui você pode adicionar outras propriedades específicas de usuário
    }
}
