using Microsoft.AspNetCore.Mvc;
using EstacionamientoAPI.Models;

namespace EstacionamientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialController : ControllerBase
    {
        private static List<Historial> historial = new();

        [HttpGet]
        public IActionResult Get() => Ok(historial);

        [HttpPost]
        public IActionResult Post(Historial h)
        {
            h.Id = historial.Count + 1;
            historial.Add(h);
            return Ok(h);
        }
    }
}
