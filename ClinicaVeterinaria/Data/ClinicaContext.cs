using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Data {
    public class TutorContext : DbContext {
        public TutorContext(DbContextOptions<TutorContext> options) : base(options) {
            
        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        

    }
}
