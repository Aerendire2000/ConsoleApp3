using System;

namespace ConsoleApp3.CLASE7
{
    // CLASE 7: HERENCIA, POLIMORFISMO Y LIBRERIA MATH + REFACTORING CON COPILOT
    internal class Clase7
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 7: HERENCIA, POLIMORFISMO Y MATH ---");

            Polimorfismo();
            LibreriaMath();
            RefactorMetodoDePago();
            InversionDeDependencias();
        }

        static void Polimorfismo()
        {
            Utilitaria utilitaria = new Utilitaria();

            ProductoElectronico producto = new ProductoElectronico("Laptop", 1500.00, "220V");
            double igv = utilitaria.CalcularIGV(producto.Precio);
            Console.WriteLine($"IGV del producto: {igv}");

            // AL PRESIONAR EL BOTON DE PAGO
            producto.Pagar("Tarjeta de credito");

            ProductoOrganico organico = new ProductoOrganico("Arroz integral", 50, "Alto en fibra");
            organico.FechaCaducidad = "30/12/2026";

            // POLIMORFISMO: CADA OBJETO EJECUTA SU PROPIA VERSION DEL METODO
            Producto[] productos = { producto, organico };
            foreach (Producto p in productos)
            {
                p.OfertaProducto();
                p.NotificacionEnvio();
            }
        }

        // LISTA COMPLETA DE LA CLASE MATH:
        // https://learn.microsoft.com/es-es/dotnet/api/system.math?view=net-10.0
        static void LibreriaMath()
        {
            double numero = 4.35;
            Console.WriteLine($"Ceiling (redondea hacia arriba): {Math.Ceiling(numero)}");
            Console.WriteLine($"Floor (redondea hacia abajo): {Math.Floor(numero)}");
            Console.WriteLine($"Round: {Math.Round(numero)}");
            Console.WriteLine($"Round con 1 decimal: {Math.Round(numero, 1)}");
            Console.WriteLine($"Abs(-8): {Math.Abs(-8)}");
            Console.WriteLine($"Pow(2, 3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Sqrt(16): {Math.Sqrt(16)}");
            Console.WriteLine($"Max(3, 7): {Math.Max(3, 7)}");

            var piCalculo = Math.PI + 0.10;
            Console.WriteLine($"PI + 0.10 = {piCalculo}");

            var calculo = Math.Floor(piCalculo);
            Console.WriteLine($"Floor de lo anterior = {calculo}");

            // CUIDADO: ALGUNOS METODOS PUEDEN LANZAR EXCEPCIONES
            try
            {
                decimal valorMuyGrande = 79228162514264337593543950335M;
                int resultado = decimal.ToInt32(Math.Ceiling(valorMuyGrande));
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor es demasiado grande para convertirlo a un numero entero.");
            }
        }

        // REFACTORING CON COPILOT: ANTES SE CREABA EL PAGO CON UN SWITCH AQUI MISMO
        static void RefactorMetodoDePago()
        {
            Console.WriteLine();
            Console.WriteLine("--- METODO DE PAGO ---");
            Console.WriteLine("1. Yape");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3. Cripto");
            Console.Write("Elige: ");

            string opcionPago = Console.ReadLine();

            // OCP/DIP: DELEGAR LA CREACION DEL METODO DE PAGO A LA FABRICA
            IMetodoPagoFactory pagoFactory = new MetodoPagoFactory();
            IMetodoPago metodoPago = pagoFactory.CrearMetodoPago(opcionPago);
            if (metodoPago == null)
            {
                Console.WriteLine("[ERROR] Metodo de pago invalido.");
                return;
            }

            metodoPago.Pagar(1500.00);
        }

        static void InversionDeDependencias()
        {
            // Codigo<T> YA NO USA Console DIRECTAMENTE, USA LA INTERFAZ IEntradaDatos
            Codigo<int> codigoUsuario = new Codigo<int>();
        }
    }
}
