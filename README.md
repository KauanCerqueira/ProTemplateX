# 💼 ProTemplateX

> Template base profissional para projetos ASP.NET Core + React com arquitetura limpa, autenticação JWT e design moderno.

---

## 📚 Sobre o Projeto

O **ProTemplateX** é um modelo escalável e reutilizável para desenvolvimento de aplicações fullstack com **ASP.NET Core Web API** no backend e **React (Material UI)** no frontend. Ideal para projetos com autenticação, controle de acesso por roles, e uma base sólida para crescimento modular.

---

## 🚀 Tecnologias Utilizadas

### Backend:
- ✅ ASP.NET Core 8 (Web API)
- ✅ Entity Framework Core (ORM)
- ✅ ASP.NET Identity + JWT Auth
- ✅ AutoMapper (mapeamento de DTOs)
- ✅ SQL Server (padrão)

### Frontend:
- ⚛️ React 18+
- 🎨 Material UI (Dashboard moderno)
- 🌐 Axios (requisições HTTP)
- 🔐 Context API para autenticação

---

## 🧱 Estrutura de Pastas

```bash
/ProTemplateX
├── 1-Presentation
│   ├── ProTemplateX.WebAPI         # API ASP.NET Core
│   └── ProTemplateX.ReactApp       # Frontend em React
├── 2-Application                   # Regras de negócio
├── 3-Infra
│   ├── Infra.Data                  # Acesso a dados (EF Core)
│   └── Infra.Domain                # Entidades + Contratos
