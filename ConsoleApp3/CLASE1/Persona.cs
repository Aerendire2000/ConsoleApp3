using System;

namespace ConsoleApp3.CLASE1
{
    // ADELANTO DE LA CLASE 4: CADA CLASE EN SU PROPIO ARCHIVO
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} anios.");
        }
    }
}
