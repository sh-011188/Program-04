using Microsoft.EntityFrameworkCore;
using Tienda.Domain.Entities;

namespace Tienda.Infrastructure.Persistence
{
    public class AppDbContext : DbContextBase
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> Detalles { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
