using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE9
{
    internal class Usuario : ICRUD
    {
        private string nombre { get; set; }
        public string edad { get; set; }

        public Usuario(string nombre = "Guest")
        {
            this.nombre = nombre;
        }

        public void CreateData()
        {
            Console.WriteLine("Crear nuevo usuario...");
            Console.Write("Ingrese nombre: ");
            string nuevoNombre = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            string nuevaEdad = Console.ReadLine();

            this.nombre = nuevoNombre;
            this.edad = nuevaEdad;

            Console.WriteLine($"Usuario creado: {this.nombre}, Edad: {this.edad}");
        }

        public void ReadData()
        {
            Console.WriteLine("---- Datos del Usuario ----");
            Console.WriteLine($"Nombre: {ObtenerNombre()}");
            Console.WriteLine($"Edad: {ObtenerEdad()}");
            Console.WriteLine("---------------------------");
        }

        public void UpdateData()
        {
            Console.WriteLine("Actualizar datos del usuario...");
            Console.Write("Ingrese nuevo nombre (o presione Enter para mantener): ");
            string nuevoNombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                ModificarNombre(nuevoNombre);
            }

            Console.Write("Ingrese nueva edad (o presione Enter para mantener): ");
            string nuevaEdad = Console.ReadLine();
            if (!string.IsNullOrEmpty(nuevaEdad))
            {
                ModificarEdad(nuevaEdad);
            }

            Console.WriteLine("Datos actualizados correctamente.");
        }

        // AUN NO LO NECESITO, PERO LA INTERFAZ ME OBLIGA A TENERLO
        public void DeleteData()
        {
            throw new NotImplementedException("El metodo DeleteData() aun no ha sido implementado.");
        }

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
    }
}
