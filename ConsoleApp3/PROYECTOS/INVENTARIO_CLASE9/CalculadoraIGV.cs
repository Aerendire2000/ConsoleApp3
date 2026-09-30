using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // IGV DE PERU (18%)
    public class CalculadoraIGV : ICalculoIGV
    {
        public decimal CalcularIGV(decimal monto) => monto * 0.18m;
    }
}
