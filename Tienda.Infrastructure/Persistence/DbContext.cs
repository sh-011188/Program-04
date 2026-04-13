using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Tienda.Infrastructure.Persistence
{
    public abstract class DbContextBase : DbContext
    {
        protected DbContextBase(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración global de entidades
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextBase).Assembly);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
