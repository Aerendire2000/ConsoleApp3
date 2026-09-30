using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // DIP: DEPENDE DE ABSTRACCIONES (ICalculoIGV) EN LUGAR DE IMPLEMENTACIONES
    internal abstract class Producto
    {
        protected string _nombre;
        protected double _precio;
        protected ICalculoIGV _calculadoraIGV;

        public string Nombre { get { return _nombre; } }
        public double Precio { get { return _precio; } }

        public Producto(string nombre, double precio, ICalculoIGV calculadoraIGV = null)
        {
            _nombre = nombre;
            _precio = precio;
            // SI NO ME PASAN CALCULADORA USO LA DE PERU POR DEFECTO
            _calculadoraIGV = calculadoraIGV ?? new CalculadoraIGV();
        }

        // SRP: METODO ESPECIFICO DEL PRODUCTO
        public virtual void OfertaProducto()
        {
            Console.WriteLine($"El producto {_nombre} tiene un precio de {_precio}");
            bool tieneOferta = false;
            var resultado = (tieneOferta) ? "YES" : "NO";
            Console.WriteLine($"Tiene oferta? {resultado}");
        }

        public abstract void NotificacionEnvio();
    }
}
