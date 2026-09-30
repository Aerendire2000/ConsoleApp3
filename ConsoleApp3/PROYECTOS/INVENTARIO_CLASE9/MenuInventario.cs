using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // TODA LA SELECCION Y EL MENU DE OPCIONES ESTA EN ESTA CLASE (NO EN Main)
    internal class MenuInventario
    {
        private readonly ServicioInventario _servicio;
        private readonly IEntradaDatos _entrada;
        private readonly IReporteInventario _reporte;
        private readonly IProductoFactory _factory;

        public MenuInventario(ServicioInventario servicio, IEntradaDatos entrada,
            IReporteInventario reporte, IProductoFactory factory)
        {
            _servicio = servicio;
            _entrada = entrada;
            _reporte = reporte;
            _factory = factory;
        }

        public void Mostrar()
        {
            string opcion = "";
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- CONTROL DE INVENTARIO ---");
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Agregar producto nuevo");
                Console.WriteLine("3. Registrar ingreso");
                Console.WriteLine("4. Registrar salida");
                Console.WriteLine("5. Cambiar precio de un producto");
                Console.WriteLine("6. Eliminar producto");
                Console.WriteLine("7. Ver productos en stock critico");
                Console.WriteLine("8. Ver productos ordenados por stock");
                Console.WriteLine("9. Resumen por categoria");
                Console.WriteLine("10. Top 3 productos mas valiosos");
                Console.WriteLine("11. Calcular reposicion");
                Console.WriteLine("12. Ver historial de movimientos");
                Console.WriteLine("13. Ver ultimo movimiento");
                Console.WriteLine("0. Salir");
                opcion = Console.ReadLine();

                // try/catch: SI ALGO FALLA, SE MUESTRA EL ERROR Y EL MENU SIGUE FUNCIONANDO
                try
                {
                    EjecutarOpcion(opcion);
                }
                catch (InventarioException ex)
                {
                    _reporte.MostrarMensaje($"[AVISO] {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    _reporte.MostrarMensaje($"[DATO INVALIDO] {ex.Message}");
                }
                catch (Exception ex)
                {
                    _reporte.MostrarMensaje($"[ERROR INESPERADO] {ex.Message}");
                }
            } while (opcion != "0");

            _reporte.MostrarMensaje($"Movimientos registrados en la sesion: {ServicioInventario.TotalMovimientos}");
        }

        void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    _reporte.MostrarLista("INVENTARIO", _servicio.ObtenerTodos().Select(p => p.ObtenerDetalle()));
                    _reporte.MostrarMensaje($"Valor total: {_servicio.ValorTotal()} | IGV: {_servicio.IGVDelInventario()}");
                    break;
                case "2":
                    AgregarProducto();
                    break;
                case "3":
                    RegistrarMovimiento("INGRESO");
                    break;
                case "4":
                    RegistrarMovimiento("SALIDA");
                    break;
                case "5":
                    string codigoPrecio = _entrada.LeerTexto("Codigo del producto:").ToUpper();
                    decimal nuevoPrecio = _entrada.LeerDecimal("Nuevo precio:");
                    _servicio.CambiarPrecio(codigoPrecio, nuevoPrecio);
                    _reporte.MostrarMensaje(_servicio.Buscar(codigoPrecio).ObtenerDetalle());
                    break;
                case "6":
                    string codigoEliminar = _entrada.LeerTexto("Codigo del producto a eliminar:").ToUpper();
                    string confirmacion = _entrada.LeerTexto("Seguro? (si/no)").ToLower();
                    if (confirmacion == "si")
                    {
                        _servicio.Eliminar(codigoEliminar);
                        _reporte.MostrarMensaje("Producto eliminado.");
                    }
                    break;
                case "7":
                    _reporte.MostrarLista("STOCK CRITICO", _servicio.ObtenerCriticos().Select(p => p.ObtenerDetalle()));
                    break;
                case "8":
                    _reporte.MostrarLista("ORDENADOS POR STOCK", _servicio.OrdenarPorStock().Select(p => $"{p.Nombre}: {p.Stock}"));
                    break;
                case "9":
                    _reporte.MostrarLista("RESUMEN POR CATEGORIA", _servicio.ResumenPorCategoria());
                    break;
                case "10":
                    _reporte.MostrarLista("TOP 3 MAS VALIOSOS", _servicio.ObtenerMasValiosos().Select(p => $"{p.Nombre}: {Math.Round(p.CalcularValor(), 2)}"));
                    break;
                case "11":
                    _reporte.MostrarLista("REPOSICION", _servicio.CalcularReposicion());
                    break;
                case "12":
                    _reporte.MostrarLista("HISTORIAL", _servicio.ObtenerHistorial().Select(m => m.ToString()));
                    break;
                case "13":
                    _reporte.MostrarMensaje($"Ultimo movimiento: {_servicio.ObtenerUltimoMovimiento()}");
                    break;
                case "0":
                    _reporte.MostrarMensaje("Saliendo del inventario...");
                    break;
                default:
                    _reporte.MostrarMensaje("Opcion no valida.");
                    break;
            }
        }

        void AgregarProducto()
        {
            string tipo = _entrada.LeerTexto("Tipo: 1. Accesorio  2. Con garantia  3. Consumible");
            string codigo = _entrada.LeerTexto("Codigo (ej. P006):").ToUpper();
            string nombre = _entrada.LeerTexto("Nombre:");
            int stock = _entrada.LeerEntero("Stock inicial:");
            decimal precio = _entrada.LeerDecimal("Precio:");

            _servicio.Agregar(_factory.CrearProducto(tipo, codigo, nombre, stock, precio));
            _reporte.MostrarMensaje("Producto agregado.");
        }

        void RegistrarMovimiento(string tipo)
        {
            string codigo = _entrada.LeerTexto("Codigo del producto:").ToUpper();
            int cantidad = _entrada.LeerEntero("Cantidad:");

            _servicio.RegistrarMovimiento(codigo, tipo, cantidad);
            _reporte.MostrarMensaje(_servicio.Buscar(codigo).ObtenerDetalle());
        }
    }
}
