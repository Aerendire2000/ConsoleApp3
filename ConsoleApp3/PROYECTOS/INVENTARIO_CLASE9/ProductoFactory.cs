using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [O] OCP - FACTORY: LA CREACION DE PRODUCTOS QUEDA CENTRALIZADA AQUI.
    // SI MANANA HAY UN TIPO NUEVO, SOLO SE AGREGA UN case EN ESTA CLASE.
    internal class ProductoFactory : IProductoFactory
    {
        public Producto CrearProducto(string tipo, string codigo, string nombre, int stock, decimal precio)
        {
            switch (tipo)
            {
                case "1": return new ProductoAccesorio(codigo, nombre, stock, precio, new Ubicacion(2, 1));
                case "2": return new ProductoConGarantia(codigo, nombre, stock, precio, new Ubicacion(1, 1), 12);
                case "3": return new ProductoConsumible(codigo, nombre, stock, precio, new Ubicacion(3, 1), "31/12/2026");
                default: return null;
            }
        }
    }
}
