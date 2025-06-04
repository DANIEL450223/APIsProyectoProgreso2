using Microsoft.AspNetCore.Mvc;
using EstacionamientoAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstacionamientosController : ControllerBase
    {
        private static readonly List<Estacionamiento> espacios;

        static EstacionamientosController()
        {
            espacios = new List<Estacionamiento>();
            for (int i = 1; i <= 20; i++)
            {
                espacios.Add(new Estacionamiento
                {
                    Id = i,
                    NumeroEspacio = i,
                    EstaOcupado = false,
                    UsuarioId = null
                });
            }
        }

        [HttpGet]
        public IActionResult Get() => Ok(espacios);

        [HttpPut("{id}")]
        public IActionResult Put(int id, Estacionamiento espacio)
        {
            var existing = espacios.FirstOrDefault(e => e.Id == id);
            if (existing == null)
                return NotFound();

            existing.NumeroEspacio = espacio.NumeroEspacio;
            existing.EstaOcupado = espacio.EstaOcupado;
            existing.UsuarioId = espacio.UsuarioId;
            return Ok(existing);
        }
    }
}
