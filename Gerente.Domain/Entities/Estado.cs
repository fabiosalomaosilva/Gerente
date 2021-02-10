using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Gerente.Domain.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        [JsonIgnore]
        public virtual ICollection<Municipio> Municipios { get; set; }
        public virtual ICollection<LocalProcedimento> LocalProcedimentos { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<Secretaria> Secretarias { get; set; }

    }
}