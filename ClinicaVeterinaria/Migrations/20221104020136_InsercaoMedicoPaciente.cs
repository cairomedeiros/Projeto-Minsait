using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaVeterinaria.Migrations
{
    public partial class InsercaoMedicoPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO public.\"MedicoResponsavelPaciente\" (\"MedicoResponsavelListId\", \"PacienteListId\") VALUES ('e894a7a136c94b7d995ab23de86f4c36','368a40873de74bc8921eaa6a5a9be54a')");
            migrationBuilder.Sql($"INSERT INTO public.\"MedicoResponsavelPaciente\" (\"MedicoResponsavelListId\", \"PacienteListId\") VALUES ('b6d4b2879e5e4c368320689a941d8074','234eea2a034845b599a144b20f010e03')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
