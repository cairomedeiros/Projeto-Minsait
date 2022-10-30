namespace ClinicaVeterinaria.Models {
    public class Tutor {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public List<Paciente> PacienteList { get; set; }


    }
}
