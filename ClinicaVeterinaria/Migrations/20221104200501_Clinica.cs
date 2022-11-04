using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaVeterinaria.Migrations
{
    public partial class Clinica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Especie = table.Column<string>(type: "text", nullable: false),
                    Raca = table.Column<string>(type: "text", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Cor = table.Column<string>(type: "text", nullable: false),
                    TutorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "CPF", "DataNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { new Guid("40213770-be5a-4c20-9a3b-31e405378768"), "12312332124", "02/05/2002", "JP", "Rita", "99999999" },
                    { new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029"), "12312332124", "05/07/2000", "Cabedelo", "Cairo", "99999999" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Cor", "Especie", "Idade", "Nome", "Peso", "Raca", "TutorId" },
                values: new object[,]
                {
                    { new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"), "Marrom", "Cachorro", 7, "Mel", 10f, "Shitzu", new Guid("40213770-be5a-4c20-9a3b-31e405378768") },
                    { new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"), "Preta", "Cachorro", 4, "Nymeria", 22f, "Pastor Alemão", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}
