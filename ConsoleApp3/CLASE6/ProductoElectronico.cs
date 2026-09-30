using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    // OTRA CLASE CON LA MISMA INTERFAZ PERO CON SUS PROPIOS ATRIBUTOS
    internal class ProductoElectronico : AlmacenajeProducto
    {
        string _nombre;
        double _precio;
        string _voltaje;

        public ProductoElectronico(string voltaje)
        {
            _voltaje = voltaje;
        }

        public void GuardarProducto(string nombre, double precio)
        {
            _nombre = nombre;
            _precio = precio;
            Console.WriteLine($"Producto electronico guardado: {_nombre} {_voltaje}, Precio: {_precio}");
        }
    }
}
