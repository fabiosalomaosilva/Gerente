using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Secretaria : ControleVersao
    {
        public string Nome { get; set; }
        public string NomeSimplificado { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual ICollection<Pessoa> Servidores { get; set; }
        public virtual ICollection<Setor> Setores { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }

    }
}