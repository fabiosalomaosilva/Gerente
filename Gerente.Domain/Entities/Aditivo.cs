using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Aditivo : ControleVersao
    {
        public int ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }
        public string Numero { get; set; }
        public DateTime DataAditivo { get; set; }
        public int MesesAcrescidos { get; set; }
        public string Objeto { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }

    }
}