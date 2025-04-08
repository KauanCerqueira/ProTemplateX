# 💼 ProTemplateX

> Template base profissional para projetos ASP.NET Core com Razor Pages, arquitetura limpa, autenticação JWT e design moderno baseado no Material Dashboard.

---

## 📚 Sobre o Projeto

O **ProTemplateX** é um modelo escalável e reutilizável para desenvolvimento de aplicações web com **ASP.NET Core 8** utilizando **Razor Pages** e **ASP.NET MVC** no frontend. Ele inclui autenticação com Identity, estrutura modular de camadas e um layout visual moderno baseado no **Material Dashboard**.

---

## 🚀 Tecnologias Utilizadas

### Backend:
- ✅ ASP.NET Core 8 (Web API + MVC + Razor Pages)
- ✅ Entity Framework Core (ORM)
- ✅ ASP.NET Identity + JWT Auth
- ✅ AutoMapper (mapeamento de DTOs)
- ✅ SQL Server (padrão)

### Frontend:
- 🧩 Razor Pages + MVC
- 🎨 Material Dashboard 2 (HTML + CSS + JS)
- 📦 Bootstrap 5 (via template)
- 📄 Razor Views customizadas

---

## 🧱 Estrutura de Pastas

```bash
/ProTemplateX
🔹 1-Presentation
├── ProTemplateX.WebAPI         # API ASP.NET Core com Razor Pages
│   ├── Views/Home              # Páginas como Index, Login, Cadastro
│   ├── Controllers             # Controllers MVC
│   └── wwwroot/assets          # Template Material Dashboard
🔹 2-Application                # Regras de negócio
🔹 3-Infra
    ├── Infra.Data             # Acesso a dados (EF Core)
    └── Infra.Domain           # Entidades + Interfaces
