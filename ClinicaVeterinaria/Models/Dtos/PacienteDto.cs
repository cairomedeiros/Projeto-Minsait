using ClinicaVeterinaria.Enum;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models.Dtos
{
    public class PacienteDto
    {
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Especie { get; set; }
        [MaxLength(150)]
        public string Raca { get; set; }
        public double Idade { get; set; }
        public double Peso { get; set; }
        [MaxLength(80)]
        public string Cor { get; set; }
        public Guid TutorId { get; set; }
        public EResultadoTriagem EResultadoTriagem { get; set; }
    }
}
