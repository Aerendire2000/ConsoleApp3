using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE6
{
    // UNA CLASE PUEDE IMPLEMENTAR VARIAS INTERFACES A LA VEZ
    internal class PedidoOnline : GuardadoProducto, PagoProducto, EntregaDeProducto
    {
        public void GuardarProducto(string nombre, double precio)
        {
            Console.WriteLine($"Pedido guardado: {nombre} por {precio}");
        }

        public void PagarProducto(string nombre, double precio)
        {
            Console.WriteLine($"Pago realizado: {nombre} por {precio}");
        }

        public void EntregarProducto(string nombre, double precio)
        {
            Console.WriteLine($"Producto entregado: {nombre}");
        }
    }
}
