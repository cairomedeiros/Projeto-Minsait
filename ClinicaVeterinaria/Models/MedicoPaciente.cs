using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class MedicoPaciente {
        [ForeignKey("MedicoResponsavelId")]
        public Guid MedicoResponsavelId { get; set; }
        [ForeignKey("PacienteId")]
        public Guid PacienteId { get; set; }
    }
}
