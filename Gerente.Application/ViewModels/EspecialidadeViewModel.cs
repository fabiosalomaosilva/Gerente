using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class EspecialidadeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome da especialidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(150, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

    }
}