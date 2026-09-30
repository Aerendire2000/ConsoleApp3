using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // CADA INGRESO O SALIDA QUEDA REGISTRADO COMO UN MOVIMIENTO
    internal class Movimiento
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy HH:mm} | {Tipo} | {Codigo} | {Cantidad} unidades";
        }
    }
}
