using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProTemplateX.Data;
using ProTemplateX.Data.Context;
using ProTemplateX.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

// 1. Banco de Dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// 🔧 Corrige o redirecionamento padrão de login/logout
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Auth/Login";
    options.LogoutPath = "/Auth/Logout";
    options.AccessDeniedPath = "/Auth/AccessDenied";
});

// 3. MVC e Razor
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews(); // <- Suporte a MVC

var app = builder.Build();

// 4. Pipeline de Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages(); // <- Opcional, apenas se estiver usando Razor Pages
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");

app.Run();
