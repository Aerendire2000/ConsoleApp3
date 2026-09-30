using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // CALCULO DE IMPUESTO PARA USA
    public class CalculadoraIGV_USA : ICalculoIGV
    {
        public double CalcularIGV(double precio)
        {
            return precio * 0.07;
        }
    }
}
