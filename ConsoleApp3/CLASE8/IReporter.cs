using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // SRP: RESPONSABILIDAD UNICA - PRESENTACION DE REPORTES
    internal interface IReporter
    {
        void MostrarReporte(string reporte);
    }

    internal class ConsoleReporter : IReporter
    {
        public void MostrarReporte(string reporte)
        {
            Console.WriteLine($"[REPORTE] {reporte}");
        }
    }
}
