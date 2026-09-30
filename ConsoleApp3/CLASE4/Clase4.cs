using System;

namespace ConsoleApp3.CLASE4
{
    // POO - CLASES Y OBJETOS
    internal class Clase4
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 4: CLASES Y OBJETOS ---");

            CrearUsuarios();
            TallerMecanico();
        }

        // EJEMPLO DE CREACION DE OBJETOS USUARIOS
        static void CrearUsuarios()
        {
            Usuario usuario1 = new Usuario();       // SIN NOMBRE -> "Guest"
            Usuario usuario2 = new Usuario("Bob");

            Console.WriteLine($"Usuario 1: {usuario1.nombre}");
            Console.WriteLine($"Usuario 2: {usuario2.ObtenerNombre()}");

            Usuario usuario3 = new Usuario();
            usuario3.ModificarNombre("RafaPoma");
            int edadUsuario3 = usuario3.ObtenerEdad();
            Console.WriteLine($"Usuario 3: {usuario3.nombre}, Edad: {edadUsuario3}");

            usuario3.ModificarEdad("29");
            usuario3.CumplirAnios();
            Console.WriteLine($"Usuario 3 despues de cumplir anios: {usuario3.ObtenerEdad()}");
        }

        // TALLER MECANICO "EL RAPIDO"
        static void TallerMecanico()
        {
            Automovil automovil1 = new Automovil();

            Console.WriteLine("Ingrese la marca del automovil:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del automovil:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el color del automovil:");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese la matricula del automovil:");
            string matricula = Console.ReadLine();
            Console.WriteLine("Ingrese en % el nivel de combustible del automovil:");
            double nivelCombustible = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del mecanico:");
            string mecanico = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion del problema:");
            string descripcionDelProblema = Console.ReadLine();

            automovil1.agregarInformacion(marca, modelo, color, matricula, nivelCombustible,
                mecanico, descripcionDelProblema);

            automovil1.EncenderMotor();
            automovil1.Acelerar();
            automovil1.Frenar();

            Console.WriteLine("Informacion del Automovil 1:");
            automovil1.MostrarInformacion();
        }
    }
}
