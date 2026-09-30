using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // CLASE BASE PARA EL SISTEMA DE LA TIENDA CON ROLES
    public class Usuario
    {
        public string Nombre;
        private int Edad { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }

        public Usuario(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
