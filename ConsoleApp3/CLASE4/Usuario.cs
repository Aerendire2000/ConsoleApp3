using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE4
{
    internal class Usuario
    {
        // ATRIBUTOS
        public string nombre { get; set; }
        public string edad { get; set; }

        // CONSTRUCTOR: SE EJECUTA AL HACER new
        // SI NO ME PASAN NOMBRE, POR DEFECTO ES "Guest"
        public Usuario(string nombre = "Guest")
        {
            this.nombre = nombre;
        }

        // FUNCION: DEVUELVE LA EDAD COMO NUMERO
        public int ObtenerEdad()
        {
            int edadNumerica;
            if (int.TryParse(edad, out edadNumerica)) // edadNumerica = edad
            {
                return edadNumerica;
            }
            else
            {
                Console.WriteLine("Edad no valida. No se puede convertir a numero.");
                return -1; // Valor de error
            }
        }

        public void ModificarEdad(string nuevaEdad)
        {
            edad = nuevaEdad;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void ModificarNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
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
                Console.WriteLine("Edad no valida. No se puede convertir a numero.");
            }
        }
    }
}
