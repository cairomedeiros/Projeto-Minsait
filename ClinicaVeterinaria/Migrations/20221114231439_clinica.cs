using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaVeterinaria.Migrations
{
    public partial class clinica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogErros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StackTrace = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Mensagem = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    InnerException = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DataHoraRegistro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErros", x => x.Id);
                });

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
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Especie = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Raca = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Idade = table.Column<double>(type: "double precision", nullable: true),
                    Peso = table.Column<double>(type: "double precision", nullable: true),
                    Cor = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    TutorId = table.Column<Guid>(type: "uuid", nullable: true),
                    EResultadoTriagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "CPF", "DataNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { new Guid("40213770-be5a-4c20-9a3b-31e405378768"), "12312332124", "05/07/2000", "JP", "Rita", "99999999" },
                    { new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029"), "12312332124", "02/05/2002", "Cabedelo", "Cairo", "99999999" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Cor", "EResultadoTriagem", "Especie", "Idade", "Nome", "Peso", "Raca", "TutorId" },
                values: new object[,]
                {
                    { new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"), "Marrom", "Cardiologia", "Cachorro", 7.0, "Mel", 10.0, "Shitzu", new Guid("40213770-be5a-4c20-9a3b-31e405378768") },
                    { new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"), "Preta", "Odontologia", "Cachorro", 4.0, "Nymeria", 22.0, "Pastor Alemão", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogErros");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}
