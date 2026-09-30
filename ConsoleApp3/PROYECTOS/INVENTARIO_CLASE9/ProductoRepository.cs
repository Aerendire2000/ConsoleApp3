using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [D] DIP + REPOSITORY: EL SERVICIO SOLO CONOCE IRepository<Producto>.
    // HOY LOS DATOS ESTAN EN MEMORIA; MANANA PUEDE SER SQL SERVER SIN TOCAR EL SERVICIO
    internal class ProductoRepository : IRepository<Producto>
    {
        // STATIC: EL CONTADOR DE IDS LO COMPARTEN TODAS LAS INSTANCIAS
        private static int _siguienteId = 1;

        // READONLY: LAS COLECCIONES SE CREAN UNA VEZ Y NO SE REEMPLAZAN
        private readonly List<Producto> _baseDeDatos = new List<Producto>();
        private readonly Dictionary<string, Producto> _indicePorCodigo = new Dictionary<string, Producto>();

        public IEnumerable<Producto> ObtenerTodos()
        {
            return _baseDeDatos;
        }

        public Producto ObtenerPorId(int id)
        {
            return _baseDeDatos.FirstOrDefault(p => p.Id == id);
        }

        public Producto ObtenerPorCodigo(string codigo)
        {
            _indicePorCodigo.TryGetValue(codigo, out Producto producto);
            return producto;
        }

        public void Agregar(Producto producto)
        {
            if (_indicePorCodigo.ContainsKey(producto.Codigo))
            {
                throw new InventarioException($"Ya existe un producto con el codigo {producto.Codigo}.");
            }

            producto.Id = _siguienteId++;
            _baseDeDatos.Add(producto);
            _indicePorCodigo.Add(producto.Codigo, producto);
        }

        public void Actualizar(Producto producto)
        {
            var productoExistente = ObtenerPorId(producto.Id);
            if (productoExistente == null)
            {
                throw new InventarioException($"No existe un producto con Id {producto.Id}.");
            }

            productoExistente.Nombre = producto.Nombre;
            productoExistente.Precio = producto.Precio;
        }

        public void Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            if (producto == null)
            {
                throw new InventarioException($"No existe un producto con Id {id}.");
            }

            _baseDeDatos.Remove(producto);
            _indicePorCodigo.Remove(producto.Codigo);
        }
    }
}
