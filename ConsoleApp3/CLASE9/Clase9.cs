using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.CLASE9
{
    // CLASE 9: CAPTURA DE ERRORES Y PATRONES (TRY CATCH, THROW, CRUD Y REPOSITORY)
    internal class Clase9
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 9: CAPTURA DE ERRORES Y PATRONES ---");

            TryCatchDivisionPorCero();
            ValidarConFuncion();
            UltimoElemento();
            EjemploCRUD();
            EjemploRepository();
        }

        // DAME UN TRY CATCH ERROR PARA UNA DIVISION POR CERO
        static void TryCatchDivisionPorCero()
        {
            var a = 120;
            var b = 0;
            try
            {
                int resultado = a / b;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                // SE PONE PRIMERO LA EXCEPCION MAS ESPECIFICA
                Console.WriteLine($"Error: No se puede dividir por cero. {ex.Message}");
            }
            catch (Exception ex)
            {
                // Y AL FINAL LA MAS GENERAL
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                // FINALLY SE EJECUTA SIEMPRE, HAYA ERROR O NO
                Console.WriteLine("Operacion finalizada.");
            }
        }

        // LA MISMA IDEA PERO EN UNA FUNCION QUE DEVUELVE TRUE O FALSE
        static bool ValidarDivisionPorCero(int a, int b)
        {
            try
            {
                var resultado = a / b;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                return false;
            }
            return true;
        }

        static void ValidarConFuncion()
        {
            var resultadoBool = ValidarDivisionPorCero(120, 0);
            Console.WriteLine($"La division se pudo hacer? {resultadoBool}");

            // THROW: YO MISMO LANZO EL ERROR CUANDO UN DATO NO ES VALIDO
            try
            {
                RegistrarEdad(-5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error capturado: {ex.Message}");
            }
        }

        static void RegistrarEdad(int edad)
        {
            if (edad < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa.");
            }
            Console.WriteLine($"Edad registrada: {edad}");
        }

        #region EJEMPLO DEL ULTIMO ELEMENTO CON C# 9 EN ADELANTE
        static void UltimoElemento()
        {
            List<int> listaNumeros = new List<int> { 4, 2, 1, 14, 33, 23 };
            var ultimoIndice = listaNumeros.Count - 1;
            var ultimoDatoValor = listaNumeros[ultimoIndice];
            Console.WriteLine($"Ultimo elemento: {ultimoDatoValor}");

            // EN C# 9 EN ADELANTE (.NET 5+) SE PUEDE ESCRIBIR ASI:
            // var ultimoDatoValor = listaNumeros[^1];
            // ESTE PROYECTO ES .NET FRAMEWORK 4.7.2 (C# 7.3), POR ESO USO Count - 1
        }
        #endregion

        static void EjemploCRUD()
        {
            Usuario usuario = new Usuario("Levi");
            usuario.ModificarEdad("30");
            usuario.ReadData();

            try
            {
                usuario.DeleteData();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Aviso: {ex.Message}");
            }
        }

        static void EjemploRepository()
        {
            IRepository<Producto> repo = new ProductoRepository();

            // AGREGAMOS UN CATALOGO DE PRODUCTOS
            repo.Agregar(new Producto { Nombre = "Laptop Gaming", Precio = 1500.00m });
            repo.Agregar(new Producto { Nombre = "Raton Inalambrico", Precio = 25.00m });
            repo.Agregar(new Producto { Nombre = "Teclado Mecanico", Precio = 85.00m });
            repo.Agregar(new Producto { Nombre = "Monitor 24 pulgadas", Precio = 180.00m });
            repo.Agregar(new Producto { Nombre = "Auriculares", Precio = 45.00m });
            repo.Agregar(new Producto { Nombre = "Cable HDMI", Precio = 10.00m });

            // OBTENEMOS TODOS LOS DATOS DEL REPOSITORIO
            var productos = repo.ObtenerTodos();

            // WHERE LINQ
            var productosEconomicos = productos.Where(p => p.Precio < 50.00m);
            Console.WriteLine("Productos economicos:");
            foreach (var p in productosEconomicos)
            {
                Console.WriteLine($"nombre: {p.Nombre}, precio: {p.Precio}");
            }

            // ORDERBY LINQ
            var ordenados = productos.OrderBy(p => p.Precio);
            Console.WriteLine("Ordenados por precio:");
            foreach (var p in ordenados)
            {
                Console.WriteLine($"nombre: {p.Nombre}, precio: {p.Precio}");
            }

            // ACTUALIZAR Y ELIMINAR
            var cable = repo.ObtenerPorId(6);
            cable.Precio = 12.50m;
            repo.Actualizar(cable);
            repo.Eliminar(2);
            Console.WriteLine($"Productos despues de actualizar y eliminar: {repo.ObtenerTodos().Count()}");
        }
    }
}
