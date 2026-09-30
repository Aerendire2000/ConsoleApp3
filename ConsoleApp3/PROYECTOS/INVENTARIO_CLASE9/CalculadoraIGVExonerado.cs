using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // PARA PRODUCTOS EXONERADOS: SE PUEDE CAMBIAR SIN TOCAR EL SERVICIO (LSP)
    public class CalculadoraIGVExonerado : ICalculoIGV
    {
        public decimal CalcularIGV(decimal monto) => 0;
    }
}
