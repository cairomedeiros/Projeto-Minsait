using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;
using ClinicaVeterinaria.Repository;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase {

        private readonly ITutorRepository _tutorRepository;
        private readonly LogErroRepository _logErroRepository;
        private readonly string erroBadRequest = "Ocorreu uma falha interna.";

        public TutorController(ITutorRepository tutorRepository, ClinicaContext _dbContext) { 
            _tutorRepository = tutorRepository;
            _logErroRepository = new(_dbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<Tutor>>> RetornarTodosTutores() {
            try
            {
                List<Tutor> resultado = await _tutorRepository.RetornarTodosTutores();
                return Ok(resultado);
            }
            catch (Exception ex) {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Tutor>> BuscarPorId(Guid id) {
            try
            {
                Tutor resultado = await _tutorRepository.BuscarPorId(id);
                return Ok(resultado);
            }
            catch(Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Tutor>> Adicionar([FromBody] TutorAdicionarDto tutorAdicionarDto) {
            try
            {
                Tutor resultado = await _tutorRepository.Adicionar(tutorAdicionarDto);
                return Ok(resultado);
            }
            catch(Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Tutor>> Editar(Guid id, [FromBody] Tutor tutor) {
            try
            {
                tutor.Id = id;
                Tutor resultado = await _tutorRepository.Editar(id, tutor);
                return Ok(resultado);
            }
            catch(Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeletarTutor(Guid id) {
            try
            {
                bool resultado = await _tutorRepository.DeletarTutor(id);
                return Ok(resultado);
            }
            catch(Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

    }
}
