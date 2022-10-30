using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Repository.Interfaces {
    public interface ITutorRepository {

        Task<List<Tutor>> RetornarTodosTutores();
        Task<Tutor> BuscarPorId(Guid id);
        Task<Tutor> Adicionar(Tutor tutor);
        Task<Tutor> Editar(Guid id, Tutor tutor);
        Task<bool> DeletarTutor(Guid id);
    }
}
