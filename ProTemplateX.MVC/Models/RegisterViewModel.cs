using System.ComponentModel.DataAnnotations;

namespace ProTemplateX.MVC.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O nome completo � obrigat�rio.")]
        [Display(Name = "Nome completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail v�lido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha � obrigat�ria.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "A confirma��o de senha � obrigat�ria.")]
        [Compare("Password", ErrorMessage = "As senhas n�o coincidem.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Aceito os termos")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "� necess�rio aceitar os termos.")]
        public bool AceitaTermos { get; set; }
    }
}
