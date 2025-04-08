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
🔹 1-Presentation
├── ProTemplateX.WebAPI         # API ASP.NET Core
└── ProTemplateX.ReactApp       # Frontend em React
🔹 2-Application                   # Regras de negócio
🔹 3-Infra
    ├── Infra.Data                  # Acesso a dados (EF Core)
    └── Infra.Domain                # Entidades + Contratos
```

---

## ✅ Funcionalidades Implementadas

- [x] Cadastro de usuários com Identity
- [x] Login com token JWT
- [x] Proteção de rotas com autorização
- [x] Estrutura modular e escalável
- [x] Integração inicial com React Dashboard

---

## 📦 Como Executar o Projeto

### 🔧 Backend

```bash
# Navegue até a API
cd 1-Presentation/ProTemplateX.WebAPI

# Execute com o Visual Studio ou CLI:
dotnet run
```

### 💻 Frontend

```bash
# Navegue até o app React
cd 1-Presentation/ProTemplateX.ReactApp

# Instale as dependências
npm install

# Inicie o servidor React
npm start
```

---

## 🧪 Em Desenvolvimento

- [ ] Painel de administração
- [ ] Controle de permissões por Role
- [ ] Upload de arquivos
- [ ] Notificações e mensagens

---

## 🤝 Contribuindo

1. Faça um fork 🍝
2. Crie uma branch com sua feature (`git checkout -b feature/NovaFeature`)
3. Commit suas alterações (`git commit -m 'feat: Minha nova feature'`)
4. Push na branch (`git push origin feature/NovaFeature`)
5. Abra um Pull Request ✅

---

## 📄 Licença

Este projeto está sob a licença MIT.

---

Feito com ❤️ por Kauan Cerqueira

