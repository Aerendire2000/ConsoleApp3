using System;

namespace ConsoleApp3.CLASE3
{
    // CLASE 3: DO-WHILE, STATIC, PARAMETROS POR DEFECTO Y ref
    internal class Clase3
    {
        // VARIABLE STATIC: LA COMPARTE TODO EL PROGRAMA Y SI PUEDE CAMBIAR
        static double fondoTotalEmpresa = 1000.00;

        // CONST: NO CAMBIA NUNCA
        const double IGV = 0.18;

        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 3: DO-WHILE, STATIC Y ref ---");

            ValidarUsuario();
            ProbarFondo();
            ProbarParametros();
            ProbarIGV();
            ConversorDeFloatAInt();
        }

        // BUCLE DO-WHILE PARA VALIDAR ENTRADAS
        static void ValidarUsuario()
        {
            string nombreUsuario = "";
            do
            {
                Console.WriteLine("Ingresa tu nombre de usuario:");
                nombreUsuario = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombreUsuario));

            Console.WriteLine($"Usuario valido: {nombreUsuario}");
        }

        static void ProbarFondo()
        {
            Console.WriteLine($"Fondo inicial: {fondoTotalEmpresa}");

            RegistrarIngresoAlFondo(250.50);
            RegistrarIngresoAlFondo(100);

            // EL VALOR SE ACUMULA ENTRE LLAMADAS PORQUE LA VARIABLE ES STATIC
            Console.WriteLine($"Fondo final: {fondoTotalEmpresa}");
        }

        static void RegistrarIngresoAlFondo(double ingreso)
        {
            // Modifica directamente la variable global estatica
            fondoTotalEmpresa += ingreso;
            Console.WriteLine($">> Se han sumado {ingreso} al fondo global.");
        }

        static void ProbarParametros()
        {
            // LA VARIABLE SE DECLARA FUERA DEL BUCLE PARA PODER USARLA DESPUES
            string nombreUsuario = "";
            do
            {
                Console.WriteLine("Ingresa tu nombre de usuario (o SALIR para terminar):");
                nombreUsuario = Console.ReadLine();
                if (nombreUsuario.ToUpper() == "SALIR") break;

                // EL ref VA EN LA DEFINICION Y TAMBIEN EN LA LLAMADA
                MostrarUsuarioRegistrado(ref nombreUsuario);
                Console.WriteLine($"nombre de usuario en Main: {nombreUsuario}");
            } while (true);

            MostrarUsuarioRegistrado("Juan"); // Muestra "Usuario registrado: Juan"
            MostrarUsuarioRegistrado();       // Muestra "Usuario registrado: Guest"
        }

        // PARAMETROS POR DEFECTO
        static void MostrarUsuarioRegistrado(string nombreUsuario = "Guest")
        {
            Console.WriteLine($"Usuario registrado: {nombreUsuario}");
        }

        // PARAMETROS POR REFERENCIA (ref)
        static void MostrarUsuarioRegistrado(ref string nombreUsuario)
        {
            if (nombreUsuario == "ADMIN" || nombreUsuario == "admin")
            {
                return; // No se permite mostrar el nombre de usuario
            }

            nombreUsuario = nombreUsuario.ToUpper(); // Convertir a mayusculas
            Console.WriteLine($"Usuario registrado: {nombreUsuario}");
        }

        // FUNCION QUE USA LA CONSTANTE IGV
        static double CalcularIGV(double precio)
        {
            return precio * IGV;
        }

        static void ProbarIGV()
        {
            double resultadoIGV = CalcularIGV(100) + 100;
            Console.WriteLine($"Precio de 100 con IGV: {resultadoIGV}");
        }

        // CONVERSOR DE FLOAT A INT (SE PIERDEN LOS DECIMALES)
        static void ConversorDeFloatAInt()
        {
            float number = 2.5f;
            int result = (int)(number * 5); // 12.5 -> 12
            Console.WriteLine($"(int)(2.5f * 5) = {result}");

            // COMANDOS PARA COMENTAR UN BLOQUE DE CODIGO
            // ctrl + k
            // ctrl + c

            // COMANDO PARA DESCOMENTAR UN BLOQUE DE CODIGO
            // ctrl + u
        }
    }
}
