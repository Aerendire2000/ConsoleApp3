using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    internal class Producto : AlmacenajeProducto
    {
        string _nombre;
        double _precio;

        public void GuardarProducto(string nombre, double precio)
        {
            _nombre = nombre;
            _precio = precio;
            Console.WriteLine($"Producto guardado: {_nombre}, Precio: {_precio}");
        }
    }
}
