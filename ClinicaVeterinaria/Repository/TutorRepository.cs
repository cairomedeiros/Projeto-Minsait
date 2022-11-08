using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ClinicaVeterinaria.Repository {
    public class TutorRepository : ITutorRepository {
        private readonly ClinicaContext _dbContext;

        public TutorRepository(ClinicaContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Tutor> Adicionar(TutorAdicionarDto tutorAdicionarDto) {
            Tutor tutor = new Tutor();

            tutor.Nome = tutorAdicionarDto.Nome;
            tutor.CPF = tutorAdicionarDto.CPF;
            tutor.Endereco = tutorAdicionarDto.Endereco;
            tutor.Telefone = tutorAdicionarDto.Telefone;
            tutor.DataNascimento = tutorAdicionarDto.DataNascimento;
            tutor.PacienteList = tutorAdicionarDto.PacienteList;

            await _dbContext.Tutores.AddAsync(tutor);
            await _dbContext.SaveChangesAsync();
            return tutor;
        }

        public async Task<Tutor> BuscarPorId(Guid id) {

            var tutor = await _dbContext.Tutores
                .Include(x => x.PacienteList)
                .FirstOrDefaultAsync(x => x.Id == id);


            if (tutor == null) {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
                
            }

            return tutor;

        }

        public async Task<bool> DeletarTutor(Guid id) {
            var tutorId = await _dbContext.Tutores.FindAsync(id);

            if(tutorId == null) {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
            }

            _dbContext.Remove(tutorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Tutor> Editar(Guid id, Tutor tutor) {
            var tutorId = await _dbContext.Tutores.FindAsync(id);
            if(tutorId == null) {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
            }

            tutorId.Nome = tutor.Nome;
            tutorId.CPF = tutor.CPF;
            tutorId.Endereco = tutor.Endereco;
            tutorId.Telefone = tutor.Telefone;
            tutorId.DataNascimento = tutor.DataNascimento;
            tutorId.PacienteList = tutor.PacienteList;

            _dbContext.Tutores.Update(tutorId);
            await _dbContext.SaveChangesAsync();

            return tutorId;
        }

        public async Task<List<Tutor>> RetornarTodosTutores() {
            return await _dbContext.Tutores.Include(x => x.PacienteList).ToListAsync();
        }
    }
}
