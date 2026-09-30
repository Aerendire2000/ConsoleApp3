using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS
{
    // PROYECTO 1: SIMULADOR DE CARRITO DE COMPRAS (E-COMMERCE)
    public class SimuladorCarritoDeCompras
    {
        static string respuesta = "";
        static decimal total = 0;

        public static void Ejecutar()
        {
            // SE REINICIA PARA QUE NO SE ACUMULE SI LO EJECUTO OTRA VEZ DESDE EL MENU
            respuesta = "";
            total = 0;

            do
            {
                Console.WriteLine("Deseas agregar un producto al carrito? (si/no):");
                respuesta = Console.ReadLine().ToLower();
                switch (respuesta)
                {
                    case "si":
                        Console.WriteLine("Nombre del producto?");
                        string nombreProducto = Console.ReadLine();

                        Console.WriteLine("Precio del producto?");
                        decimal precioProducto = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Cantidad?");
                        int cantidadProducto = int.Parse(Console.ReadLine());

                        decimal subTotal = CalcularSubTotal(precioProducto, cantidadProducto);
                        total = total + subTotal;
                        Console.WriteLine($"{nombreProducto} | SubTotal: {subTotal} | Total acumulado {total}");
                        break;
                    case "no":
                        Console.WriteLine("Cerrando el carrito...");
                        break;
                    default:
                        Console.WriteLine("Respuesta no valida. Escribe 'si' o 'no'");
                        break;
                }
            } while (respuesta != "no");

            MostrarTotal();
        }

        // FUNCION: CALCULA Y DEVUELVE EL SUBTOTAL
        static decimal CalcularSubTotal(decimal precio, int cantidad)
        {
            return precio * cantidad;
        }

        // PROCEDIMIENTO: SOLO MUESTRA EL TOTAL
        static void MostrarTotal()
        {
            Console.WriteLine($"TOTAL A PAGAR: {total}");
        }
    }
}
