using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class AditivoViewModel
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public string Numero { get; set; }
        public DateTime DataAditivo { get; set; }
        public int MesesAcrescidos { get; set; }
        public string Objeto { get; set; }

    }
    public class ContratoViewModel
    {
        public int Id { get; set; }
        public TipoInstrumento TipoInstrumento { get; set; }
        public string Numero { get; set; }
        public int FornecedorId { get; set; }
        public ModalidadeLicitacao ModalidadeLicitacao { get; set; }
        public SistemaLicitacao SistemaLicitacao { get; set; }
        public string NumeroLicitacao { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime DataFinalVigencia { get; set; }
        public string Objeto { get; set; }
    }

    public class DocumentoContratoViewModel
    {
        public DocumentoContratoViewModel()
        {
            TipoDocumento = TipoDocumento.Contrato;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int ContratoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }

    public class DocumentoAditivoViewModel
    {
        public DocumentoAditivoViewModel()
        {
            TipoDocumento = TipoDocumento.Aditivo;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int AditivoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }

    public class DocumentoAcompanhanteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int AcompanhanteId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }


    public class ServidorViewModel
    {
        public ServidorViewModel()
        {
            NaturezaJuridica = NaturezaJuridica.PessoaFisica;
            TipoPessoa = TipoPessoa.Servidor;
        }
        public int Id { get; set; }
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public int SecretariaId { get; set; }
    }
    public class SecretariaViewModelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeSimplificado { get; set; }
    }

    public class FornecedorViewModelo
    {
        public FornecedorViewModelo()
        {
            NaturezaJuridica = NaturezaJuridica.PessaoJuridica;
            TipoPessoa = TipoPessoa.Fornecedor;
        }
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public NaturezaJuridica NaturezaJuridica { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
    }

}
