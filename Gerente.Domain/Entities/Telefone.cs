using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Telefone
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public string PessoaResponsavel { get; set; }
        public CategoriaTelefone TipoTelefone { get; set; }
        public string Numero { get; set; }
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public int SetorId { get; set; }
        public virtual Setor Setor { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}