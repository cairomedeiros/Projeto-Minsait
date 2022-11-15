using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ClinicaVeterinaria.Repository
{
    public class TutorRepository : ITutorRepository
    {
        private readonly ClinicaContext _dbContext;

        public TutorRepository(ClinicaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Tutor> Adicionar(TutorAdicionarDto tutorAdicionarDto)
        {
            Tutor tutor = new Tutor();

            tutor.Nome = tutorAdicionarDto.Nome;
            tutor.CPF = tutorAdicionarDto.CPF;
            tutor.Endereco = tutorAdicionarDto.Endereco;
            tutor.Telefone = tutorAdicionarDto.Telefone;
            tutor.DataNascimento = tutorAdicionarDto.DataNascimento;
            tutor.Ativo = true;
            tutor.PacienteList = tutorAdicionarDto.PacienteList;

            await _dbContext.Tutores.AddAsync(tutor);
            await _dbContext.SaveChangesAsync();
            return tutor;
        }

        public async Task<Tutor> BuscarPorId(Guid id)
        {
            var tutor = await _dbContext.Tutores
                .Include(x => x.PacienteList)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (tutor == null)
            {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
            }
            return tutor;
        }

        public async Task<bool> DesativarTutor(Guid id)
        {
            var tutorId = await _dbContext.Tutores.FindAsync(id);

            if (tutorId == null)
            {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
            }

            tutorId.Ativo = false;

            _dbContext.Tutores.Update(tutorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Tutor> Editar(Guid id, TutorEditarDTO tutorEditarDTO)
        {
            var tutorId = await _dbContext.Tutores.FindAsync(id);
            if (tutorId == null)
            {
                throw new Exception($"Tutor com Id: ${id} não encontrado");
            }
            tutorId.Nome = tutorEditarDTO.Nome;
            tutorId.CPF = tutorEditarDTO.CPF;
            tutorId.Endereco = tutorEditarDTO.Endereco;
            tutorId.Telefone = tutorEditarDTO.Telefone;
            tutorId.DataNascimento = tutorEditarDTO.DataNascimento;

            _dbContext.Tutores.Update(tutorId);
            await _dbContext.SaveChangesAsync();

            return tutorId;
        }

        public async Task<List<Tutor>> RetornarTodosTutores()
        {
            return await _dbContext.Tutores.Include(x => x.PacienteList).Where(w => w.Ativo).ToListAsync();
        }
    }
}
