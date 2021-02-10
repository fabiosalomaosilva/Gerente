using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Entities;

namespace Gerente.Application.ViewModels
{
    public class EstadoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(30, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "UF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(2, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Uf { get; set; }
    }
}