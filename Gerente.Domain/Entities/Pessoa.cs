using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Pessoa : ControleVersaoEndereco
    {
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string CartaoSus { get; set; }
        public string CartaoFundhacre { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public string Matricula { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
        public virtual ICollection<Pessoa> Acompanhantes { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<Setor> Setores { get; set; }

    }
}