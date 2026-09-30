using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    public class ProductoConGarantia : Producto
    {
        public int MesesGarantia { get; set; }

        public ProductoConGarantia(string codigo, string nombre, int stock, decimal precio,
            Ubicacion ubicacion, int mesesGarantia)
            : base(codigo, nombre, stock, precio, Categoria.Tecnologia, ubicacion)
        {
            MesesGarantia = mesesGarantia;
            _stockMinimo = 3;
        }

        public override decimal CalcularValor()
        {
            return Stock * Precio;
        }

        // OVERRIDE: AGREGO LA GARANTIA AL DETALLE DEL PADRE
        public override string ObtenerDetalle()
        {
            return base.ObtenerDetalle() + $" | Garantia: {MesesGarantia} meses";
        }
    }
}
