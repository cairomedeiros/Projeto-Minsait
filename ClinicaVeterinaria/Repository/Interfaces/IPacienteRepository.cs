using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Repository.Interfaces {
    public interface IPacienteRepository {


        Task<List<Paciente>> RetornarTodosPacientes();
        Task<Paciente> BuscarPorId(Guid id);
        Task<Paciente> Adicionar(Paciente paciente);
        Task<Paciente> Editar(Guid id, Paciente paciente);
        Task<bool> DeletarPaciente(Guid id);
    }
}
