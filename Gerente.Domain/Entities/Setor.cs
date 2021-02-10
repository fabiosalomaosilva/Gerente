using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Setor : ControleVersao
    {
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Pessoa> Servidores { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }


    }
}