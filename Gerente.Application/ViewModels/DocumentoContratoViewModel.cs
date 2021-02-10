using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class DocumentoContratoViewModel
    {
        public DocumentoContratoViewModel()
        {
            TipoDocumento = TipoDocumento.Contrato;
        }

        public int Id { get; set; }

        [Display(Name = "Nome do documento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(150, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(255, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Url { get; set; }

        [Display(Name = "Contrato")]
        public int ContratoId { get; set; }

        public TipoDocumento TipoDocumento { get; set; }
    }
}