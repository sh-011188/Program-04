using Tienda.Domain.Entities;

namespace Tienda.Domain.Interfaces
{
    public interface IPagoRepository
    {
        void Agregar(Pago pago);
        List<Pago> ObtenerTodos();
    }
}
