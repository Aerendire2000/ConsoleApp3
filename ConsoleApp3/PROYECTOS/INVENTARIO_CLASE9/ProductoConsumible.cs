using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    public class ProductoConsumible : Producto
    {
        const decimal MERMA = 0.05m; // 5% SE PIERDE POR VENCIMIENTO

        public string FechaVencimiento { get; set; }

        public ProductoConsumible(string codigo, string nombre, int stock, decimal precio,
            Ubicacion ubicacion, string fechaVencimiento)
            : base(codigo, nombre, stock, precio, Categoria.Consumibles, ubicacion)
        {
            FechaVencimiento = fechaVencimiento;
            _stockMinimo = 10;
        }

        // LOS CONSUMIBLES VALEN UN POCO MENOS POR LA MERMA
        public override decimal CalcularValor()
        {
            return Stock * Precio * (1 - MERMA);
        }

        public override string ObtenerDetalle()
        {
            return base.ObtenerDetalle() + $" | Vence: {FechaVencimiento}";
        }
    }
}
