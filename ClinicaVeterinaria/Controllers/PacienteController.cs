using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Repository;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers {
    public class PacienteController : Controller {
        private readonly IPacienteRepository _pacienteRepository;

        [HttpGet]
        public async Task<ActionResult<List<Paciente>>> RetornarTodosTutores() {
            List<Paciente> resultado = await _pacienteRepository.RetornarTodosPacientes();
            return Ok(resultado);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Paciente>> BuscarPorId(Guid id) {
            Paciente resultado = await _pacienteRepository.BuscarPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> Adicionar([FromBody] Paciente paciente) {
            Paciente resultado = await _pacienteRepository.Adicionar(paciente);
            return Ok(resultado);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Paciente>> Editar(Guid id, [FromBody] Paciente paciente) {
            paciente.Id = id;
            Paciente resultado = await _pacienteRepository.Editar(id, paciente);
            return Ok(resultado);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeletarPaciente(Guid id) {
            bool resultado = await _pacienteRepository.DeletarPaciente(id);
            return Ok(resultado);
        }
    }
}
