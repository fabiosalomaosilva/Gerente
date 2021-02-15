using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Infra.Data.EntityConfiguration;
using Gerente.Infra.Data.Models;
using Gerente.Infra.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Context
{
    public class DataDbContext : IdentityDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public DataDbContext(DbContextOptions<DataDbContext> options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<Aditivo> Aditivos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var data = DateTime.Now;
            foreach (var i in ChangeTracker.Entries().Where(p => p.State == EntityState.Added && p.Entity is ControleVersao))
            {
                var controle = i.Entity as ControleVersao;
                controle.CriadoPor = _currentUserService.GetUser();
                controle.AlteradoPor = _currentUserService.GetUser();
                controle.CriadoEm = data;
                controle.AlteradoEm = data;
                controle.Ativo = true;
            }
            foreach (var i in ChangeTracker.Entries().Where(p => p.State == EntityState.Modified && p.Entity is ControleVersao))
            {
                var controle = i.Entity as ControleVersao;
                controle.AlteradoPor = _currentUserService.GetUser();
                controle.AlteradoEm = data;
                i.Property(nameof(controle.CriadoPor)).IsModified = false;
                i.Property(nameof(controle.CriadoEm)).IsModified = false;
                i.Property(nameof(controle.Ativo)).IsModified = false;
            }
            foreach (var i in ChangeTracker.Entries().Where(p => p.State == EntityState.Deleted && p.Entity is ControleVersao))
            {
                var controle = i.Entity as ControleVersao;
                controle.AlteradoPor = _currentUserService.GetUser();
                controle.AlteradoEm = data;
                i.Property(nameof(controle.CriadoPor)).IsModified = false;
                i.Property(nameof(controle.CriadoEm)).IsModified = false;
                i.Property(nameof(controle.Ativo)).IsModified = false;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Aditivo>().ToTable("Aditivo");
            builder.Entity<Agendamento>().ToTable("Agendamento");
            builder.Entity<Auditoria>().ToTable("Auditoria");
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
            builder.ApplyConfiguration(new AgendamentoConfiguration());
            builder.ApplyConfiguration(new AuditoriaConfiguration());
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

            var role = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            builder.Entity<IdentityRole>().HasData(role);

            var lista = this.RetornaTabelas();
            int id = 0;
            foreach (var i in lista)
            {
                id++;
                builder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>
                {
                    Id = id,
                    ClaimType = $"{i}View",
                    ClaimValue = "false",
                    RoleId = role.Id
                });
        
                id++;
                builder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>
                {
                    Id = id,
                    ClaimType = $"{i}Add",
                    ClaimValue = "false",
                    RoleId = role.Id
                });

                id++;
                builder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>
                {
                    Id = id,
                    ClaimType = $"{i}Edit",
                    ClaimValue = "false",
                    RoleId = role.Id
                });

                id++;
                builder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>
                {
                    Id = id,
                    ClaimType = $"{i}Delete",
                    ClaimValue = "false",
                    RoleId = role.Id
                });

            }

            var user = new Usuario
            {
                Id = Guid.NewGuid().ToString(),
                NomeCompleto = "Fábio Salomão Silva Vogth",
                Email = "fabio@arquivarnet.com.br",
                UserName = "fabio@arquivarnet.com.br",
                Matricula = "123456",
                Cpf = "65788974291",
                DataNascimento = Convert.ToDateTime("08/02/1981"),
                SecretariaId = 1,
                SetorId = 1,
                Foto = "https://fundhacre.blob.core.windows.net/avatar/masculino01.png",
                FotoExtensao = ".png",
                Sexo = "Indefinido",
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                NormalizedEmail = "FABIO@ARQUIVARNET.COM.BR"
            };
            var ph = new PasswordHasher<Usuario>();
            user.PasswordHash = ph.HashPassword(user, user.Cpf);
            builder.Entity<Usuario>().HasData(user);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = role.Id,
                UserId = user.Id
            });

        }
    }
}
