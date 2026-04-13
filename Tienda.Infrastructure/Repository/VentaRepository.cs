using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;
using Tienda.Infrastructure.Persistence;

namespace Tienda.Infrastructure.Repository
{
    public class VentaRepository : IVentaRepository
    {
        private readonly AppDbContext _context;

        public VentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Agregar(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public List<Venta> ObtenerTodos()
        {
            return _context.Ventas.ToList();
        }
    }
}
