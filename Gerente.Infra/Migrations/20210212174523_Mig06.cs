using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gerente.Infra.Data.Migrations
{
    public partial class Mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Setor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Cpf", "DataNascimento", "Discriminator", "Email", "EmailConfirmed", "Foto", "FotoExtensao", "LockoutEnabled", "LockoutEnd", "Matricula", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Secretaria", "SecretariaId", "SecurityStamp", "Setor", "SetorId", "Sexo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7fbb0d73-ec4b-4e73-ab8e-677d182839b6", 0, "b3600bb1-cd42-4998-b635-38878ef32e4a", "65788974291", new DateTime(1981, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Usuario", "fabio@arquivarnet.com.br", true, "https://fundhacre.blob.core.windows.net/avatar/masculino01.png", ".png", false, null, "123456", "Fábio Salomão Silva Vogth", null, null, "AQAAAAEAACcQAAAAEFgmiFClWXRobSvg0eZ0+jdrdHX3XLNbEsVVq0G89sqmLcrfa1APmlbmOuGfDsuwyg==", null, false, null, 1, "efa731be-dd57-4b44-bb4d-0527ec82fbd7", null, 1, "Indefinido", false, "fabio@arquivarnet.com.br" });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "Nome", "Uf" },
                values: new object[] { 1, new DateTime(2021, 2, 12, 12, 45, 22, 745, DateTimeKind.Local).AddTicks(7989), "admin", true, new DateTime(2021, 2, 12, 12, 45, 22, 744, DateTimeKind.Local).AddTicks(1614), "admin", "Acre", "AC" });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "EstadoId", "Nome" },
                values: new object[] { 1, new DateTime(2021, 2, 12, 12, 45, 22, 748, DateTimeKind.Local).AddTicks(3659), "admin", true, new DateTime(2021, 2, 12, 12, 45, 22, 748, DateTimeKind.Local).AddTicks(2824), "admin", 1, "Rio Branco" });

            migrationBuilder.InsertData(
                table: "Secretaria",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "Bairro", "Cep", "Complemento", "CriadoEm", "CriadoPor", "EstadoId", "Logradouro", "MunicipioId", "Nome", "NomeSimplificado", "Numero" },
                values: new object[] { 1, new DateTime(2021, 2, 12, 12, 45, 22, 749, DateTimeKind.Local).AddTicks(30), "admin", true, "Centro", "69900000", null, new DateTime(2021, 2, 12, 12, 45, 22, 748, DateTimeKind.Local).AddTicks(9362), "admin", 1, "Rua Benjamim Constant", 1, "Secretaria de Estado de Saúde do Acre", "SESACRE", "81" });

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "Id", "AlteradoEm", "AlteradoPor", "Ativo", "CriadoEm", "CriadoPor", "Email", "Nome", "SecretariaId" },
                values: new object[] { 1, new DateTime(2021, 2, 12, 12, 45, 22, 749, DateTimeKind.Local).AddTicks(9661), "admin", true, new DateTime(2021, 2, 12, 12, 45, 22, 749, DateTimeKind.Local).AddTicks(8991), "admin", "gerenciacomplexo@gmail.com", "Complexo Regulador Estadual", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fbb0d73-ec4b-4e73-ab8e-677d182839b6");

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Secretaria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Municipio",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Setor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
