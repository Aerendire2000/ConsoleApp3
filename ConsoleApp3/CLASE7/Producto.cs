using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE7
{
    // CLASE ABSTRACTA: NO SE PUEDE HACER new Producto()
    // SIRVE COMO PLANTILLA PARA LAS CLASES HIJAS
    internal abstract class Producto
    {
        protected Utilitaria utilitaria = new Utilitaria();
        protected string _nombre;
        protected double _precio;

        public string Nombre { get { return _nombre; } }
        public double Precio { get { return _precio; } }

        public Producto(string nombre, double precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        // VIRTUAL: TIENE UNA VERSION POR DEFECTO, LAS HIJAS PUEDEN CAMBIARLA
        public virtual void OfertaProducto()
        {
            Console.WriteLine($"El producto {_nombre} tiene un precio de {_precio}");
        }

        // ABSTRACT: NO TIENE CUERPO, LAS HIJAS ESTAN OBLIGADAS A IMPLEMENTARLO
        public abstract void NotificacionEnvio();
    }
}
