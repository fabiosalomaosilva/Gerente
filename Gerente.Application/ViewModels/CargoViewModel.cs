using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class CargoViewModel
    {
        public int Id { get; set; }
      
        [Display(Name = "Nome do cargo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }
      
        [Display(Name = "Secretaria")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int SecretariaId { get; set; }
      
        [Display(Name = "Setor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int SetorId { get; set; }

    }
}