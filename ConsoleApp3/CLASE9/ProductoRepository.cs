using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE9
{
    internal class ProductoRepository : IRepository<Producto>
    {
        // SIMULAMOS LA BASE DE DATOS CON UNA LISTA EN MEMORIA
        private readonly List<Producto> _baseDeDatos = new List<Producto>();
        private int _siguienteId = 1;

        public IEnumerable<Producto> ObtenerTodos()
        {
            return _baseDeDatos;
        }

        public Producto ObtenerPorId(int id)
        {
            return _baseDeDatos.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(Producto producto)
        {
            producto.Id = _siguienteId++;
            _baseDeDatos.Add(producto);
        }

        public void Actualizar(Producto producto)
        {
            var productoExistente = ObtenerPorId(producto.Id);
            if (productoExistente != null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
            }
        }

        public void Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            if (producto != null)
            {
                _baseDeDatos.Remove(producto);
            }
        }
    }
}
