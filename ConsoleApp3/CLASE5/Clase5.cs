using System;

namespace ConsoleApp3.CLASE5
{
    // STRUCT, ENUM Y ENCAPSULAMIENTO + HERENCIA
    internal class Clase5
    {
        // ENUM CLASICO: UN CONJUNTO FIJO DE VALORES CON NOMBRE
        enum ColorEnum
        {
            Red,
            Green,
            Blue
        }

        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 5: STRUCT, ENUM, ENCAPSULAMIENTO Y HERENCIA ---");

            Structs();
            Enums();
            Encapsulamiento();
            Herencia();
        }

        static void Structs()
        {
            int a = 5;
            string b = "Hello" + a.ToString();
            Console.WriteLine($"String b: {b}");

            Punto coord_1 = new Punto(3, 4);
            Punto coord_2 = coord_1; // SE COPIA EL VALOR COMPLETO

            // MODIFICAR coord_2 NO AFECTA A coord_1
            coord_2.X += 10;
            coord_2.Y += 20;

            Console.WriteLine($"Point 1: {coord_1}"); // (3, 4)
            Console.WriteLine($"Point 2: {coord_2}"); // (13, 24)
        }

        static void Enums()
        {
            ColorEnum colorEnum = ColorEnum.Red;
            Console.WriteLine($"Selected color (enum): {colorEnum}");

            Color pintura = Color.Red;
            Console.WriteLine($"Selected color: {pintura}");

            if (pintura == Color.Green)
            {
                Console.WriteLine("The color is Green.");
            }

            pintura = Color.Green;
            Console.WriteLine($"Changed color: {pintura}");
        }

        static void Encapsulamiento()
        {
            Empleado anthony = new Empleado(50000m);
            Console.WriteLine($"Sueldo de Anthony: {anthony.Sueldo}");

            anthony.AumentarSueldo();
            Console.WriteLine($"Sueldo de Anthony despues del aumento: {anthony.Sueldo}");

            anthony.Sueldo = -100; // DISPARA LA VALIDACION
            Console.WriteLine($"Sueldo de Anthony despues: {anthony.Sueldo}");

            Producto producto = new Producto();
            producto.Nombre = "Mouse";
            producto.Precio = -5;  // DISPARA LA VALIDACION
            producto.Cantidad = 3;
            Console.WriteLine($"{producto.Nombre} | Precio: {producto.Precio} | Cantidad: {producto.Cantidad}");
        }

        static void Herencia()
        {
            Usuario user = new Usuario("Juan", 30);
            user.MostrarInformacion();

            Cajero cajero = new Cajero("Manana", 1500m, "Maria", 25);
            cajero.MostrarInformacion(); // HEREDADO DE Usuario
            cajero.ProcesarPago();       // PROPIO DE Cajero

            Almacenero almacenero = new Almacenero("Zona A", "Pedro", 35);
            almacenero.MostrarInformacion();
            almacenero.OrganizarInventario();

            TransferenciaBancaria transferencia = new TransferenciaBancaria();
            transferencia.deudor = user;
            transferencia.monto = 250m;
            transferencia.MostrarTransferencia();
        }
    }
}
