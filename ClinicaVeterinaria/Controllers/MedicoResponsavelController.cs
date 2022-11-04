using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Repository;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoResponsavelController : Controller {
        private readonly IMedicoResponsavelRepository _medicoResponsavelRepository;

        public MedicoResponsavelController(IMedicoResponsavelRepository medicicoResponsavelRepository) {
            _medicoResponsavelRepository = medicicoResponsavelRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MedicoResponsavel>>> RetornarTodosTutores() {
            List<MedicoResponsavel> resultado = await _medicoResponsavelRepository.RetornarTodosMedicos();
            return Ok(resultado);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<MedicoResponsavel>> BuscarPorId(Guid id) {
            MedicoResponsavel resultado = await _medicoResponsavelRepository.BuscarPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult<MedicoResponsavel>> Adicionar([FromBody] MedicoResponsavel medicoResponsavel) {
            MedicoResponsavel resultado = await _medicoResponsavelRepository.Adicionar(medicoResponsavel);
            return Ok(resultado);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<MedicoResponsavel>> Editar(Guid id, [FromBody] MedicoResponsavel medicoResponsavel) {
            medicoResponsavel.Id = id;
            MedicoResponsavel resultado = await _medicoResponsavelRepository.Editar(id, medicoResponsavel);
            return Ok(resultado);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeletarMedico(Guid id) {
            bool resultado = await _medicoResponsavelRepository.DeletarMedico(id);
            return Ok(resultado);
        }
    }
}
