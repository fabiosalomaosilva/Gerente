using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerente.Application.ViewModels
{
    public class AditivoViewModel
    {
        public int Id { get; set; }
     
        [Display(Name = "Contrato")]
        public int ContratoId { get; set; }

        [Display(Name = "Número do aditivo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(30, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")] 
        public string Numero { get; set; }

        [Display(Name = "Data do aditivo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")] 
        public DateTime DataAditivo { get; set; }

        [Display(Name = "Meses de acrésicmo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")] 
        public int MesesAcrescidos { get; set; }

        [Display(Name = "Objeto do aditivo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(1000, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Objeto { get; set; }

    }
}
