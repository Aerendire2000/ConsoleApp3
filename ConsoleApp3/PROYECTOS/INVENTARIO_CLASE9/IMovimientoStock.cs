using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [I] ISP: INTERFAZ PEQUENIA, SOLO LO NECESARIO PARA MOVER STOCK
    internal interface IMovimientoStock
    {
        void Ingresar(int cantidad);
        bool Retirar(int cantidad);
    }
}
