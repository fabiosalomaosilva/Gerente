using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Setor
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Pessoa> Servidores { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }


    }
}