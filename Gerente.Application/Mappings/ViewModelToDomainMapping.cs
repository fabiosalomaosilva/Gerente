using AutoMapper;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Mappings
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<AcompanhanteViewModel, Pessoa>();
            CreateMap<PacienteViewModel, Pessoa>();
            CreateMap<FornecedorViewModel, Pessoa>();
            CreateMap<ServidorViewModel, Pessoa>();
            CreateMap<AditivoViewModel, Aditivo>();
            CreateMap<AgendamentoViewModel, Agendamento>();
            CreateMap<CargoViewModel, Cargo>();
            CreateMap<ContratoViewModel, Contrato>();
            CreateMap<DocumentoAcompanhanteViewModel, Documento>();
            CreateMap<DocumentoAditivoViewModel, Documento>();
            CreateMap<DocumentoContratoViewModel, Documento>();
            CreateMap<EspecialidadeViewModel, Especialidade>();
            CreateMap<EstadoViewModel, Estado>();
            CreateMap<FilaProcedimentoViewModel, FilaProcedimento>();
            CreateMap<LocalProcedimentoViewModel, LocalProcedimento>();
            CreateMap<MedicoViewModel, Medico>();
            CreateMap<MunicipioViewModel, Municipio>();
            CreateMap<ProcedimentoViewModel, Procedimento>();
            CreateMap<SecretariaViewModel, Secretaria>();
            CreateMap<SetorViewModel, Setor>();
            CreateMap<TelefoneViewModel, Telefone>();
            CreateMap<UsuarioViewModel, User>();
        }
    }
}