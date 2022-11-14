using ClinicaVeterinaria.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    public class Paciente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid? Id { get; set; }
        [MaxLength(100)]
        public string? Nome { get; set; }
        [MaxLength(100)]
        public string? Especie { get; set; }
        [MaxLength(150)]
        public string? Raca { get; set; }
        public double? Idade { get; set; }
        public double? Peso { get; set; }
        [MaxLength(80)]
        public string? Cor { get; set; }
        public Guid? TutorId { get; set; }
        public EResultadoTriagem? EResultadoTriagem { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, double idade, double peso, string cor, EResultadoTriagem eResultadoTriagem, Guid tutorId)
        {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            EResultadoTriagem = eResultadoTriagem;
            TutorId = tutorId;
        }

        public Paciente()
        {
        }
    }
}
