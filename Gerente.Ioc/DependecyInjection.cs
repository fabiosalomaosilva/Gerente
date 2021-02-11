using Gerente.Application.Interfaces;
using Gerente.Application.Services;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Gerente.Infra.Data.Models;
using Gerente.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerente.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataDbContext>(o =>
                o.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(DataDbContext).Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<Usuario>(o =>
                {
                    o.SignIn.RequireConfirmedAccount = false;
                    o.SignIn.RequireConfirmedEmail = true;
                    o.Password.RequireDigit = false;
                    o.Password.RequireLowercase = false;
                    o.Password.RequiredLength = 6;
                    o.Password.RequireNonAlphanumeric = false;
                    o.Password.RequireUppercase = false;
                    o.User.RequireUniqueEmail = true;

                })
                .AddEntityFrameworkStores<DataDbContext>();

            services.AddScoped<IAditivoRepository, AditivoRepository>();
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IContratoRepository, ContratoRepository>();
            services.AddScoped<IDocumentoRepository, DocumentoRepository>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IFilaProcedimentoRepository, FilaProcedimentoRepository>();
            services.AddScoped<ILocalProcedimentoRepository, LocalProcedimentoRepository>();
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IMunicipioRepository, MunicipioRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IProcedimentoRepository, ProcedimentoRepository>();
            services.AddScoped<ISecretariaRepository, SecretariaRepository>();
            services.AddScoped<ISetorRepository, SetorRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();

            services.AddScoped<IAcompanhanteService, AcompanhanteService>();
            services.AddScoped<IAditivoService, AditivoService>();
            services.AddScoped<IAgendamentoService, AgendamentoService>();
            services.AddScoped<ICargoService, CargoService>();
            services.AddScoped<IContratoService, ContratoService>();
            services.AddScoped<IDocumentoAcompanhanteService, DocumentoAcompanhanteService>();
            services.AddScoped<IDocumentoAditivoService, DocumentoAditivoService>();
            services.AddScoped<IDocumentoContratoService, DocumentoContratoService>();
            services.AddScoped<IEspecialidadeService, EspecialidadeService>();
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<IFilaProcedimentoService, FilaProcedimentoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<ILocalProcedimentoService, LocalProcedimentoService>();
            services.AddScoped<IMedicoService, MedicoService>();
            services.AddScoped<IMunicipioService, MunicipioService>();
            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<ProcedimentoService, ProcedimentoService>();
            services.AddScoped<ISecretariaService, SecretariaService>();
            services.AddScoped<IServidorService, ServidorService>();
            services.AddScoped<ISetorService, SetorService>();
            services.AddScoped<ITelefoneService, TelefoneService>();

            return services;
        }
    }
}
