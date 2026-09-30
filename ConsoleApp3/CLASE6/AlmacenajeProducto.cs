using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    // INTERFAZ: SOLO DEFINE LA FIRMA, LA CLASE QUE LA USE ESTA OBLIGADA A IMPLEMENTARLA
    internal interface AlmacenajeProducto
    {
        void GuardarProducto(string nombre, double precio);
    }
}
