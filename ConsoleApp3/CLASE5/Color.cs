using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // SIMULAR UN ENUM CON UNA CLASE: STATIC READONLY + CONSTRUCTOR PRIVADO
    public class Color
    {
        public static readonly Color Red = new Color("Red");
        public static readonly Color Green = new Color("Green");
        public static readonly Color Blue = new Color("Blue");

        private string Name { get; }

        // PRIVADO: NADIE DE AFUERA PUEDE CREAR COLORES NUEVOS
        private Color(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
