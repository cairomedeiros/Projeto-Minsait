namespace ClinicaVeterinaria.Models {
    public class Paciente {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public Tutor Tutor { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public string Cor { get; set; }
        public string MedicoResponsavel { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, Tutor tutor, int idade, float peso, string cor, string medicoResponsavel) {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Tutor = tutor;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            MedicoResponsavel = medicoResponsavel;
        }

        public Paciente() {
        }
    }
}
