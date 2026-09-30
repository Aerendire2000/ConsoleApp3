using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS
{
    // PROYECTO 3: CONTROL DE INVENTARIO Y STOCK CRITICO (ALMACEN)
    internal class ControlDeInventario
    {
        // PRODUCTOS DEL ALMACEN (VARIABLES GLOBALES)
        static string producto1 = "Laptop";
        static int stock1 = 10;
        static string producto2 = "Mouse";
        static int stock2 = 25;
        static string producto3 = "Teclado";
        static int stock3 = 4;
        const int STOCK_MINIMO = 5;

        public static void Ejecutar()
        {
            string opcion = "";
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- CONTROL DE INVENTARIO ---");
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Registrar ingreso de productos");
                Console.WriteLine("3. Registrar salida de productos");
                Console.WriteLine("0. Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarInventario();
                        break;
                    case "2":
                        MoverStock(true);
                        break;
                    case "3":
                        MoverStock(false);
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del inventario...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            } while (opcion != "0");
        }

        // PROCEDIMIENTO: MUESTRA CADA PRODUCTO Y AVISA SI ESTA EN STOCK CRITICO
        static void MostrarInventario()
        {
            MostrarProducto(producto1, stock1);
            MostrarProducto(producto2, stock2);
            MostrarProducto(producto3, stock3);
        }

        static void MostrarProducto(string producto, int stock)
        {
            if (EsStockCritico(stock))
            {
                Console.WriteLine($"{producto}: {stock} unidades  <-- STOCK CRITICO");
            }
            else
            {
                Console.WriteLine($"{producto}: {stock} unidades");
            }
        }

        // FUNCION: DEVUELVE TRUE SI EL STOCK ESTA POR DEBAJO DEL MINIMO
        static bool EsStockCritico(int stock)
        {
            return stock < STOCK_MINIMO;
        }

        // PROCEDIMIENTO: SUMA O RESTA STOCK SEGUN SEA INGRESO O SALIDA
        static void MoverStock(bool esIngreso)
        {
            Console.WriteLine("Que producto? (1. Laptop, 2. Mouse, 3. Teclado)");
            string numeroProducto = Console.ReadLine();

            int cantidad = 0;
            do
            {
                Console.WriteLine("Cantidad:");
            } while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0);

            if (!esIngreso)
            {
                cantidad = -cantidad;
            }

            switch (numeroProducto)
            {
                case "1":
                    stock1 = CalcularNuevoStock(stock1, cantidad);
                    MostrarProducto(producto1, stock1);
                    break;
                case "2":
                    stock2 = CalcularNuevoStock(stock2, cantidad);
                    MostrarProducto(producto2, stock2);
                    break;
                case "3":
                    stock3 = CalcularNuevoStock(stock3, cantidad);
                    MostrarProducto(producto3, stock3);
                    break;
                default:
                    Console.WriteLine("Producto no valido.");
                    break;
            }
        }

        // FUNCION: NO DEJA QUE EL STOCK QUEDE NEGATIVO
        static int CalcularNuevoStock(int stockActual, int cantidad)
        {
            int nuevoStock = stockActual + cantidad;
            if (nuevoStock < 0)
            {
                Console.WriteLine("No hay suficiente stock para esa salida.");
                return stockActual;
            }
            return nuevoStock;
        }
    }
}
