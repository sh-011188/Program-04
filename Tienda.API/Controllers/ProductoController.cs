using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Tienda.Application.Services;
using Tienda.Domain.Entities;

[ApiController]
[Route("api/productos")]
public class ProductoController : ControllerBase
{
    private readonly ProductoService _service;

    public ProductoController(ProductoService service)
    {
        _service = service;
    }

    // 1
    [HttpPost("registrar")]
    public IActionResult Registrar(Producto producto)
    {
        _service.CrearProducto(producto);
        return Ok("Producto registrado");
    }

    // 2
    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_service.ListarProductos());
    }

    // 3
    [HttpGet("buscar/{id}")]
    public IActionResult Buscar(int id)
    {
        return Ok(_service.BuscarPorId(id));
    }
}
