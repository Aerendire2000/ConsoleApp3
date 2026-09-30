using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [S] SRP: ESTA CLASE SOLO SABE IMPRIMIR EN CONSOLA
    internal class ReporteConsola : IReporteInventario
    {
        public void MostrarLista(string titulo, IEnumerable<string> lineas)
        {
            Console.WriteLine($"--- {titulo} ---");
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
