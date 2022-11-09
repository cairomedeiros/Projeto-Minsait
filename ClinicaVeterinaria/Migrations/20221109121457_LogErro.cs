using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaVeterinaria.Migrations
{
    public partial class LogErro : Migration
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
                    DataHoraRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogErros");
        }
    }
}
