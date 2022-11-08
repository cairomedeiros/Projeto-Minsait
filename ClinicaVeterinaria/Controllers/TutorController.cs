using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase {

        private readonly ITutorRepository _tutorRepository;

        public TutorController(ITutorRepository tutorRepository) { 
            _tutorRepository = tutorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tutor>>> RetornarTodosTutores() { 
            List<Tutor> resultado = await _tutorRepository.RetornarTodosTutores();
            return Ok(resultado);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Tutor>> BuscarPorId(Guid id) {
            Tutor resultado = await _tutorRepository.BuscarPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult<Tutor>> Adicionar([FromBody] TutorAdicionarDto tutorAdicionarDto) {
            Tutor resultado = await _tutorRepository.Adicionar(tutorAdicionarDto);
            return Ok(resultado);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Tutor>> Editar(Guid id, [FromBody] Tutor tutor) {
            tutor.Id = id;
            Tutor resultado = await _tutorRepository.Editar(id, tutor);
            return Ok(resultado);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeletarTutor(Guid id) {
            bool resultado = await _tutorRepository.DeletarTutor(id);
            return Ok(resultado);
        }

    }
}
