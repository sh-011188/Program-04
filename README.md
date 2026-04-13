# TiendaRopa - Sistema de Gestión de Tienda de Ropa

Aplicación backend desarrollada en **.NET 8** para la gestión integral de una tienda de ropa, implementando una arquitectura en capas con separación de responsabilidades.

## 🏗️ Arquitectura

El proyecto sigue la arquitectura de **Clean Architecture** con las siguientes capas:

### Capas del Proyecto

- **Tienda.Domain** - Capa de dominio
  - Entidades de negocio
  - Interfaces de repositorios
  - Reglas de negocio centrales

- **Tienda.Application** - Capa de aplicación
  - Servicios de aplicación
  - Lógica de casos de uso
  - Orquestación entre capas

- **Tienda.Infrastructure** - Capa de infraestructura
  - Implementación de repositorios
  - Contexto de base de datos (Entity Framework Core)
  - Persistencia de datos

- **Tienda.API** - Capa de presentación (API REST)
  - Controladores REST
  - Configuración de la aplicación
  - Middleware y dependencias

## 📋 Entidades Principales

- **Cliente** - Información de clientes
- **Producto** - Catálogo de productos
- **Venta** - Registro de ventas
- **DetalleVenta** - Detalles de cada venta
- **Pago** - Información de pagos

## 🛠️ Tecnologías

- .NET 8
- Entity Framework Core
- SQL Server / SQLite
- ASP.NET Core REST API

## 📁 Estructura de Directorios

```
TiendaRopa/
├── Tienda.Domain/
│   ├── Entities/
│   └── Interfaces/
├── Tienda.Application/
│   └── Services/
├── Tienda.Infrastructure/
│   ├── Persistence/
│   └── Repository/
├── Tienda.API/
│   ├── Controllers/
│   ├── Properties/
│   └── Program.cs
└── README.md
```

## 🚀 Cómo Empezar

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/sh-011188/Program-04.git
   cd Program-04
   ```

2. **Restaurar dependencias**
   ```bash
   dotnet restore
   ```

3. **Compilar el proyecto**
   ```bash
   dotnet build
   ```

4. **Ejecutar migraciones de base de datos**
   ```bash
   dotnet ef database update
   ```

5. **Ejecutar la API**
   ```bash
   dotnet run --project Tienda.API
   ```

La API estará disponible en `https://localhost:5001`

## 📝 Endpoints Principales

### Clientes
- `GET /api/cliente` - Obtener todos los clientes
- `POST /api/cliente` - Crear cliente
- `PUT /api/cliente/{id}` - Actualizar cliente
- `DELETE /api/cliente/{id}` - Eliminar cliente

### Productos
- `GET /api/producto` - Obtener todos los productos
- `POST /api/producto` - Crear producto
- `PUT /api/producto/{id}` - Actualizar producto
- `DELETE /api/producto/{id}` - Eliminar producto

### Ventas
- `GET /api/venta` - Obtener todas las ventas
- `POST /api/venta` - Crear venta
- `GET /api/venta/{id}` - Obtener venta por ID

### Pagos
- `GET /api/pago` - Obtener todos los pagos
- `POST /api/pago` - Registrar pago

### Reportes
- `GET /api/reporte` - Obtener reportes de ventas

## 📦 Servicios

### ClienteService
Gestión de clientes

### ProductoService
Gestión del catálogo de productos

### VentaService
Procesamiento de ventas

### PagoService
Gestión de pagos

## 📄 Licencia

Este proyecto está bajo la licencia MIT.

## ✉️ Autor

sh-011188

---

**Última actualización:** 2026
