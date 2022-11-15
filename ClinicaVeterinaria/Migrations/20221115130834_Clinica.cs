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
                    { new Guid("40213770-be5a-4c20-9a3b-31e405378768"), "12312332124", "03/05/1990", "Grand Line", "Luffy", "99999999" },
                    { new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029"), "12312332124", "16/10/1997", "Konoha", "Naruto", "99999999" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Cor", "EResultadoTriagem", "Especie", "Idade", "Nome", "Peso", "Raca", "TutorId" },
                values: new object[,]
                {
                    { new Guid("0628d876-63b3-4b5e-923e-0678941494e5"), "Laranja", "Hematologia", "Dragão", 3.0, "Dragaozinho", 40.0, "Charmander", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") },
                    { new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"), "Marrom", "Cardiologia", "Cachorro", 7.0, "Mel", 10.0, "Shitzu", new Guid("40213770-be5a-4c20-9a3b-31e405378768") },
                    { new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"), "Preta", "Odontologia", "Cachorro", 4.0, "Nymeria", 22.0, "Pastor Alemão", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") },
                    { new Guid("3abe35e4-ec64-4226-8ec7-f2d4fe942177"), "Preta e branca", "Endocrinologia", "Cachorro", 4.0, "Maya", 10.0, "Shitzu", new Guid("40213770-be5a-4c20-9a3b-31e405378768") },
                    { new Guid("59045bc1-2b6c-4f5a-a01d-79f5190a28e3"), "Laranja", "Cardiologia", "Peixe", 30.0, "Nemo", 1.0, "Peixe Palhaço", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") },
                    { new Guid("9bac6f15-a352-481c-b06e-3e0d82f18ff4"), "Verde e branca", "Oftalmologia", "Pokemón Gato", 5.0, "Snorlax", 1000.0, "Snorlax", new Guid("ea249baa-c22a-495f-981b-ed6d7c9ea029") },
                    { new Guid("eaa6291d-849a-471d-bc0b-2be7bcc3c696"), "Azul", "Nutrologia", "Pokemón Tartaruga", 12.0, "Giga", 700.0, "Blastoise", new Guid("40213770-be5a-4c20-9a3b-31e405378768") }
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
