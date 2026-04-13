using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;

namespace Tienda.Application.Services
{
    public class VentaService
    {
        private readonly IVentaRepository _ventaRepo;

        public VentaService(IVentaRepository ventaRepo)
        {
            _ventaRepo = ventaRepo;
        }

        public void CrearVenta(Venta venta)
        {
            venta.Fecha = DateTime.Now;

            venta.Total = venta.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);

            _ventaRepo.Agregar(venta);
        }

        public List<Venta> ListarVentas()
        {
            return _ventaRepo.ObtenerTodos();
        }

        public decimal CalcularIngresos()
        {
            return _ventaRepo.ObtenerTodos().Sum(v => v.Total);
        }

        public int ProductoMasVendido()
        {
            var ventas = _ventaRepo.ObtenerTodos();

            return ventas
                .SelectMany(v => v.Detalles)
                .GroupBy(d => d.ProductoId)
                .OrderByDescending(g => g.Sum(x => x.Cantidad))
                .FirstOrDefault()?.Key ?? 0;
        }
    }
}


