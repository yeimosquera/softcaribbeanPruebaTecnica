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
            return Ok(await _personasRepository.GetAllPersonas());
        }

        [HttpGet("{tipo_persona}")]
        public async Task<IActionResult> ObtenerPersonasPacientes(int tipo_persona)
        {
            return Ok(await _personasRepository.GetPersonasPacientes(tipo_persona));

        }

        [HttpPost]
        public async Task<IActionResult> CrearPersona([FromBody] Persona persona)
        {
            if (persona == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();           

            var personaCreada = await _personasRepository.InsertPersonas(persona);

            return Created("Se creo la persona", personaCreada);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarPersona([FromBody] Persona persona)
        {
            if (persona == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

           var personaCreada = await _personasRepository.UpdatePersonas(persona);

            return Created("Se actualiza la persona", personaCreada);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPersona(int id)
        {
            await _personasRepository.DeletePersonas(new Persona() { Id = id });
            return NoContent();

        }
    }

}
