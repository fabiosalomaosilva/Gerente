using System;
using System.Collections.Generic;

namespace Gerente.Domain.Entities
{
    public class Aditivo
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public int ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }
        public string Numero { get; set; }
        public DateTime DataAditivo { get; set; }
        public int MesesAcrescidos { get; set; }
        public string Objeto { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }

    }
}