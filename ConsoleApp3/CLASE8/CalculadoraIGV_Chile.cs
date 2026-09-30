using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // CALCULO DE IMPUESTO PARA Chile
    public class CalculadoraIGV_Chile : ICalculoIGV
    {
        public double CalcularIGV(double precio)
        {
            return precio * 0.19;
        }
    }
}
