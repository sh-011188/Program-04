using Microsoft.AspNetCore.Mvc;
using Tienda.Application.Services;
using Tienda.Domain.Entities;

namespace Tienda.API.Controllers
{
    [ApiController]
    [Route("api/pagos")]
    public class PagoController : ControllerBase
    {
        private readonly PagoService _service;

        public PagoController(PagoService service)
        {
            _service = service;
        }

        // Historia 8: Registrar pago
        [HttpPost("registrar")]
        public IActionResult RegistrarPago(Pago pago)
        {
            _service.RegistrarPago(pago);
            return Ok("Pago registrado correctamente");
        }

        // Extra: Listar pagos (por si lo necesitas)
        [HttpGet("listar")]
        public IActionResult ListarPagos()
        {
            return Ok(_service.ListarPagos());
        }
    }
}
