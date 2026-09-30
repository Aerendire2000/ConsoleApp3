using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    // MetodoPagoFactory aplica OCP y DIP: la creacion de metodos de pago queda centralizada
    // y se expone via la interfaz IMetodoPagoFactory. Para aniadir un nuevo metodo de pago
    // solo hay que extender esta fabrica; no es necesario cambiar la logica de venta.
    internal class MetodoPagoFactory : IMetodoPagoFactory
    {
        public IMetodoPago CrearMetodoPago(string opcion)
        {
            switch (opcion)
            {
                case "1": return new PagoYape();
                case "2": return new PagoTarjeta();
                case "3": return new PagoCripto();
                default: return null;
            }
        }
    }
}
