using Tienda.Domain.Entities;

namespace Tienda.Domain.Interfaces
{
    public interface IVentaRepository
    {
        void Agregar(Venta venta);
        List<Venta> ObtenerTodos();
    }
}
