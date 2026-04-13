using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;

namespace Tienda.Application.Services
{
    public class PagoService
    {
        private readonly IPagoRepository _repo;

        public PagoService(IPagoRepository repo)
        {
            _repo = repo;
        }

        public void RegistrarPago(Pago pago)
        {
            pago.Fecha = DateTime.Now;
            _repo.Agregar(pago);
        }

        public List<Pago> ListarPagos()
        {
            return _repo.ObtenerTodos();
        }
    }
}

