using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // EXCEPCION PROPIA DEL INVENTARIO: LA LANZO CON throw CUANDO UNA REGLA DEL NEGOCIO NO SE CUMPLE
    public class InventarioException : Exception
    {
        public InventarioException(string mensaje) : base(mensaje)
        {
        }
    }
}
