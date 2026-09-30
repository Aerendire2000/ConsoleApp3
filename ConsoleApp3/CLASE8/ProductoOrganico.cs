using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // OCP: EXTENSIBLE CON SU PROPIO COMPORTAMIENTO
    internal class ProductoOrganico : Producto
    {
        protected string _datoNutricional;

        // DIP: INYECCION DE DEPENDENCIAS
        public ProductoOrganico(
            string nombre,
            double precio,
            string datoNutricional,
            ICalculoIGV calculadoraIGV = null) : base(nombre, precio, calculadoraIGV)
        {
            _datoNutricional = datoNutricional;
        }

        public override void NotificacionEnvio()
        {
            Console.WriteLine($"El producto {_nombre} ({_datoNutricional}) ha sido enviado con exito.");
        }
    }
}
