using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class MedicoResponsavel {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        [ForeignKey("PacienteId")]
        public Guid PacienteId { get; set; }
        public List<Paciente> PacienteList { get; set; }

        public MedicoResponsavel(Guid id, string nome, Guid pacienteId) {
            Id = id;
            Nome = nome;
            PacienteId = pacienteId;
        }

        public MedicoResponsavel() {

        }
    }
}
