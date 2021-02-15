using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Pessoa : ControleVersao
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string CartaoSus { get; set; }
        public string CartaoFundhacre { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public int SecretariaId { get; set; }
        public virtual Secretaria Secretaria { get; set; }
        public int SetorId { get; set; }
        public virtual Setor Setor { get; set; }

        public int AcompanhanteId { get; set; }
        public virtual Pessoa Acompanhante { get; set; }

        public int RepresentanteId { get; set; }
        public virtual Pessoa Representante { get; set; }


        public string Matricula { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<FilaProcedimento> FilaProcedimentos { get; set; }
        public virtual ICollection<Pessoa> Acompanhantes { get; set; }
        public virtual ICollection<Pessoa> Representantes { get; set; }
        public virtual ICollection<Contrato> ContratosFornecedores { get; set; }
        public virtual ICollection<Contrato> ContratosRepresentantes { get; set; }

    }
}