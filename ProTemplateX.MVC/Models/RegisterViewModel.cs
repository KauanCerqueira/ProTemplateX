using System.ComponentModel.DataAnnotations;

namespace ProTemplateX.MVC.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "E-mail inv�lido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha � obrigat�ria.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter no m�nimo 6 caracteres.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "As senhas n�o coincidem.")]
        public string ConfirmPassword { get; set; }
    }
}
