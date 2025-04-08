namespace ProTemplateX.Application.DTOs
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; } // Essa propriedade será preenchida se o name="rememberMe"
    }
}
