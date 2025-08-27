# ProTemplateX

Template profissional para aplicações **ASP.NET Core 8** com **Razor Pages** e **ASP.NET MVC**, estruturado em camadas (clean architecture), **Identity + JWT**, mapeamento com **AutoMapper** e layout moderno com **Bootstrap 5**.

> Foco: base reutilizável, padrão de organização e boas práticas para iniciar projetos de forma consistente.

---

## Sumário
- [Visão Geral](#visão-geral)
- [Stack Tecnológico](#stack-tecnológico)
- [Arquitetura & Estrutura](#arquitetura--estrutura)
- [Funcionalidades](#funcionalidades)
- [Demonstrações](#demonstrações)
- [Como Executar](#como-executar)
- [Configuração (appsettings)](#configuração-appsettings)
- [Comandos Úteis (EF Core)](#comandos-úteis-ef-core)
- [Roadmap](#roadmap)
- [Contribuição](#contribuição)
- [Licença](#licença)

---

## Visão Geral
O **ProTemplateX** fornece um ponto de partida sólido para sistemas corporativos: autenticação pronta, separação de camadas, controllers/views organizados, padronização de DTOs e mapeamentos, além de uma base para evoluir com testes, observabilidade e CI/CD.

---

## Stack Tecnológico

**Backend**
- ASP.NET Core 8 (Web API, MVC e Razor Pages)  
- Entity Framework Core (ORM)  
- ASP.NET Identity + JWT  
- AutoMapper  
- SQL Server (padrão)

**Frontend**
- Razor Pages & Razor Views  
- Bootstrap 5  
- JavaScript para componentes interativos

---

## Arquitetura & Estrutura

Camadas separadas para apresentação, aplicação e infraestrutura, favorecendo testabilidade e manutenção.

```
/ProTemplateX
1-Presentation/
  ProTemplateX.WebAPI/             # ASP.NET Core (API) + MVC + Razor Pages
    Controllers/
    Views/                          # Ex.: Home/Index, Account/Login, Register
    wwwroot/assets/                 # CSS, JS, imagens
2-Application/                      # Regras de negócio, DTOs, Services
3-Infra/
  Infra.Data/                       # EF Core, Migrations, Repositórios
  Infra.Domain/                     # Entidades e Interfaces
```

---

## Funcionalidades
- Cadastro e login de usuários com **Identity**
- Autenticação **JWT** integrada
- Telas de **Login** e **Cadastro** personalizadas
- **Termos de Uso** via modal
- Base modular e escalável (Domain, Data e Application)
- Layout responsivo com Bootstrap

---

## Demonstrações

**Tela de Login**  
![Tela de Login](https://raw.githubusercontent.com/KauanCerqueira/ProTemplateX/master/ProTemplateX.MVC/wwwroot/assets/img/prints/login.png)

**Perfil do Usuário**  
![Profile](https://raw.githubusercontent.com/KauanCerqueira/ProTemplateX/master/ProTemplateX.MVC/wwwroot/assets/img/prints/profile.png)

**Dashboard Principal**  
![Dashboard 1](https://raw.githubusercontent.com/KauanCerqueira/ProTemplateX/master/ProTemplateX.MVC/wwwroot/assets/img/prints/dashboard1.png)

**Dashboard Avançada (em desenvolvimento)**  
![Dashboard 2](https://raw.githubusercontent.com/KauanCerqueira/ProTemplateX/master/ProTemplateX.MVC/wwwroot/assets/img/prints/dashboard2.png)

**Logomarca do Projeto**  
![Logo](https://raw.githubusercontent.com/KauanCerqueira/ProTemplateX/master/ProTemplateX.MVC/wwwroot/assets/img/prints/Logo.png)

---

## Como Executar

### Requisitos
- .NET 8 SDK  
- Visual Studio 2022 (ou VS Code)  
- SQL Server / LocalDB

### Passos
1. Configure a **connection string** e o **JWT** no `appsettings.Development.json` (exemplo abaixo).  
2. Aplique as **migrations** do EF Core (veja a seção “Comandos Úteis”).  
3. Execute a aplicação:

```bash
# Exemplo: executando a camada de apresentação
cd 1-Presentation/ProTemplateX.WebAPI
dotnet run

# Acesse
http://localhost:5000
```

> Caso utilize multiple startup projects (API + MVC), ajuste os perfis de execução no Visual Studio/launchSettings.

---

## Comandos Úteis (EF Core)

```bash
# Criar migration
dotnet ef migrations add InitialCreate -p 3-Infra/Infra.Data -s 1-Presentation/ProTemplateX.WebAPI

# Atualizar banco
dotnet ef database update -p 3-Infra/Infra.Data -s 1-Presentation/ProTemplateX.WebAPI

# Reverter (opcional)
dotnet ef database update LastGoodMigration -p 3-Infra/Infra.Data -s 1-Presentation/ProTemplateX.WebAPI
```

> Ajuste os caminhos de `-p` (projeto de Data) e `-s` (startup) conforme sua solução.

---

## Roadmap
- Painel administrativo com cards e gráficos  
- Controle de permissões por **Role/Policy**  
- Upload de arquivos e gerenciamento de mídia  
- Dashboard com **KPIs**, gráficos e tabelas  
- Testes automatizados (unitários e integração)  
- Observabilidade (logging estruturado e métricas)

---

## Contribuição
1. Faça um fork do repositório  
2. Crie uma branch: `git checkout -b feature/minha-feature`  
3. Commit: `git commit -m "feat: descrição objetiva"`  
4. Push: `git push origin feature/minha-feature`  
5. Abra um Pull Request

---

## Licença
Licenciado sob a **MIT License**.
