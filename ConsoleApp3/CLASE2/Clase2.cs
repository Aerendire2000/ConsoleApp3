using System;

namespace ConsoleApp3.CLASE2
{
    // CLASE 2: CONDICIONALES, BUCLES, METODOS Y CONST
    internal class Clase2
    {
        // CONST: VALORES QUE NO CAMBIAN NUNCA.
        const double COMISION_FIJA = 5.0;

        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 2: CONDICIONALES, BUCLES Y METODOS ---");

            CatalogoDeVariables();
            Condicionales();
            Bucles();
            BreakYContinue();
            Metodos();
        }

        // REPASO: CADA PROPIEDAD DEL PRODUCTO CON SU TIPO DE DATO
        static void CatalogoDeVariables()
        {
            string nombre = "Laptop Gamer";
            double precio = 1250.50;
            int cantidad = 3;
            bool enStock = true;

            Console.WriteLine($"{nombre} | Precio: {precio} | Cantidad: {cantidad} | En stock: {enStock}");
        }

        static void Condicionales()
        {
            // IF: SI LA CONDICION ES TRUE, SE EJECUTA EL BLOQUE DE CODIGO
            double precio = 150;

            if (precio > 100)
            {
                var descuento = precio * 0.1;
                precio = precio - descuento;
                Console.WriteLine("Precio con descuento: " + precio);
            }
            else
            {
                Console.WriteLine("Precio sin descuento: " + precio);
            }

            // ELEGIR ENTRE MUCHAS OPCIONES CON SWITCH
            double precioMercaderia = 180;
            string tipoMercaderia = "Electronica";

            switch (tipoMercaderia)
            {
                case "Electronica":
                    precioMercaderia *= 0.8; // 20% de descuento
                    break;
                case "Ropa":
                    precioMercaderia *= 0.9; // 10% de descuento
                    break;
                case "Libros":
                    precioMercaderia *= 0.85; // 15% de descuento
                    break;
                default:
                    Console.WriteLine("Tipo de mercaderia no valido");
                    break;
            }

            Console.WriteLine($"Precio final de {tipoMercaderia}: {precioMercaderia}");
        }

        static void Bucles()
        {
            // WHILE: CUANDO NO SABES CUANTAS VUELTAS VA A DAR
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("El valor de i es: " + i);
                i++;
            }

            // FOR: CUANDO SABES CUANTAS VUELTAS VA A DAR
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("El valor de j es: " + j);
            }

            // FOREACH: PARA RECORRER COLECCIONES
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (var item in numeros)
            {
                Console.WriteLine("El valor del item es: " + item);
            }

            // BUCLE INFINITO CONTROLADO: SE CORTA A MANO CON BREAK
            Console.WriteLine("Escribe numeros. El bucle termina cuando escribas 0:");
            for (; ; )
            {
                int numeroLeido = int.Parse(Console.ReadLine());
                if (numeroLeido == 0)
                {
                    break;
                }
            }
        }

        // CORTAR Y SALTAR: BREAK Y CONTINUE
        static void BreakYContinue()
        {
            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    break; // sale del bucle
                }
                if (k % 2 == 0)
                {
                    continue; // salta a la siguiente iteracion
                }
                Console.WriteLine("El valor de k es: " + k);
            }

            // EJEMPLO DE CLASE: DIVISIBLES POR 3, 4 Y 5
            for (int i = 0; i < 25; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Numero divisible por 3: " + i);
                    Console.WriteLine("Continuando con la siguiente iteracion");
                    continue;
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("Numero divisible por 4: " + i);
                    Console.WriteLine("Cierre del bucle");
                    break;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Numero divisible por 5: " + i);
                }
                Console.WriteLine("Numero: " + i);
            }
            Console.WriteLine("Fin del programa");
        }

        static void Metodos()
        {
            MostrarSuma(5, 10);

            int suma = ObtenerSuma(4, 1);
            Console.WriteLine("La suma es: " + suma);

            Console.WriteLine($"Total con comision: {CalcularTotalConComision(100)}");
        }

        // UN PROCEDIMIENTO HACE ALGO PERO NO DEVUELVE NADA (VOID)
        static void MostrarSuma(int numeroA, int numeroB)
        {
            var suma = numeroA + numeroB;
            Console.WriteLine("La suma es: " + suma);
        }

        // UNA FUNCION CALCULA ALGO Y LO RETORNA PARA QUE LO USES EN OTRO SITIO
        static int ObtenerSuma(int numeroA, int numeroB)
        {
            return numeroA + numeroB;
        }

        // AQUI USO LA CONSTANTE COMISION_FIJA
        static double CalcularTotalConComision(double precioBase)
        {
            return precioBase + COMISION_FIJA;
        }
    }
}
