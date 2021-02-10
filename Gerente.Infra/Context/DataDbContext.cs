using Gerente.Domain.Entities;
using Gerente.Infra.Data.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Context
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public DbSet<Aditivo> Aditivos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Cargo> Cargos{ get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FilaProcedimento> FilaProcedimentos { get; set; }
        public DbSet<LocalProcedimento> LocalProcedimentos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Secretaria> Secretarias { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Aditivo>().ToTable("Aditivo");
            builder.Entity<Agendamento>().ToTable("Agendamento");
            builder.Entity<Cargo>().ToTable("Cargo");
            builder.Entity<Contrato>().ToTable("Contrato");
            builder.Entity<Documento>().ToTable("Documento");
            builder.Entity<Especialidade>().ToTable("Especialidade");
            builder.Entity<Estado>().ToTable("Estado");
            builder.Entity<FilaProcedimento>().ToTable("FilaProcedimento");
            builder.Entity<LocalProcedimento>().ToTable("LocalProcedimento");
            builder.Entity<Medico>().ToTable("Medico");
            builder.Entity<Municipio>().ToTable("Municipio");
            builder.Entity<Pessoa>().ToTable("Pessoa");
            builder.Entity<Procedimento>().ToTable("Procedimento");
            builder.Entity<Secretaria>().ToTable("Secretaria");
            builder.Entity<Setor>().ToTable("Setor");
            builder.Entity<Telefone>().ToTable("Telefone");

            builder.ApplyConfiguration(new AditivoConfiguration());
            builder.ApplyConfiguration(new ContratoConfiguration());
            builder.ApplyConfiguration(new DocumentoConfiguration());
            builder.ApplyConfiguration(new EspecialidadeConfiguration());
            builder.ApplyConfiguration(new EstadoConfiguration());
            builder.ApplyConfiguration(new FilaProcedimentoConfiguration());
            builder.ApplyConfiguration(new LocalProcedimentoConfiguration());
            builder.ApplyConfiguration(new MedicoConfiguration());
            builder.ApplyConfiguration(new MunicipioConfiguration());
            builder.ApplyConfiguration(new PessoaConfiguration());
            builder.ApplyConfiguration(new ProcedimentoConfiguration());
            builder.ApplyConfiguration(new SecretariaConfiguration());
            builder.ApplyConfiguration(new SetorConfiguration());
            builder.ApplyConfiguration(new TelefoneConfiguration());
            builder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
