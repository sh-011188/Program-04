using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;

namespace Tienda.Application.Services
{
    public class ProductoService
    {
        private readonly IProductoRepository _repo;

        public ProductoService(IProductoRepository repo)
        {
            _repo = repo;
        }

        public void CrearProducto(Producto producto)
        {
            _repo.Agregar(producto);
        }

        public List<Producto> ListarProductos()
        {
            return _repo.ObtenerTodos();
        }

        public Producto BuscarPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }
    }
}
