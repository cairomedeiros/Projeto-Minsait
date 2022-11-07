using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaVeterinaria.Migrations
{
    public partial class AjustandoEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"),
                column: "EDirecaoEspecialidade",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"),
                column: "EDirecaoEspecialidade",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: new Guid("234eea2a-0348-45b5-99a1-44b20f010e03"),
                column: "EDirecaoEspecialidade",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: new Guid("368a4087-3de7-4bc8-921e-aa6a5a9be54a"),
                column: "EDirecaoEspecialidade",
                value: 6);
        }
    }
}
