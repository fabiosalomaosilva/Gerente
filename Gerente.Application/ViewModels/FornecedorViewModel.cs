﻿using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            NaturezaJuridica = NaturezaJuridica.PessaoJuridica;
            TipoPessoa = TipoPessoa.Fornecedor;
        }
        public int Id { get; set; }
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string NomeCompleto { get; set; }
     
        [Display(Name = "Nome de fantasia")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string NomeFantsia { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Email { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Cnpj { get; set; }

    }
}