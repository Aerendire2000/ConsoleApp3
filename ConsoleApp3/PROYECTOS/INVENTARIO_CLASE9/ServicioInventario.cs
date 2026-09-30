using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [S] SRP: LA LOGICA DEL INVENTARIO VIVE AQUI (NO IMPRIME, NO LEE DE CONSOLA)
    // [D] DIP: RECIBE EL REPOSITORIO Y LA CALCULADORA POR EL CONSTRUCTOR
    internal class ServicioInventario
    {
        const int UNIDADES_POR_CAJA = 6;

        // STATIC: TOTAL DE MOVIMIENTOS DE TODA LA EJECUCION
        public static int TotalMovimientos { get; private set; }

        private readonly ProductoRepository _repositorio;
        private readonly ICalculoIGV _calculadoraIGV;
        private readonly Historial<Movimiento> _historial = new Historial<Movimiento>();

        public ServicioInventario(ProductoRepository repositorio, ICalculoIGV calculadoraIGV)
        {
            _repositorio = repositorio;
            _calculadoraIGV = calculadoraIGV;
        }

        public void Agregar(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentException("Tipo de producto invalido.");
            }
            _repositorio.Agregar(producto);
        }

        public Producto Buscar(string codigo)
        {
            Producto producto = _repositorio.ObtenerPorCodigo(codigo);
            if (producto == null)
            {
                throw new InventarioException($"No se encontro el producto {codigo}.");
            }
            return producto;
        }

        public void CambiarPrecio(string codigo, decimal nuevoPrecio)
        {
            Producto producto = Buscar(codigo);
            producto.Precio = nuevoPrecio; // SI ES INVALIDO, LA PROPIEDAD LANZA ArgumentException
            _repositorio.Actualizar(producto);
        }

        public void Eliminar(string codigo)
        {
            Producto producto = Buscar(codigo);
            _repositorio.Eliminar(producto.Id);
        }

        public void RegistrarMovimiento(string codigo, string tipo, int cantidad)
        {
            Producto producto = Buscar(codigo);

            if (tipo == "INGRESO") producto.Ingresar(cantidad);
            else producto.Retirar(cantidad); // PUEDE LANZAR InventarioException

            _historial.Agregar(new Movimiento { Codigo = codigo, Tipo = tipo, Cantidad = cantidad, Fecha = DateTime.Now });
            TotalMovimientos++;
        }

        public List<Movimiento> ObtenerHistorial() => _historial.ObtenerTodos();

        public Movimiento ObtenerUltimoMovimiento()
        {
            List<Movimiento> movimientos = _historial.ObtenerTodos();
            if (movimientos.Count == 0)
            {
                throw new InventarioException("Todavia no hay movimientos registrados.");
            }

            // EN C# 9 EN ADELANTE SERIA movimientos[^1], PERO ESTE PROYECTO ES .NET FRAMEWORK (C# 7.3)
            return movimientos[movimientos.Count - 1];
        }

        // ---------------- CONSULTAS: REPOSITORY + LINQ ----------------

        public List<Producto> ObtenerTodos() => _repositorio.ObtenerTodos().OrderBy(p => p.Codigo).ToList();

        public List<Producto> ObtenerCriticos() => _repositorio.ObtenerTodos().Where(p => p.EsStockCritico()).ToList();

        public List<string> ObtenerNombres() => _repositorio.ObtenerTodos().Select(p => p.Nombre).ToList();

        public List<Producto> OrdenarPorStock() => _repositorio.ObtenerTodos().OrderBy(p => p.Stock).ToList();

        public List<Producto> ObtenerMasValiosos() => _repositorio.ObtenerTodos().OrderByDescending(p => p.CalcularValor()).Take(3).ToList();

        public List<string> ResumenPorCategoria()
        {
            return _repositorio.ObtenerTodos()
                .GroupBy(p => p.Categoria.ToString())
                .Select(g => $"{g.Key}: {g.Count()} producto(s), {g.Sum(p => p.Stock)} unidades")
                .ToList();
        }

        public decimal ValorTotal() => Math.Round(_repositorio.ObtenerTodos().Sum(p => p.CalcularValor()), 2);

        public decimal IGVDelInventario() => Math.Round(_calculadoraIGV.CalcularIGV(ValorTotal()), 2);

        public List<string> CalcularReposicion()
        {
            return ObtenerCriticos()
                .Select(p =>
                {
                    int faltantes = Math.Max(0, p.StockMinimo * 2 - p.Stock);
                    int cajas = (int)Math.Ceiling((double)faltantes / UNIDADES_POR_CAJA);
                    return $"{p.Nombre}: faltan {faltantes} unidades -> pedir {cajas} caja(s)";
                })
                .ToList();
        }
    }
}
