using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [O] OCP: UN IMPUESTO NUEVO ES UNA CLASE NUEVA, NO UN if MAS
    public interface ICalculoIGV
    {
        decimal CalcularIGV(decimal monto);
    }

}
