using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    // CLASE DE APOYO: CALCULOS QUE USAN VARIOS PRODUCTOS
    internal class Utilitaria : ICalculoIGV
    {
        public double CalcularIGV(double precio)
        {
            return precio * 0.18; // Ejemplo de calculo del IGV (18%)
        }
    }
}
