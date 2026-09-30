using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    internal class ProductoElectronico : Producto, IPago
    {
        string _voltaje;

        // GENERAR EL CONSTRUCTOR
        public ProductoElectronico(
            string nombre,
            double precio,
            string voltaje) : base(nombre, precio)
        {
            _voltaje = voltaje;
        }

        public void Pagar(string TipoPago)
        {
            Console.WriteLine($"Pago realizado para productos electronicos con: {TipoPago} del producto {_nombre} ({_voltaje})");
            Console.WriteLine($"El IGV del producto {_nombre} es: {utilitaria.CalcularIGV(_precio)}");
        }

        public override void NotificacionEnvio()
        {
            Console.WriteLine($"El producto {_nombre} ha sido enviado con exito y de regalo le haremos llegar un protector de pantalla.");
        }
    }
}
