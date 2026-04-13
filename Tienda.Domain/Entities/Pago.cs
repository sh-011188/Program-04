namespace Tienda.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}

