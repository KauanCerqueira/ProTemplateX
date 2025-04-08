# 💼 ProTemplateX

> Template base profissional para projetos ASP.NET Core com Razor Pages, arquitetura limpa, autenticação JWT e design moderno com layout customizado.

---

## 📚 Sobre o Projeto

O **ProTemplateX** é um modelo escalável e reutilizável para desenvolvimento de aplicações web com **ASP.NET Core 8**, utilizando **Razor Pages** e **ASP.NET MVC** no frontend. Ele inclui autenticação com Identity, estrutura modular em camadas e uma base sólida para sistemas profissionais.

---

## 🚀 Tecnologias Utilizadas

### Backend:
- ✅ ASP.NET Core 8 (Web API + MVC + Razor Pages)
- ✅ Entity Framework Core (ORM)
- ✅ ASP.NET Identity + JWT Auth
- ✅ AutoMapper (mapeamento de DTOs)
- ✅ SQL Server (padrão)

### Frontend:
- 🧹 Razor Pages + MVC
- 📄 Razor Views customizadas
- 🎨 Bootstrap 5 (estilização)
- 💬 JavaScript para componentes interativos

---

## 🧱 Estrutura de Pastas

```bash
/ProTemplateX
🔹 1-Presentation
🔽— ProTemplateX.WebAPI         # API ASP.NET Core com Razor Pages
│   🔽— Views/Home              # Páginas como Index, Login, Cadastro
│   🔽— Controllers             # Controllers MVC
│   └️ wwwroot/assets          # Arquivos estáticos (CSS, JS, imagens)
🔹 2-Application                # Regras de negócio
🔹 3-Infra
    🔽— Infra.Data             # Acesso a dados (EF Core)
    └️ Infra.Domain           # Entidades + Interfaces
✅ Funcionalidades Implementadas
 Cadastro de usuários com Identity

 Login com autenticação JWT

 Telas de Login e Cadastro customizadas

 Modal de Termos de Uso

 Estrutura modular e escalável (Camadas Domain, Data e Application)

📦 Como Executar o Projeto
🪰 Requisitos
.NET 8 SDK

Visual Studio 2022 ou VS Code

SQL Server (ou LocalDB)

⚖️ Backend + Frontend (Razor)
bash
Copiar
Editar
# Navegue até a API
cd 1-Presentation/ProTemplateX.WebAPI

# Execute o projeto com Visual Studio ou CLI:
dotnet run
Acesse: http://localhost:5000

🧪 Em Desenvolvimento
 Painel de administração com cards e gráficos

 Controle de permissões por Role

 Upload de arquivos

 Dashboard com KPIs, gráficos e tabela de dados

🤝 Contribuindo
Faça um fork 🍝

Crie uma branch com sua feature (git checkout -b feature/NovaFeature)

Commit suas alterações (git commit -m 'feat: Minha nova feature')

Push na branch (git push origin feature/NovaFeature)

Abra um Pull Request ✅

📄 Licença
Este projeto está sob a licença MIT.

Feito com ❤️ por Kauan Cerqueira

swift
Copiar
Editar

Você pode agora adicionar as imagens no seu repositório e usá-las nas seções do README, como mencionei anteriormente. Basta usar a sintaxe de Markdown para adicionar imagens:

```markdown
![Logo](caminho/para/logo.png)
![Tela de Login](caminho/para/login.png)
![Dashboard 1](caminho/para/dashboard1.png)
![Dashboard 2](caminho/para/dashboard2.png)
![Profile](caminho/para/profile.png)
