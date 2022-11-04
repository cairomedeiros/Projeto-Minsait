using System.ComponentModel;
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
        [ForeignKey("TutorId")]
        public Guid TutorId { get; set; }
        public Tutor Tutor { get; set; }
        [ForeignKey("MedicoId")]
        public Guid MedicoId {get; set;}
        public List<MedicoResponsavel> MedicoResponsavelList { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, int idade, float peso, string cor, Guid tutorId, Tutor tutor, Guid medicoId) {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            TutorId = tutorId;
            Tutor = tutor;
            MedicoId = medicoId;
        }

        public Paciente() {
        }
    }
}
