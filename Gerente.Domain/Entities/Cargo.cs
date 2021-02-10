using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Cargo : ControleVersao
    {
        public string Nome { get; set; }
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public int SetorId { get; set; }
        public virtual Setor Setor { get; set; }
        
    }
}