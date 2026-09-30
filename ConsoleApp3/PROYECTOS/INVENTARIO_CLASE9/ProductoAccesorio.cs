using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // PRODUCTO GENERAL (MOUSE, TECLADO, CABLES...)
    public class ProductoAccesorio : Producto
    {
        public ProductoAccesorio(string codigo, string nombre, int stock, decimal precio, Ubicacion ubicacion)
            : base(codigo, nombre, stock, precio, Categoria.Accesorios, ubicacion)
        {
        }

        public override decimal CalcularValor()
        {
            return Stock * Precio;
        }
    }
}
