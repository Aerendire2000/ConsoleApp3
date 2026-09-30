using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    // DIP: DEPENDE DE LA ABSTRACCION (IEntradaDatos), NO DE Console DIRECTAMENTE
    internal class Codigo<T>
    {
        public T Identificador;
        private IEntradaDatos _entrada;

        public Codigo(IEntradaDatos entrada = null)
        {
            _entrada = entrada ?? new EntradaDatosConsola();
            string datos = _entrada.ObtenerDatos("Ingrese el identificador del usuario:");
            try
            {
                Identificador = (T)Convert.ChangeType(datos, typeof(T));
                Console.WriteLine($"El identificador del usuario es: {Identificador}");
            }
            catch
            {
                Console.WriteLine("El identificador del usuario no es valido.");
            }
        }
    }
}
