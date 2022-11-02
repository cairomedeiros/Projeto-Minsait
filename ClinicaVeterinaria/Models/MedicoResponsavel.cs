namespace ClinicaVeterinaria.Models {
    public class MedicoResponsavel {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Paciente Paciente { get; set; }

        public MedicoResponsavel(Guid id, string nome, Paciente paciente) {
            Id = id;
            Nome = nome;
            Paciente = paciente;
        }

        public MedicoResponsavel() {

        }
    }
}
