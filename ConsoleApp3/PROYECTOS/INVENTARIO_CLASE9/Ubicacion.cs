using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // STRUCT: LA UBICACION ES UN DATO PEQUENIO, SE COPIA POR VALOR
    public struct Ubicacion
    {
        public int Pasillo;
        public int Estante;

        public Ubicacion(int pasillo, int estante)
        {
            Pasillo = pasillo;
            Estante = estante;
        }

        public override string ToString()
        {
            return $"Pasillo {Pasillo} - Estante {Estante}";
        }
    }
}
