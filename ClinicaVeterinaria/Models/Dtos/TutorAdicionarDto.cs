using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models.Dtos {
    public class TutorAdicionarDto {

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }
        [Required]
        [MaxLength(200)]
        public string Endereco { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefone { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        [ForeignKey("TutorId")]
        public List<Paciente> PacienteList { get; set; }
    }
}
