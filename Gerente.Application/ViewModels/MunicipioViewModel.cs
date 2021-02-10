using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class MunicipioViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(80, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int EstadoId { get; set; }
    }
}