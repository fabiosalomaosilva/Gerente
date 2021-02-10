using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gerente.Domain.Enums;

namespace Gerente.Domain.Entities
{
    public class FilaProcedimento: ControleVersao
    {
       public int PacienteId { get; set; }
        public virtual Pessoa Paciente { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public int  ProcedimentoId { get; set; }
        public virtual Procedimento Procedimento { get; set; }
        public int LocalProcedimentoId { get; set; }
        public virtual LocalProcedimento LocalProcedimento { get; set; }
        public int MedicoId { get; set; }
        public virtual Medico Medico { get; set; }
        public Prioridade Prioridade { get; set; }
        public Status Status { get; set; }
        public bool LadoDireito { get; set; }
        public bool LadoEsquerdo { get; set; }
        public bool Finalizado { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<Agendamento> Agendamentos { get; set; }  
    }
}