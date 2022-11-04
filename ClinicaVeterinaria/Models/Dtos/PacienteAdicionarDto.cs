namespace ClinicaVeterinaria.Models.Dtos {
    public class PacienteAdicionarDto {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public string Cor { get; set; }
        public Guid TutorId { get; set; }
    }
}
