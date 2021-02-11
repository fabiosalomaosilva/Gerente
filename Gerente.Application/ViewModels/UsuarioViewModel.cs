using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Foto { get; set; }
        public string FotoExtensao { get; set; }
        public string Sexo { get; set; }
        public int SecretariaId { get; set; }
        public string Secretaria { get; set; }
        public int SetorId { get; set; }
        public string Setor { get; set; }
    }

    public class UserLoginResultModel
    {
        public UsuarioViewModel Usuario { get; set; }
        public bool Succeeded { get; set; }
        public string Error { get; set; }
    }

    public class DefinicaoSexoModelViewModel
    {
        public string Sexo { get; set; }
        public string Precisao { get; set; }
    }


    public class ResultadosApiDefinirSexoViewModel
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string localidade { get; set; }
        public List<DadosViewModel> res { get; set; }
    }

    public class DadosViewModel
    {
        public string periodo { get; set; }
        public int frequencia { get; set; }
    }


    public class SexoViewModel
    {
        public static string Masculino => "Masculino";
        public static string Feminino => "Feminino";
        public static string Indefinido => "Indefinido";

    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo deve ser um enereço de e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }

    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo deve ser um enereço de e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        [Display(Name = "Senha")]
        [MinLength(6, ErrorMessage = "A Senha deve possuir no mínimo 6 caracteres.")]
        public string Password { get; set; }
    }

    public class ResendEmailViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo deve ser um enereço de e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }

    public class ConfirmEmailViewModel
    {
        public string UserId { get; set; }
        public string Code { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public UsuarioViewModel Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma a nova senha")]
        [Compare("NewPassword", ErrorMessage = "A nova senha e a confirmação senha não coincidem.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo deve ser um enereço de e-mail")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar a senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação não coincidem.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

    }
}