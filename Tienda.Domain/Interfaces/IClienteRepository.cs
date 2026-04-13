using Tienda.Domain.Entities;

namespace Tienda.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Agregar(Cliente cliente);
        List<Cliente> ObtenerTodos();
    }
}
