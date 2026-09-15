using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Usuario
    {
        public string nombre { get; set; }
        public string edad { get; set; }

        public Usuario(string nombre = "Guest")
        {
            this.nombre = nombre;
        }

        public int ObtenerEdad()
        {
            int edadNumerica;
            if (int.TryParse(edad, out edadNumerica))// edadNumerica = edad
            {
                return edadNumerica;
            }
            else
            {
                Console.WriteLine("Edad no válida. No se puede convertir a número.");
                return -1; // Valor de error
            }
        }
        public void ModificarEdad(string nuevaEdad)
        {
            edad = nuevaEdad;
        }

        public void CumplirAnios()
        {
            int edadActual;
            if (int.TryParse(edad, out edadActual))
            {
                edadActual++;
                edad = edadActual.ToString();
            }
            else
            {
                Console.WriteLine("Edad no válida. No se puede incrementar.");
            }
        }
    }
}