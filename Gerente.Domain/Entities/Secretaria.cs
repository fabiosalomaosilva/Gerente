using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Secretaria : ControleVersaoEndereco
    {
        public string Nome { get; set; }
        public string NomeSimplificado { get; set; }
        public virtual ICollection<Pessoa> Servidores { get; set; }
        public virtual ICollection<Setor> Setores { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }

    }
}