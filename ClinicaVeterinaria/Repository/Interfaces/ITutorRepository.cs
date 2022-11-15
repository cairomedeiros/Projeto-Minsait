using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;

namespace ClinicaVeterinaria.Repository.Interfaces
{
    public interface ITutorRepository
    {
        Task<List<Tutor>> RetornarTodosTutores();
        Task<Tutor> BuscarPorId(Guid id);
        Task<Tutor> Adicionar(TutorAdicionarDto tutorAdicionarDto);
        Task<Tutor> Editar(Guid id, TutorEditarDTO tutorEditarDTO);
        Task<bool> DesativarTutor(Guid id);
    }
}
