using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Repository.Interfaces {
    public interface IMedicoResponsavel {
        Task<List<MedicoResponsavel>> RetornarTodosMedicos();
        Task<MedicoResponsavel> BuscarPorId(Guid id);
        Task<MedicoResponsavel> Adicionar(MedicoResponsavel tutor);
        Task<MedicoResponsavel> Editar(Guid id, MedicoResponsavel tutor);
        Task<bool> DeletarMedico(Guid id);
    }
}
