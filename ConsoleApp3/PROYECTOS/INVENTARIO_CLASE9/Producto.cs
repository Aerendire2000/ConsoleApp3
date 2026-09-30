using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [L] LSP: CUALQUIER HIJA (Accesorio, ConGarantia, Consumible) PUEDE USARSE DONDE SE ESPERA UN Producto
    // HERENCIA CON CLASE ABSTRACTA + MODIFICADOR protected
    public abstract class Producto : IMovimientoStock, IReportable
    {
        // CONST: VALOR FIJO PARA TODOS LOS PRODUCTOS
        public const int STOCK_MINIMO_POR_DEFECTO = 5;

        private string _nombre;
        private int _stock;
        private decimal _precio;
        protected int _stockMinimo;

        public int Id { get; set; }
        public string Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del producto no puede estar vacio.");
                }
                _nombre = value;
            }
        }

        public int Stock
        {
            get { return _stock; }
            private set { _stock = value < 0 ? 0 : value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                }
                _precio = value;
            }
        }

        public int StockMinimo { get { return _stockMinimo; } }

        protected Producto(string codigo, string nombre, int stock, decimal precio, Categoria categoria, Ubicacion ubicacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            Categoria = categoria;
            Ubicacion = ubicacion;
            _stockMinimo = STOCK_MINIMO_POR_DEFECTO;
        }

        public void Ingresar(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a ingresar debe ser mayor que 0.");
            }
            Stock += cantidad;
        }

        public bool Retirar(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a retirar debe ser mayor que 0.");
            }
            if (cantidad > Stock)
            {
                throw new InventarioException($"Stock insuficiente de {Nombre}. Disponible: {Stock}, solicitado: {cantidad}.");
            }
            Stock -= cantidad;
            return true;
        }

        public bool EsStockCritico()
        {
            return Stock < _stockMinimo;
        }

        public abstract decimal CalcularValor();

        public virtual string ObtenerDetalle()
        {
            string alerta = EsStockCritico() ? "  <-- STOCK CRITICO" : "";
            return $"[{Codigo}] {Nombre} ({Categoria}) | Stock: {Stock} | Valor: {Math.Round(CalcularValor(), 2)} | {Ubicacion}{alerta}";
        }
    }
}
