using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    internal class ProductoOrganico : Producto
    {
        protected string _datoNutricional;

        public string FechaCaducidad { get; set; }

        public ProductoOrganico(string nombre, double precio, string datoNutricional)
            : base(nombre, precio)
        {
            _datoNutricional = datoNutricional;
        }

        // SOBREESCRIBE EL METODO VIRTUAL DEL PADRE
        public override void OfertaProducto()
        {
            Console.WriteLine($"El producto {_nombre} ({_datoNutricional}) esta en oferta a {_precio * 0.9}");
        }

        public override void NotificacionEnvio()
        {
            Console.WriteLine($"El producto {_nombre} ha sido enviado con exito y llegara antes del {FechaCaducidad}.");
        }
    }
}
