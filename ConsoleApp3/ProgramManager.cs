using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ProgramManager
    {
        public static void Ejecutar()
        {
            string opcion = "";

            do
            {
                // Console.Clear() falla si la salida esta redirigida, asi que
                // solo limpiamos cuando hay una consola de verdad.
                if (!Console.IsOutputRedirected)
                {
                    Console.Clear();
                }

                MostrarMenu();
                opcion = Console.ReadLine();

                try
                {
                    EjecutarOpcion(opcion);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] {ex.Message}");
                }

                if (opcion != "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("Presiona ENTER para volver al menu...");
                    Console.ReadLine();
                }

            } while (opcion != "0");
        }

        static void MostrarMenu()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Clase 1 - Variables, tipos y operadores");
            Console.WriteLine("2. Clase 2 - Condicionales, bucles y metodos");
            Console.WriteLine("3. Clase 3 - do-while, static y ref");
            Console.WriteLine("4. Clase 4 - Clases y objetos");
            Console.WriteLine("5. Clase 5 - Struct, enum, encapsulamiento y herencia");
            Console.WriteLine("6. Clase 6 - Listas, diccionarios, genericos e interfaces");
            Console.WriteLine("7. Clase 7 - Polimorfismo, Math y refactoring con Copilot");
            Console.WriteLine("8. Clase 8 - SOLID y LINQ");
            Console.WriteLine("9. Clase 9 - Captura de errores y patron Repository");
            Console.WriteLine();
            Console.WriteLine("10. PROYECTO - Control de inventario y stock critico");
            Console.WriteLine();
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.WriteLine("Que quieres ejecutar?");
        }

        static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1": CLASE1.Clase1.Ejecutar(); break;
                case "2": CLASE2.Clase2.Ejecutar(); break;
                case "3": CLASE3.Clase3.Ejecutar(); break;
                case "4": CLASE4.Clase4.Ejecutar(); break;
                case "5": CLASE5.Clase5.Ejecutar(); break;
                case "6": CLASE6.Clase6.Ejecutar(); break;
                case "7": CLASE7.Clase7.Ejecutar(); break;
                case "8": CLASE8.Clase8.Ejecutar(); break;
                case "9": CLASE9.Clase9.Ejecutar(); break;
                case "10": PROYECTOS.INVENTARIO_CLASE9.ControlDeInventario.Ejecutar(); break;
                case "0": Console.WriteLine("============"); break;
                default: Console.WriteLine("Opcion no valida."); break;
            }
        }
    }
}
