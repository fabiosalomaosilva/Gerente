using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Mappings
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Pessoa, AcompanhanteViewModel>();
            CreateMap<Pessoa, PacienteViewModel>();
            CreateMap<Pessoa, FornecedorViewModel>();
            CreateMap<Pessoa, ServidorViewModel>();
            CreateMap<Aditivo, AditivoViewModel>();
            CreateMap<Agendamento, AgendamentoViewModel>();
            CreateMap<Cargo, CargoViewModel>();
            CreateMap<Contrato, ContratoViewModel>();
            CreateMap<Documento, DocumentoAcompanhanteViewModel>();
            CreateMap<Documento, DocumentoAditivoViewModel>();
            CreateMap<Documento, DocumentoContratoViewModel>();
            CreateMap<Especialidade, EspecialidadeViewModel>();
            CreateMap<Estado, EstadoViewModel>();
            CreateMap<FilaProcedimento, FilaProcedimentoViewModel>();
            CreateMap<LocalProcedimento, LocalProcedimentoViewModel>();
            CreateMap<Medico, MedicoViewModel>();
            CreateMap<Municipio, MunicipioViewModel>();
            CreateMap<Procedimento, ProcedimentoViewModel>();
            CreateMap<Secretaria, SecretariaViewModel>();
            CreateMap<Setor, SetorViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
            CreateMap<User, UsuarioViewModel>();
        }
    }
}
