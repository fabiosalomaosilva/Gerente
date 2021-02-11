using System;

namespace Gerente.Domain.Entities
{
    public class User
    {
        public bool EmailConfirmed { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string NomeCompleto { get; set; }
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
        public bool LockoutEnabled { get; set; }
    }

    public class UserLoginResult
    {
        public User Usuario { get; set; }
        public bool Succeeded { get; set; }
        public string Error { get; set; }
    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ChangePassword
    {
        public User Usuario { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class ResetPassword
    {
        public User Usuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Code { get; set; }
    }
}