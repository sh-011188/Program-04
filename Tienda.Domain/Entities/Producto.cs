namespace Tienda.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Talla { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
