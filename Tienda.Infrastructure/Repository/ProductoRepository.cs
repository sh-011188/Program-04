using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;
using Tienda.Infrastructure.Persistence;

namespace Tienda.Infrastructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public Producto ObtenerPorId(int id)
        {
            return _context.Productos.Find(id);
        }
    }
}
