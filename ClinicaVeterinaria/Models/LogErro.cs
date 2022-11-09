using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class LogErro
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(500)]
        public string StackTrace { get; set; }
        [Required, MaxLength(200)]
        public string Mensagem { get; set; }
        [MaxLength(500)]
        public string? InnerException { get; set; }
        [Required]
        public DateTime DataHoraRegistro { get; set; }
    }
}
