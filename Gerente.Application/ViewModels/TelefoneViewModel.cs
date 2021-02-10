using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class TelefoneViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(30, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Numero { get; set; }

        [Display(Name = "Secretaria")]
        public int SecretariaId { get; set; }

        [Display(Name = "Setor")]
        public int SetorId { get; set; }

        [Display(Name = "Pessoa")]
        public int PessoaId { get; set; }
    }
}