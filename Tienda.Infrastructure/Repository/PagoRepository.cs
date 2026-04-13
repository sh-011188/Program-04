using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;
using Tienda.Infrastructure.Persistence;

namespace Tienda.Infrastructure.Repository
{
    public class PagoRepository : IPagoRepository
    {
        private readonly AppDbContext _context;

        public PagoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Agregar(Pago pago)
        {
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }

        public List<Pago> ObtenerTodos()
        {
            return _context.Pagos.ToList();
        }
    }
}
