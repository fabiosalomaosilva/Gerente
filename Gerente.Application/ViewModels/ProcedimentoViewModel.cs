using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class ProcedimentoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }


        [Display(Name = "Especialidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int EspecialidadeId { get; set; }


        [Display(Name = "Realiza em dois membros?")]
        public bool DoisMembros { get; set; }


        [Display(Name = "Tempo de duração do procedimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string TempoDuracao { get; set; }
    }
}