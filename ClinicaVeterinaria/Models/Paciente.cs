using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class Paciente {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public string Cor { get; set; }
        public string MedicoResponsavel { get; set; }
        [ForeignKey("TutorId")]
        public Guid? TutorId { get; set; }
        public Tutor Tutor { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, int idade, float peso, string cor, string medicoResponsavel, Guid tutorId, Tutor tutor) {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            MedicoResponsavel = medicoResponsavel;
            TutorId = tutorId;
            Tutor = tutor;
        }

        public Paciente() {
        }
    }
}
