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
                name: "MedicosPacientes",
                columns: table => new
                {
                    MedicoResponsavelId = table.Column<Guid>(type: "uuid", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicosPacientes", x => new { x.PacienteId, x.MedicoResponsavelId });
                });

            migrationBuilder.CreateTable(
                name: "MedicosResponsaveis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicosResponsaveis", x => x.Id);
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
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Especie = table.Column<string>(type: "text", nullable: false),
                    Raca = table.Column<string>(type: "text", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Cor = table.Column<string>(type: "text", nullable: false),
                    TutorId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicoId = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "MedicoResponsavelPaciente",
                columns: table => new
                {
                    MedicoResponsavelListId = table.Column<Guid>(type: "uuid", nullable: false),
                    PacienteListId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoResponsavelPaciente", x => new { x.MedicoResponsavelListId, x.PacienteListId });
                    table.ForeignKey(
                        name: "FK_MedicoResponsavelPaciente_MedicosResponsaveis_MedicoRespons~",
                        column: x => x.MedicoResponsavelListId,
                        principalTable: "MedicosResponsaveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoResponsavelPaciente_Pacientes_PacienteListId",
                        column: x => x.PacienteListId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MedicosResponsaveis",
                columns: new[] { "Id", "Nome", "PacienteId" },
                values: new object[,]
                {
                    { new Guid("b6d4b287-9e5e-4c36-8320-689a941d8074"), "Jiraya", new Guid("234eea2a-0348-45b5-99a1-44b20f010e03") },
                    { new Guid("e894a7a1-36c9-4b7d-995a-b23de86f4c36"), "Naruto", new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a") }
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
                columns: new[] { "Id", "Cor", "Especie", "Idade", "MedicoId", "Nome", "Peso", "Raca", "TutorId" },
                values: new object[,]
                {
                    { new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"), "Marrom", "Cachorro", 7, new Guid("b6d4b287-9e5e-4c36-8320-689a941d8074"), "Mel", 10f, "Shitzu", new Guid("40213770-be5a-4c20-9a3b-31e405378768") },
                    { new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"), "Preta", "Cachorro", 4, new Guid("e894a7a1-36c9-4b7d-995a-b23de86f4c36"), "Nymeria", 22f, "Pastor Alemão", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoResponsavelPaciente_PacienteListId",
                table: "MedicoResponsavelPaciente",
                column: "PacienteListId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoResponsavelPaciente");

            migrationBuilder.DropTable(
                name: "MedicosPacientes");

            migrationBuilder.DropTable(
                name: "MedicosResponsaveis");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}
