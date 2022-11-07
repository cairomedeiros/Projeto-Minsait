using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models.Dtos {
    public class TutorAdicionarDto {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        [ForeignKey("TutorId")]
        public List<PacienteDto> PacienteDtoList { get; set; }
    }
}
