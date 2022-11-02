using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Data {
    public class ClinicaContext : DbContext {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options) {
            
        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<MedicoResponsavel> MedicosResponsaveis { get; set; }



    }
}
