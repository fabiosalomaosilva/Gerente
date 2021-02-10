using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class ContratoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de instrumento")]
        public TipoInstrumento TipoInstrumento { get; set; }
        
        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(40, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Numero { get; set; }

        [Display(Name = "Fornecedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int FornecedorId { get; set; }


        [Display(Name = "Modalidade de licitação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public ModalidadeLicitacao ModalidadeLicitacao { get; set; }


        [Display(Name = "Sistema de licitação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public SistemaLicitacao SistemaLicitacao { get; set; }


        [Display(Name = "Número da licitação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string NumeroLicitacao { get; set; }


        [Display(Name = "Data do contrato")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataContrato { get; set; }


        [Display(Name = "Data final da vigência")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataFinalVigencia { get; set; }


        [Display(Name = "Objeto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Objeto { get; set; }
    }
}