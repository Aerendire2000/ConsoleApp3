using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.CLASE8
{
    // CLASE 8: PRINCIPIOS SOLID A FONDO Y LINQ
    internal class Clase8
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 8: SOLID Y LINQ ---");

            EjemploSolid();
            LinqProductos();
            LinqEmpleados();
        }

        static void EjemploSolid()
        {
            // [S]
            Carrito carrito = new Carrito();
            carrito.AgregarProducto("Laptop");
            carrito.AgregarProducto("Mouse");
            new TicketImpresora().Imprimir(carrito);

            // [O]
            IDescuento descuento = new DescuentoVIP();
            Console.WriteLine($"Total con descuento VIP: {descuento.Aplicar(100)}");

            // [L] + [I]
            ProductoDigital ebook = new ProductoDigital { Nombre = "Ebook C#" };
            ebook.GenerarLink();
            ProductoFisico libro = new ProductoFisico { Nombre = "Libro C#" };
            Console.WriteLine($"Peso de {libro.Nombre}: {libro.CalcularPeso()} kg");

            // [D]
            CarritoConBaseDatos carritoDb = new CarritoConBaseDatos(new BaseDatosMemoria());
            carritoDb.Guardar("Teclado");

            // EJEMPLO 2: USO DE ISP - INTERFACES SEGREGADAS
            IReporter reporter = new ConsoleReporter();
            reporter.MostrarReporte("Reporte de ventas generado correctamente");

            // LSP: LISKOV SUBSTITUTION PRINCIPLE
            Dictionary<string, ICalculoIGV> diccionarioCalculoImpuestos = new Dictionary<string, ICalculoIGV>
            {
                { "Peru", new CalculadoraIGV() },
                { "USA", new CalculadoraIGV_USA() },
                { "Chile", new CalculadoraIGV_Chile() },
            };

            var productoElectronico = new ProductoElectronico(
                "Laptop",
                1000,
                "220V",
                diccionarioCalculoImpuestos["Peru"]); // DIP: INYECTAMOS LA DEPENDENCIA

            productoElectronico.OfertaProducto();
            productoElectronico.Pagar("Tarjeta de Credito");
            productoElectronico.NotificacionEnvio();

            Console.WriteLine("\n--- Ejemplo de ProductoOrganico ---\n");

            var productoOrganico = new ProductoOrganico(
                "Arroz integral",
                50,
                "Alto en fibra",
                diccionarioCalculoImpuestos["Chile"]); // DIP: INYECTAMOS LA DEPENDENCIA

            productoOrganico.OfertaProducto();
            productoOrganico.NotificacionEnvio();
        }

        static void LinqProductos()
        {
            List<ProductoElectronico> equiposComputacionales = new List<ProductoElectronico>
            {
                new ProductoElectronico("PC", 1200, "220"),
                new ProductoElectronico("GPU3050", 1500, "220"),
                new ProductoElectronico("GPU4070", 2200, "220"),
                new ProductoElectronico("GPU5080", 5200, "220"),
                new ProductoElectronico("MouseVerdeLed", 35, "220"),
                new ProductoElectronico("MouseOptico", 25, "220"),
                new ProductoElectronico("MouseLift", 95, "220"),
                new ProductoElectronico("MouseGamer", 55, "220"),
            };

            // EJEMPLO WHERE: FILTRAR
            Console.WriteLine("Mostrar los precios mayores que 50 y menores que 100");
            var tempElec = equiposComputacionales.Where(x => x.Precio > 50 && x.Precio < 100).ToList();
            foreach (var i in tempElec)
            {
                Console.WriteLine(i.Precio);
            }
            Console.WriteLine();

            // EJEMPLO SELECT: GUARDAR LOS ELEMENTOS O ATRIBUTOS DESIGNADOS
            Console.WriteLine("Guardar los elementos o atributos designados en el Select");
            List<string> selectElec = equiposComputacionales.Select(x => x.Nombre).ToList();
            foreach (var i in selectElec)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // EJEMPLO ORDERBY: ORDENAR
            Console.WriteLine("Ordenado por precio");
            var orderElec = equiposComputacionales.OrderBy(x => x.Precio).ToList();
            foreach (var i in orderElec)
            {
                Console.WriteLine($"{i.Nombre} - {i.Precio}");
            }
            Console.WriteLine();

            // EJEMPLO GROUPBY: AGRUPAR
            Console.WriteLine("Agrupado por precio (baratos y caros)");
            var groupElec = equiposComputacionales.GroupBy(x => x.Precio >= 100 ? "Caros" : "Baratos");
            foreach (var grupo in groupElec)
            {
                Console.WriteLine($"{grupo.Key} (Total: {grupo.Count()})");
                foreach (var i in grupo)
                {
                    Console.WriteLine($"  - {i.Nombre}");
                }
            }
            Console.WriteLine();
        }

        static void LinqEmpleados()
        {
            // 1. CREACION DE LA LISTA CON 20 ELEMENTOS
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado { Id = 1, Nombre = "Ana", Departamento = "TI", Salario = 3500, Edad = 28 },
                new Empleado { Id = 2, Nombre = "Carlos", Departamento = "Ventas", Salario = 2200, Edad = 35 },
                new Empleado { Id = 3, Nombre = "Beatriz", Departamento = "TI", Salario = 4100, Edad = 42 },
                new Empleado { Id = 4, Nombre = "David", Departamento = "Finanzas", Salario = 2900, Edad = 30 },
                new Empleado { Id = 5, Nombre = "Elena", Departamento = "RRHH", Salario = 2500, Edad = 26 },
                new Empleado { Id = 6, Nombre = "Fernando", Departamento = "TI", Salario = 3800, Edad = 31 },
                new Empleado { Id = 7, Nombre = "Gabriela", Departamento = "Ventas", Salario = 1800, Edad = 23 },
                new Empleado { Id = 8, Nombre = "Hugo", Departamento = "Finanzas", Salario = 3100, Edad = 45 },
                new Empleado { Id = 9, Nombre = "Isabel", Departamento = "RRHH", Salario = 2700, Edad = 38 },
                new Empleado { Id = 10, Nombre = "Javier", Departamento = "TI", Salario = 4500, Edad = 29 },
                new Empleado { Id = 11, Nombre = "Karla", Departamento = "Ventas", Salario = 2400, Edad = 27 },
                new Empleado { Id = 12, Nombre = "Luis", Departamento = "Finanzas", Salario = 3300, Edad = 50 },
                new Empleado { Id = 13, Nombre = "Maria", Departamento = "RRHH", Salario = 2600, Edad = 33 },
                new Empleado { Id = 14, Nombre = "Nicolas", Departamento = "TI", Salario = 3200, Edad = 24 },
                new Empleado { Id = 15, Nombre = "Olga", Departamento = "Ventas", Salario = 2100, Edad = 41 },
                new Empleado { Id = 16, Nombre = "Pedro", Departamento = "Finanzas", Salario = 2800, Edad = 36 },
                new Empleado { Id = 17, Nombre = "Rocio", Departamento = "TI", Salario = 3900, Edad = 34 },
                new Empleado { Id = 18, Nombre = "Santiago", Departamento = "Ventas", Salario = 1900, Edad = 22 },
                new Empleado { Id = 19, Nombre = "Teresa", Departamento = "RRHH", Salario = 2900, Edad = 47 },
                new Empleado { Id = 20, Nombre = "Victor", Departamento = "Finanzas", Salario = 4000, Edad = 39 },
            };

            // --- WHERE ---
            Console.WriteLine("--- WHERE ---");
            Console.WriteLine("Ejemplo 1 (Salario > 3500):");
            foreach (var e in empleados.Where(e => e.Salario > 3500))
            {
                Console.WriteLine($" - {e.Nombre}: ${e.Salario}");
            }
            Console.WriteLine("Ejemplo 2 (TI y Edad < 35):");
            foreach (var e in empleados.Where(e => e.Departamento == "TI" && e.Edad < 35))
            {
                Console.WriteLine($" - {e.Nombre} ({e.Edad} anios)");
            }

            // --- SELECT ---
            Console.WriteLine("--- SELECT ---");
            List<string> nombres = empleados.Select(e => e.Nombre).ToList();
            Console.WriteLine($"Ejemplo 1 (Solo nombres): {string.Join(", ", nombres)}");
            Console.WriteLine("Ejemplo 2 (Nombre y Salario Anual):");
            foreach (var e in empleados.Take(5).Select(e => new { e.Nombre, SalarioAnual = e.Salario * 12 }))
            {
                Console.WriteLine($" - {e.Nombre}: ${e.SalarioAnual} al anio");
            }

            // --- ORDERBY ---
            Console.WriteLine("--- ORDERBY ---");
            Console.WriteLine("Ejemplo 1 (Ordenados por Edad Ascendente):");
            foreach (var e in empleados.OrderBy(e => e.Edad).Take(5))
            {
                Console.WriteLine($" - {e.Nombre}: {e.Edad} anios");
            }
            Console.WriteLine("Ejemplo 2 (Ordenados por Salario Descendente):");
            foreach (var e in empleados.OrderByDescending(e => e.Salario).Take(5))
            {
                Console.WriteLine($" - {e.Nombre}: ${e.Salario}");
            }

            // --- GROUPBY ---
            Console.WriteLine("--- GROUPBY ---");
            Console.WriteLine("Ejemplo 1 (Agrupados por Departamento):");
            foreach (var grupo in empleados.GroupBy(e => e.Departamento))
            {
                Console.WriteLine($" * Departamento: {grupo.Key} (Total: {grupo.Count()})");
                foreach (var e in grupo.OrderBy(e => e.Nombre))
                {
                    Console.WriteLine($"   - {e.Nombre}");
                }
            }
            Console.WriteLine("Ejemplo 2 (Agrupados por Rango de Edad):");
            foreach (var grupo in empleados.GroupBy(e => e.Edad <= 30 ? "30 o menores" : "Mayores de 30"))
            {
                Console.WriteLine($" * Grupo: {grupo.Key} (Total: {grupo.Count()})");
                foreach (var e in grupo)
                {
                    Console.WriteLine($"   - {e.Nombre} ({e.Edad})");
                }
            }
        }
    }
}
