using Microsoft.AspNetCore.Identity;
using System;

namespace ProTemplateX.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? NomeCompleto { get; set; }

        public DateTime DataDeCriacao { get; set; } = DateTime.UtcNow;

        public bool Ativo { get; set; } = true;

        public string? Role { get; set; }
    }
}
