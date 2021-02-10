using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class LocalProcedimento
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
    }
}