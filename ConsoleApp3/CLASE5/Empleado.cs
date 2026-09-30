using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // ENCAPSULAMIENTO: EL CAMPO ES PRIVADO Y SOLO SE TOCA POR LA PROPIEDAD
    internal class Empleado
    {
        private decimal _sueldo;

        public decimal Sueldo
        {
            get { return _sueldo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El sueldo no puede ser negativo. Se asignara un sueldo de 0.");
                    _sueldo = 0;
                }
                else
                {
                    _sueldo = value;
                }
            }
        }

        public Empleado(decimal sueldo)
        {
            Sueldo = sueldo; // PASA POR EL SET Y SE VALIDA
        }

        public void AumentarSueldo()
        {
            Sueldo = Sueldo * 1.10m; // 10% DE AUMENTO
        }
    }
}
