using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    // CLASE GENERICA: T SE DEFINE AL MOMENTO DE USARLA
    internal class Codigo<T>
    {
        List<T> lista = new List<T>();

        public T Identificador { get; set; }

        public void Agregar(T elemento)
        {
            lista.Add(elemento);
        }

        public int Cantidad()
        {
            return lista.Count;
        }
    }
}
