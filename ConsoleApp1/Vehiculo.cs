using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public string matricula { get; set; }
        public string nivelCombustible { get; set; }
        public bool motorEncendido { get; private set; }
        public string velocidad { get; set; }
        public Vehiculo(string marca = "Desconocida", string modelo = "Desconocido", string color = "Blanco", string matricula = "SIN-000")
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.matricula = matricula;
            this.nivelCombustible = "0";
            this.motorEncendido = false;
            this.velocidad = "0";
        }

        public int ObtenerNivelCombustible()
        {
            int nivelNumerico;
            if (int.TryParse(nivelCombustible, out nivelNumerico))
            {
                return nivelNumerico;
            }
            else
            {
                Console.WriteLine("Nivel de combustible no válido. No se puede convertir a número.");
                return -1;
            }
        }
        //
        public void EncenderMotor()
        {
            if (!motorEncendido)
            {
                motorEncendido = true;
                Console.WriteLine($"{marca} {modelo} ({matricula}): el mecánico giró la llave, motor encendido.");
            }
            else
            {
                Console.WriteLine($"{marca} {modelo} ({matricula}): el motor ya estaba encendido.");
            }
        }
        public void ApagarMotor()
        {
            if (motorEncendido)
            {
                motorEncendido = false;
                Console.WriteLine($"{marca} {modelo} ({matricula}): el mecánico giró la llave, motor apagado.");
            }
            else
            {
                Console.WriteLine($"{marca} {modelo} ({matricula}): el motor ya estaba apagado.");
            }
        }

    }
}