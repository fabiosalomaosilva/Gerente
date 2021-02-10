using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class PacienteViewModel
    {
        public PacienteViewModel()
        {
            NaturezaJuridica = NaturezaJuridica.PessoaFisica;
            TipoPessoa = TipoPessoa.Paciente;
        }
        public int Id { get; set; }
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string NomeCompleto { get; set; }

        [Display(Name = "E-mail")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Email { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string Cpf { get; set; }
     
        [Display(Name = "Cartão SUS")]
        [Required(ErrorMessage = "O campo {0} é obrigatório."), MaxLength(30, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string CartaoSus { get; set; }
   
        [Display(Name = "Cartão FUNDHACRE")]
        [MaxLength(20, ErrorMessage = "O campo {0} deve possuir até {1} caracteres")]
        public string CartaoFundhacre { get; set; }

    }
}