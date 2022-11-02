using System.Collections.ObjectModel;

namespace ClinicaVeterinaria.Models {
    public class Tutor {
        

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public List<Paciente> PacienteList { get; set; }

        public Tutor(Guid id, string nome, string cPF, string endereco, string telefone, string dataNascimento) {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public Tutor() {
        }
    }
}
