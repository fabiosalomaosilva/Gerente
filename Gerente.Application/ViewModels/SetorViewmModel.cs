using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class SetorViewModel
    {
        public int Id { get; set; }
    
        [Display(Name = "Secretaria")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int SecretariaId { get; set; }
    
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), EmailAddress(ErrorMessage = "o campo deve ser um endereço de E-mail"), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Email { get; set; }
    }
}