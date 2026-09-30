using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // STRUCT: TIPO DE DATO POR VALOR (SE COPIA COMPLETO AL ASIGNARLO)
    public struct Punto
    {
        public int X;
        public int Y;

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
