using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProTemplateX.Data.Entities;

namespace ProTemplateX.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Adicione aqui os DbSet se já tiver entidades
        // public DbSet<Exemplo> Exemplos { get; set; }
    }
}
