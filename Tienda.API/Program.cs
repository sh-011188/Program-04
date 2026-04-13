using Microsoft.EntityFrameworkCore;
using Tienda.Infrastructure.Persistence;
using Tienda.Domain.Interfaces;
using Tienda.Infrastructure.Repository;
using Tienda.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("TiendaRopaDB"));

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IVentaRepository, VentaRepository>();
builder.Services.AddScoped<IPagoRepository, PagoRepository>();

builder.Services.AddScoped<ProductoService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<VentaService>();
builder.Services.AddScoped<PagoService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
