using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // UNA CLASE PUEDE TENER COMO ATRIBUTO UN OBJETO DE OTRA CLASE
    internal class TransferenciaBancaria
    {
        public Usuario deudor;
        public decimal monto;

        public void MostrarTransferencia()
        {
            Console.WriteLine($"Transferencia de {monto} a nombre de {deudor.Nombre}");
        }
    }
}
