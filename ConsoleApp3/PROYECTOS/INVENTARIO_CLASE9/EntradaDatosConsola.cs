using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // DIP: EL INVENTARIO NO USA Console DIRECTAMENTE PARA LEER, USA ESTA CLASE
    internal class EntradaDatosConsola : IEntradaDatos
    {
        public string LeerTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        public int LeerEntero(string mensaje)
        {
            int numero;
            do
            {
                Console.WriteLine(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0);
            return numero;
        }

        public decimal LeerDecimal(string mensaje)
        {
            decimal numero;
            do
            {
                Console.WriteLine(mensaje);
            } while (!decimal.TryParse(Console.ReadLine(), out numero) || numero <= 0);
            return numero;
        }
    }
}
