using System.Runtime.InteropServices;
using Tienda.Domain.Entities;
using Tienda.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tienda.API.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _service;

    public ClienteController(ClienteService service)
    {
        _service = service;
    }

    // 4
    [HttpPost("registrar")]
    public IActionResult Registrar(Cliente cliente)
    {
        _service.CrearCliente(cliente);
        return Ok();
    }

    // 5
    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_service.ListarClientes());
    }
}
