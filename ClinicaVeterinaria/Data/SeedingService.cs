using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Data {
    public class SeedingService {
        private readonly ClinicaContext _context;

        public SeedingService(ClinicaContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Tutores.Any() ||
                _context.Pacientes.Any()) {
                return;
            }

            Tutor tutor1 = new(new Guid(), "Cairo", "12312332124", "cabedelo", "99999999", "12/22/2000");
            Paciente paciente1 = new(new Guid(), "Nymeria", "Cachorro", "Pastor alemão", tutor1, 12, 20, "preto", "Dr. Júlio");

            _context.Tutores.AddRange(tutor1);
            _context.Pacientes.AddRange(paciente1);

            _context.SaveChanges();

           

        }
    }   
}
