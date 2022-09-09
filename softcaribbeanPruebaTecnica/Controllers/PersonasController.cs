using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using softcaribbeanPruebaTecnica.Data.Repositories;
using softcaribbeanPruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softcaribbeanPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaRepository _personasRepository;

        public PersonasController(IPersonaRepository personasRepository)
        {
            _personasRepository = personasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPersonas()
        {
            try
            {
                return Ok(await _personasRepository.GetAllPersonas());
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
           
        }

        [HttpGet("{tipo_persona}")]
        public async Task<IActionResult> ObtenerPersonasPacientes(int tipo_persona)
        {
            try
            {
                return Ok(await _personasRepository.GetPersonasPacientes(tipo_persona));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }

        [HttpPost]
        public async Task<IActionResult> CrearPersona([FromBody] Persona persona)
        {
            try
            {
                if (persona == null)
                    return BadRequest();
                if (!ModelState.IsValid)
                    return BadRequest();

                var personaCreada = await _personasRepository.InsertPersonas(persona);

                return StatusCode(200, personaCreada);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPut]
        public async Task<IActionResult> ActualizarPersona([FromBody] Persona persona)
        {
            try {
                if (persona == null)
                    return BadRequest();
                if (!ModelState.IsValid)
                    return BadRequest();

                var personaCreada = await _personasRepository.UpdatePersonas(persona);

                return Created("Se actualiza la persona", personaCreada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPersona(int id)
        {
            try
            {
                await _personasRepository.DeletePersonas(new Persona() { Id = id });
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }

}
