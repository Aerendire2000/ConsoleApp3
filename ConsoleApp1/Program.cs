using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario("Bob");
            Console.WriteLine($"Usuario 1: {usuario1.nombre}");
            Console.WriteLine($"Usuario 2: {usuario2.nombre}");


            Usuario usuario3 = new Usuario();
            usuario3.nombre = "RafaPoma";
            int edadUsuario3 = usuario3.ObtenerEdad();
            Console.WriteLine($"Usuario 3: {usuario3.nombre}, Edad: {edadUsuario3}");
            */
            Vehiculo corolla = new Vehiculo("Toyota", "Corolla", "Rojo brillante", "XYZ-123");
            corolla.nivelCombustible = "50";

            Console.WriteLine($"Vehículo ingresado: {corolla.marca} {corolla.modelo}, color {corolla.color}, matrícula {corolla.matricula}");
            Console.WriteLine($"Nivel de combustible: {corolla.ObtenerNivelCombustible()}%");

            corolla.EncenderMotor();
            Console.WriteLine($"Motor encendido: {corolla.motorEncendido}");
            corolla.ApagarMotor();
            Console.WriteLine($"Motor apagado: {corolla.motorEncendido}");

        }
    }
}