using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class LocalProcedimentoViewModel
    {
        public int Id { get; set; }
     
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(150, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }
     
        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(150, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(50, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Numero { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Complemento")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Complemento { get; set; }

        [Display(Name = "CEP")]
        [MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int EstadoId { get; set; }

        [Display(Name = "Município")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int MunicipioId { get; set; }
    }
}