using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    internal class PagoTarjeta : IMetodoPago
    {
        public void Pagar(double monto)
        {
            Console.WriteLine($"Pago de {monto} realizado con Tarjeta.");
        }
    }
}
