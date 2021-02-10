using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class MedicoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do médico")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(150, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Local do procedimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int LocalProcedimentoId { get; set; }
      
    }
}