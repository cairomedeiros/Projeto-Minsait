using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Models.Dtos;
using ClinicaVeterinaria.Repository;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly LogErroRepository _logErroRepository;
        private readonly string erroBadRequest = "Ocorreu uma falha interna.";

        public PacienteController(IPacienteRepository pacienteRepository, ClinicaContext _dbContext)
        {
            _pacienteRepository = pacienteRepository;
            _logErroRepository = new(_dbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<Paciente>>> RetornarTodosTutores()
        {
            try
            {
                List<Paciente> resultado = await _pacienteRepository.RetornarTodosPacientes();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }

        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Paciente>> BuscarPorId(Guid id)
        {
            try
            {
                Paciente resultado = await _pacienteRepository.BuscarPorId(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Paciente>> Adicionar([FromBody] PacienteAdicionarDto pacienteAdicionarDto)
        {
            try
            {
                Paciente resultado = await _pacienteRepository.Adicionar(pacienteAdicionarDto);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Paciente>> Editar(Guid id, [FromBody] Paciente paciente)
        {
            try
            {
                paciente.Id = id;
                Paciente resultado = await _pacienteRepository.Editar(id, paciente);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeletarPaciente(Guid id)
        {
            try
            {
                bool resultado = await _pacienteRepository.DeletarPaciente(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _logErroRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }
    }
}
