﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gerente.Infra.Data.Migrations
{
    public partial class Mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FotoExtensao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SecretariaId = table.Column<int>(type: "int", nullable: true),
                    Secretaria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SetorId = table.Column<int>(type: "int", nullable: true),
                    Setor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    IdObjeto = table.Column<int>(type: "int", nullable: false),
                    Tabela = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Operacao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    AuditadoPor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    AuditadoEm = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NaturezaProcedimento = table.Column<int>(type: "int", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false),
                    DoisMembros = table.Column<bool>(type: "bit", nullable: false),
                    TempoDuracao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procedimento_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LocalProcedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalProcedimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalProcedimento_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LocalProcedimento_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Secretaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NomeSimplificado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secretaria_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Secretaria_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalProcedimentoId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_LocalProcedimento_LocalProcedimentoId",
                        column: x => x.LocalProcedimentoId,
                        principalTable: "LocalProcedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecretariaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setor_Secretaria_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretariaId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Secretaria_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cargo_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    ContratoId = table.Column<int>(type: "int", nullable: false),
                    AditivoId = table.Column<int>(type: "int", nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aditivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DataAditivo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesesAcrescidos = table.Column<int>(type: "int", nullable: false),
                    Objeto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aditivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: false),
                    NaturezaJuridica = table.Column<int>(type: "int", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CartaoSus = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CartaoFundhacre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipoPessoa = table.Column<int>(type: "int", nullable: false),
                    SecretariaId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false),
                    AcompanhanteId = table.Column<int>(type: "int", nullable: false),
                    RepresentanteId = table.Column<int>(type: "int", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ContratoId = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoa_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoa_Pessoa_AcompanhanteId",
                        column: x => x.AcompanhanteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoa_Pessoa_RepresentanteId",
                        column: x => x.RepresentanteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoa_Secretaria_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoa_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInstrumento = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    RepresentanteId = table.Column<int>(type: "int", nullable: false),
                    ModalidadeLicitacao = table.Column<int>(type: "int", nullable: false),
                    SistemaLicitacao = table.Column<int>(type: "int", nullable: false),
                    NumeroLicitacao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinalVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Objeto = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrato_Pessoa_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Contrato_Pessoa_RepresentanteId",
                        column: x => x.RepresentanteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FilaProcedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false),
                    ProcedimentoId = table.Column<int>(type: "int", nullable: false),
                    LocalProcedimentoId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    Prioridade = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LadoDireito = table.Column<bool>(type: "bit", nullable: false),
                    LadoEsquerdo = table.Column<bool>(type: "bit", nullable: false),
                    Finalizado = table.Column<bool>(type: "bit", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilaProcedimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilaProcedimento_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilaProcedimento_LocalProcedimento_LocalProcedimentoId",
                        column: x => x.LocalProcedimentoId,
                        principalTable: "LocalProcedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilaProcedimento_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilaProcedimento_Pessoa_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilaProcedimento_Procedimento_ProcedimentoId",
                        column: x => x.ProcedimentoId,
                        principalTable: "Procedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaResponsavel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TipoTelefone = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SecretariaId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Telefone_Secretaria_SecretariaId",
                        column: x => x.SecretariaId,
                        principalTable: "Secretaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Telefone_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilaProcedimentoId = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<int>(type: "int", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MensagemNotificacao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Membro = table.Column<int>(type: "int", nullable: false),
                    Confirmado = table.Column<bool>(type: "bit", nullable: false),
                    NomePessoaConfirmacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Realizado = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    CriadoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlteradoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AlteradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamento_FilaProcedimento_FilaProcedimentoId",
                        column: x => x.FilaProcedimentoId,
                        principalTable: "FilaProcedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f2a91a1-df68-4566-9e8f-7d387a89bffd", "daa325fd-78a0-4ae1-a574-142d9dfda068", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Cpf", "DataNascimento", "Discriminator", "Email", "EmailConfirmed", "Foto", "FotoExtensao", "LockoutEnabled", "LockoutEnd", "Matricula", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Secretaria", "SecretariaId", "SecurityStamp", "Setor", "SetorId", "Sexo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e1b6762c-0a6c-4724-ba3c-ba0564e4ef7e", 0, "acb0ae18-dd0c-44cf-8dfb-71eb1de22151", "65788974291", new DateTime(1981, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Usuario", "fabio@arquivarnet.com.br", true, "https://fundhacre.blob.core.windows.net/avatar/masculino01.png", ".png", false, null, "123456", "Fábio Salomão Silva Vogth", "FABIO@ARQUIVARNET.COM.BR", "FABIO@ARQUIVARNET.COM.BR", "AQAAAAEAACcQAAAAEKkHzSru9lji/fZlyihN6cHdZyZlio9PH2eJSNO48iuzAyzJY7z7WGgIcPPW1xCUpA==", null, false, "Secretaria de Estado de Saúde", 1, "bffa88c1-1304-403a-92f8-330a17c4a4f8", "Complexo Regulador Estadual", 1, "Indefinido", false, "fabio@arquivarnet.com.br" });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "Nome", "Uf" },
                values: new object[] { 1, new DateTime(2021, 2, 15, 15, 49, 22, 847, DateTimeKind.Local).AddTicks(8886), "admin", true, new DateTime(2021, 2, 15, 15, 49, 22, 846, DateTimeKind.Local).AddTicks(3989), "admin", "Acre", "AC" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 34, "FilaProcedimentosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 36, "FilaProcedimentosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 37, "LocalProcedimentosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 38, "LocalProcedimentosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 39, "LocalProcedimentosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 40, "LocalProcedimentosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 41, "MedicosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 42, "MedicosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 43, "MedicosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 44, "MedicosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 45, "MunicipiosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 46, "MunicipiosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 47, "MunicipiosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 48, "MunicipiosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 49, "PessoasView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 35, "FilaProcedimentosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 50, "PessoasAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 52, "PessoasDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 53, "ProcedimentosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 54, "ProcedimentosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 55, "ProcedimentosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 56, "ProcedimentosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 57, "SecretariasView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 58, "SecretariasAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 59, "SecretariasEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 60, "SecretariasDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 61, "SetoresView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 62, "SetoresAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 63, "SetoresEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 64, "SetoresDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 65, "TelefonesView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 51, "PessoasEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 68, "TelefonesDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 33, "FilaProcedimentosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 32, "EstadosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 1, "AditivosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 2, "AditivosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 3, "AditivosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 4, "AditivosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 5, "AgendamentosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 6, "AgendamentosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 7, "AgendamentosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 8, "AgendamentosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 9, "AuditoriasView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 10, "AuditoriasAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 11, "AuditoriasEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 12, "AuditoriasDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 13, "CargosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 14, "CargosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 15, "CargosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 16, "CargosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 17, "ContratosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 31, "EstadosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 30, "EstadosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 29, "EstadosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 28, "EspecialidadesDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 27, "EspecialidadesEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 26, "EspecialidadesAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 66, "TelefonesAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 25, "EspecialidadesView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 23, "DocumentosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 22, "DocumentosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 21, "DocumentosView", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 20, "ContratosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 19, "ContratosEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 18, "ContratosAdd", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 24, "DocumentosDelete", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" },
                    { 67, "TelefonesEdit", "false", "4f2a91a1-df68-4566-9e8f-7d387a89bffd" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f2a91a1-df68-4566-9e8f-7d387a89bffd", "e1b6762c-0a6c-4724-ba3c-ba0564e4ef7e" });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "EstadoId", "Nome" },
                values: new object[] { 1, new DateTime(2021, 2, 15, 15, 49, 22, 857, DateTimeKind.Local).AddTicks(2267), "admin", true, new DateTime(2021, 2, 15, 15, 49, 22, 857, DateTimeKind.Local).AddTicks(2249), "admin", 1, "Rio Branco" });

            migrationBuilder.InsertData(
                table: "Secretaria",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "Bairro", "Cep", "Complemento", "CriadoEm", "CriadoPor", "EstadoId", "Logradouro", "MunicipioId", "Nome", "NomeSimplificado", "Numero" },
                values: new object[] { 1, new DateTime(2021, 2, 15, 15, 49, 22, 869, DateTimeKind.Local).AddTicks(4543), "admin", true, "Centro", "69900000", null, new DateTime(2021, 2, 15, 15, 49, 22, 869, DateTimeKind.Local).AddTicks(4524), "admin", 1, "Rua Benjamim Constant", 1, "Secretaria de Estado de Saúde do Acre", "SESACRE", "81" });

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "Email", "Nome", "SecretariaId" },
                values: new object[] { 1, new DateTime(2021, 2, 15, 15, 49, 22, 871, DateTimeKind.Local).AddTicks(2055), "admin", true, new DateTime(2021, 2, 15, 15, 49, 22, 871, DateTimeKind.Local).AddTicks(2048), "admin", "gerenciacomplexo@gmail.com", "Complexo Regulador Estadual", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Aditivo_ContratoId",
                table: "Aditivo",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_FilaProcedimentoId",
                table: "Agendamento",
                column: "FilaProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_Id",
                table: "Auditoria",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_SecretariaId",
                table: "Cargo",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_SetorId",
                table: "Cargo",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_FornecedorId",
                table: "Contrato",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_RepresentanteId",
                table: "Contrato",
                column: "RepresentanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_AditivoId",
                table: "Documento",
                column: "AditivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_ContratoId",
                table: "Documento",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_PessoaId",
                table: "Documento",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_FilaProcedimento_EspecialidadeId",
                table: "FilaProcedimento",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_FilaProcedimento_LocalProcedimentoId",
                table: "FilaProcedimento",
                column: "LocalProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_FilaProcedimento_MedicoId",
                table: "FilaProcedimento",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FilaProcedimento_PacienteId",
                table: "FilaProcedimento",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_FilaProcedimento_ProcedimentoId",
                table: "FilaProcedimento",
                column: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalProcedimento_EstadoId",
                table: "LocalProcedimento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalProcedimento_MunicipioId",
                table: "LocalProcedimento",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_LocalProcedimentoId",
                table: "Medico",
                column: "LocalProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_EstadoId",
                table: "Municipio",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_AcompanhanteId",
                table: "Pessoa",
                column: "AcompanhanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CartaoFundhacre",
                table: "Pessoa",
                column: "CartaoFundhacre",
                unique: true,
                filter: "[CartaoFundhacre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CartaoSus",
                table: "Pessoa",
                column: "CartaoSus",
                unique: true,
                filter: "[CartaoSus] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Cnpj",
                table: "Pessoa",
                column: "Cnpj",
                unique: true,
                filter: "[Cnpj] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_ContratoId",
                table: "Pessoa",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Cpf",
                table: "Pessoa",
                column: "Cpf",
                unique: true,
                filter: "[Cpf] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EstadoId",
                table: "Pessoa",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_MunicipioId",
                table: "Pessoa",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_RepresentanteId",
                table: "Pessoa",
                column: "RepresentanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_SecretariaId",
                table: "Pessoa",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_SetorId",
                table: "Pessoa",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedimento_EspecialidadeId",
                table: "Procedimento",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Secretaria_EstadoId",
                table: "Secretaria",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Secretaria_MunicipioId",
                table: "Secretaria",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Setor_SecretariaId",
                table: "Setor",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_SecretariaId",
                table: "Telefone",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_SetorId",
                table: "Telefone",
                column: "SetorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_Aditivo_AditivoId",
                table: "Documento",
                column: "AditivoId",
                principalTable: "Aditivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_Contrato_ContratoId",
                table: "Documento",
                column: "ContratoId",
                principalTable: "Contrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Documento_Pessoa_PessoaId",
                table: "Documento",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Aditivo_Contrato_ContratoId",
                table: "Aditivo",
                column: "ContratoId",
                principalTable: "Contrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Contrato_ContratoId",
                table: "Pessoa",
                column: "ContratoId",
                principalTable: "Contrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Contrato_ContratoId",
                table: "Pessoa");

            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "FilaProcedimento");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Aditivo");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.DropTable(
                name: "LocalProcedimento");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "Secretaria");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}