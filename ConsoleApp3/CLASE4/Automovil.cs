using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE4
{
    // ACTIVIDAD 1: TALLER MECANICO "EL RAPIDO"
    // CLASE: Automovil (SIRVE PARA CUALQUIER VEHICULO QUE LLEGUE AL TALLER)
    // OBJETO: EL TOYOTA COROLLA ROJO XYZ-123
    internal class Automovil
    {
        // ATRIBUTOS (CARACTERISTICAS)
        private string marca;
        private string modelo;
        private string color;
        private string matricula;
        private double nivelCombustible;
        private string mecanico;
        private string descripcionDelProblema;

        public void agregarInformacion(string marca, string modelo, string color, string matricula,
            double nivelCombustible, string mecanico, string descripcionDelProblema)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.matricula = matricula;
            this.nivelCombustible = nivelCombustible;
            this.mecanico = mecanico;
            this.descripcionDelProblema = descripcionDelProblema;
        }

        // METODOS (ACCIONES)
        public void EncenderMotor()
        {
            Console.WriteLine($"{mecanico} giro la llave y encendio el motor.");
        }

        public void Acelerar()
        {
            Console.WriteLine($"{mecanico} acelero suavemente para ingresar al area de revision.");
        }

        public void Frenar()
        {
            Console.WriteLine($"{mecanico} piso el pedal y detuvo el vehiculo por completo.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Nivel de combustible: {nivelCombustible}%");
            Console.WriteLine($"Mecanico: {mecanico}");
            Console.WriteLine($"Problema: {descripcionDelProblema}");
        }
    }
}
