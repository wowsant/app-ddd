using System.ComponentModel.DataAnnotations;

namespace APP.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é um campo obrigatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres. ")]
        public string Email { get; set; }
        // public string Password { get; set; }
    }
}
