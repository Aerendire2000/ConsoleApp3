using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    internal class ControlDeInventario
    {
        public static void Ejecutar()
        {
            ServicioInventario servicio = new ServicioInventario(new ProductoRepository(), new CalculadoraIGV());
            IProductoFactory factory = new ProductoFactory();

            try
            {
                CargarDatosIniciales(servicio, factory);

                MenuInventario menu = new MenuInventario(servicio, new EntradaDatosConsola(), new ReporteConsola(), factory);
                menu.Mostrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] No se pudo iniciar el inventario: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Control de inventario finalizado.");
            }
        }

        static void CargarDatosIniciales(ServicioInventario servicio, IProductoFactory factory)
        {
            servicio.Agregar(factory.CrearProducto("2", "P001", "Laptop", 10, 3500.00m));
            servicio.Agregar(factory.CrearProducto("1", "P002", "Mouse", 25, 45.90m));
            servicio.Agregar(factory.CrearProducto("3", "P003", "Tinta HP", 6, 89.00m));
            servicio.Agregar(factory.CrearProducto("1", "P004", "Teclado", 4, 120.00m));
            servicio.Agregar(factory.CrearProducto("2", "P005", "Monitor 24", 2, 650.00m));
        }
    }
}
