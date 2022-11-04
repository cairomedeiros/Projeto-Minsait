using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class Paciente {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public string Cor { get; set; }
        public Guid TutorId { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, int idade, float peso, string cor, Guid tutorId) {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            TutorId = tutorId;
        }

        public Paciente() {

        }
    }
}
