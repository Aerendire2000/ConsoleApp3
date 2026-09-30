using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // HERENCIA: CAJERO ES UN USUARIO
    public class Cajero : Usuario
    {
        public decimal Sueldo { get; set; }
        public string Turno { get; set; }
        protected string Genero { get; set; } // SOLO LO VE ESTA CLASE Y SUS HIJAS

        public Cajero(
            string turno,
            decimal sueldo,
            string nombre,
            int edad
            ) : base(nombre, edad)
        {
            this.Turno = turno;
            this.Sueldo = sueldo;
        }

        public void ProcesarPago()
        {
            Console.WriteLine($"{Nombre} esta procesando un pago.");
        }
    }
}
