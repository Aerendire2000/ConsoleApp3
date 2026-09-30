using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    internal interface IEntradaDatos
    {
        string LeerTexto(string mensaje);
        int LeerEntero(string mensaje);
        decimal LeerDecimal(string mensaje);
    }
}
