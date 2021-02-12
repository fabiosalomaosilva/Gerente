using System;
using Gerente.Domain.Entities;
using Gerente.Infra.Data.EntityConfiguration;
using Gerente.Infra.Data.Models;
using Microsoft.AspNetCore.Identity;
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

            builder.Entity<Estado>().HasData(new Estado
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Acre",
                Uf = "AC"
            });
            builder.Entity<Municipio>().HasData(new Municipio
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Rio Branco",
                EstadoId = 1
            });
            builder.Entity<Secretaria>().HasData(new Secretaria
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Secretaria de Estado de Saúde do Acre",
                NomeSimplificado = "SESACRE",
                Logradouro = "Rua Benjamim Constant",
                Numero = "81",
                Bairro = "Centro",
                Cep = "69900000",
                EstadoId = 1,
                MunicipioId = 1
            });
            builder.Entity<Setor>().HasData(new Setor
            {
                Id = 1,
                CriadoPor = "admin",
                AlteradoPor = "admin",
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                Ativo = true,
                Nome = "Complexo Regulador Estadual",
                Email = "gerenciacomplexo@gmail.com",
                SecretariaId = 1
            });

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
                EmailConfirmed = true
            };
            var ph = new PasswordHasher<Usuario>();
            user.PasswordHash = ph.HashPassword(user, user.Cpf);
            builder.Entity<Usuario>().HasData(user);
        }
    }
}
