using ClinicaVeterinaria.Enum;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models.Dtos
{
    public class PacienteDto
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(100)]
        public string Especie { get; set; }
        [Required]
        [MaxLength(150)]
        public string Raca { get; set; }
        [Required]
        public double Idade { get; set; }
        [Required]
        public double Peso { get; set; }
        [MaxLength(80)]
        [Required]
        public string Cor { get; set; }
        [Required]
        public Guid TutorId { get; set; }
        [Required]
        public EResultadoTriagem EResultadoTriagem { get; set; }
    }
}
