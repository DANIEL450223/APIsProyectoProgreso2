using Microsoft.AspNetCore.Mvc;
using EstacionamientoAPI.Models;

namespace EstacionamientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new();

        [HttpGet]
        public IActionResult Get() => Ok(usuarios);

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            usuario.Id = usuarios.Count + 1;
            usuarios.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuario)
        {
            var existing = usuarios.FirstOrDefault(u => u.Id == id);
            if (existing == null) return NotFound();

            existing.Cedula = usuario.Cedula;
            existing.Nombre = usuario.Nombre;
            existing.Vehiculo = usuario.Vehiculo;
            existing.FechaIngreso = usuario.FechaIngreso;
            existing.FechaSalida = usuario.FechaSalida;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null) return NotFound();
            usuarios.Remove(usuario);
            return NoContent();
        }
    }
}
