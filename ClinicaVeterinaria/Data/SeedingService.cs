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

            Tutor tutor1 = new(new Guid(), "Cairo", "12312332124", "Cabedelo", "99999999", "05/07/2000");
            Tutor tutor2 = new(new Guid(), "Bob Esponja", "12312332124", "Oceano", "99999999", "12/22/2000");
            Tutor tutor3 = new(new Guid(), "Naruto", "12312332124", "Konoha", "99999999", "16/10/1990");
            Tutor tutor4 = new(new Guid(), "Maria Rita", "12312332124", "João Pessoa", "99999999", "02/05/2002");

            Paciente paciente1 = new(new Guid(), "Nymeria", "Cachorro", "Pastor alemão", 4, 20, "Preta", "Dr. Júlio", tutor1.Id, tutor1);
            Paciente paciente2 = new(new Guid(), "Mel", "Cachorro", "Shitzu", 7, 20, "Marrom", "Dr. Júlio", tutor4.Id, tutor4);
            Paciente paciente3 = new(new Guid(), "Nemo", "Peixe", "Peixe palhaço", 20, 1, "Laranja com listras", "Dr. Júlio", tutor1.Id, tutor1);
            Paciente paciente4 = new(new Guid(), "Gary", "Caracol", "Caracol do mar", 16, 10, "Rosa", "Dr. Júlio", tutor2.Id, tutor2);
            Paciente paciente5 = new(new Guid(), "Gamakichi", "Sapo", "Sapo ninja", 100, 30, "Laranja", "Dr. Jiraya", tutor3.Id, tutor3);
            Paciente paciente6 = new(new Guid(), "Kurama", "Raposa", "Raposa de nove caldas", 90, 102, "preto", "Dr. Jiraya", tutor3.Id, tutor3);

            _context.Tutores.AddRange(tutor1, tutor2, tutor3, tutor4);
            _context.Pacientes.AddRange(paciente1, paciente2, paciente3, paciente4, paciente5, paciente6);

            _context.SaveChanges();

           

        }
    }   
}
