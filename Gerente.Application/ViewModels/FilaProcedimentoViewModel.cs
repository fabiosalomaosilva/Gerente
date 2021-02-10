using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class FilaProcedimentoViewModel
    {
        public int Id { get; set; }
     
        [Display(Name = "Paciente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int PacienteId { get; set; }

        [Display(Name = "Especialidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int EspecialidadeId { get; set; }

        [Display(Name = "Procedimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int ProcedimentoId { get; set; }

        [Display(Name = "Local do procedimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int LocalProcedimentoId { get; set; }

        [Display(Name = "Médico")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int MedicoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Prioridade Prioridade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Status Status { get; set; }
      
        [Display(Name = "Lado direito")]
        public bool LadoDireito { get; set; }
     
        [Display(Name = "Lado esquerdo")]
        public bool LadoEsquerdo { get; set; }
   
        [Display(Name = "Observações")]
        [MaxLength(2000, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Observacoes { get; set; }
    }
}