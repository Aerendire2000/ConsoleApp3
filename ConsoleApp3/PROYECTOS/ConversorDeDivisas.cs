using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS
{
    // PROYECTO 4: CONVERSOR DE DIVISAS Y COMISIONES (FINTECH)
    internal class ConversorDeDivisas
    {
        // TIPOS DE CAMBIO DE EJEMPLO (1 MONEDA = X SOLES)
        static decimal tipoCambioDolar = 3.75m;
        static decimal tipoCambioEuro = 4.05m;
        const decimal COMISION = 0.02m; // 2% POR OPERACION
        const decimal MONTO_SIN_COMISION = 1000m;

        public static void Ejecutar()
        {
            string continuar = "";
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- CONVERSOR DE DIVISAS ---");
                Console.WriteLine("1. Soles a Dolares");
                Console.WriteLine("2. Soles a Euros");
                Console.WriteLine("3. Dolares a Soles");
                Console.WriteLine("4. Euros a Soles");
                string opcion = Console.ReadLine();

                decimal monto = 0;
                do
                {
                    Console.WriteLine("Ingresa el monto:");
                } while (!decimal.TryParse(Console.ReadLine(), out monto) || monto <= 0);

                decimal convertido = 0;
                switch (opcion)
                {
                    case "1":
                        convertido = monto / tipoCambioDolar;
                        break;
                    case "2":
                        convertido = monto / tipoCambioEuro;
                        break;
                    case "3":
                        convertido = monto * tipoCambioDolar;
                        break;
                    case "4":
                        convertido = monto * tipoCambioEuro;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                if (convertido > 0)
                {
                    decimal comision = CalcularComision(monto);
                    MostrarResultado(monto, convertido, comision);
                }

                Console.WriteLine("Deseas hacer otra conversion? (si/no)");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "si");
        }

        // FUNCION: LA COMISION SOLO SE COBRA SI EL MONTO PASA EL LIMITE
        static decimal CalcularComision(decimal monto)
        {
            if (monto > MONTO_SIN_COMISION)
            {
                return monto * COMISION;
            }
            return 0;
        }

        // PROCEDIMIENTO: MUESTRA EL DETALLE DE LA OPERACION
        static void MostrarResultado(decimal monto, decimal convertido, decimal comision)
        {
            Console.WriteLine($"Monto ingresado: {monto}");
            Console.WriteLine($"Monto convertido: {Math.Round(convertido, 2)}");
            Console.WriteLine($"Comision cobrada: {Math.Round(comision, 2)}");
        }
    }
}
