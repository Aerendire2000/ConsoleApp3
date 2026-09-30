using System;

namespace ConsoleApp3.CLASE1
{
    // CLASE 1: VARIABLES, TIPOS DE DATOS, OPERADORES Y EXPRESIONES
    internal class Clase1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 1: VARIABLES, TIPOS Y OPERADORES ---");

            // PRIMER PROGRAMA
            Console.WriteLine("Hello, World!");

            // ESCRIBE EN CONSOLA
            Console.WriteLine("Escribe el numero:");

            // CONSOLE RETORNA UN VALOR DE TIPO STRING
            string numero = Console.ReadLine();

            TiposDeDatos();
            Operadores(numero);
            TipoAnonimo();
            AdelantoDeClases();
        }

        static void TiposDeDatos()
        {
            // TEXTO
            string nombre = "Laptop Gamer";

            // NUMEROS ENTEROS
            int entero1 = 10;
            int entero2 = 20;
            Console.WriteLine($"entero1 = {entero1}, entero2 = {entero2}");

            // NUMEROS DECIMALES
            decimal resultado = entero2 / 3.0m;   // SUFIJO m -> DECIMAL (PARA DINERO)
            float resultado2 = entero2 / 3.0f;    // SUFIJO f -> FLOAT
            double resultado3 = entero2 / 3.0;    // SIN SUFIJO -> DOUBLE

            Console.WriteLine($"Con decimal: {resultado}");
            Console.WriteLine($"Con float: {resultado2}");
            Console.WriteLine($"Con double: {resultado3}");

            // BOOLEANO: SOLO TRUE O FALSE
            bool enStock = true;
            Console.WriteLine($"{nombre} en stock? {enStock}");

            // VAR: EL COMPILADOR DETERMINA EL TIPO DE DATO SEGUN EL VALOR ASIGNADO
            // LUEGO DE ELLO YA NO SE PUEDE CAMBIAR EL TIPO DE DATO
            var resultado4 = entero2 / 3.0;
            Console.WriteLine($"Con var (el compilador deduce double): {resultado4}");

            // DYNAMIC: SI SE PUEDE CAMBIAR EL TIPO DE DATO EN TIEMPO DE EJECUCION
            dynamic resultado5 = entero2 / 3.0;
            Console.WriteLine($"Con dynamic, primero un numero: {resultado5}");
            resultado5 = "y ahora un texto";
            Console.WriteLine($"Con dynamic, despues: {resultado5}");
        }

        // OPERADORES Y EXPRESIONES
        static void Operadores(string numero)
        {
            int numeroIngresado = int.Parse(numero);
            numeroIngresado += 5; // EQUIVALE A numeroIngresado = numeroIngresado + 5
            Console.WriteLine($"El numero ingresado mas 5 es: {numeroIngresado}");

            int numero2 = numeroIngresado + 10 * (6 - 15); // PRIMERO PARENTESIS, LUEGO *, LUEGO +
            Console.WriteLine($"numero + 10 * (6 - 15) = {numero2}");

            // PRECEDENCIA: () * / % + -
            int sinParentesis = 10 + 5 * 2;   // 20
            int conParentesis = (10 + 5) * 2; // 30
            Console.WriteLine($"10 + 5 * 2 = {sinParentesis}");
            Console.WriteLine($"(10 + 5) * 2 = {conParentesis}");

            float cociente = 10 / 3.0f;         // 3.3333333
            double residuo = sinParentesis % 2; // 0
            Console.WriteLine($"Cociente: {cociente} | Residuo: {residuo}");

            // COMPARACIONES: EL RESULTADO SIEMPRE ES TRUE O FALSE
            bool esPar = numeroIngresado % 2 == 0; // TRUE SI ES PAR, FALSE SI ES IMPAR
            bool noEsCero = numeroIngresado != 0;
            bool menorQue5 = sinParentesis < 5;
            bool mayorQue5 = sinParentesis > 5;
            bool menorOIgualQue5 = sinParentesis <= 5;
            bool mayorOIgualQue15 = sinParentesis >= 15;

            Console.WriteLine($"El numero ingresado es par? {esPar}");
            Console.WriteLine($"Es distinto de 0? {noEsCero}");
            Console.WriteLine($"Es menor que 5? {menorQue5}");
            Console.WriteLine($"Es mayor que 5? {mayorQue5}");
            Console.WriteLine($"Es menor o igual que 5? {menorOIgualQue5}");
            Console.WriteLine($"Es mayor o igual que 15? {mayorOIgualQue15}");
        }

        // TIPO ANONIMO: UN OBJETO AL VUELO, SIN DECLARAR UNA CLASE
        static void TipoAnonimo()
        {
            var persona = new
            {
                Nombre = "Jorge luis de nolasco",
                Edad = 30,
                FechaNacimiento = new DateTime(1993, 1, 1)
            };

            Console.WriteLine($"La persona es {persona.Nombre} " +
                $"y tiene {persona.Edad} anios y nacio el " +
                $"{persona.FechaNacimiento.ToShortDateString()}");
        }

        // ADELANTO DE LA CLASE 4: LO MISMO QUE EL TIPO ANONIMO,
        // PERO CON UNA CLASE DE VERDAD QUE SI PUEDO REUTILIZAR
        static void AdelantoDeClases()
        {
            Persona persona = new Persona();
            persona.Nombre = "Jorge";
            persona.Edad = 30;
            persona.Saludar();
        }
    }
}
