using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class AgendamentoViewModel
    {
        public int Id { get; set; }
     
        public int FilaProcedimentoId { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Titulo { get; set; }
    
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int HoraInicio { get; set; }
     
        public LadoMembro Membro { get; set; }
     
        public bool Confirmado { get; set; }

        [MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string NomePessoaConfirmacao { get; set; }
     
        [MaxLength(4000, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Descricao { get; set; }
    }
}