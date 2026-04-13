using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;

namespace Tienda.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repo;

        public ClienteService(IClienteRepository repo)
        {
            _repo = repo;
        }

        public void CrearCliente(Cliente cliente)
        {
            _repo.Agregar(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _repo.ObtenerTodos();
        }
    }
}
