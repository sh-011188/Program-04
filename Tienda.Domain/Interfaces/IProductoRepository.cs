using Tienda.Domain.Entities;

namespace Tienda.Domain.Interfaces
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
    }
}
