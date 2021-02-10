using System;
using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class Auditoria
    {
        public string Id { get; set; }
        public int IdObjeto { get; set; }

        [MaxLength(20)]
        public string Tabela { get; set; }

        [MaxLength(20)]
        public string Operacao { get; set; }

        public string Valor { get; set; }

        [MaxLength(40)]
        public string AuditadoPor { get; set; }

        public DateTime AuditadoEm { get; set; }
    }
}