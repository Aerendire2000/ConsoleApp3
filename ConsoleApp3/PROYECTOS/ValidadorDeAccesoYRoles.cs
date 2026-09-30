using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS
{
    internal class ValidadorDeAccesoYRoles
    {
        // PRIMER USUARIO: ADMINISTRADOR
        static string usr1 = "jlevi";
        static string pass1 = "1234";
        static string rol1 = "administrador";
        static double sueldo1 = 1000.00;
        // SEGUNDO USUARIO: CAJERO
        static string usr2 = "acastro";
        static string pass2 = "abcd";
        static string rol2 = "cajero";
        static double sueldo2 = 1800.00;
        const int INTENTOS_MAXIMOS = 3;
        public static void Ejecutar()
        {
            int intentos = 0;
            bool ingreso = false;
            while (intentos < INTENTOS_MAXIMOS && !ingreso)
            {
                Console.WriteLine("Usuario:");
                string usuario = Console.ReadLine();

                Console.WriteLine("Clave:");
                string clave = Console.ReadLine();
                string rol = ObtenerRol(usuario, clave);
                if (rol != "")
                {
                    ingreso = true;
                    Console.WriteLine($"Bienvenido {usuario}!");
                    MostrarPermisos(rol);
                    MostrarSueldo(rol);
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"Incorrecto. Intento {intentos}");
                }
            }
        }

        // FUNCION: DEVEULVE EL ROL, O CADENA VACIA SI NO COINCIDE
        static string ObtenerRol(string usuario, string clave)
        {
            if (usuario == usr1 && clave == pass1)
            {
                return rol1;
            }
            else if (usuario == usr2 && clave == pass2)
            {
                return rol2;
            }
            else
            {
                return string.Empty;
            }
        }


        // PROCEDIMIENTO: MUESTRA EL SUELDO SEGUN EL ROL
        static void MostrarSueldo(string rol)
        {
            if (rol == rol1)
            {
                Console.WriteLine($"Tu sueldo registrado es: {sueldo1}");
            }
            else if (rol == rol2)
            {
                Console.WriteLine($"Tu sueldo registrado es: {sueldo2}");
            }
        }

        // PROCEDIMIENTO: SOLO INFORMA, NO DEVUELVE NADA
        static void MostrarPermisos(string rol)
        {
            switch (rol)
            {
                case "administrador":
                    Console.WriteLine("Permisos: acceso completo al sistema");
                    break;
                case "cajero":
                    Console.WriteLine("Permisos: registrar ventas y cobrar.");
                    break;
                default:
                    Console.WriteLine("El rol no tiene permisos asignados.");
                    break;
            }
        }
    }
}