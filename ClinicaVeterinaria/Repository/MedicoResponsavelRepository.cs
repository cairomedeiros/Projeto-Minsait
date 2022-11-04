using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Repository {
    public class MedicoResponsavelRepository : IMedicoResponsavelRepository{
        private readonly ClinicaContext _dbContext;

        public MedicoResponsavelRepository(ClinicaContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<MedicoResponsavel> Adicionar(MedicoResponsavel medicoResponsavel) {
            await _dbContext.MedicosResponsaveis.AddAsync(medicoResponsavel);
            await _dbContext.SaveChangesAsync();
            return medicoResponsavel;
        }

        public async Task<MedicoResponsavel> BuscarPorId(Guid id) {
            var medicoResponsavel = await _dbContext.MedicosResponsaveis
                .Include(b => b.PacienteList)
                .FirstOrDefaultAsync(y => y.Id == id);

            if (medicoResponsavel == null)
            {
                throw new Exception($"Médico com Id: ${id} não encontrado");
            }
            return medicoResponsavel;
        }

        public async Task<bool> DeletarMedico(Guid id) {
            var medicoResponsavelId = await _dbContext.Pacientes.FindAsync(id);

            if (medicoResponsavelId == null)
            {
                throw new Exception($"Médico com Id: ${id} não encontrado");
            }
            _dbContext.Remove(medicoResponsavelId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<MedicoResponsavel> Editar(Guid id, MedicoResponsavel medicoResponsavel) {
            var medicoResponsavelId = await _dbContext.MedicosResponsaveis.FindAsync(id);
            if (medicoResponsavelId == null)
            {
                throw new Exception($"Médico com Id: ${id} não encontrado");
            }
            medicoResponsavelId.Nome = medicoResponsavel.Nome;
            _dbContext.MedicosResponsaveis.Update(medicoResponsavelId);
            await _dbContext.SaveChangesAsync();
            return medicoResponsavelId;
        }

        public async Task<List<MedicoResponsavel>> RetornarTodosMedicos() {
            return await _dbContext.MedicosResponsaveis
                .Include(a => a.PacienteList)
                .ToListAsync();
        }
    }
}
