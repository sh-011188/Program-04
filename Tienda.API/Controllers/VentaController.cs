using System.Runtime.InteropServices;
using Tienda.Domain.Entities;
using Tienda.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tienda.API.Controllers
{
    [ApiController]
    [Route("api/ventas")]
    public class VentaController : ControllerBase
    {
        private readonly VentaService _service;

        public VentaController(VentaService service)
        {
            _service = service;
        }

        // 6
        [HttpPost("realizar")]
        public IActionResult Realizar(Venta venta)
        {
            _service.CrearVenta(venta);
            return Ok();
        }

        // 7
        [HttpGet("listar")]
        public IActionResult Listar()
        {
            return Ok(_service.ListarVentas());
        }
    }
}
