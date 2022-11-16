using ClinicaVeterinaria.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models.Dtos
{
    public class PacienteEditarDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, MaxLength(100)]
        public string Especie { get; set; }
        [Required, MaxLength(150)]
        public string Raca { get; set; }
        [Required]
        public double Idade { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required, MaxLength(80)]
        public string Cor { get; set; }
        [Required]
        public EResultadoTriagem? EResultadoTriagem { get; set; }
    }
}
