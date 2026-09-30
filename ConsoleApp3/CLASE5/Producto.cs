using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    internal class Producto
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private decimal _precio;
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ingrese un precio mayor que 0. Se asignara el valor de 0.");
                    _precio = 0;
                }
                else
                {
                    _precio = value;
                }
            }
        }

        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("La cantidad no puede ser negativa. Se asignara 0.");
                    _cantidad = 0;
                }
                else
                {
                    _cantidad = value;
                }
            }
        }
    }
}
