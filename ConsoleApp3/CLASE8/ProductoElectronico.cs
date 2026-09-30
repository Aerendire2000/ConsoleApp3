using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // OCP: EXTENSIBLE SIN MODIFICAR LA CLASE BASE
    internal class ProductoElectronico : Producto, IPago
    {
        string _voltaje;

        // DIP: INYECCION DE DEPENDENCIAS PARA LA CALCULADORA
        public ProductoElectronico(
            string nombre,
            double precio,
            string voltaje,
            ICalculoIGV calculadoraIGV = null) : base(nombre, precio, calculadoraIGV)
        {
            _voltaje = voltaje;
        }

        // SRP: RESPONSABILIDAD UNICA - PROCESAMIENTO DE PAGOS
        public void Pagar(string TipoPago)
        {
            Console.WriteLine($"Pago realizado para productos electronicos con: {TipoPago} del producto {_nombre} ({_voltaje})");
            Console.WriteLine($"El IGV del producto {_nombre} es: {_calculadoraIGV.CalcularIGV(_precio)}");
        }

        public override void NotificacionEnvio()
        {
            Console.WriteLine($"El producto {_nombre} ha sido enviado con exito y de regalo le haremos llegar un protector de pantalla.");
        }
    }
}
