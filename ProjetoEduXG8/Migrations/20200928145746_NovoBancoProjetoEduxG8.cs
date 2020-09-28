using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEduXG8.Migrations
{
    public partial class NovoBancoProjetoEduxG8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curtidas",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(nullable: false),
                    IdCurtida = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtidas", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Objetivos",
                columns: table => new
                {
                    IdObjetivo = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivos", x => x.IdObjetivo);
                });

            migrationBuilder.CreateTable(
                name: "Perfils",
                columns: table => new
                {
                    IdPerfil = table.Column<Guid>(nullable: false),
                    Permissao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfils", x => x.IdPerfil);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curtidas");

            migrationBuilder.DropTable(
                name: "Objetivos");

            migrationBuilder.DropTable(
                name: "Perfils");
        }
    }
}
