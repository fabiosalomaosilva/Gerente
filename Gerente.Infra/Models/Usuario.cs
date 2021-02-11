using System;
using Microsoft.AspNetCore.Identity;

namespace Gerente.Infra.Data.Models
{
    public class Usuario : IdentityUser
    {
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
    }
}
