using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;

namespace ClinicaVeterinaria.Repository.Interfaces
{
    public interface IPacienteRepository
    {
        Task<List<Paciente>> RetornarTodosPacientes();
        Task<Paciente> BuscarPorId(Guid id);
        Task<Paciente> Adicionar(PacienteAdicionarDto pacienteDto);
        Task<Paciente> Editar(Guid id, Paciente paciente);
        Task<bool> DeletarPaciente(Guid id);
    }
}
