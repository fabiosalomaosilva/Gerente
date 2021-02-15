using System;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class ControleVersao
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
    }
}