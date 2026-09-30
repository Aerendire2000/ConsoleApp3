using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    internal interface IProductoFactory
    {
        Producto CrearProducto(string tipo, string codigo, string nombre, int stock, decimal precio);
    }
}
