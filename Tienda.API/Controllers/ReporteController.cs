using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Tienda.Application.Services;

namespace Tienda.API.Controllers
{
    [ApiController]
    [Route("api/reportes")]
    public class ReporteController : ControllerBase
    {
        private readonly VentaService _ventaService;

        public ReporteController(VentaService ventaService)
        {
            _ventaService = ventaService;
        }

        // 9
        [HttpGet("ingresos")]
        public IActionResult TotalIngresos()
        {
            return Ok(_ventaService.CalcularIngresos());
        }

        // 10
        [HttpGet("producto-mas-vendido")]
        public IActionResult ProductoMasVendido()
        {
            return Ok(_ventaService.ProductoMasVendido());
        }
    }
}





