using System.Collections.Generic;
using System.Linq;
using Tienda.Domain.Entities;
using Tienda.Domain.Interfaces;
using Tienda.Infrastructure.Persistence;

namespace Tienda.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
