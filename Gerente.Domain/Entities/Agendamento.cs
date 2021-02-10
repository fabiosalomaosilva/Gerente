using System;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public bool Ativo { get; set; }
        public int FilaProcedimentoId { get; set; }
        public FilaProcedimento FilaProcedimento { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public int HoraInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string MensagemNotificacao { get; set; }
        public LadoMembro Membro { get; set; }
        public bool Confirmado { get; set; }
        public string NomePessoaConfirmacao { get; set; }
        public bool Realizado { get; set; }
        public string Descricao { get; set; }
        public bool Cancelado { get; set; }
    }
}