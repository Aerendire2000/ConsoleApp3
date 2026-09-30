using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    // CLASE GENERICA CON DOS TIPOS: GUARDA DOS VALORES RELACIONADOS
    internal class Pair<T, U>
    {
        public T First;
        public U Second;

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()
        {
            return $"First: {First}, Second: {Second}";
        }

        public T PrimerDato()
        {
            return First;
        }
    }
}
